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
    public partial class hodNotice : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        public hodNotice()
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

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void upload_Click(object sender, EventArgs e)
        {
            if (title.Text == "" ||
               desc.Text == ""                    
               )

            {
                MessageBox.Show("entry empty");
            }

            cmd = new SqlCommand("INSERT INTO notice(id , Title , Description) VALUES(@id , @title , @description )", con);
            con.Open();

            cmd.Parameters.AddWithValue("@id", idBox.Text);
            cmd.Parameters.AddWithValue("@title", title.Text);
            cmd.Parameters.AddWithValue("@description", desc.Text);
           
            cmd.ExecuteNonQuery();

            MessageBox.Show("Success");
            con.Close();
        }

        private void view_Click(object sender, EventArgs e)
        {
            
            noticeGrid ng = new noticeGrid();
            ng.displayDataGridView();
            ng.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            else
            {
                cmd = new SqlCommand("DELETE notice WHERE id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", idBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                idBox.Text = " ";
            }
        }
    }
}
