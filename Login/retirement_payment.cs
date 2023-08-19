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
    public partial class retirement_payment : Form
    {
        public retirement_payment()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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
    }
}
