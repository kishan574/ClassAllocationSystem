namespace ClassAllocationSystem
{
    partial class stdTeacherInfo
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
            this.phone = new System.Windows.Forms.Label();
            this.phnBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.emailId = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.signOut = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phone.Location = new System.Drawing.Point(14, 247);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(49, 17);
            this.phone.TabIndex = 36;
            this.phone.Text = "Phone";
            // 
            // phnBox
            // 
            this.phnBox.Location = new System.Drawing.Point(108, 247);
            this.phnBox.Name = "phnBox";
            this.phnBox.Size = new System.Drawing.Size(252, 20);
            this.phnBox.TabIndex = 35;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(108, 202);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(252, 20);
            this.emailBox.TabIndex = 34;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(108, 120);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(175, 20);
            this.idBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(14, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Id";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(17, 65);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 31;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // emailId
            // 
            this.emailId.AutoSize = true;
            this.emailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailId.Location = new System.Drawing.Point(14, 202);
            this.emailId.Name = "emailId";
            this.emailId.Size = new System.Drawing.Size(59, 17);
            this.emailId.TabIndex = 30;
            this.emailId.Text = "Email ID";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name.Location = new System.Drawing.Point(14, 158);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 17);
            this.name.TabIndex = 29;
            this.name.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(108, 157);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(175, 20);
            this.nameBox.TabIndex = 27;
            // 
            // signOut
            // 
            this.signOut.Location = new System.Drawing.Point(319, 19);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(75, 23);
            this.signOut.TabIndex = 26;
            this.signOut.Text = "signOut";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(14, 19);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 25;
            this.back.Text = "back";
            this.back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // stdTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 323);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.phnBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.view);
            this.Controls.Add(this.emailId);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.back);
            this.Name = "stdTeacherInfo";
            this.Text = "stdTeacherInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Label emailId;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Button back;
        public System.Windows.Forms.TextBox phnBox;
        public System.Windows.Forms.TextBox emailBox;
        public System.Windows.Forms.TextBox idBox;
        public System.Windows.Forms.TextBox nameBox;
    }
}