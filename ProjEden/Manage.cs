using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProjEden_and_Ofir
{
    public partial class Manage : Form
    {
        LogIn logIn;

        public Manage(LogIn logInn)
        {
            InitializeComponent();
            logIn = logInn;
            ChangeVisibilityForOP();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                bool userOk = logIn.CheckUserName(txtUsername.Text);
                bool passwordOk = logIn.CheckPassword(int.Parse(txtPassword.Text));

                if (userOk && passwordOk)
                {
                    if (cbIsManager.Checked)
                    {
                        logIn.AddManager(txtUsername.Text, int.Parse(txtPassword.Text));
                    }
                    else
                    {
                        logIn.AddUser(txtUsername.Text, int.Parse(txtPassword.Text));
                    }

                    MessageBox.Show("The user has been added", "Success");
                    Close();

                }
                else if (!userOk && !passwordOk)
                {
                    lblPassword.ForeColor = Color.WhiteSmoke;
                    lblUserName.ForeColor = Color.WhiteSmoke;
                }
                else if (!userOk)
                {
                    lblUserName.ForeColor = Color.WhiteSmoke;
                    lblPassword.ForeColor = Color.Black;
                }
                else
                {
                    lblPassword.ForeColor = Color.WhiteSmoke;
                    lblUserName.ForeColor = Color.Black;
                }
            }
            catch (FormatException)
            {
                lblPassword.ForeColor = Color.Red;
            }
            catch (Exception)
            {
                MessageBox.Show("Please try again", "Error");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                logIn.DeleteUser(txtUsername.Text, int.Parse(txtPassword.Text));
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please try again","Error");
            }

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            bool dubbed = false; int ageLimit = 0;
            List<string> typeList = new List<string>();

            try
            {
                if (CheckMovie())
                {
                    foreach (var item in ClbType.CheckedItems)
                    {
                        typeList.Add(item.ToString());
                    }

                    if (cbKidsMovieCheck.Checked)
                    {
                        if (cmbDubbed.SelectedItem.ToString() == "yes")
                        {
                            dubbed = true;
                        }
                        logIn.AddKidsMovie(txtMovieName.Text, int.Parse(txtYearCreated.Text), int.Parse(txtMovieDuration.Text), int.Parse(txtGrade.Text), txtCreator.Text, typeList, dubbed);
                    }
                    else
                    {
                        if (cmbAgeLimit.SelectedItem != null)
                        {
                            ageLimit = int.Parse(cmbAgeLimit.SelectedItem.ToString());
                        }
                        logIn.AddAllAgesMovie(txtMovieName.Text, int.Parse(txtYearCreated.Text), int.Parse(txtMovieDuration.Text), int.Parse(txtGrade.Text), txtCreator.Text, typeList, ageLimit);
                    }

                    MessageBox.Show("The movie has been added successfully", "Success");
                    Close();
                }
                else
                {
                    MessageBox.Show("one or more values are invalid", "Error");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
                
            }
            catch (Exception)
            {

                MessageBox.Show("please try again", "Error"); ;
            }

        }

        private bool CheckMovie()
        {
            bool yearOK = false, creatorOK = false, nameOK = false, durationOK = false, gradeOK = false, checkTypeOK = false, condition = false;

            int yearCreated, movieDuration, movieGrade;
            string movieName = txtMovieName.Text.ToUpper();
            string creatorName = txtCreator.Text.ToUpper();

            //checkYear
            if (CheckIfonlyNums(txtYearCreated.Text))
            {
                yearCreated = int.Parse(txtYearCreated.Text);
                if (1960 <= yearCreated && yearCreated <= 2021)
                {
                    lblYearCreated.ForeColor = Color.Black;
                    yearOK = true;
                }
                else
                {
                    lblYearCreated.ForeColor = Color.IndianRed;
                }
            }
            else
            {
                lblYearCreated.ForeColor = Color.IndianRed;
            }

            //checkDuration
            if (CheckIfonlyNums(txtMovieDuration.Text))
            {
                movieDuration = int.Parse(txtMovieDuration.Text);

                if (75 <= movieDuration && movieDuration <= 210)
                {
                    lblMovieDuration.ForeColor = Color.Black;
                    durationOK = true;
                }
                else
                {
                    lblMovieDuration.ForeColor = Color.IndianRed;
                }

            }
            else
            {
                lblMovieDuration.ForeColor = Color.IndianRed;
            }
              
            //checkCreator
            if (logIn.CheckName(creatorName))
            {
                lblCreator.ForeColor = Color.Black;
                creatorOK = true;
            }
            else
            {
                lblCreator.ForeColor = Color.IndianRed;
            }


            //checkGrade
            if (CheckIfonlyNums(txtGrade.Text))
            {
                movieGrade = int.Parse(txtGrade.Text);
                if (1 <= movieGrade && movieGrade <= 10)
                {
                    lblGrade.ForeColor = Color.Black;
                    gradeOK = true;
                }
                else
                {
                    lblGrade.ForeColor = Color.IndianRed;
                }
            }
            else
            {
                lblGrade.ForeColor = Color.IndianRed;
            }

            //checkTypes
            if (ClbType.CheckedItems.Count == 0)
            {
                lblChooseType.ForeColor = Color.IndianRed;
            }
            else
            {
                lblChooseType.ForeColor = Color.Black;
                checkTypeOK = true;
            }

            //checkConditions
            if (cbKidsMovieCheck.Checked)
            {
                if (cmbDubbed.SelectedItem == null)
                {
                    lblKidsOp.ForeColor = Color.IndianRed;
                }
                else
                {
                    lblKidsOp.ForeColor = Color.Black;
                    condition = true;
                }
            }
            else
            {
                if (cmbAgeLimit.SelectedItem == null)
                {
                    lblAgeLimit.ForeColor = Color.IndianRed;
                }
                else
                {
                    lblAgeLimit.ForeColor = Color.Black;
                    condition = true;
                }
            }


            //checkMOvieName
            if (logIn.CheckName(movieName))
            {
                if (logIn.CheckIfMovieNameExists(movieName))
                {
                    lblMovieName.ForeColor = Color.Black;
                    nameOK = true;
                }
                else
                {
                    lblMovieName.ForeColor = Color.IndianRed;
                    throw new ArgumentException("movie with this name is already exists");
                }

            }
            else
            {
                lblMovieName.ForeColor = Color.IndianRed;

            }

            return gradeOK && creatorOK && nameOK && durationOK && yearOK && checkTypeOK && condition;
        }

        private bool CheckIfonlyNums(string checkNums)
        {
            try
            {
                int checkNums1 = int.Parse(checkNums);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void ChangeVisibilityForOP()
        {
            if (cbKidsMovieCheck.Checked)
            {
                gbOptionsForAll.Visible = false;
                gbOptionsForKids.Visible = true;

            }
            else
            {
                gbOptionsForAll.Visible = true;
                gbOptionsForKids.Visible = false;

            }
        }

        private void btnDeleteMovie_Click_1(object sender, EventArgs e)
        {
            logIn.DeleteMovieFromDB(int.Parse(txtDeleteMovie.Text));
            Close();
        }

        private void cbKidsMovieCheck_CheckedChanged_1(object sender, EventArgs e)
        {
            ChangeVisibilityForOP();
        }


        private void ClbType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (ClbType.CheckedItems.Count > 1)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }

        private void lblGradeInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Grade needs to be between 1 to 10", "Helper");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblDeleteMovieInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attention! after deleting a movie you must click\n on the refresh button in the cash screen","Helper");
        }

        private void btnPressToKnow_Click(object sender, EventArgs e)
        {
            lblBestSeller.Text = logIn.BestSeller();

            btnPressToKnow.Visible = false;
        }
    }
}
