namespace ClassAllocationSystem
{
    partial class stdDataGrid
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
            this.stddataGridView1 = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stddataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stddataGridView1
            // 
            this.stddataGridView1.AccessibleDescription = "";
            this.stddataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stddataGridView1.Location = new System.Drawing.Point(12, 14);
            this.stddataGridView1.Name = "stddataGridView1";
            this.stddataGridView1.Size = new System.Drawing.Size(613, 268);
            this.stddataGridView1.TabIndex = 5;
            this.stddataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stddataGridView1_CellClick);
            this.stddataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stddataGridView1_CellContentClick);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(550, 288);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 4;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(12, 288);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // stdDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 324);
            this.Controls.Add(this.stddataGridView1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.refresh);
            this.Name = "stdDataGrid";
            this.Text = "stdDataGrid";
            ((System.ComponentModel.ISupportInitialize)(this.stddataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView stddataGridView1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button refresh;
    }
}