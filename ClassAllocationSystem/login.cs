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
using System.Xml.Linq;


namespace ClassAllocationSystem
{

    public partial class login : Form
    {
        RadioCheckStatus radioStatus = RadioCheckStatus.none;
        private enum RadioCheckStatus
        {
            none = 0,
            radioHod = 1,
            radioStudents = 2,
            radioAdmin = 3,
        }

        public login()
        {
            InitializeComponent();
       
        }

        private void login_Load(object sender, EventArgs e)
        {                   

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void signIn_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }


            switch (radioStatus)
            {          
                
                case RadioCheckStatus.radioAdmin:
                    {
                        try //admin table
                        {
                            SqlConnection signIn_con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
                            SqlDataAdapter signIn_sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin WHERE admin_Username='" + usernameBox.Text + "' AND admin_Password='" + passwordBox.Text + "'", signIn_con);

                            signIn_con.Open();
                            DataTable dt = new DataTable();
                            signIn_sda.Fill(dt);


                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                this.Hide();
                                adminMain adminForm = new adminMain();
                                adminForm.ShowDialog();
                            }

                            else
                            {
                                MessageBox.Show("Inavlid Username or Password!!");
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        break;
                    }


                case RadioCheckStatus.radioHod:
                    {                        
                        try //hod table
                        {
                            SqlConnection signIn_con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
                            SqlDataAdapter signIn_sda = new SqlDataAdapter("SELECT COUNT(*) FROM HoDDTable WHERE hodd_ID='" + usernameBox.Text + "' AND hodd_Password='" + passwordBox.Text + "'", signIn_con);

                            signIn_con.Open();
                            DataTable dt = new DataTable();
                            signIn_sda.Fill(dt);


                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                this.Hide();
                                hodMain hodForm = new hodMain();
                                hodForm.Show();
                            }

                            else
                            {
                                MessageBox.Show("Inavlid Username or Password!!");
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }



                        break;
                    }

                case RadioCheckStatus.radioStudents:
                    {
                        try
                        {
                            SqlConnection signIn_con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
                            SqlDataAdapter signIn_sda = new SqlDataAdapter("SELECT COUNT(*) FROM StudentTable WHERE std_Roll='" + usernameBox.Text + "' AND std_Password='" + passwordBox.Text + "'", signIn_con);

                            signIn_con.Open();
                            DataTable dt = new DataTable();
                            signIn_sda.Fill(dt);


                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                this.Hide();
                                studentMain stdForm = new studentMain();
                                stdForm.Show();
                               
                            }

                            else
                            {
                                MessageBox.Show("Inavlid Username or Password!!");
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    }

                default:
                    {
                        MessageBox.Show("User not specified!!");
                        break;
                    }

            }

         
        }
    
            

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }


        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            radioStatus = RadioCheckStatus.radioAdmin;
            return;
        }




        private void radioHod_CheckedChanged(object sender, EventArgs e)
        {
            radioStatus = RadioCheckStatus.radioHod;
            return;
        }

        private void radioStudents_CheckedChanged(object sender, EventArgs e)
        {
            radioStatus = RadioCheckStatus.radioStudents;
            return;
        }


        
        private void loginTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void login_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           if(MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
           {
           e.Cancel = true;
                Application.Exit();
           }
     
        }

    }

}



