using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ClassAllocationSystem
{
    public partial class examGrid : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        public examGrid()
        {
            InitializeComponent();
        }
        public void displayDataGridView()
        {
            cmd = new SqlCommand("SELECT * FROM examRoutine", con);
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
        private void examGrid_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                stdExam adHod = new stdExam();

                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                adHod.idBox.Text = row.Cells[0].Value.ToString();
                adHod.assignmentName.Text = row.Cells[1].Value.ToString();
                adHod.textBox1.Text = row.Cells[2].Value.ToString();
                                                       
                adHod.ShowDialog();

             }
            }
        }
}
