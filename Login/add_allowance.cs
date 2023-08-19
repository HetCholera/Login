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
    public partial class add_allowance : Form
    {
        int rowcount, recordposition = -1, id = 0;
        Class1 cls1 = new Class1();
        public add_allowance()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            setting setting = new setting();    
            setting.ShowDialog();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void add_allowance_Load(object sender, EventArgs e)
        {
            loaddata(); 
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_allowance(name,date,status,allowance_amount)values('" + txtname.Text + "','" + txtdate.Text + "','" + txtstatus.Text + "','" + txtamount.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cls1.InsertUpdateDelete(ins);
            txtname.Clear();
            txtstatus.Clear();
            txtamount.Clear();
        }
        private void loaddata()
        {
            string sql = "select * from tbl_allowance";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvallow.DataSource = dt;
        }
    }
}
