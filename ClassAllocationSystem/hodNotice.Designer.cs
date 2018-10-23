namespace ClassAllocationSystem
{
    partial class hodNotice
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
            this.back = new System.Windows.Forms.Button();
            this.signOut = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.upload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(17, 22);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "back";
            this.back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // signOut
            // 
            this.signOut.Location = new System.Drawing.Point(322, 22);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(75, 23);
            this.signOut.TabIndex = 1;
            this.signOut.Text = "signOut";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(122, 111);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(241, 20);
            this.title.TabIndex = 2;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(122, 137);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(241, 96);
            this.desc.TabIndex = 3;
            this.desc.Text = "";
            this.desc.TextChanged += new System.EventHandler(this.desc_TextChanged);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(313, 258);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 4;
            this.upload.Text = "upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(17, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(17, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(96, 257);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 7;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(122, 85);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(241, 20);
            this.idBox.TabIndex = 9;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(208, 257);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 10;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // hodNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 323);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.title);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.back);
            this.Name = "hodNotice";
            this.Text = "hodNotice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.RichTextBox desc;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button delete;
    }
}