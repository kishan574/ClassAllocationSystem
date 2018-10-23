using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClassAllocationSystem
{
    public partial class stdExam : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
        
        public stdExam()
        {
            InitializeComponent();
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login logIn = new login();
            logIn.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            hodMain hm = new hodMain();
            hm.Show();
        }

            
        private void view_Click(object sender, EventArgs e)
        {
            examGrid eg = new examGrid();
            eg.displayDataGridView();
            eg.Show(); 
        }

        private void stdExam_Load(object sender, EventArgs e)
        {

        }
    }
}
