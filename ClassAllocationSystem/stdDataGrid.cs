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
    public partial class stdDataGrid : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        public stdDataGrid()
        {
            InitializeComponent();
        }



        private void refresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");

            // SqlCommand cmdStd = new SqlCommand("SELECT * FROM StudentTable", con);
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentTable", con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                stddataGridView1.DataSource = bsource;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }



        }
        public void displayDataGridView()
        {
            cmd = new SqlCommand("SELECT * FROM StudentTable", con);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                stddataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void stddataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //it checks if the row index of the cell is greater than or equal to zero
            if (e.RowIndex >= 0)
            {
                admin_students adStd = new admin_students();

                //gets a collection that contains all the rows
                DataGridViewRow row = this.stddataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                adStd.stdIdBox.Text = row.Cells[0].Value.ToString();
                adStd.stdNameBox.Text = row.Cells[1].Value.ToString();
                adStd.stdPasswordBox.Text = row.Cells[2].Value.ToString();
                adStd.stdFacultyBox.Text = row.Cells[3].Value.ToString();
                adStd.stdAddressBox.Text = row.Cells[4].Value.ToString();
                adStd.stdPhoneBox.Text = row.Cells[5].Value.ToString();
                adStd.stdParentBox.Text = row.Cells[7].Value.ToString();
                adStd.stdEmailBox.Text = row.Cells[8].Value.ToString();

                if (row.Cells[6].Value.ToString() == "Male")
                {
                    adStd.radioMale.Checked = true;

                }

                else
                {
                    adStd.radioFemale.Checked = true;

                }

                adStd.ShowDialog();
                //adHod.Show();


            }


        }

        private void stddataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}



