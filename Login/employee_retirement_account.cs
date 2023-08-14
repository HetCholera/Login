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
    public partial class employee_retirement_account : Form
    {
        public employee_retirement_account()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
            account account = new account();    
            account.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
            Home home = new Home();
            home.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                btnpayment.Enabled = true;
            }
            else
            {
                btnpayment.Enabled = false; 
            }
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            this.Dispose();
            retirement_payment retirement_Payment = new retirement_payment();
            retirement_Payment.ShowDialog();
        }
    }
}
