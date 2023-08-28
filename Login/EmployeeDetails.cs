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
           // FillCombobox(branch_code, cmb_branch_code);

           
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
