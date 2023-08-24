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
            label6.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_allowance set allowance_name ='" + txtname.Text + "',date ='" + txtdate.Text + "',status ='" + txtstatus.Text + "',amount ='" + txtamount.Text + "' where allowance_id = '" + label6.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
        }

        private void dgvallow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dgvallow.SelectedCells[0].Value.ToString();
            txtname.Text = dgvallow.SelectedCells[1].Value.ToString();
            txtdate.Text = dgvallow.SelectedCells[2].Value.ToString();
            txtstatus.Text = dgvallow.SelectedCells[3].Value.ToString();
            txtamount.Text = dgvallow.SelectedCells[4].Value.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_allowance(allowance_name,date,status,amount)values('" + txtname.Text + "','" + txtdate.Text + "','" + txtstatus.Text + "','" + txtamount.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cls1.InsertUpdateDelete(ins);
           clear();
            loaddata();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_allowance where allowance_id='" + label6.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clear();
            loaddata();
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
        private void clear()
        {
            txtname.Text = txtdate.Text = txtstatus.Text = txtamount.Text = string.Empty;
            txtname.Focus();
        }
    }
}
