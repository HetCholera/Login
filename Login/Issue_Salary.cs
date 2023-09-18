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
    public partial class Issue_Salary : Form
    {
        public Issue_Salary()
        {
            InitializeComponent();
        }

        private void Issue_Salary_Load(object sender, EventArgs e)
        {
            string sl = "select emp_name from tbl_emp_details";
            SqlDataAdapter dap = new SqlDataAdapter(sl, Class1.cn);
            DataTable dat = new DataTable();
            dap.Fill(dat);
            for (int i = 0; i < dat.Rows.Count; i++)
            {
                comboBox1.Items.Add(dat.Rows[i][0].ToString());
            }
            string sql = "select name from tbl_bonus";

            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i][0].ToString());
            }
            string fd = "select allowance_name from tbl_allowance";
            SqlDataAdapter dpa = new SqlDataAdapter(fd, Class1.cn);
            DataTable dtb = new DataTable();
            dpa.Fill(dtb);
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                comboBox3.Items.Add(dtb.Rows[i][0].ToString());
            }
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
