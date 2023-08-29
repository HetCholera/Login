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
    public partial class add_loan : Form
    {
        int rowcount, recordposition = -1;
        Class1 cls1 = new Class1();
        public add_loan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            employee_loan employee_Loan = new employee_loan();
            employee_Loan.ShowDialog();
        }

        private void add_loan_Load(object sender, EventArgs e)
        {
            loaddata();
            label3.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_add_loan set loan_name ='" + txtname.Text + "',date ='" + txtdate.Text + "',amount ='" + txtamount.Text + "' where loan_id = '" + label3.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
        }

       

        private void dgvloan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dgvloan.SelectedCells[0].Value.ToString();
            txtname.Text = dgvloan.SelectedCells[1].Value.ToString();
            txtdate.Text = dgvloan.SelectedCells[2].Value.ToString();
            txtamount.Text = dgvloan.SelectedCells[3].Value.ToString();
            recordposition = 0;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_add_loan where loan_id='" + label3.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clear();
            loaddata();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_add_loan values('" + txtname.Text + "','" + txtdate.Text + "','" + txtamount.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            loaddata();
        }

        private void loaddata()
        {
            string sql = "select * from tbl_add_loan";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvloan.DataSource = dt;
        }
        private void clear()
        {
            txtname.Text = txtamount.Text = string.Empty;
            txtname.Focus();
        }
    }
}
