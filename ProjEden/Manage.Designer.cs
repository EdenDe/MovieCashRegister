
namespace FinalProjEden_and_Ofir
{
    partial class Manage
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gbAddUser = new System.Windows.Forms.GroupBox();
            this.btnPressToKnow = new System.Windows.Forms.Button();
            this.lblBestSeller = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsManager = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbAddMovie = new System.Windows.Forms.GroupBox();
            this.lblDeleteMovieInfo = new System.Windows.Forms.Label();
            this.lblGradeInfo = new System.Windows.Forms.Label();
            this.lblChooseType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbOptionsForAll = new System.Windows.Forms.GroupBox();
            this.cmbAgeLimit = new System.Windows.Forms.ComboBox();
            this.lblAgeLimit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.txtDeleteMovie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClbType = new System.Windows.Forms.CheckedListBox();
            this.gbOptionsForKids = new System.Windows.Forms.GroupBox();
            this.cmbDubbed = new System.Windows.Forms.ComboBox();
            this.lblKidsOp = new System.Windows.Forms.Label();
            this.cbKidsMovieCheck = new System.Windows.Forms.CheckBox();
            this.lblYearCreated = new System.Windows.Forms.Label();
            this.txtYearCreated = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblMovieDuration = new System.Windows.Forms.Label();
            this.txtMovieDuration = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gbAddUser.SuspendLayout();
            this.gbAddMovie.SuspendLayout();
            this.gbOptionsForAll.SuspendLayout();
            this.gbOptionsForKids.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddUser.Location = new System.Drawing.Point(16, 321);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(82, 48);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddMovie.Location = new System.Drawing.Point(206, 272);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(116, 31);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Linen;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUsername.Location = new System.Drawing.Point(23, 171);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUserName.Location = new System.Drawing.Point(20, 145);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(85, 19);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User name:";
            // 
            // gbAddUser
            // 
            this.gbAddUser.BackColor = System.Drawing.Color.Transparent;
            this.gbAddUser.Controls.Add(this.btnPressToKnow);
            this.gbAddUser.Controls.Add(this.lblBestSeller);
            this.gbAddUser.Controls.Add(this.label1);
            this.gbAddUser.Controls.Add(this.cbIsManager);
            this.gbAddUser.Controls.Add(this.txtPassword);
            this.gbAddUser.Controls.Add(this.lblPassword);
            this.gbAddUser.Controls.Add(this.btnDelete);
            this.gbAddUser.Controls.Add(this.lblUserName);
            this.gbAddUser.Controls.Add(this.txtUsername);
            this.gbAddUser.Controls.Add(this.btnAddUser);
            this.gbAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbAddUser.Location = new System.Drawing.Point(2, -1);
            this.gbAddUser.Name = "gbAddUser";
            this.gbAddUser.Size = new System.Drawing.Size(265, 382);
            this.gbAddUser.TabIndex = 4;
            this.gbAddUser.TabStop = false;
            // 
            // btnPressToKnow
            // 
            this.btnPressToKnow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPressToKnow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPressToKnow.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPressToKnow.Location = new System.Drawing.Point(24, 34);
            this.btnPressToKnow.Name = "btnPressToKnow";
            this.btnPressToKnow.Size = new System.Drawing.Size(188, 49);
            this.btnPressToKnow.TabIndex = 11;
            this.btnPressToKnow.Text = "Press here to know who is the best seller!";
            this.btnPressToKnow.UseVisualStyleBackColor = false;
            this.btnPressToKnow.Click += new System.EventHandler(this.btnPressToKnow_Click);
            // 
            // lblBestSeller
            // 
            this.lblBestSeller.AutoSize = true;
            this.lblBestSeller.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBestSeller.Location = new System.Drawing.Point(43, 41);
            this.lblBestSeller.Name = "lblBestSeller";
            this.lblBestSeller.Size = new System.Drawing.Size(98, 39);
            this.lblBestSeller.TabIndex = 10;
            this.lblBestSeller.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(17, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add/Delete User!";
            // 
            // cbIsManager
            // 
            this.cbIsManager.AutoSize = true;
            this.cbIsManager.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbIsManager.Location = new System.Drawing.Point(23, 272);
            this.cbIsManager.Name = "cbIsManager";
            this.cbIsManager.Size = new System.Drawing.Size(189, 23);
            this.cbIsManager.TabIndex = 8;
            this.cbIsManager.Text = "is the worker manager?";
            this.cbIsManager.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Linen;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPassword.Location = new System.Drawing.Point(23, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPassword.Location = new System.Drawing.Point(20, 209);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.Location = new System.Drawing.Point(131, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 48);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "delete User";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbAddMovie
            // 
            this.gbAddMovie.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gbAddMovie.Controls.Add(this.lblDeleteMovieInfo);
            this.gbAddMovie.Controls.Add(this.lblGradeInfo);
            this.gbAddMovie.Controls.Add(this.lblChooseType);
            this.gbAddMovie.Controls.Add(this.label5);
            this.gbAddMovie.Controls.Add(this.gbOptionsForAll);
            this.gbAddMovie.Controls.Add(this.label4);
            this.gbAddMovie.Controls.Add(this.btnDeleteMovie);
            this.gbAddMovie.Controls.Add(this.txtDeleteMovie);
            this.gbAddMovie.Controls.Add(this.label2);
            this.gbAddMovie.Controls.Add(this.ClbType);
            this.gbAddMovie.Controls.Add(this.gbOptionsForKids);
            this.gbAddMovie.Controls.Add(this.cbKidsMovieCheck);
            this.gbAddMovie.Controls.Add(this.btnAddMovie);
            this.gbAddMovie.Controls.Add(this.lblYearCreated);
            this.gbAddMovie.Controls.Add(this.txtYearCreated);
            this.gbAddMovie.Controls.Add(this.txtGrade);
            this.gbAddMovie.Controls.Add(this.lblGrade);
            this.gbAddMovie.Controls.Add(this.lblMovieName);
            this.gbAddMovie.Controls.Add(this.txtMovieName);
            this.gbAddMovie.Controls.Add(this.txtCreator);
            this.gbAddMovie.Controls.Add(this.lblCreator);
            this.gbAddMovie.Controls.Add(this.lblMovieDuration);
            this.gbAddMovie.Controls.Add(this.txtMovieDuration);
            this.gbAddMovie.Location = new System.Drawing.Point(267, -1);
            this.gbAddMovie.Name = "gbAddMovie";
            this.gbAddMovie.Size = new System.Drawing.Size(536, 457);
            this.gbAddMovie.TabIndex = 6;
            this.gbAddMovie.TabStop = false;
            // 
            // lblDeleteMovieInfo
            // 
            this.lblDeleteMovieInfo.AutoSize = true;
            this.lblDeleteMovieInfo.BackColor = System.Drawing.Color.LightCyan;
            this.lblDeleteMovieInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeleteMovieInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDeleteMovieInfo.Location = new System.Drawing.Point(413, 408);
            this.lblDeleteMovieInfo.Name = "lblDeleteMovieInfo";
            this.lblDeleteMovieInfo.Size = new System.Drawing.Size(18, 21);
            this.lblDeleteMovieInfo.TabIndex = 21;
            this.lblDeleteMovieInfo.Text = "?";
            this.lblDeleteMovieInfo.Click += new System.EventHandler(this.lblDeleteMovieInfo_Click);
            // 
            // lblGradeInfo
            // 
            this.lblGradeInfo.AutoSize = true;
            this.lblGradeInfo.BackColor = System.Drawing.Color.LightCyan;
            this.lblGradeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGradeInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGradeInfo.Location = new System.Drawing.Point(223, 62);
            this.lblGradeInfo.Name = "lblGradeInfo";
            this.lblGradeInfo.Size = new System.Drawing.Size(18, 21);
            this.lblGradeInfo.TabIndex = 20;
            this.lblGradeInfo.Text = "?";
            this.lblGradeInfo.Click += new System.EventHandler(this.lblGradeInfo_Click);
            // 
            // lblChooseType
            // 
            this.lblChooseType.AutoSize = true;
            this.lblChooseType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblChooseType.Location = new System.Drawing.Point(340, 132);
            this.lblChooseType.Name = "lblChooseType";
            this.lblChooseType.Size = new System.Drawing.Size(128, 19);
            this.lblChooseType.TabIndex = 19;
            this.lblChooseType.Text = "Choose 1-2 types:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(178, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 33);
            this.label5.TabIndex = 18;
            this.label5.Text = "Delete movie!";
            // 
            // gbOptionsForAll
            // 
            this.gbOptionsForAll.Controls.Add(this.cmbAgeLimit);
            this.gbOptionsForAll.Controls.Add(this.lblAgeLimit);
            this.gbOptionsForAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gbOptionsForAll.Location = new System.Drawing.Point(116, 171);
            this.gbOptionsForAll.Name = "gbOptionsForAll";
            this.gbOptionsForAll.Size = new System.Drawing.Size(180, 86);
            this.gbOptionsForAll.TabIndex = 16;
            this.gbOptionsForAll.TabStop = false;
            // 
            // cmbAgeLimit
            // 
            this.cmbAgeLimit.BackColor = System.Drawing.Color.Linen;
            this.cmbAgeLimit.FormattingEnabled = true;
            this.cmbAgeLimit.Items.AddRange(new object[] {
            "0",
            "12",
            "14",
            "16",
            "18"});
            this.cmbAgeLimit.Location = new System.Drawing.Point(35, 38);
            this.cmbAgeLimit.Name = "cmbAgeLimit";
            this.cmbAgeLimit.Size = new System.Drawing.Size(108, 27);
            this.cmbAgeLimit.TabIndex = 16;
            // 
            // lblAgeLimit
            // 
            this.lblAgeLimit.AutoSize = true;
            this.lblAgeLimit.Location = new System.Drawing.Point(6, 16);
            this.lblAgeLimit.Name = "lblAgeLimit";
            this.lblAgeLimit.Size = new System.Drawing.Size(155, 19);
            this.lblAgeLimit.TabIndex = 15;
            this.lblAgeLimit.Text = "what is the age limit?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(166, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add movie!";
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDeleteMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMovie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(268, 403);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(129, 28);
            this.btnDeleteMovie.TabIndex = 8;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click_1);
            // 
            // txtDeleteMovie
            // 
            this.txtDeleteMovie.BackColor = System.Drawing.SystemColors.Info;
            this.txtDeleteMovie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDeleteMovie.Location = new System.Drawing.Point(157, 404);
            this.txtDeleteMovie.Name = "txtDeleteMovie";
            this.txtDeleteMovie.Size = new System.Drawing.Size(89, 27);
            this.txtDeleteMovie.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(109, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "insert the movie code you would like to delete:";
            // 
            // ClbType
            // 
            this.ClbType.BackColor = System.Drawing.Color.Linen;
            this.ClbType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ClbType.FormattingEnabled = true;
            this.ClbType.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Family",
            "Drama",
            "Horror"});
            this.ClbType.Location = new System.Drawing.Point(359, 154);
            this.ClbType.Name = "ClbType";
            this.ClbType.Size = new System.Drawing.Size(88, 114);
            this.ClbType.TabIndex = 17;
            this.ClbType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbType_ItemCheck);
            // 
            // gbOptionsForKids
            // 
            this.gbOptionsForKids.Controls.Add(this.cmbDubbed);
            this.gbOptionsForKids.Controls.Add(this.lblKidsOp);
            this.gbOptionsForKids.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gbOptionsForKids.Location = new System.Drawing.Point(134, 175);
            this.gbOptionsForKids.Name = "gbOptionsForKids";
            this.gbOptionsForKids.Size = new System.Drawing.Size(168, 82);
            this.gbOptionsForKids.TabIndex = 15;
            this.gbOptionsForKids.TabStop = false;
            // 
            // cmbDubbed
            // 
            this.cmbDubbed.BackColor = System.Drawing.Color.Linen;
            this.cmbDubbed.FormattingEnabled = true;
            this.cmbDubbed.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cmbDubbed.Location = new System.Drawing.Point(6, 43);
            this.cmbDubbed.Name = "cmbDubbed";
            this.cmbDubbed.Size = new System.Drawing.Size(108, 27);
            this.cmbDubbed.TabIndex = 17;
            // 
            // lblKidsOp
            // 
            this.lblKidsOp.AutoSize = true;
            this.lblKidsOp.Location = new System.Drawing.Point(6, 16);
            this.lblKidsOp.Name = "lblKidsOp";
            this.lblKidsOp.Size = new System.Drawing.Size(156, 19);
            this.lblKidsOp.TabIndex = 13;
            this.lblKidsOp.Text = "is the movie dubbed?";
            // 
            // cbKidsMovieCheck
            // 
            this.cbKidsMovieCheck.AutoSize = true;
            this.cbKidsMovieCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbKidsMovieCheck.Location = new System.Drawing.Point(172, 142);
            this.cbKidsMovieCheck.Name = "cbKidsMovieCheck";
            this.cbKidsMovieCheck.Size = new System.Drawing.Size(103, 23);
            this.cbKidsMovieCheck.TabIndex = 13;
            this.cbKidsMovieCheck.Text = "Kids Movie";
            this.cbKidsMovieCheck.UseVisualStyleBackColor = true;
            this.cbKidsMovieCheck.CheckedChanged += new System.EventHandler(this.cbKidsMovieCheck_CheckedChanged_1);
            // 
            // lblYearCreated
            // 
            this.lblYearCreated.AutoSize = true;
            this.lblYearCreated.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblYearCreated.Location = new System.Drawing.Point(409, 64);
            this.lblYearCreated.Name = "lblYearCreated";
            this.lblYearCreated.Size = new System.Drawing.Size(99, 19);
            this.lblYearCreated.TabIndex = 11;
            this.lblYearCreated.Text = "Year Created:";
            // 
            // txtYearCreated
            // 
            this.txtYearCreated.BackColor = System.Drawing.Color.Linen;
            this.txtYearCreated.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtYearCreated.Location = new System.Drawing.Point(413, 86);
            this.txtYearCreated.MaxLength = 4;
            this.txtYearCreated.Name = "txtYearCreated";
            this.txtYearCreated.Size = new System.Drawing.Size(91, 27);
            this.txtYearCreated.TabIndex = 10;
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.Color.Linen;
            this.txtGrade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtGrade.Location = new System.Drawing.Point(172, 86);
            this.txtGrade.MaxLength = 2;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(72, 27);
            this.txtGrade.TabIndex = 9;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGrade.Location = new System.Drawing.Point(168, 64);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(54, 19);
            this.lblGrade.TabIndex = 8;
            this.lblGrade.Text = "Grade:";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMovieName.Location = new System.Drawing.Point(6, 64);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(144, 19);
            this.lblMovieName.TabIndex = 7;
            this.lblMovieName.Text = "Name of the movie:";
            // 
            // txtMovieName
            // 
            this.txtMovieName.BackColor = System.Drawing.Color.Linen;
            this.txtMovieName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMovieName.Location = new System.Drawing.Point(9, 86);
            this.txtMovieName.MaxLength = 20;
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(133, 27);
            this.txtMovieName.TabIndex = 6;
            // 
            // txtCreator
            // 
            this.txtCreator.BackColor = System.Drawing.Color.Linen;
            this.txtCreator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCreator.Location = new System.Drawing.Point(10, 142);
            this.txtCreator.MaxLength = 20;
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(132, 27);
            this.txtCreator.TabIndex = 5;
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCreator.Location = new System.Drawing.Point(10, 120);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(64, 19);
            this.lblCreator.TabIndex = 4;
            this.lblCreator.Text = "Creator:";
            // 
            // lblMovieDuration
            // 
            this.lblMovieDuration.AutoSize = true;
            this.lblMovieDuration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMovieDuration.Location = new System.Drawing.Point(264, 64);
            this.lblMovieDuration.Name = "lblMovieDuration";
            this.lblMovieDuration.Size = new System.Drawing.Size(120, 19);
            this.lblMovieDuration.TabIndex = 3;
            this.lblMovieDuration.Text = "Movie Duration:";
            // 
            // txtMovieDuration
            // 
            this.txtMovieDuration.BackColor = System.Drawing.Color.Linen;
            this.txtMovieDuration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMovieDuration.Location = new System.Drawing.Point(268, 86);
            this.txtMovieDuration.MaxLength = 3;
            this.txtMovieDuration.Name = "txtMovieDuration";
            this.txtMovieDuration.Size = new System.Drawing.Size(116, 27);
            this.txtMovieDuration.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DimGray;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Location = new System.Drawing.Point(45, 396);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(169, 42);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbAddMovie);
            this.Controls.Add(this.gbAddUser);
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.gbAddUser.ResumeLayout(false);
            this.gbAddUser.PerformLayout();
            this.gbAddMovie.ResumeLayout(false);
            this.gbAddMovie.PerformLayout();
            this.gbOptionsForAll.ResumeLayout(false);
            this.gbOptionsForAll.PerformLayout();
            this.gbOptionsForKids.ResumeLayout(false);
            this.gbOptionsForKids.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox gbAddUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gbAddMovie;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblMovieDuration;
        private System.Windows.Forms.TextBox txtMovieDuration;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.CheckBox cbIsManager;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblYearCreated;
        private System.Windows.Forms.TextBox txtYearCreated;
        private System.Windows.Forms.CheckBox cbKidsMovieCheck;
        private System.Windows.Forms.GroupBox gbOptionsForAll;
        private System.Windows.Forms.Label lblAgeLimit;
        private System.Windows.Forms.GroupBox gbOptionsForKids;
        private System.Windows.Forms.Label lblKidsOp;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.TextBox txtDeleteMovie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAgeLimit;
        private System.Windows.Forms.ComboBox cmbDubbed;
        private System.Windows.Forms.CheckedListBox ClbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblChooseType;
        private System.Windows.Forms.Label lblGradeInfo;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDeleteMovieInfo;
        private System.Windows.Forms.Button btnPressToKnow;
        private System.Windows.Forms.Label lblBestSeller;
    }
}