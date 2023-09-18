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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class add_basic_salary : Form
    {
        int rowcount, recordposition = -1, id = 0;
        Class1 cls1 = new Class1();
        public add_basic_salary()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            setting setting = new setting();
            setting.ShowDialog();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_add_basic_salary(emp_name,personal_designation,pd_amount,total_amount,functional_designation,fd_amount,date)values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + txtpdamount.Text + "','" + txttotalamount.Text + "','" + comboBox3.Text + "','" + txtfdamount.Text + "','" + date.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cls1.InsertUpdateDelete(ins);
            clear();
            loaddata();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Salary salary = new Salary();   
            salary.ShowDialog();
        }

        private void add_basic_salary_Load(object sender, EventArgs e)
        {
            loaddata();
            label9.Hide();
            string sql = "select designation_name from tbl_designation";
           
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i][0].ToString());
               
            }
            string sl = "select emp_name from tbl_emp_details";
            SqlDataAdapter dap = new SqlDataAdapter(sl, Class1.cn);
            DataTable dat = new DataTable();
            dap.Fill(dat);
            for (int i = 0; i < dat.Rows.Count; i++)
            {
                comboBox1.Items.Add(dat.Rows[i][0].ToString());
            }
            string fd = "select fun_name from tbl_functional_designation";
            SqlDataAdapter dpa = new SqlDataAdapter(fd, Class1.cn);
            DataTable dtb = new DataTable();
            dpa.Fill(dtb);
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                comboBox3.Items.Add(dtb.Rows[i][0].ToString());
            }
        }

        private void dgvaddbasicsalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label9.Text = dgvaddbasicsalary.SelectedCells[0].Value.ToString();
            comboBox1.Text = dgvaddbasicsalary.SelectedCells[1].Value.ToString();
            comboBox2.Text = dgvaddbasicsalary.SelectedCells[2].Value.ToString();
            txtpdamount.Text = dgvaddbasicsalary.SelectedCells[3].Value.ToString();
            txttotalamount.Text = dgvaddbasicsalary.SelectedCells[4].Value.ToString();
            comboBox3.Text = dgvaddbasicsalary.SelectedCells[5].Value.ToString();
            txtfdamount.Text = dgvaddbasicsalary.SelectedCells[6].Value.ToString();
            date.Text = dgvaddbasicsalary.SelectedCells[7].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_add_basic_salary set emp_name ='" + comboBox1.Text + "',personal_designation ='" + comboBox2.Text + "',pd_amount ='" + txtpdamount.Text + "',total_amount ='" + txttotalamount.Text + "' , functional_designation ='"+ comboBox3.Text+"',fd_amount='"+ txtfdamount .Text+ "',date='"+date.Text+"' where Id = '" + label9.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_add_basic_salary where Id='" + label9.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clear();
            loaddata();
        }

        private void loaddata()
        {
            string sql = "select * from tbl_add_basic_salary";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvaddbasicsalary.DataSource = dt;
        }
        private void clear()
        {
            comboBox1.Text = comboBox2.Text = txtpdamount.Text = txttotalamount.Text = comboBox3.Text = txtfdamount.Text = date.Text = string.Empty;
            comboBox1.Focus();
        }
    } 
}
