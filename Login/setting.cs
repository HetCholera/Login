using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Home home = new Home(); 
            home.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            add_designation add_Designation = new add_designation();    
            add_Designation.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            add_branch add_branch = new add_branch();
            add_branch.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            add_bonus add_Bonus = new add_bonus();  
            add_Bonus.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            this.Dispose();
            add_allowance add_Allowance = new add_allowance();
            add_Allowance.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            add_category add_category = new add_category();
            add_category.ShowDialog();
        }
    }
}
