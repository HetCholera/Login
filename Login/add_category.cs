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
    public partial class add_category : Form
    {
        int rowcount, recordposition = -1, id = 0;
        Class1 cls1 = new Class1();
        public add_category()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            setting setting = new setting();
            setting.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_category(cate_name,cate_date,cate_status)values('" + txtname.Text + "','" + txtdate.Text + "','" + txtstatus.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cls1.InsertUpdateDelete(ins);
            clear();
            loaddata();
        }

        private void dgvcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dgvcategory.SelectedCells[0].Value.ToString();
            txtname.Text = dgvcategory.SelectedCells[1].Value.ToString();
            txtdate.Text = dgvcategory.SelectedCells[2].Value.ToString();
            txtstatus.Text = dgvcategory.SelectedCells[3].Value.ToString();
        }

        private void add_category_Load(object sender, EventArgs e)
        {
            loaddata();
            label6.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_category set cate_name ='" + txtname.Text + "',cate_date ='" + txtdate.Text + "',cate_status ='" + txtstatus.Text + "' where emp_category_id = '" + label6.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_category where emp_category_id='" + label6.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clear();
            loaddata();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void loaddata()
        {
            string sql = "select * from tbl_category";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvcategory.DataSource = dt;
        }
        private void clear()
        {
            txtname.Text = txtdate.Text = txtstatus.Text = string.Empty;
            txtname.Focus();
        }
    }
}
