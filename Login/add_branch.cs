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
    public partial class add_branch : Form
    {
        int rowcount, recordposition = -1, id = 0;
        Class1 cls1 = new Class1(); 
        public add_branch()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string ins = "insert into tbl_branch(branch_code,date,location,contact)values('" + txtbranchcode.Text+ "','"+ txtdate.Text+ "','"+ txtlocation.Text+ "','"+ txtphone.Text+"')";
             SqlDataAdapter da = new SqlDataAdapter(ins,Class1.cn);
             DataTable dt = new DataTable();
             da.Fill(dt);
             MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
             cls1.InsertUpdateDelete(ins);
             txtbranchcode.Clear();
             txtlocation.Clear();
             txtphone.Clear();
        }

        private void add_branch_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loaddata()
        {
            string sql = "select * from tbl_branch";
            SqlDataAdapter da = new SqlDataAdapter(sql,Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvbranch.DataSource = dt;
        }
    }
}
