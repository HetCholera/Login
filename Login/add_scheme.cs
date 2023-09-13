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

namespace Login
{
    public partial class add_scheme : Form
    {
        int rowcount, recordposition = -1, id = 0;
        Class1 cls1 = new Class1();
        public add_scheme()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            employee_loan employee_Loan = new employee_loan();
            employee_Loan.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_add_scheme(emp_no,name,date,per_month_amount,loan_name,loan_amount,basic_salary,duration)values('" + txt_empno.Text + "','"+ comboBox1.Text + "','" + txtdate.Text + "','" + txt_permonthamount.Text + "','" + comboBox2.Text + "','" + txt_loan_amount.Text + "','" + txt_basic_salary.Text + "','"+ comboBox3.Text +"')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cls1.InsertUpdateDelete(ins);
            clear();
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            clear();
        }

        private void add_scheme_Load(object sender, EventArgs e)
        {
            loaddata();
            label4.Hide();
            string sql = "select loan_name from tbl_add_loan";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i][0].ToString());
            }
            string sl = "select applicant_name from tbl_add_applicant";
            SqlDataAdapter dap = new SqlDataAdapter(sl, Class1.cn);
            DataTable dat = new DataTable();
            dap.Fill(dat);
            for (int i = 0; i < dat.Rows.Count; i++)
            {
                comboBox1.Items.Add(dat.Rows[i][0].ToString());
            }
            // rowcount = dt.Rows.Count;
        }

        private void dgvloanscheme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = dgvloanscheme.SelectedCells[0].Value.ToString();
            txt_empno.Text = dgvloanscheme.SelectedCells[1].Value.ToString();
            comboBox1.Text = dgvloanscheme.SelectedCells[2].Value.ToString();
            txtdate.Text = dgvloanscheme.SelectedCells[3].Value.ToString();
            txt_permonthamount.Text = dgvloanscheme.SelectedCells[4].Value.ToString();
            comboBox2.Text = dgvloanscheme.SelectedCells[5].Value.ToString();
            txt_loan_amount.Text = dgvloanscheme.SelectedCells[6].Value.ToString();
            txt_basic_salary.Text = dgvloanscheme.SelectedCells[7].Value.ToString();
            comboBox3.Text = dgvloanscheme.SelectedCells[8].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_add_scheme set emp_no ='" + txt_empno.Text + "',name ='" + comboBox1.Text + "',date ='" + txtdate.Text + "',per_month_amount ='" + txt_permonthamount.Text + "',loan_name ='" + comboBox2.Text + "', loan_amount='"+ txt_loan_amount.Text + "',basic_salary='"+ txt_basic_salary.Text + "',duration='" + comboBox3.Text + "' where scheme_id = '" + label4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_add_scheme where scheme_id='" + label4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clear();
            loaddata();
        }

        private void loaddata()
        {
            string sql = "select * from tbl_add_scheme";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvloanscheme.DataSource = dt;
        }
        private void clear()
        {
            txt_empno.Text= comboBox1.Text = txtdate.Text = txt_permonthamount.Text = comboBox2.Text = txt_loan_amount.Text = txt_basic_salary.Text = comboBox3.Text = string.Empty;
            comboBox1.Focus();
        }
    }
}
