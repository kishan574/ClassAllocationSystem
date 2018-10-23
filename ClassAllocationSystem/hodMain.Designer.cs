namespace ClassAllocationSystem
{
    partial class hodMain
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
            this.notice = new System.Windows.Forms.Button();
            this.teachersInfo = new System.Windows.Forms.Button();
            this.assignment = new System.Windows.Forms.Button();
            this.examRoutine = new System.Windows.Forms.Button();
            this.classRoutine = new System.Windows.Forms.Button();
            this.courseDesc = new System.Windows.Forms.Button();
            this.signOut = new System.Windows.Forms.Button();
            this.students = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notice
            // 
            this.notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notice.Location = new System.Drawing.Point(473, 182);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(124, 109);
            this.notice.TabIndex = 16;
            this.notice.Text = "Notice";
            this.notice.UseVisualStyleBackColor = true;
            this.notice.Click += new System.EventHandler(this.notice_Click);
            // 
            // teachersInfo
            // 
            this.teachersInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.teachersInfo.Location = new System.Drawing.Point(331, 182);
            this.teachersInfo.Name = "teachersInfo";
            this.teachersInfo.Size = new System.Drawing.Size(118, 109);
            this.teachersInfo.TabIndex = 15;
            this.teachersInfo.Text = "Teachers Info";
            this.teachersInfo.UseVisualStyleBackColor = true;
            this.teachersInfo.Click += new System.EventHandler(this.teachersInfo_Click);
            // 
            // assignment
            // 
            this.assignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.assignment.Location = new System.Drawing.Point(239, 50);
            this.assignment.Name = "assignment";
            this.assignment.Size = new System.Drawing.Size(150, 102);
            this.assignment.TabIndex = 14;
            this.assignment.Text = "Assignments";
            this.assignment.UseVisualStyleBackColor = true;
            this.assignment.Click += new System.EventHandler(this.assignment_Click);
            // 
            // examRoutine
            // 
            this.examRoutine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.examRoutine.Location = new System.Drawing.Point(21, 182);
            this.examRoutine.Name = "examRoutine";
            this.examRoutine.Size = new System.Drawing.Size(134, 109);
            this.examRoutine.TabIndex = 13;
            this.examRoutine.Text = "Exam Routine";
            this.examRoutine.UseVisualStyleBackColor = true;
            this.examRoutine.Click += new System.EventHandler(this.examRoutine_Click);
            // 
            // classRoutine
            // 
            this.classRoutine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.classRoutine.Location = new System.Drawing.Point(447, 50);
            this.classRoutine.Name = "classRoutine";
            this.classRoutine.Size = new System.Drawing.Size(150, 102);
            this.classRoutine.TabIndex = 12;
            this.classRoutine.Text = "Class Routine";
            this.classRoutine.UseVisualStyleBackColor = true;
            this.classRoutine.Click += new System.EventHandler(this.classRoutine_Click);
            // 
            // courseDesc
            // 
            this.courseDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.courseDesc.Location = new System.Drawing.Point(186, 182);
            this.courseDesc.Name = "courseDesc";
            this.courseDesc.Size = new System.Drawing.Size(117, 109);
            this.courseDesc.TabIndex = 11;
            this.courseDesc.Text = "Course Description";
            this.courseDesc.UseVisualStyleBackColor = true;
            // 
            // signOut
            // 
            this.signOut.Location = new System.Drawing.Point(550, 12);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(75, 23);
            this.signOut.TabIndex = 9;
            this.signOut.Text = "SignOut";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click_1);
            // 
            // students
            // 
            this.students.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.students.Location = new System.Drawing.Point(21, 50);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(150, 102);
            this.students.TabIndex = 17;
            this.students.Text = "Students";
            this.students.UseVisualStyleBackColor = true;
            this.students.Click += new System.EventHandler(this.students_Click);
            // 
            // hodMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 324);
            this.Controls.Add(this.students);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.teachersInfo);
            this.Controls.Add(this.assignment);
            this.Controls.Add(this.examRoutine);
            this.Controls.Add(this.classRoutine);
            this.Controls.Add(this.courseDesc);
            this.Controls.Add(this.signOut);
            this.Name = "hodMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hodMain";
            this.Load += new System.EventHandler(this.hodMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button notice;
        private System.Windows.Forms.Button teachersInfo;
        private System.Windows.Forms.Button assignment;
        private System.Windows.Forms.Button examRoutine;
        private System.Windows.Forms.Button classRoutine;
        private System.Windows.Forms.Button courseDesc;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Button students;
    }
}