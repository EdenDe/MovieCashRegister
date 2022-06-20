using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjEden_and_Ofir
{
    public partial class EnterAccess : Form
    {
        int access, tries;
        Cashier form2;


        public EnterAccess(Cashier form2,int access)
        {
            InitializeComponent();
            this.access= access;
            this.form2 = form2;
            StartPoint();
        }

        private void StartPoint()
        {
            lblTimer.Text = "30";
            tries = 3;
            lblTries.Visible = false;

            txtEnterAccess.ReadOnly = false;
            lblTimer.Visible = false;          
        }

        private void tmUntilNextTry_Tick(object sender, EventArgs e)
        {
            lblTimer.Visible = true;
            lblTimer.Text = (int.Parse(lblTimer.Text) - 1).ToString();
            if (lblTimer.Text == "0")
            {
                tmUntilNextTry.Stop();
                MessageBox.Show("You can try again now");
                StartPoint();
            }            
        }

        private void lblEnterAccess_Click(object sender, EventArgs e)
        {
            if (access.ToString() == txtEnterAccess.Text)
            {
                MessageBox.Show("access granted", "Success");
                form2.GiveAccess();     
                Close();                            
            }
            else
            {
               
                if (tries == 1)
                {                  
                    tmUntilNextTry.Start();
                    lblTries.Text = "falied to log in, please try again in";
                    txtEnterAccess.ReadOnly = true;
                }
                else
                {

                    lblTries.Visible = true;
                    lblTries.Text = "                you got " + --tries + " more tries";
                }

                txtEnterAccess.Text = "";
            }           
        }
    }
}
