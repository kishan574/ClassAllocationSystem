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
    public partial class admin_students : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;

        public admin_students()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
         
        
            if (
            stdIdBox.Text == "" ||
            stdAddressBox.Text == "" ||
            stdPasswordBox.Text == "" ||
            stdPhoneBox.Text == "" ||
            stdNameBox.Text == "" ||
            stdFacultyBox.Text == "" ||
            stdParentBox.Text == ""
                 )
            {
                MessageBox.Show("Please Select Record to Update");
            }
            else
            {
                cmd = new SqlCommand("UPDATE StudentTable SET std_Roll=@id , std_Name=@name , std_Password=@password , std_Faculty=@faculty , std_Address=@address, std_Phone=@phone, std_Sex=@sex, std_Email=@email , std_ParentName=@parent  WHERE  std_Roll=@id", con);
                con.Open();

                cmd.Parameters.AddWithValue("@id", stdIdBox.Text);
                cmd.Parameters.AddWithValue("@name", stdNameBox.Text);
                cmd.Parameters.AddWithValue("@password",stdPasswordBox.Text);
                cmd.Parameters.AddWithValue("@faculty", stdFacultyBox.Text);
                cmd.Parameters.AddWithValue("@address", stdAddressBox.Text);
                cmd.Parameters.AddWithValue("@phone", stdPasswordBox.Text);
                cmd.Parameters.AddWithValue("@sex", RadioButtonText());
                cmd.Parameters.AddWithValue("@email", stdEmailBox.Text);
                cmd.Parameters.AddWithValue("@parent", stdParentBox.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");
                con.Close();

                stdDataGrid grid = new stdDataGrid();

                grid.displayDataGridView();

            }
        }

    

    private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stdIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdFacultyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdAddressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdEmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdPhoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminMain adMain = new adminMain();
            adMain.Show();

        }

        private void signOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();

            hodDataGrid hdg = new hodDataGrid();
            hdg.Dispose();

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

        private void show_Click(object sender, EventArgs e)
        {
            stdDataGrid grid = new stdDataGrid();

            grid.Show();
            grid.displayDataGridView();

            admin_students adS = new admin_students();
            adS.Close();
        }

        public void add_Std_Click(object sender, EventArgs e)
        {
            if (

            stdIdBox.Text == "" ||
            stdAddressBox.Text == "" ||
            stdPasswordBox.Text == "" ||
            stdPhoneBox.Text == "" ||
            stdNameBox.Text == "" ||
            stdFacultyBox.Text == ""||
              stdParentBox.Text == ""

                )
            {
                MessageBox.Show("Please provide all the information!!");
                return;
            }

            else
            {
                cmd = new SqlCommand("INSERT INTO StudentTable(std_Roll , std_Name , std_Password , std_Faculty, std_Address , std_Phone  ,  std_Sex , std_ParentName ,   std_Email  ) VALUES(@id , @name , @password , @faculty , @address , @phone , @sex , @parentname , @email)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@id", stdIdBox.Text);
                cmd.Parameters.AddWithValue("@name", stdNameBox.Text);
                cmd.Parameters.AddWithValue("@password", stdPasswordBox.Text);
                cmd.Parameters.AddWithValue("@faculty", stdFacultyBox.Text);
                cmd.Parameters.AddWithValue("@address", stdAddressBox.Text);
                cmd.Parameters.AddWithValue("@phone", stdPasswordBox.Text);
                cmd.Parameters.AddWithValue("@sex", RadioButtonText());
                cmd.Parameters.AddWithValue("@parentname", stdParentBox.Text);
                cmd.Parameters.AddWithValue("@email", stdEmailBox.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Record Inserted Successfully");
                clear();

                stdDataGrid grid = new stdDataGrid();
                grid.Show();
                grid.displayDataGridView();
            }
        }

        private void clear()
        {
            stdIdBox.Clear();
            stdAddressBox.Clear();
            stdEmailBox.Clear();
            stdPasswordBox.Clear();
            stdPhoneBox.Clear();
            stdNameBox.Clear();
            stdParentBox.Clear();
            stdFacultyBox.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (stdIdBox.Text == "")
            {
                MessageBox.Show("Please Select Record to Delete");
            }
            else
            {
                cmd = new SqlCommand("DELETE StudentTable WHERE std_Roll=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", stdIdBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");

                stdDataGrid grid = new stdDataGrid();
                grid.displayDataGridView();

            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void stdParentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_students_FormClosing(object sender, FormClosingEventArgs e)
        {
                this.Dispose();

        }

        private void admin_students_Load(object sender, EventArgs e)
        {

        }
    }
}
