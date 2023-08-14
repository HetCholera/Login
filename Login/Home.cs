using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;


namespace Login
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            EmployeeDetails EmployeeDetails = new EmployeeDetails();
            EmployeeDetails.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            setting setting = new setting();    
            setting.ShowDialog();   
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Salary salary = new Salary();
            salary.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            employee_loan employee_Loan = new employee_loan();
            employee_Loan.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            account account = new account();
            account.ShowDialog();
        }
    }

}
