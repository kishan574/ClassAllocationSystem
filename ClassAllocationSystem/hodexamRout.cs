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
    public partial class hodexamRout : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        string pdfLog;
        public hodexamRout()
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

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openpdf = new OpenFileDialog();
            Openpdf.Filter = "PDF files|*.pdf|All files|*.*;";
            if (Openpdf.ShowDialog() == DialogResult.OK)
            {
                pdfLog = Openpdf.FileName.ToString();
                textBox1.Text = pdfLog;
                //pdfUploadbox.Text = pdfLog;
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "" ||
                assignmentName.Text == "" ||
                    textBox1.Text == " "
                )

            {
                MessageBox.Show("entry empty");
            }

            else
            {
                cmd = new SqlCommand("INSERT INTO examRoutine(Id , Filename , Data , time) VALUES(@id, @filename , @data , @time )", con);
                con.Open();

                cmd.Parameters.AddWithValue("@id", idBox.Text);
                cmd.Parameters.AddWithValue("@filename", assignmentName.Text);
                cmd.Parameters.AddWithValue("@data", pdfLog);
                cmd.Parameters.AddWithValue("@time", DateTime.Today);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Success");
                con.Close();
            }

            examGrid grid = new examGrid();

            grid.displayDataGridView();
            grid.Show();

        }
    }
}
