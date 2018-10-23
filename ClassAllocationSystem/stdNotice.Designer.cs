namespace ClassAllocationSystem
{
    partial class stdNotice
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
            this.idBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.signOut = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(122, 120);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(241, 20);
            this.idBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Id";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(17, 67);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 18;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(17, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(17, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Title";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(122, 172);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(241, 96);
            this.desc.TabIndex = 14;
            this.desc.Text = "";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(122, 146);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(241, 20);
            this.title.TabIndex = 13;
            // 
            // signOut
            // 
            this.signOut.Location = new System.Drawing.Point(322, 22);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(75, 23);
            this.signOut.TabIndex = 12;
            this.signOut.Text = "signOut";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(17, 22);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 11;
            this.back.Text = "back";
            this.back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // stdNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 323);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.title);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.back);
            this.Name = "stdNotice";
            this.Text = "stdNotice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Button back;
        public System.Windows.Forms.TextBox idBox;
        public System.Windows.Forms.RichTextBox desc;
        public System.Windows.Forms.TextBox title;
    }
}