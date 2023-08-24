using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
             string ins = "insert into branch_tbl(branch_code,date,location,phone)values('" + txtbranchcode.Text+ "','"+ txtdate.Text+ "','"+ txtlocation.Text+ "','"+ txtphone.Text+"')";
             SqlDataAdapter da = new SqlDataAdapter(ins,Class1.cn);
             DataTable dt = new DataTable();
             da.Fill(dt);
             MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
             cls1.InsertUpdateDelete(ins);
             clear();
            loaddata();
        }
          
        private void add_branch_Load(object sender, EventArgs e)
        {
            label6.Hide();
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "update branch_tbl set branch_code ='" + txtbranchcode.Text + "',date ='" + txtdate.Text + "',location ='" + txtlocation.Text + "',phone ='" + txtphone.Text + "' where branch_id = '" + label6.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
        }

        private void dgvbranch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dgvbranch.SelectedCells[0].Value.ToString();
            txtbranchcode.Text = dgvbranch.SelectedCells[1].Value.ToString();
            txtdate.Text = dgvbranch.SelectedCells[2].Value.ToString();
            txtlocation.Text = dgvbranch.SelectedCells[3].Value.ToString();
            txtphone.Text = dgvbranch.SelectedCells[4].Value.ToString();
            //recordposition = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "delete from branch_tbl where branch_id='" + label6.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clear();
            loaddata();
        }

        private void loaddata()
        {
            string sql = "select * from branch_tbl";
            SqlDataAdapter da = new SqlDataAdapter(sql,Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvbranch.DataSource = dt;
        }
        private void clear()
        {
            txtbranchcode.Text = txtdate.Text = txtlocation.Text = txtphone.Text = string.Empty;
            txtbranchcode.Focus();
        }
    }
}
