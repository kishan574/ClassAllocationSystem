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
    public partial class studentMain : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\kishu\onedrive\documents\visual studio 2015\Projects\ClassAllocationSystem\ClassAllocationSystem\classAlloc.mdf'; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;

        public studentMain()
        {
            InitializeComponent();
        }

        private void studentMain_Load(object sender, EventArgs e)
        {

        }
        private void signOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login logIn = new login();
            logIn.Show();
        }

        private void studentMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void courseDesc_Click(object sender, EventArgs e)
        {

        }

        private void assignment_Click(object sender, EventArgs e)
        {
            this.Hide();
            stdAssingment sAss = new stdAssingment();
            sAss.Show();


        }

        private void notice_Click(object sender, EventArgs e)
        {
            this.Hide();
            stdNotice sn = new stdNotice();
            sn.Show();
        }

        private void teachersInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            stdTeacherInfo sti = new stdTeacherInfo();
            sti.Show(); 

        }

        private void examRoutine_Click(object sender, EventArgs e)
        {
            this.Hide();
            stdExam se = new stdExam();
            se.Show();
        }

        private void classRoutine_Click(object sender, EventArgs e)
        {
            this.Hide();
            stdClassRout ec = new stdClassRout();
            ec.Show();

        }
    }
}
