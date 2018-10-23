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
    public partial class stdTeacherInfo : Form
    {
        public stdTeacherInfo()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {

            this.Hide();
            studentMain hm = new studentMain();
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
            idBox.Text = "";
            nameBox.Text = "";
            emailBox.Text = "";
            phnBox.Text = "";
        }

        private void view_Click(object sender, EventArgs e)
        {
            teacherGrid ng = new teacherGrid();
            ng.displayDataGridView();
            ng.Show();
        }
    }
}
