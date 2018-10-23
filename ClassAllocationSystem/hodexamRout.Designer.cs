namespace ClassAllocationSystem
{
    partial class hodexamRout
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
            this.signOut = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assignmentName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.upload = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.assignmentName);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.upload);
            this.panel1.Controls.Add(this.open);
            this.panel1.Controls.Add(this.signOut);
            this.panel1.Controls.Add(this.back);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 300);
            this.panel1.TabIndex = 2;
            // 
            // signOut
            // 
            this.signOut.Location = new System.Drawing.Point(296, 12);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(75, 23);
            this.signOut.TabIndex = 9;
            this.signOut.Text = "sign Out";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(17, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 3;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(103, 88);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(113, 20);
            this.idBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // assignmentName
            // 
            this.assignmentName.Location = new System.Drawing.Point(104, 115);
            this.assignmentName.Name = "assignmentName";
            this.assignmentName.Size = new System.Drawing.Size(161, 20);
            this.assignmentName.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 13;
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(225, 182);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 31);
            this.upload.TabIndex = 12;
            this.upload.Text = "upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(124, 182);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(83, 31);
            this.open.TabIndex = 11;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // hodexamRout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 323);
            this.Controls.Add(this.panel1);
            this.Name = "hodexamRout";
            this.Text = "hodexamRout";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox assignmentName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button open;
    }
}