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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class EmployeeDetails : Form
    {
        int rowcount, recordposition = -1, id = 0;
        Class1 cls1 = new Class1();
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Home home = new Home(); 
            home.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
            setting setting = new setting();
            setting.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Salary salary = new Salary();   
            salary.ShowDialog();
        }
        byte[] filename;
        public byte[] ImageToByteArray(Image img,PictureBox pb)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            if(pb!= null)
            {
                img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return memoryStream.ToArray();
        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dr = openFileDialog.ShowDialog();
            if(dr==DialogResult.OK)
            {
                pic.BackgroundImage=Image.FromFile(openFileDialog.FileName);
                pic.BackgroundImageLayout=ImageLayout.Stretch;
                filename = ImageToByteArray(pic.BackgroundImage,pic);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_emp_details(branch_code,emp_name,father_name,gender,phone_number,cnic_no,personal_Designation,functional_designation,bps,emp_no,dob,address,category,status,join_date)values('" + cmb_branch_code.Text + "','" + txtname.Text + "','" + txtfathername.Text + "','" + cmb_gender.Text + "','" +txtphone.Text + "','" + txtcnicno.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + txtbps.Text + "','" + txtempno.Text + "','" + txtdob.Text + "','" + txtaddress.Text + "','"+ comboBox5.Text+"','"+ txtstatus.Text + "','"+ txtjoindate .Text+ "')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cls1.InsertUpdateDelete(ins);
            clear();
            loaddata();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            account account = new account();    
            account.ShowDialog();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            /* string branchcode = "select branch_code from tbl_branch";
             cls1.fillcombox(branchcode, cmb_branch_code);*/
            string sql = "select branch_code from tbl_branch";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_branch_code.Items.Add(dt.Rows[i][0].ToString());
            }

            // FillCombobox(branch_code, cmb_branch_code);
            string sl = "select designation_name from tbl_designation";
            SqlDataAdapter d = new SqlDataAdapter(sl, Class1.cn);
            DataTable dat = new DataTable();
            d.Fill(dat);
            for (int i = 0; i < dat.Rows.Count; i++)
            {
                comboBox3.Items.Add(dat.Rows[i][0].ToString());
            }
            string fd = "select fun_name from tbl_functional_designation";
            SqlDataAdapter dap = new SqlDataAdapter(fd, Class1.cn);
            DataTable dtb = new DataTable();
            dap.Fill(dtb);
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                comboBox4.Items.Add(dtb.Rows[i][0].ToString());
            }
            string cat = "select cate_name from tbl_category";
            SqlDataAdapter aca = new SqlDataAdapter(cat, Class1.cn);
            DataTable cadt = new DataTable();
            aca.Fill(cadt);
            for (int i = 0; i < cadt.Rows.Count; i++)
            {
                comboBox5.Items.Add(cadt.Rows[i][0].ToString());
            }

        }
        private void loaddata()
        {
            string sql = "select * from tbl_emp_details";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvempdetails.DataSource = dt;
        }
        private void clear()
        {
            cmb_branch_code.Text = txtname.Text = txtfathername.Text = cmb_gender.Text = txtphone.Text = txtcnicno.Text = comboBox3.Text = comboBox4.Text = txtbps.Text = txtempno.Text = txtdob.Text = txtaddress.Text = comboBox5.Text = txtstatus.Text = txtjoindate.Text = string.Empty;
            txtempno.Focus();
        }
        /*  public void FillCombobox()
          {

              string sql = "select branch_code from tbl_branch";
              SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
              DataTable dt = new DataTable();
              da.Fill(dt);

              SqlDataReader myreader;
              try
              {

                  while (myreader.Read())
                  {
                      string cname = myreader.GetString(1);
                      cmb_branch_code.Items.Add(branchcode);
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Cannot open connection ! ");
              }
          }*/
    }
}
