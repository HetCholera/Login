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
    public partial class add_applicant : Form
    {
        int rowcount, recordposition = -1;
        Class1 cls1 = new Class1();
        public add_applicant()
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_add_applicant set applicant_name ='" + txtname.Text + "',status ='" + txtstatus.Text + "',description ='" + txtdescription.Text + "' where applicant_id = '" + label3.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
        }

        private void add_applicant_Load(object sender, EventArgs e)
        {
            loaddata();
            label3.Hide();
        }

        private void dgvapplicant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dgvapplicant.SelectedCells[0].Value.ToString();
            txtname.Text = dgvapplicant.SelectedCells[1].Value.ToString();
            txtstatus.Text = dgvapplicant.SelectedCells[2].Value.ToString();
            txtdescription.Text = dgvapplicant.SelectedCells[3].Value.ToString();
            recordposition = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_add_applicant where applicant_id='" + label3.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clear();
            loaddata();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_add_applicant values('" + txtname.Text + "','" + txtstatus.Text + "','" + txtdescription.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            loaddata();
        }

        private void loaddata()
        {
            string sql = "select * from tbl_add_applicant";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvapplicant.DataSource = dt;
        }
        private void clear()
        {
            txtname.Text = txtstatus.Text = txtdescription.Text = string.Empty;
            txtname.Focus();
        }
    }
}
