using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;


namespace FinalProjEden_and_Ofir
{
    public partial class LogIn : Form
    {
        AllUsers allUsers;
        dbConnection db;
        List<Movies> listMovies;
        XDocument MoviesToXML;

        Sellers[] howManySold;

        User isOnline;

        public LogIn()
        {
            listMovies = new List<Movies>();
            db = new dbConnection();
            howManySold = new Sellers[0];

            InitializeComponent();

            if (File.Exists("UserList.txt"))
            {
                UploadUserList();
            }
            else
            {
                AddManager("eden", 111111);
            }

            if (File.Exists("MoviesList.xml"))
            {
                UploadMovieList();
            }
            else
            {
                NewXML();
            }

            ReadSellsFromTXT();
        }

    

        public string BestSeller()
        {
            Array.Sort(howManySold, new CompareSells());

            return howManySold[0].Name;
        }


        //Open forms
        private void btnEnterCash_Click(object sender, EventArgs e)
        {
            User temp;
            int access;
            temp = allUsers[txtEnterUser.Text, int.Parse(txtPassword.Text)];

            if (temp is Manager)
            {
                access = ((Manager)temp).AccessCode;
            }
            else
            {
                access = 0;
            }

            if (temp != null)
            {
                isOnline = temp;
                Cashier cash = new Cashier(this, access);

                cash.Show();
            }
            else if (allUsers[txtEnterUser.Text])
            {
                MessageBox.Show("The password do not match the username", "Error");
            }
            else
            {
                MessageBox.Show("There is no usename with this name", "Error");
            }
        }

        public void OpenAbout(string MovieName)
        {

            string movieDetails = "";

            foreach (Movies item in listMovies)
            {
                if (item.Name == MovieName)
                {
                    movieDetails += item.ToString();

                    About about = new About(item.Name, movieDetails);
                    about.ShowDialog();
                }
            }
        }

        public void OpenManageForm()
        {
            Manage manage = new Manage(this);
            manage.Show();
        }


        //ADD and DELETE ** MOVEIS **
        public void AddAllAgesMovie(string name, int yearCreated, int duration, int grade, string creator, List<string> type, int ageLimit)
        {
            Movies newMovie = new AllAgesMovies(name, yearCreated, duration, grade, creator, type, ageLimit);

            AddMovieToList(newMovie);

        }

        public void AddKidsMovie(string name, int yearCreated, int duration, int grade, string creator, List<string> type, bool isDubbed)
        {
            Movies newMovie = new KidsMovie(name, yearCreated, duration, grade, creator, type, isDubbed);

            AddMovieToList(newMovie);

        }

        public void RemoveMovie(int removeCode)
        {

            DataTable movies = BringDB(); string item11 = "";

            var action = from movieSort in movies.AsEnumerable()
                         where int.Parse(movieSort["MovieCode"].ToString()) == removeCode
                         select movieSort["MovieName"];

            foreach (var item in action)
            {
                item11 = item.ToString();
            }

            foreach (var item in listMovies)
            {
                if (item.Name == item11)
                {
                    listMovies.Remove(item);
                    return;
                }
            }

        }


        private void AddMovieToList(Movies movie)
        {
            listMovies.Add(movie);
            AddMovieToDB(movie);
            AddToXML(movie);
        }


        //ADD and DELETE ** USERS **
        public void AddUser(string name, int password)
        {
            User[] newUser = new User[1];
            newUser[0] = new User(name, password);
            allUsers.AddNewUser(newUser);

            AddUserToTXTList(newUser[0]);
        }

        public void AddManager(string name, int password)
        {
            Random random = new Random();
            int accessCode;
            bool outTheLoop = false;

            do
            {
                accessCode = random.Next(1000, 9999);
                if (allUsers != null)
                {
                    if (!allUsers[accessCode, name, password])
                    {
                        outTheLoop = true;
                    }
                }
                else
                {
                    outTheLoop = true;
                }
            } while (!outTheLoop);

            User[] newManager = new User[1];
            newManager[0] = new Manager(name, password, accessCode);
            if (allUsers != null)
            {
                allUsers.AddNewUser(newManager);
            }
            else
            {
                allUsers = new AllUsers(newManager);
            }

            AddUserToTXTList(newManager[0]);
        }


        public void AddPayToUser(int num)
        {
            foreach (var item in howManySold)
            {
                if (item.Name == isOnline.Username)
                {
                    int untilNow = item.Sells;
                    untilNow += num;

                    item.Sells = untilNow;
                    UpdateTXTsellers();
                    return;
                }
            }

            Sellers[] temp = new Sellers[howManySold.Length + 1];
            howManySold.CopyTo(temp, 0);

            temp[temp.Length - 1] = new Sellers(isOnline.Username, num);

            howManySold = temp;

            AddSoldToTXT(isOnline.Username, num);
        }


        public void DeleteUser(string username, int password)
        {
            if (allUsers.RemovedUser(allUsers[username, password]))
            {
                UpdateTXTusers();
                MessageBox.Show("User has been removed successfully", "Success");
            }
            else if (allUsers[username, password] == null)
            {
                MessageBox.Show("No user with these details", "Error");
            }
            else
            {
                MessageBox.Show("User has NOT been removed", "Error");
            }
        }

        //TXTcode

        public void AddSoldToTXT(string nameOfSeller, int num)
        {
            StreamWriter sw = File.AppendText("BestCashier.txt");

            sw.WriteLine("Name of seller :" + nameOfSeller + ", sold :" + num);

            sw.Close();
        }

        private void ReadSellsFromTXT()
        {
            if (File.Exists("BestCashier.txt"))
            {
                StreamReader sr = new StreamReader("BestCashier.txt");

                string[] split;

                string text;

                while (!sr.EndOfStream)
                {
                    text = sr.ReadLine();

                    split = text.Split(':', ',');

                    Sellers[] temp = new Sellers[howManySold.Length + 1];
                    howManySold.CopyTo(temp, 0);

                    temp[temp.Length - 1] = new Sellers(split[1], int.Parse(split[3]));

                    howManySold = temp;
                }

                sr.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter("BestCashier.txt");
            }
        }

        private void UpdateTXTsellers()
        {
            StreamWriter sw = new StreamWriter("BestCashier.txt");

            foreach (var item in howManySold)
            {
                sw.WriteLine("Name of seller :" + item.Name + ", sold :" + item.Sells);

            }
            sw.Close();
        }

        private void UploadUserList()
        {
            string temp; string[] split;
            StreamReader sr = new StreamReader("UserList.txt");
            User[] userTemp = new User[0];
            User[] tempArray;

            while (!sr.EndOfStream)
            {
                temp = sr.ReadLine();
                split = temp.Split('=', ',');

                tempArray = new User[userTemp.Length + 1];
                userTemp.CopyTo(tempArray, 0);

                userTemp = tempArray;

                if (split.Length > 4)
                {
                    userTemp[userTemp.Length - 1] = new Manager(split[1], int.Parse(split[3]), int.Parse(split[5]));
                }
                else
                {
                    userTemp[userTemp.Length - 1] = new User(split[1], int.Parse(split[3]));
                }
            }

            allUsers = new AllUsers(userTemp);
            sr.Close();
        }


        private void AddUserToTXTList(User newUser)
        {
            StreamWriter sw1 = File.AppendText("UserList.txt");
            sw1.WriteLine(newUser.ToString());
            sw1.Close();
        }

        private void UpdateTXTusers()
        {
            StreamWriter sw1 = new StreamWriter("UserList.txt");
            int num = 0;

            while (allUsers[num] != null)
            {
                sw1.WriteLine(allUsers[num++].ToString());
            }

            sw1.Close();
        }


        //XML Code
        private void NewXML()
        {
            MoviesToXML = new XDocument();
            XElement root = new XElement("Movies_List");
            MoviesToXML.Add(root);

            MoviesToXML.Save("MoviesList.xml");
        }

        private void AddToXML(Movies movie)
        {
            MoviesToXML = XDocument.Load("MoviesList.xml");
            XElement root = MoviesToXML.Root;

            XElement MovieToAdd = new XElement("Movie", new XElement("Movie_Name", movie.Name));

            for (int i = 0; i < movie.Type.Count; i++)
            {
                MovieToAdd.Add(new XElement("Types_" + (i + 1), movie.Type[i]));
            }

            MovieToAdd.Add(new XElement("Movie_Duration", movie.MovieDuration),
                        new XElement("Grade", movie.Grade),
                        new XElement("Creator", movie.Creator),
                        new XElement("Year_Created", movie.YearCreated));

            if (movie is KidsMovie)
            {
                KidsMovie temp = movie as KidsMovie;
                MovieToAdd.Add(new XElement("Is_Dubbed", temp.IsDubbed));
            }
            else
            {
                AllAgesMovies temp = movie as AllAgesMovies;
                MovieToAdd.Add(new XElement("Age_Limit", temp.AgeLimit));
            }

            root.Add(MovieToAdd);
            MoviesToXML.Save("MoviesList.xml");
        }


        private void UploadMovieList()
        {
            MoviesToXML = XDocument.Load("MoviesList.xml");

            IEnumerable<XElement> movieList = MoviesToXML.Elements();

            List<string> tempList;

            List<string> typeList;

            List<XElement> tempList11 = new List<XElement>();


            IEnumerable<XElement> MoviesLinq = from item in movieList.Elements("Movie")
                                               select item;



            foreach (var item in MoviesLinq)
            {
                tempList = new List<string>();
                foreach (var i in item.Elements())
                {
                    tempList.Add((string)i);
                }

                typeList = new List<string> { tempList[1] };

                if (tempList.Count == 8)
                {
                    typeList.Add(tempList[2]);

                    if (tempList[7] == "true" || tempList[7] == "false")
                    {

                        listMovies.Add(new KidsMovie(tempList[0], int.Parse(tempList[6]), int.Parse(tempList[3]),
                        int.Parse(tempList[4]), tempList[5], typeList, bool.Parse(tempList[7])));

                    }
                    else
                    {
                        listMovies.Add(new AllAgesMovies(tempList[0], int.Parse(tempList[6]), int.Parse(tempList[3]),
                        int.Parse(tempList[4]), tempList[5], typeList, int.Parse(tempList[7])));
                    }
                }
                else
                {

                    if (tempList[6] == "true" || tempList[6] == "false")
                    {
                        listMovies.Add(new KidsMovie(tempList[0], int.Parse(tempList[5]), int.Parse(tempList[2]),
                         int.Parse(tempList[3]), tempList[4], typeList, bool.Parse(tempList[6])));
                    }
                    else
                    {

                        listMovies.Add(new AllAgesMovies(tempList[0], int.Parse(tempList[5]), int.Parse(tempList[2]),
                        int.Parse(tempList[3]), tempList[4], typeList, int.Parse(tempList[6])));
                    }

                }


            }

        }



        //check things related code:
        public bool CheckUserName(string userName)
        {
            if (!allUsers[userName])
            {
                return CheckName(userName.ToUpper());
            }
            else
            {
                MessageBox.Show("the username is taken, choose another one");
            }

            return false;
        }

        public bool CheckName(string name)
        {
            bool lettersOk = false;

            for (int i = 0; i < name.Length; i++)
            {

                if (65 <= name[i] && name[i] <= 90)
                {
                    lettersOk = true;
                }
                else if (0 <= name[i] && name[i] <= 9)
                {
                    return false;
                }
            }
            if (lettersOk && name.Length >= 2)
            {
                return true;
            }

            return false;

        }

        public bool CheckPassword(int password)
        {
            return password.ToString().Length == 6;
        }


        public bool CheckIfMovieNameExists(string name)
        {

            foreach (var item in listMovies)
            {
                if (item.Name.ToUpper() == name.ToUpper())
                {
                    return false;
                }
            }

            return true;
        }


        //DB related code:
        public void UpdateDataBase1(DataTable dt)
        {
            db.UpdateDataBase(dt);
            db.DBRefreshDB();
        }

        public DataTable BringDB()
        {
            return db.DBRefreshDB();
        }

        private void AddMovieToDB(Movies movie)
        {
            if (db.InsertMovie(movie) == 0)
            {
                MessageBox.Show("The movie wasnt inserted");
            }
           
        
        }

        public void DeleteMovieFromDB(int movieCode)
        {
            RemoveMovie(movieCode);

            NewXML();

            foreach (Movies item in listMovies)
            {
                AddToXML(item);
            }

            db.DeleteMovie(movieCode);

        }

        public DataTable SortWithProc(string sort)
        {
            return db.Sort(sort);
        }
    }
}
