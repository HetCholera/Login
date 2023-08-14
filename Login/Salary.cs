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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
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

        private void button11_Click(object sender, EventArgs e)
        {
            this.Dispose();
            EmployeeDetails details = new EmployeeDetails();    
            details.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Dispose();
            add_basic_salary add_Basic_Salary = new add_basic_salary();
            add_Basic_Salary.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Dispose();
           Issue_Salary issue_Salary = new Issue_Salary();  
            issue_Salary.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Advance_Salary_Scheme advance_Salary_Scheme = new Advance_Salary_Scheme();
            advance_Salary_Scheme.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Issue_Advance_Salary issue_Advance_Salary = new Issue_Advance_Salary();
            issue_Advance_Salary.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            account account = new account();    
            account.ShowDialog();   
        }
    }
}
