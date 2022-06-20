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
    public partial class About : Form
    {
        string name, details;           

        public About(string name,string details)
        {
            InitializeComponent();
            this.name = name;
            this.details = details;

            ShowDetails();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowDetails()
        {
            lblMovieName.Text = name;

            lblMovieDetails.Text = details;
        }
    }
}
