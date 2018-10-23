namespace ClassAllocationSystem
{
    partial class adminMain
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
            this.signOut = new System.Windows.Forms.Button();
            this.hod = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.adminPanelUp = new System.Windows.Forms.Panel();
            this.adminPanelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // signOut
            // 
            this.signOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signOut.Location = new System.Drawing.Point(307, 3);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(75, 23);
            this.signOut.TabIndex = 0;
            this.signOut.Text = "SignOut";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // hod
            // 
            this.hod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hod.Location = new System.Drawing.Point(17, 59);
            this.hod.Name = "hod";
            this.hod.Size = new System.Drawing.Size(175, 180);
            this.hod.TabIndex = 1;
            this.hod.Text = "Head Of Departnment";
            this.hod.UseVisualStyleBackColor = true;
            this.hod.Click += new System.EventHandler(this.hod_Click);
            // 
            // student
            // 
            this.student.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.student.Location = new System.Drawing.Point(207, 59);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(175, 180);
            this.student.TabIndex = 2;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // adminPanelUp
            // 
            this.adminPanelUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminPanelUp.Controls.Add(this.signOut);
            this.adminPanelUp.Controls.Add(this.student);
            this.adminPanelUp.Controls.Add(this.hod);
            this.adminPanelUp.Location = new System.Drawing.Point(3, 9);
            this.adminPanelUp.Name = "adminPanelUp";
            this.adminPanelUp.Size = new System.Drawing.Size(400, 303);
            this.adminPanelUp.TabIndex = 3;
            // 
            // adminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(409, 323);
            this.Controls.Add(this.adminPanelUp);
            this.Name = "adminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminMain_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            this.adminPanelUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Button hod;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Panel adminPanelUp;
    }
}