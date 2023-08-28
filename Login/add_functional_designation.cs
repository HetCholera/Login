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
    public partial class add_functional_designation : Form
    {
        int rowcount, recordposition = -1;
        Class1 cls1 = new Class1();
        public add_functional_designation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_functional_designation values('" + txtname.Text + "','" + txtdate.Text + "','" + txtstatus.Text + "','" + txtamount.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            loaddata();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            setting setting = new setting();    
            setting.ShowDialog();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           clear();
        }

        private void add_functional_designation_Load(object sender, EventArgs e)
        {
            loaddata();
            label6.Hide();
        }

        private void clear()
        {
            txtname.Text = txtdate.Text = txtstatus.Text = txtamount.Text = string.Empty;
            txtname.Focus();
        }

        private void dgvfundesignation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dgvfundesignation.SelectedCells[0].Value.ToString();
            txtname.Text = dgvfundesignation.SelectedCells[1].Value.ToString();
            txtdate.Text = dgvfundesignation.SelectedCells[2].Value.ToString();
            txtstatus.Text = dgvfundesignation.SelectedCells[3].Value.ToString();
            txtamount.Text = dgvfundesignation.SelectedCells[4].Value.ToString();
            recordposition = 0;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_functional_designation where emp_functional_designation_id='" + label6.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clear();
            loaddata();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_functional_designation set fun_name ='" + txtname.Text + "',fun_date ='" + txtdate.Text + "',fun_status ='" + txtstatus.Text + "',fun_amount ='" + txtamount.Text + "' where emp_functional_designation_id = '" + label6.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
        }

        private void loaddata()
        {
            string sql = "select * from tbl_functional_designation";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvfundesignation.DataSource = dt;
        }
    }
}
