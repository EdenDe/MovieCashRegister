
namespace FinalProjEden_and_Ofir
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblMovieDetails = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMovieName.Location = new System.Drawing.Point(227, 61);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(147, 59);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "label1";
            // 
            // lblMovieDetails
            // 
            this.lblMovieDetails.AutoSize = true;
            this.lblMovieDetails.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblMovieDetails.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMovieDetails.Location = new System.Drawing.Point(42, 173);
            this.lblMovieDetails.Name = "lblMovieDetails";
            this.lblMovieDetails.Size = new System.Drawing.Size(84, 33);
            this.lblMovieDetails.TabIndex = 1;
            this.lblMovieDetails.Text = "label1";
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BtnReturn.Location = new System.Drawing.Point(23, 381);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(87, 46);
            this.BtnReturn.TabIndex = 2;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.lblMovieDetails);
            this.Controls.Add(this.lblMovieName);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblMovieDetails;
        private System.Windows.Forms.Button BtnReturn;
    }
}