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
    public partial class stdAssingment : Form
    {
        public stdAssingment()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain sMain = new studentMain();
            sMain.Show();

        }

        private void signOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();

        }

        private void view_Click(object sender, EventArgs e)
        {
            stdAssGrid grid = new stdAssGrid();

            grid.Show();
            grid.displayDataGridView();
                        
        }

        public void titleBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void stdAssingment_Load(object sender, EventArgs e)
        {

        }
    }
}
