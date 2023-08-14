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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
           Home home = new Home();  
            home.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            employee_account emp_account = new employee_account();  
            emp_account.ShowDialog();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            add_insurance_account add_insurance_account = new add_insurance_account();  
            add_insurance_account.ShowDialog(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            org_contribute_amount org_Contribute_Amount = new org_contribute_amount();
            org_Contribute_Amount.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            medical_payment_account medical_payment_account = new medical_payment_account();
            medical_payment_account.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            employee_retirement_account emp_retir_acc = new employee_retirement_account();  
            emp_retir_acc.ShowDialog();
        }
    }
}
