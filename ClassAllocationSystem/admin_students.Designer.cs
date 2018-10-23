namespace ClassAllocationSystem
{
    partial class admin_students
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
            this.show = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.stdEmailBox = new System.Windows.Forms.TextBox();
            this.stdEmailLabel = new System.Windows.Forms.Label();
            this.signOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stdParentLabel = new System.Windows.Forms.Label();
            this.stdParentBox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.add_Std = new System.Windows.Forms.Button();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.stdPasswordBox = new System.Windows.Forms.TextBox();
            this.stdPhoneBox = new System.Windows.Forms.TextBox();
            this.stdAddressBox = new System.Windows.Forms.TextBox();
            this.stdNameBox = new System.Windows.Forms.TextBox();
            this.stdFacultyBox = new System.Windows.Forms.TextBox();
            this.stdIdBox = new System.Windows.Forms.TextBox();
            this.stdSexLable = new System.Windows.Forms.Label();
            this.stdPhoneLable = new System.Windows.Forms.Label();
            this.stdAddressLable = new System.Windows.Forms.Label();
            this.stdPassword = new System.Windows.Forms.Label();
            this.stdNameLable = new System.Windows.Forms.Label();
            this.hodFacultyLable = new System.Windows.Forms.Label();
            this.stdIdLable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(82, 262);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 24;
            this.show.Text = "Show Data";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(276, 262);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 23;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(372, 262);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 22;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // stdEmailBox
            // 
            this.stdEmailBox.Location = new System.Drawing.Point(103, 188);
            this.stdEmailBox.Name = "stdEmailBox";
            this.stdEmailBox.Size = new System.Drawing.Size(200, 20);
            this.stdEmailBox.TabIndex = 21;
            this.stdEmailBox.TextChanged += new System.EventHandler(this.stdEmailBox_TextChanged);
            // 
            // stdEmailLabel
            // 
            this.stdEmailLabel.AutoSize = true;
            this.stdEmailLabel.Location = new System.Drawing.Point(11, 188);
            this.stdEmailLabel.Name = "stdEmailLabel";
            this.stdEmailLabel.Size = new System.Drawing.Size(75, 13);
            this.stdEmailLabel.TabIndex = 20;
            this.stdEmailLabel.Text = "Student E-mail";
            // 
            // signOut
            // 
            this.signOut.Location = new System.Drawing.Point(518, 12);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(75, 23);
            this.signOut.TabIndex = 19;
            this.signOut.Text = "SignOut";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.stdParentLabel);
            this.panel1.Controls.Add(this.stdParentBox);
            this.panel1.Controls.Add(this.show);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.stdEmailBox);
            this.panel1.Controls.Add(this.stdEmailLabel);
            this.panel1.Controls.Add(this.signOut);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.add_Std);
            this.panel1.Controls.Add(this.radioFemale);
            this.panel1.Controls.Add(this.radioMale);
            this.panel1.Controls.Add(this.stdPasswordBox);
            this.panel1.Controls.Add(this.stdPhoneBox);
            this.panel1.Controls.Add(this.stdAddressBox);
            this.panel1.Controls.Add(this.stdNameBox);
            this.panel1.Controls.Add(this.stdFacultyBox);
            this.panel1.Controls.Add(this.stdIdBox);
            this.panel1.Controls.Add(this.stdSexLable);
            this.panel1.Controls.Add(this.stdPhoneLable);
            this.panel1.Controls.Add(this.stdAddressLable);
            this.panel1.Controls.Add(this.stdPassword);
            this.panel1.Controls.Add(this.stdNameLable);
            this.panel1.Controls.Add(this.hodFacultyLable);
            this.panel1.Controls.Add(this.stdIdLable);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 300);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // stdParentLabel
            // 
            this.stdParentLabel.AutoSize = true;
            this.stdParentLabel.Location = new System.Drawing.Point(317, 187);
            this.stdParentLabel.Name = "stdParentLabel";
            this.stdParentLabel.Size = new System.Drawing.Size(69, 13);
            this.stdParentLabel.TabIndex = 26;
            this.stdParentLabel.Text = "Parent Name";
            // 
            // stdParentBox
            // 
            this.stdParentBox.Location = new System.Drawing.Point(416, 187);
            this.stdParentBox.Name = "stdParentBox";
            this.stdParentBox.Size = new System.Drawing.Size(192, 20);
            this.stdParentBox.TabIndex = 25;
            this.stdParentBox.TextChanged += new System.EventHandler(this.stdParentBox_TextChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(14, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 18;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(470, 262);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 17;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // add_Std
            // 
            this.add_Std.Location = new System.Drawing.Point(179, 262);
            this.add_Std.Name = "add_Std";
            this.add_Std.Size = new System.Drawing.Size(75, 23);
            this.add_Std.TabIndex = 16;
            this.add_Std.Text = "ADD";
            this.add_Std.UseVisualStyleBackColor = true;
            this.add_Std.Click += new System.EventHandler(this.add_Std_Click);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(470, 225);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 15;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(416, 225);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 14;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // stdPasswordBox
            // 
            this.stdPasswordBox.Location = new System.Drawing.Point(416, 105);
            this.stdPasswordBox.Name = "stdPasswordBox";
            this.stdPasswordBox.Size = new System.Drawing.Size(192, 20);
            this.stdPasswordBox.TabIndex = 13;
            this.stdPasswordBox.TextChanged += new System.EventHandler(this.stdPasswordBox_TextChanged);
            // 
            // stdPhoneBox
            // 
            this.stdPhoneBox.Location = new System.Drawing.Point(416, 152);
            this.stdPhoneBox.Name = "stdPhoneBox";
            this.stdPhoneBox.Size = new System.Drawing.Size(192, 20);
            this.stdPhoneBox.TabIndex = 11;
            this.stdPhoneBox.TextChanged += new System.EventHandler(this.stdPhoneBox_TextChanged);
            // 
            // stdAddressBox
            // 
            this.stdAddressBox.Location = new System.Drawing.Point(103, 152);
            this.stdAddressBox.Name = "stdAddressBox";
            this.stdAddressBox.Size = new System.Drawing.Size(200, 20);
            this.stdAddressBox.TabIndex = 10;
            this.stdAddressBox.TextChanged += new System.EventHandler(this.stdAddressBox_TextChanged);
            // 
            // stdNameBox
            // 
            this.stdNameBox.Location = new System.Drawing.Point(416, 66);
            this.stdNameBox.Name = "stdNameBox";
            this.stdNameBox.Size = new System.Drawing.Size(192, 20);
            this.stdNameBox.TabIndex = 9;
            this.stdNameBox.TextChanged += new System.EventHandler(this.stdNameBox_TextChanged);
            // 
            // stdFacultyBox
            // 
            this.stdFacultyBox.Location = new System.Drawing.Point(103, 108);
            this.stdFacultyBox.Name = "stdFacultyBox";
            this.stdFacultyBox.Size = new System.Drawing.Size(200, 20);
            this.stdFacultyBox.TabIndex = 8;
            this.stdFacultyBox.TextChanged += new System.EventHandler(this.stdFacultyBox_TextChanged);
            // 
            // stdIdBox
            // 
            this.stdIdBox.Location = new System.Drawing.Point(103, 69);
            this.stdIdBox.Name = "stdIdBox";
            this.stdIdBox.Size = new System.Drawing.Size(200, 20);
            this.stdIdBox.TabIndex = 7;
            this.stdIdBox.TextChanged += new System.EventHandler(this.stdIdBox_TextChanged);
            // 
            // stdSexLable
            // 
            this.stdSexLable.AutoSize = true;
            this.stdSexLable.Location = new System.Drawing.Point(317, 225);
            this.stdSexLable.Name = "stdSexLable";
            this.stdSexLable.Size = new System.Drawing.Size(65, 13);
            this.stdSexLable.TabIndex = 6;
            this.stdSexLable.Text = "Student Sex";
            // 
            // stdPhoneLable
            // 
            this.stdPhoneLable.AutoSize = true;
            this.stdPhoneLable.Location = new System.Drawing.Point(317, 152);
            this.stdPhoneLable.Name = "stdPhoneLable";
            this.stdPhoneLable.Size = new System.Drawing.Size(77, 13);
            this.stdPhoneLable.TabIndex = 5;
            this.stdPhoneLable.Text = "Student phone";
            // 
            // stdAddressLable
            // 
            this.stdAddressLable.AutoSize = true;
            this.stdAddressLable.Location = new System.Drawing.Point(11, 152);
            this.stdAddressLable.Name = "stdAddressLable";
            this.stdAddressLable.Size = new System.Drawing.Size(85, 13);
            this.stdAddressLable.TabIndex = 4;
            this.stdAddressLable.Text = "Student Address";
            // 
            // stdPassword
            // 
            this.stdPassword.AutoSize = true;
            this.stdPassword.Location = new System.Drawing.Point(317, 111);
            this.stdPassword.Name = "stdPassword";
            this.stdPassword.Size = new System.Drawing.Size(93, 13);
            this.stdPassword.TabIndex = 3;
            this.stdPassword.Text = "Student Password";
            // 
            // stdNameLable
            // 
            this.stdNameLable.AutoSize = true;
            this.stdNameLable.Location = new System.Drawing.Point(317, 66);
            this.stdNameLable.Name = "stdNameLable";
            this.stdNameLable.Size = new System.Drawing.Size(75, 13);
            this.stdNameLable.TabIndex = 2;
            this.stdNameLable.Text = "Student Name";
            // 
            // hodFacultyLable
            // 
            this.hodFacultyLable.AutoSize = true;
            this.hodFacultyLable.Location = new System.Drawing.Point(11, 108);
            this.hodFacultyLable.Name = "hodFacultyLable";
            this.hodFacultyLable.Size = new System.Drawing.Size(81, 13);
            this.hodFacultyLable.TabIndex = 1;
            this.hodFacultyLable.Text = "Student Faculty";
            // 
            // stdIdLable
            // 
            this.stdIdLable.AutoSize = true;
            this.stdIdLable.Location = new System.Drawing.Point(11, 76);
            this.stdIdLable.Name = "stdIdLable";
            this.stdIdLable.Size = new System.Drawing.Size(58, 13);
            this.stdIdLable.TabIndex = 0;
            this.stdIdLable.Text = "Student ID";
            // 
            // admin_students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 324);
            this.Controls.Add(this.panel1);
            this.Name = "admin_students";
            this.Text = "admin_students";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admin_students_FormClosing);
            this.Load += new System.EventHandler(this.admin_students_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        public System.Windows.Forms.TextBox stdEmailBox;
        private System.Windows.Forms.Label stdEmailLabel;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button add_Std;
        public System.Windows.Forms.RadioButton radioFemale;
        public System.Windows.Forms.RadioButton radioMale;
        public System.Windows.Forms.TextBox stdPasswordBox;
        public System.Windows.Forms.TextBox stdPhoneBox;
        public System.Windows.Forms.TextBox stdAddressBox;
        public System.Windows.Forms.TextBox stdNameBox;
        public System.Windows.Forms.TextBox stdFacultyBox;
        public System.Windows.Forms.TextBox stdIdBox;
        private System.Windows.Forms.Label stdSexLable;
        private System.Windows.Forms.Label stdPhoneLable;
        private System.Windows.Forms.Label stdAddressLable;
        private System.Windows.Forms.Label stdPassword;
        private System.Windows.Forms.Label stdNameLable;
        private System.Windows.Forms.Label hodFacultyLable;
        private System.Windows.Forms.Label stdIdLable;
        private System.Windows.Forms.Label stdParentLabel;
        public System.Windows.Forms.Button show;
        public System.Windows.Forms.TextBox stdParentBox;
    }
}