namespace DbUserManagement
{
    partial class frmDbUserAcess
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ObjectList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSearchObject = new System.Windows.Forms.TextBox();
            this.btnRefreshConnection = new System.Windows.Forms.Button();
            this.UserList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtNewUserPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewUserLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCreateLogin = new System.Windows.Forms.Button();
            this.txtNewLoginPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNewLoginName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkDbLoginRoles = new System.Windows.Forms.CheckedListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDefaultLoginDatabase = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtAdminPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtLoginUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(288, 33);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(119, 22);
            this.txtServer.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Server";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(699, 61);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 27);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(699, 33);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '*';
            this.txtAdminPassword.Size = new System.Drawing.Size(109, 22);
            this.txtAdminPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(76, 34);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(110, 22);
            this.txtDatabase.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Database";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Location = new System.Drawing.Point(489, 33);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(119, 22);
            this.txtLoginUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // ObjectList
            // 
            this.ObjectList.FormattingEnabled = true;
            this.ObjectList.ItemHeight = 16;
            this.ObjectList.Location = new System.Drawing.Point(175, 69);
            this.ObjectList.MultiColumn = true;
            this.ObjectList.Name = "ObjectList";
            this.ObjectList.ScrollAlwaysVisible = true;
            this.ObjectList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ObjectList.Size = new System.Drawing.Size(637, 244);
            this.ObjectList.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Grant Access";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Table",
            "View",
            "Stored Procedure"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "View",
            "Table",
            "Stored Procedure"});
            this.comboBox1.Location = new System.Drawing.Point(15, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-182, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Object Type";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(39, 133);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 347);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.txtSearchObject);
            this.tabPage1.Controls.Add(this.btnRefreshConnection);
            this.tabPage1.Controls.Add(this.UserList);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ObjectList);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grant Access";
            // 
            // txtSearchObject
            // 
            this.txtSearchObject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchObject.Location = new System.Drawing.Point(175, 41);
            this.txtSearchObject.Name = "txtSearchObject";
            this.txtSearchObject.Size = new System.Drawing.Size(323, 22);
            this.txtSearchObject.TabIndex = 6;
            this.txtSearchObject.TextChanged += new System.EventHandler(this.txtSearchObject_TextChanged);
            this.txtSearchObject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchObject_KeyDown);
            // 
            // btnRefreshConnection
            // 
            this.btnRefreshConnection.Location = new System.Drawing.Point(11, 18);
            this.btnRefreshConnection.Name = "btnRefreshConnection";
            this.btnRefreshConnection.Size = new System.Drawing.Size(158, 27);
            this.btnRefreshConnection.TabIndex = 11;
            this.btnRefreshConnection.Text = "Refresh Connection";
            this.btnRefreshConnection.UseVisualStyleBackColor = true;
            this.btnRefreshConnection.Click += new System.EventHandler(this.btnRefreshConnection_Click);
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(11, 84);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(146, 24);
            this.UserList.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Select User";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnCreateUser);
            this.tabPage2.Controls.Add(this.txtNewUserPassword);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtNewUserLogin);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtNewUser);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create User";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Enabled = false;
            this.btnCreateUser.Location = new System.Drawing.Point(569, 74);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(184, 23);
            this.btnCreateUser.TabIndex = 6;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // txtNewUserPassword
            // 
            this.txtNewUserPassword.Location = new System.Drawing.Point(569, 25);
            this.txtNewUserPassword.Name = "txtNewUserPassword";
            this.txtNewUserPassword.PasswordChar = '*';
            this.txtNewUserPassword.Size = new System.Drawing.Size(184, 22);
            this.txtNewUserPassword.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(494, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Password";
            // 
            // txtNewUserLogin
            // 
            this.txtNewUserLogin.Location = new System.Drawing.Point(310, 25);
            this.txtNewUserLogin.Name = "txtNewUserLogin";
            this.txtNewUserLogin.Size = new System.Drawing.Size(153, 22);
            this.txtNewUserLogin.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Login";
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(78, 25);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(138, 22);
            this.txtNewUser.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(514, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Type search text and press Enter";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtDefaultLoginDatabase);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.chkDbLoginRoles);
            this.tabPage3.Controls.Add(this.btnCreateLogin);
            this.tabPage3.Controls.Add(this.txtNewLoginPassword);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtNewLoginName);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(818, 318);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create Login";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.Enabled = false;
            this.btnCreateLogin.Location = new System.Drawing.Point(579, 250);
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.Size = new System.Drawing.Size(145, 48);
            this.btnCreateLogin.TabIndex = 11;
            this.btnCreateLogin.Text = "Create Login";
            this.btnCreateLogin.UseVisualStyleBackColor = true;
            this.btnCreateLogin.Click += new System.EventHandler(this.btnCreateLogin_Click);
            // 
            // txtNewLoginPassword
            // 
            this.txtNewLoginPassword.Location = new System.Drawing.Point(376, 27);
            this.txtNewLoginPassword.Name = "txtNewLoginPassword";
            this.txtNewLoginPassword.PasswordChar = '*';
            this.txtNewLoginPassword.Size = new System.Drawing.Size(184, 22);
            this.txtNewLoginPassword.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Password";
            // 
            // txtNewLoginName
            // 
            this.txtNewLoginName.Location = new System.Drawing.Point(117, 27);
            this.txtNewLoginName.Name = "txtNewLoginName";
            this.txtNewLoginName.Size = new System.Drawing.Size(153, 22);
            this.txtNewLoginName.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Login";
            // 
            // chkDbLoginRoles
            // 
            this.chkDbLoginRoles.FormattingEnabled = true;
            this.chkDbLoginRoles.Items.AddRange(new object[] {
            "bulkadmin",
            "dbcreator",
            "diskadmin",
            "processadmin",
            "public",
            "securityadmin",
            "serveradmin",
            "setupadmin",
            "sysadmin"});
            this.chkDbLoginRoles.Location = new System.Drawing.Point(55, 103);
            this.chkDbLoginRoles.Name = "chkDbLoginRoles";
            this.chkDbLoginRoles.Size = new System.Drawing.Size(120, 174);
            this.chkDbLoginRoles.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Roles";
            // 
            // txtDefaultLoginDatabase
            // 
            this.txtDefaultLoginDatabase.Location = new System.Drawing.Point(232, 103);
            this.txtDefaultLoginDatabase.Name = "txtDefaultLoginDatabase";
            this.txtDefaultLoginDatabase.Size = new System.Drawing.Size(184, 22);
            this.txtDefaultLoginDatabase.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(229, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Default Database";
            // 
            // frmDbUserAcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDbUserAcess";
            this.Text = "Database Access Managment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ObjectList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNewUserLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewUserPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox UserList;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnRefreshConnection;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchObject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox chkDbLoginRoles;
        private System.Windows.Forms.Button btnCreateLogin;
        private System.Windows.Forms.TextBox txtNewLoginPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNewLoginName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDefaultLoginDatabase;
        private System.Windows.Forms.Label label15;
    }
}

