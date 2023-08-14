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
    public partial class employee_loan : Form
    {
        public employee_loan()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Home home = new Home();
            home.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Dispose();
            add_applicant add_Applicant = new add_applicant();
            add_Applicant.ShowDialog(); 
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Dispose();
            add_loan add_loan = new add_loan(); 
            add_loan.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Dispose();
            add_scheme add_scheme = new add_scheme();   
            add_scheme.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Dispose();
            add_installment add_Installment = new add_installment();
            add_Installment.ShowDialog();
        }
    }
}
