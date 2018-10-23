namespace ClassAllocationSystem
{
    partial class studentMain
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
            this.courseDesc = new System.Windows.Forms.Button();
            this.classRoutine = new System.Windows.Forms.Button();
            this.examRoutine = new System.Windows.Forms.Button();
            this.assignment = new System.Windows.Forms.Button();
            this.teachersInfo = new System.Windows.Forms.Button();
            this.notice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signOut
            // 
            this.signOut.Location = new System.Drawing.Point(550, 12);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(75, 23);
            this.signOut.TabIndex = 0;
            this.signOut.Text = "SignOut";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // courseDesc
            // 
            this.courseDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.courseDesc.Location = new System.Drawing.Point(457, 167);
            this.courseDesc.Name = "courseDesc";
            this.courseDesc.Size = new System.Drawing.Size(150, 109);
            this.courseDesc.TabIndex = 3;
            this.courseDesc.Text = "Course Description";
            this.courseDesc.UseVisualStyleBackColor = true;
            this.courseDesc.Click += new System.EventHandler(this.courseDesc_Click);
            // 
            // classRoutine
            // 
            this.classRoutine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.classRoutine.Location = new System.Drawing.Point(256, 170);
            this.classRoutine.Name = "classRoutine";
            this.classRoutine.Size = new System.Drawing.Size(150, 109);
            this.classRoutine.TabIndex = 4;
            this.classRoutine.Text = "Class Routine";
            this.classRoutine.UseVisualStyleBackColor = true;
            this.classRoutine.Click += new System.EventHandler(this.classRoutine_Click);
            // 
            // examRoutine
            // 
            this.examRoutine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.examRoutine.Location = new System.Drawing.Point(43, 170);
            this.examRoutine.Name = "examRoutine";
            this.examRoutine.Size = new System.Drawing.Size(150, 109);
            this.examRoutine.TabIndex = 5;
            this.examRoutine.Text = "Exam Routine";
            this.examRoutine.UseVisualStyleBackColor = true;
            this.examRoutine.Click += new System.EventHandler(this.examRoutine_Click);
            // 
            // assignment
            // 
            this.assignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.assignment.Location = new System.Drawing.Point(44, 52);
            this.assignment.Name = "assignment";
            this.assignment.Size = new System.Drawing.Size(150, 109);
            this.assignment.TabIndex = 6;
            this.assignment.Text = "Assignments";
            this.assignment.UseVisualStyleBackColor = true;
            this.assignment.Click += new System.EventHandler(this.assignment_Click);
            // 
            // teachersInfo
            // 
            this.teachersInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.teachersInfo.Location = new System.Drawing.Point(256, 52);
            this.teachersInfo.Name = "teachersInfo";
            this.teachersInfo.Size = new System.Drawing.Size(150, 109);
            this.teachersInfo.TabIndex = 7;
            this.teachersInfo.Text = "Teachers Info";
            this.teachersInfo.UseVisualStyleBackColor = true;
            this.teachersInfo.Click += new System.EventHandler(this.teachersInfo_Click);
            // 
            // notice
            // 
            this.notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notice.Location = new System.Drawing.Point(457, 52);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(150, 109);
            this.notice.TabIndex = 8;
            this.notice.Text = "Notice";
            this.notice.UseVisualStyleBackColor = true;
            this.notice.Click += new System.EventHandler(this.notice_Click);
            // 
            // studentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 324);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.teachersInfo);
            this.Controls.Add(this.assignment);
            this.Controls.Add(this.examRoutine);
            this.Controls.Add(this.classRoutine);
            this.Controls.Add(this.courseDesc);
            this.Controls.Add(this.signOut);
            this.Name = "studentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentMain";
            this.Load += new System.EventHandler(this.studentMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Button courseDesc;
        private System.Windows.Forms.Button classRoutine;
        private System.Windows.Forms.Button examRoutine;
        private System.Windows.Forms.Button assignment;
        private System.Windows.Forms.Button teachersInfo;
        private System.Windows.Forms.Button notice;
    }
}