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
    public partial class classGrid : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        public void displayDataGridView()
        {
            cmd = new SqlCommand("SELECT * FROM classRoutine", con);
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
        public classGrid()
        {
            InitializeComponent();
        }

        private void classGrid_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                stdClassRout adHod = new stdClassRout();
                               
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
               
                adHod.idBox.Text = row.Cells[0].Value.ToString();
                adHod.assignmentName.Text = row.Cells[1].Value.ToString();
                adHod.textBox1.Text = row.Cells[2].Value.ToString();

                adHod.ShowDialog();

            }
        }
    }
}
