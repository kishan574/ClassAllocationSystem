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
    public partial class teachInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        public teachInfo()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            hodMain hm = new hodMain();
            hm.Show();
        
    }

        private void signOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login logIn = new login();
            logIn.Show();
        }

        void clear()
        {
            idBox.Text =  "";
            nameBox.Text = "";
            emailBox.Text = "";
            phnBox.Text = "";
        }


        private void upload_Click(object sender, EventArgs e)
        {
            if (
                idBox.Text == "" || nameBox.Text == "" || emailBox.Text =="" || phnBox.Text==""
               )

            {
                MessageBox.Show("entry empty");
            }

            cmd = new SqlCommand("INSERT INTO teacherinfo(id , name , email , phone) VALUES(@id , @namee , @emailid , @phone )", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", idBox.Text);
            cmd.Parameters.AddWithValue("@namee", nameBox.Text);
            cmd.Parameters.AddWithValue("@emailid", emailBox.Text);
            cmd.Parameters.AddWithValue("@phone", phnBox.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Success");
            clear();
            con.Close();
        }

        private void view_Click(object sender, EventArgs e)
        {
            teacherGrid ng = new teacherGrid();
            ng.displayDataGridView();
            ng.Show();
        }

        private void teachersInfo_Load(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("Please Select Record to Delete");
                clear();
            }
            else
            {
                cmd = new SqlCommand("DELETE teacherinfo WHERE id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", idBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                clear();
            }
        }
    }
}
