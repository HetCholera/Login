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
    public partial class add_scheme : Form
    {
        public add_scheme()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            employee_loan employee_Loan = new employee_loan();
            employee_Loan.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void add_scheme_Load(object sender, EventArgs e)
        {

            string sql = "select loan_name from tbl_add_loan";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i][0].ToString());
            }
            
           // rowcount = dt.Rows.Count;
        }
    }
}
