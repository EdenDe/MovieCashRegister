
namespace FinalProjEden_and_Ofir
{
    partial class EnterAccess
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
            this.components = new System.ComponentModel.Container();
            this.btnEnterAccess = new System.Windows.Forms.Button();
            this.txtEnterAccess = new System.Windows.Forms.TextBox();
            this.lblEnterAccess = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.tmUntilNextTry = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnterAccess
            // 
            this.btnEnterAccess.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEnterAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterAccess.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEnterAccess.Location = new System.Drawing.Point(166, 161);
            this.btnEnterAccess.Name = "btnEnterAccess";
            this.btnEnterAccess.Size = new System.Drawing.Size(79, 40);
            this.btnEnterAccess.TabIndex = 0;
            this.btnEnterAccess.Text = "Enter";
            this.btnEnterAccess.UseVisualStyleBackColor = false;
            this.btnEnterAccess.Click += new System.EventHandler(this.lblEnterAccess_Click);
            // 
            // txtEnterAccess
            // 
            this.txtEnterAccess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEnterAccess.Location = new System.Drawing.Point(144, 80);
            this.txtEnterAccess.Name = "txtEnterAccess";
            this.txtEnterAccess.Size = new System.Drawing.Size(129, 27);
            this.txtEnterAccess.TabIndex = 1;
            // 
            // lblEnterAccess
            // 
            this.lblEnterAccess.AutoSize = true;
            this.lblEnterAccess.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEnterAccess.Location = new System.Drawing.Point(68, 20);
            this.lblEnterAccess.Name = "lblEnterAccess";
            this.lblEnterAccess.Size = new System.Drawing.Size(277, 33);
            this.lblEnterAccess.TabIndex = 2;
            this.lblEnterAccess.Text = "Enter your access code:";
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.BackColor = System.Drawing.Color.Transparent;
            this.lblTries.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTries.ForeColor = System.Drawing.Color.Black;
            this.lblTries.Location = new System.Drawing.Point(70, 126);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(241, 19);
            this.lblTries.TabIndex = 3;
            this.lblTries.Text = "falied to log in, please try again in";
            // 
            // tmUntilNextTry
            // 
            this.tmUntilNextTry.Interval = 1000;
            this.tmUntilNextTry.Tick += new System.EventHandler(this.tmUntilNextTry_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTimer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTimer.Location = new System.Drawing.Point(311, 126);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(25, 19);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "30";
            // 
            // EnterAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(426, 241);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.lblEnterAccess);
            this.Controls.Add(this.txtEnterAccess);
            this.Controls.Add(this.btnEnterAccess);
            this.Name = "EnterAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterAccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterAccess;
        private System.Windows.Forms.TextBox txtEnterAccess;
        private System.Windows.Forms.Label lblEnterAccess;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Timer tmUntilNextTry;
        private System.Windows.Forms.Label lblTimer;
    }
}