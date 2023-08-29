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
    public partial class add_installment : Form
    {
        int rowcount, recordposition = -1;
        Class1 cls1 = new Class1();

        public add_installment()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            employee_loan employee_Loan = new employee_loan();
            employee_Loan.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void add_installment_Load(object sender, EventArgs e)
        {
            loaddata();
            label4.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_installment set emp_no ='" + txtno.Text + "',emp_name ='" + txtname.Text + "',payable_amount ='" + txtamount.Text + "' where installment_id = '" + label4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_installment values('" + txtno.Text + "','" + txtname.Text + "','" + txtamount.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            loaddata();
        }

        private void dgvviewinstallment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = dgvviewinstallment.SelectedCells[0].Value.ToString();
            txtno.Text = dgvviewinstallment.SelectedCells[1].Value.ToString();
            txtname.Text = dgvviewinstallment.SelectedCells[2].Value.ToString();
            txtamount.Text = dgvviewinstallment.SelectedCells[3].Value.ToString();
            recordposition = 0;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_installment where installment_id='" + label4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clear();
            loaddata();
        }

        private void loaddata()
        {
            string sql = "select * from tbl_installment";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvviewinstallment.DataSource = dt;
        }
        private void clear()
        {
            txtno.Text = txtname.Text = txtamount.Text = string.Empty;
            txtname.Focus();
        }
    }
}
