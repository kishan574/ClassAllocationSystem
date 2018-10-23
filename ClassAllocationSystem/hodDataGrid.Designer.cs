using System.Windows.Forms;

namespace ClassAllocationSystem
{
    partial class hodDataGrid
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
            this.refresh = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.hoddataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hoddataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(12, 6);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 0;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(550, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // hoddataGridView1
            // 
            this.hoddataGridView1.AccessibleDescription = "";
            this.hoddataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoddataGridView1.Location = new System.Drawing.Point(12, 35);
            this.hoddataGridView1.Name = "hoddataGridView1";
            this.hoddataGridView1.Size = new System.Drawing.Size(613, 277);
            this.hoddataGridView1.TabIndex = 2;
            this.hoddataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hoddataGridView1_CellClick);
            this.hoddataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hoddataGridView1_CellContentClick);
            // 
            // hodDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 324);
            this.Controls.Add(this.hoddataGridView1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.refresh);
            this.Name = "hodDataGrid";
            this.Text = "hodDataGrid";
            this.Load += new System.EventHandler(this.hodDataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoddataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button close;
        public System.Windows.Forms.DataGridView hoddataGridView1;
    }
}