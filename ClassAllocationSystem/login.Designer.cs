namespace ClassAllocationSystem
{
    partial class login
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
            this.signIn = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTitle = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.radioStudents = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioHod = new System.Windows.Forms.RadioButton();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signIn
            // 
            this.signIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.signIn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.Location = new System.Drawing.Point(120, 240);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(82, 34);
            this.signIn.TabIndex = 1;
            this.signIn.Text = "SignIn";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(90, 98);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(228, 20);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(90, 141);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(228, 20);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.usernameLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(10, 98);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(74, 20);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(10, 139);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(72, 20);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loginTitle.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.Location = new System.Drawing.Point(103, 0);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(99, 37);
            this.loginTitle.TabIndex = 6;
            this.loginTitle.Text = "LOGIN";
            // 
            // loginPanel
            // 
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.radioStudents);
            this.loginPanel.Controls.Add(this.radioAdmin);
            this.loginPanel.Controls.Add(this.radioHod);
            this.loginPanel.Controls.Add(this.loginTitle);
            this.loginPanel.Controls.Add(this.usernameBox);
            this.loginPanel.Controls.Add(this.signIn);
            this.loginPanel.Controls.Add(this.passwordBox);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginPanel.Location = new System.Drawing.Point(42, 17);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(323, 294);
            this.loginPanel.TabIndex = 7;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // radioStudents
            // 
            this.radioStudents.AutoSize = true;
            this.radioStudents.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStudents.Location = new System.Drawing.Point(231, 197);
            this.radioStudents.Name = "radioStudents";
            this.radioStudents.Size = new System.Drawing.Size(73, 20);
            this.radioStudents.TabIndex = 11;
            this.radioStudents.Text = "Student";
            this.radioStudents.UseVisualStyleBackColor = true;
            this.radioStudents.CheckedChanged += new System.EventHandler(this.radioStudents_CheckedChanged);
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioAdmin.Location = new System.Drawing.Point(78, 199);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(60, 18);
            this.radioAdmin.TabIndex = 12;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            this.radioAdmin.CheckedChanged += new System.EventHandler(this.radioAdmin_CheckedChanged);
            // 
            // radioHod
            // 
            this.radioHod.AutoSize = true;
            this.radioHod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioHod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHod.Location = new System.Drawing.Point(159, 197);
            this.radioHod.Name = "radioHod";
            this.radioHod.Size = new System.Drawing.Size(56, 20);
            this.radioHod.TabIndex = 10;
            this.radioHod.Text = "HoD";
            this.radioHod.UseVisualStyleBackColor = true;
            this.radioHod.CheckedChanged += new System.EventHandler(this.radioHod_CheckedChanged);
            // 
            // login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(409, 323);
            this.Controls.Add(this.loginPanel);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.RadioButton radioStudents;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioHod;
    }
}

