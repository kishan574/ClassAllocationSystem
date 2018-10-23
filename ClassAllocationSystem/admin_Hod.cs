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
using System.Windows;
namespace ClassAllocationSystem
{
    public partial class admin_Hod : Form  
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
       

        //  SqlDataAdapter adapt;

        public admin_Hod()
        {
                        InitializeComponent();
           
          
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();

            hodDataGrid hdg = new hodDataGrid();
            hdg.Dispose();
          
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminMain adMain = new adminMain();
            adMain.Show();
        }

        private void admin_teacher_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private string RadioButtonText()
        {
            if (radioMale.Checked)
            {
                return radioMale.Text;
            }
            else
            {
                return radioFemale.Text;
            }
        }

        private void admin_Hod_Add_Load(object sender, EventArgs e)
        {
            
        }

        private void hodIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hodFacultyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hodAddressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hodNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hodPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hodPhoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hodSexLable_Click(object sender, EventArgs e)
        {

        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hodIdLable_Click(object sender, EventArgs e)
        {

        }

        private void hodFacultyLable_Click(object sender, EventArgs e)
        {

        }

        private void hodAddressLable_Click(object sender, EventArgs e)
        {

        }

        private void hodNameLable_Click(object sender, EventArgs e)
        {

        }

        private void hodPassword_Click(object sender, EventArgs e)
        {

        }

        private void hodPhoneLable_Click(object sender, EventArgs e)
        {

        }

        public void add_hod_Click(object sender, EventArgs e)
        {


            if (

            hodIdBox.Text == "" ||
            hodAddressBox.Text == "" ||
            hodPasswordBox.Text == "" ||
            hodPhoneBox.Text == "" ||
            hodNameBox.Text == "" ||
            hodFacultyBox.Text == ""
                                         
                )
            {
                MessageBox.Show("Please provide all the information!!");
                return;
            }



            else
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
                cmd = new SqlCommand("INSERT INTO HoDDTable(hodd_Id , hodd_Name , hodd_Password , hodd_Faculty, hodd_Address , hodd_Phone , hodd_Sex, hodd_Email ) VALUES(@id , @name , @password , @faculty , @address , @phone , @sex , @email)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@id", hodIdBox.Text);
                cmd.Parameters.AddWithValue("@name", hodNameBox.Text);
                cmd.Parameters.AddWithValue("@password", hodPasswordBox.Text);
                cmd.Parameters.AddWithValue("@faculty", hodFacultyBox.Text);
                cmd.Parameters.AddWithValue("@address", hodAddressBox.Text);
                cmd.Parameters.AddWithValue("@phone", hodPasswordBox.Text);
                cmd.Parameters.AddWithValue("@sex", RadioButtonText());
                cmd.Parameters.AddWithValue("@email", hodEmailBox.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Record Inserted Successfully");
                clear();



                hodDataGrid grid = new hodDataGrid();
                grid.Show();
               grid.displayDataGridView();
            }
        }

        

        private void clear()
        {
            hodIdBox.Clear();
            hodAddressBox.Clear();
            hodEmailBox.Clear();
            hodPasswordBox.Clear();
            hodPhoneBox.Clear();
            hodNameBox.Clear();
            hodFacultyBox.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
        }


        private void reset_Click(object sender, EventArgs e)
        {
            clear();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

       if (
            hodIdBox.Text == "" ||
            hodAddressBox.Text == "" ||
            hodPasswordBox.Text == "" ||
            hodPhoneBox.Text == "" ||
            hodNameBox.Text == "" ||
            hodFacultyBox.Text == ""
            )
            {
                MessageBox.Show("Please Select Record to Update");
            }
            else
            {   
                cmd = new SqlCommand("UPDATE HoDDTable SET hodd_Id=@id,hodd_Name=@name,hodd_Password=@password, hodd_Faculty=@faculty,hodd_Address=@address, hodd_Phone=@phone, hodd_Sex=@sex, hodd_Email=@email WHERE hodd_Id=@id", con);
                con.Open();

                cmd.Parameters.AddWithValue("@id", hodIdBox.Text);
                cmd.Parameters.AddWithValue("@name", hodNameBox.Text);
                cmd.Parameters.AddWithValue("@password", hodPasswordBox.Text);
                cmd.Parameters.AddWithValue("@faculty", hodFacultyBox.Text);
                cmd.Parameters.AddWithValue("@address", hodAddressBox.Text);
                cmd.Parameters.AddWithValue("@phone", hodPasswordBox.Text);
                cmd.Parameters.AddWithValue("@sex", RadioButtonText());
                cmd.Parameters.AddWithValue("@email", hodEmailBox.Text);
                               
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");
                con.Close();

                hodDataGrid grid = new hodDataGrid();
             
                grid.displayDataGridView();

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {          
            if (hodIdBox.Text == "")
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            else
            {
                cmd = new SqlCommand("DELETE HoDDTable WHERE HoDD_Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", hodIdBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");

                hodDataGrid grid = new hodDataGrid();
                grid.displayDataGridView();
               
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            hodDataGrid grid = new hodDataGrid();
                      
                grid.Show();
                grid.displayDataGridView();

            admin_Hod adH = new admin_Hod();
            adH.Close();
        }

        private void admin_Hod_FormClosing(object sender, FormClosingEventArgs e)
        {
                this.Dispose();

        }
    }

}

    