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
    public partial class add_insurance_account : Form
    {
        int rowcount, recordposition = -1, id = 0;
        Class1 cls1 = new Class1();
        public add_insurance_account()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            account account = new account();    
            account.ShowDialog();   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Home home = new Home(); 
            home.ShowDialog();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_add_insurance(emp_no,salary_insurance_amount,date,org_contri_amount)values('" + txtempno.Text + "','" + txtsalaryinsuranceamount.Text + "','" + txtdate.Text + "','" + txtorgcontriamount.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cls1.InsertUpdateDelete(ins);
            clear();
            loaddata();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_add_insurance set emp_no ='" + txtempno.Text + "',salary_insurance_amount ='" + txtsalaryinsuranceamount.Text + "',date ='" + txtdate.Text + "',org_contri_amount ='" + txtorgcontriamount.Text + "' where Id = '" + label4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
        }

        private void add_insurance_account_Load(object sender, EventArgs e)
        {
            loaddata();
            label4.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_add_insurance where Id='" + label4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clear();
            loaddata();
        }

        private void dgvinsuranceaccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = dgvinsuranceaccount.SelectedCells[0].Value.ToString();
            txtempno.Text = dgvinsuranceaccount.SelectedCells[1].Value.ToString();
            txtsalaryinsuranceamount.Text = dgvinsuranceaccount.SelectedCells[2].Value.ToString();
            txtdate.Text = dgvinsuranceaccount.SelectedCells[3].Value.ToString();
            txtorgcontriamount.Text = dgvinsuranceaccount.SelectedCells[4].Value.ToString();
        }

        private void loaddata()
        {
            string sql = "select * from tbl_add_insurance";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvinsuranceaccount.DataSource = dt;
        }
        private void clear()
        {
            txtempno.Text = txtsalaryinsuranceamount.Text = txtdate.Text = txtorgcontriamount.Text = string.Empty;
            txtempno.Focus();
        }
    }
}
