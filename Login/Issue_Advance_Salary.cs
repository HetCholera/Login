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
    public partial class Issue_Advance_Salary : Form
    {
        public Issue_Advance_Salary()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            setting setting = new setting();
            setting.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Salary salary = new Salary();
            salary.ShowDialog();
        }
    }
}
