                                                         using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Advance_Salary_Scheme : Form
    {
        public Advance_Salary_Scheme()
        {
            InitializeComponent();
        }

        private void Advance_salary_Scheme_Load(object sender, EventArgs e)
        {
            string sl = "select emp_name from tbl_emp_details";
            SqlDataAdapter dap = new SqlDataAdapter(sl, Class1.cn);
            DataTable dat = new DataTable();
            dap.Fill(dat);
            for (int i = 0; i < dat.Rows.Count; i++)
            {
                comboBox1.Items.Add(dat.Rows[i][0].ToString());
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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
