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
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Home home = new Home(); 
            home.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
            setting setting = new setting();
            setting.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Salary salary = new Salary();   
            salary.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            account account = new account();    
            account.ShowDialog();
        }
    }
}
