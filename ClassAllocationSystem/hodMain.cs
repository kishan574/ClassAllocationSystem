using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAllocationSystem
{
    public partial class hodMain : Form
    {
        public hodMain()
        {
            InitializeComponent();
        }

        private void signOut_Click(object sender, EventArgs e)
        {

            this.Hide();
            login logIn = new login();
            logIn.Show();
        }

        private void hodMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
         
        }

        private void myInfo_Click(object sender, EventArgs e)
        {

        }

        private void teachersInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            teachInfo tinfo = new teachInfo();
            tinfo.Show();            
            
           
        }

        private void students_Click(object sender, EventArgs e)
        {
            admin_students s = new admin_students();
            s.Show();

        }

        private void assignment_Click(object sender, EventArgs e)
        {
            this.Hide();
            hodassignment hass = new hodassignment();
            hass.Show();
        }

        private void classRoutine_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            hodClassRout hcr = new hodClassRout();
            hcr.Show();
        }

        private void examRoutine_Click(object sender, EventArgs e)
        {
            this.Hide();
            hodexamRout her = new hodexamRout();
            her.Show();
        }

        private void notice_Click(object sender, EventArgs e)
        {
            this.Hide();
            hodNotice hn = new hodNotice();
            hn.Show();

        }

        private void hodMain_Load(object sender, EventArgs e)
        {

        }

        private void signOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login logIn = new login();
            logIn.Show();
        }
    }

}

