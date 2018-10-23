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
    public partial class adminMain : Form
    {

        public adminMain()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void signOut_Click(object sender, EventArgs e)
        {
           this.Hide();
           login logIn = new login();
            logIn.Show();
        }

       
        private void hod_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_Hod adHod = new admin_Hod();
            adHod.Show();

            
        }

        private void student_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_students adStd = new admin_students();
            adStd.Show();

                      
        }

       

        private void adminMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        
         private void adminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
                
        }
    }


}
