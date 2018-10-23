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
    public partial class teacherGrid : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;

        public teacherGrid()
        {
            InitializeComponent();
        }

        public void displayDataGridView()
        {
            cmd = new SqlCommand("SELECT * FROM teacherinfo", con);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //  it checks if the row index of the cell is greater than or equal to zero
            if (e.RowIndex >= 0)
            {
                teachInfo sAss = new teachInfo();
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                sAss.idBox.Text = row.Cells[0].Value.ToString();
                sAss.nameBox.Text = row.Cells[1].Value.ToString();
                sAss.emailBox.Text = row.Cells[2].Value.ToString();
                sAss.phnBox.Text = row.Cells[3].Value.ToString();
                sAss.ShowDialog();
            }

            if (e.RowIndex >= 0)
            {
                stdTeacherInfo sAss = new stdTeacherInfo();
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                sAss.idBox.Text = row.Cells[0].Value.ToString();
                sAss.nameBox.Text = row.Cells[1].Value.ToString();
                sAss.emailBox.Text = row.Cells[2].Value.ToString();
                sAss.phnBox.Text = row.Cells[3].Value.ToString();
                sAss.ShowDialog();
            }
        }
    }
}
