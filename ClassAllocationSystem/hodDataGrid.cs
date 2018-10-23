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
    public partial class hodDataGrid : Form
    {
        //   int ID;
       
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");  
        SqlCommand cmd;

        public hodDataGrid()
        {
           // hodDataGrid grid1;
            InitializeComponent();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
           
           // SqlCommand cmdStd = new SqlCommand("SELECT * FROM StudentTable", con);
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoDDTable", con);
        
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                hoddataGridView1.DataSource = bsource;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }      

        
        public void displayDataGridView()
        {         
        cmd = new SqlCommand("SELECT * FROM HoDDTable", con);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                hoddataGridView1.DataSource = dt;
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

       
        
        private void hoddataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //it checks if the row index of the cell is greater than or equal to zero
            if (e.RowIndex >= 0)
            {
                admin_Hod adHod = new admin_Hod();

                //gets a collection that contains all the rows
                DataGridViewRow row = this.hoddataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                adHod.hodIdBox.Text = row.Cells[0].Value.ToString();
                adHod.hodNameBox.Text = row.Cells[1].Value.ToString();
                adHod.hodPasswordBox.Text = row.Cells[2].Value.ToString();
                adHod.hodFacultyBox.Text = row.Cells[3].Value.ToString();
                adHod.hodAddressBox.Text = row.Cells[4].Value.ToString();
                adHod.hodPhoneBox.Text = row.Cells[5].Value.ToString();
                adHod.hodEmailBox.Text = row.Cells[7].Value.ToString();
                    

                if (row.Cells[6].Value.ToString() == "Male" )
                {
                    adHod.radioMale.Checked = true;
                   
                }

                else
                {
                    adHod.radioFemale.Checked = true;

                }

                adHod.ShowDialog();
                //adHod.Show();

               
            }

        }

        private void hodDataGrid_Load(object sender, EventArgs e)
        {

        }

        private void searchHod_TextChanged(object sender, EventArgs e)
        {

        }

        
        //private void searchHod_KeyPress(object sender, KeyPressEventArgs e)
        //{           
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    //DataSet ds = new DataSet();
        //    cmd = new SqlCommand("Select * from HoDDTable WHERE username LIKE '%" + searchHod.Text + "'%");

        //    da.SelectCommand = cmd;
        //    da.Fill(dt);    
        //    hoddataGridView1.DataSource = dt;
        //    con.Close();
                      
        //}

        private void hoddataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
}
