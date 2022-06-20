using System;
using System.Data;
using System.Windows.Forms;

namespace FinalProjEden_and_Ofir
{
    public partial class Cashier : Form
    {

        int access;
        LogIn logIn;

        int HowManyTotal = 0;
        int howMuchTotalPrice = 0;

        public bool AccessGranted { get; set; }

        public bool StartedPayment { get; set; }

        public Cashier(LogIn form, int access)
        {
            InitializeComponent();
            logIn = form;
            this.access = access;
            AccessGranted = false;
            StartedPayment = false;

            NoAccess();
            RefreshDB();
        }

        private void NoAccess()
        {
            btnManageOpen.Visible = false;
            btn0.Visible = false;
            btnEnterManager.Visible = true;
        }

        public void GiveAccess()
        {
            AccessGranted = true;
            btnEnterManager.Visible = false;
            btnManageOpen.Visible = true;
            btn0.Visible = true;
        }

        private void btnEnterManager_Click(object sender, EventArgs e)
        {
            EnterAccess enterAccess = new EnterAccess(this, access);
            enterAccess.ShowDialog();
        }

        private void btnManageOpen_Click(object sender, EventArgs e)
        {
            logIn.OpenManageForm();
        }

        private void btnExitManagerAccess_Click(object sender, EventArgs e)
        {
            NoAccess();
            AccessGranted = false;
        }

        //Order related code

        private void btn0_Click(object sender, EventArgs e)
        {
            CloseDeal(0);
        }

        private void btn15_Click_1(object sender, EventArgs e)
        {
            CloseDeal(15);
        }

        private void btn27_Click_1(object sender, EventArgs e)
        {
            CloseDeal(27);
        }

        private void btn40_Click_1(object sender, EventArgs e)
        {
            CloseDeal(40);
        }

        private void CleanTextAndLebels()
        {
            lblMovieChose.Text = "";
            txtTotalPrice.Text = "";
            lblHowManyPpl.Text = "";

            lblHowMuchCost.Text = "";
            txtHowMany.Text = "";

            txtMovieName.Text = "";
            lblHowMuchToPay.Text = "";

            HowManyTotal = 0;
            howMuchTotalPrice = 0;
        }

        private void btnEnjoy_Click(object sender, EventArgs e)
        {
            if (txtTotalPrice.TextLength != 0)
            {
                logIn.AddPayToUser(HowManyTotal);
                CleanTextAndLebels();
                StartedPayment = false;

                MessageBox.Show("Thanks for your order, Enjoy the movie!", "Success");          
            }
        }

        private void CloseDeal(int price)
        {
            try
            {
                int howManyNum, howMuchToPay;

                if (txtHowMany.TextLength != 0 && txtMovieName.TextLength != 0)
                {
                    howManyNum = int.Parse(txtHowMany.Text);

                    if (lblMovieChose.Text.Length == 0)
                    {
                        lblMovieChose.Text = txtMovieName.Text;
                        StartedPayment = true;
                    }

                    lblHowMuchCost.Text += "\n" + price;
                    lblHowManyPpl.Text += "\n" + txtHowMany.Text;

                    howMuchToPay = howManyNum * price;
                    lblHowMuchToPay.Text += "\n" + howMuchToPay.ToString();

                    howMuchTotalPrice += howMuchToPay;
                    txtTotalPrice.Text = howMuchTotalPrice + " shekels";

                    HowManyTotal += howManyNum;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("try to insert valid options", "Error");

            }
            catch (Exception)
            {
                MessageBox.Show("There is a missing information...", "Error");
            }

        }

        ////DB code     

        private void dgvMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!StartedPayment)
            {
                if (e.ColumnIndex == 1)
                {
                    txtMovieName.Text = dgvMovies.CurrentCell.Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("One movie at a time!", "Error");

            }
        }

        private void RefreshDB()
        {
            dgvMovies.DataSource = logIn.BringDB();
        }

        private void cancelSort_Click_1(object sender, EventArgs e)
        {
            RefreshDB();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {      
            RefreshDB();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            logIn.OpenAbout(txtMovieName.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            CleanTextAndLebels();
            StartedPayment = false;
        }

        private void SortBy(string sort)
        {
            DataTable movies = logIn.BringDB();

            var action = from movieSort in movies.AsEnumerable()
                         where movieSort["Type1"].ToString() == sort || movieSort["Type2"].ToString() == sort
                         orderby "MovieName"
                         select movieSort;

            DataView view = action.AsDataView();
            dgvMovies.DataSource = view;
        }

        private void sortAction_Click_1(object sender, EventArgs e)
        {
            SortBy("Action");
        }


        private void sortComedy_Click_1(object sender, EventArgs e)
        {
            SortBy("Comedy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortBy("Drama");
        }

        private void btnSortFamily_Click(object sender, EventArgs e)
        {
            SortBy("Family");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvMovies.DataSource = logIn.SortWithProc("Horror");
        }

        private void lblGradeInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on the movie the costumer chooses,\ninsert how many tickets and then choose the amount!","Helper");
        }
    }
}

