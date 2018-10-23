namespace ClassAllocationSystem
{
    partial class stdAssingment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.descBox = new System.Windows.Forms.RichTextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.signOut = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.descBox);
            this.panel1.Controls.Add(this.titleBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.view);
            this.panel1.Controls.Add(this.signOut);
            this.panel1.Controls.Add(this.back);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 299);
            this.panel1.TabIndex = 0;
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(136, 127);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(205, 140);
            this.descBox.TabIndex = 6;
            this.descBox.Text = "";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(136, 101);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(205, 20);
            this.titleBox.TabIndex = 5;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(13, 55);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 2;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // signOut
            // 
            this.signOut.Location = new System.Drawing.Point(297, 13);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(75, 23);
            this.signOut.TabIndex = 1;
            this.signOut.Text = "sign out";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // stdAssingment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 323);
            this.Controls.Add(this.panel1);
            this.Name = "stdAssingment";
            this.Text = "stdAssingment";
            this.Load += new System.EventHandler(this.stdAssingment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Button back;
        public System.Windows.Forms.RichTextBox descBox;
        public System.Windows.Forms.TextBox titleBox;
    }
}