using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class add_bonus : Form
    {
        int rowcount, recordposition = -1;
        Class1 cls1 = new Class1();
       
      
        public add_bonus()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            setting setting = new setting();    
            setting.ShowDialog();
        }

        private void add_bonus_Load(object sender, EventArgs e)
        {
          
          loaddata();
            label6.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(label6.Text);
            string sql = "update tbl_bonus set name ='"+ txtname.Text + "',date ='"+ txtdate.Text + "',status ='"+ txtstatus.Text + "',amount ='"+ txtamount.Text + "' where bonus_id = '"+label6.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {

            clear();   
        }

        private void loaddata()
        {
            string sql = "select * from tbl_bonus";
            SqlDataAdapter da = new SqlDataAdapter(sql,Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvbonus.DataSource = dt;
        }

        private void dgvbonus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvbonus_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dgvbonus_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dgvbonus.SelectedCells[0].Value.ToString();
            txtname.Text = dgvbonus.SelectedCells[1].Value.ToString();
            txtdate.Text = dgvbonus.SelectedCells[2].Value.ToString();
            txtstatus.Text = dgvbonus.SelectedCells[3].Value.ToString();
            txtamount.Text = dgvbonus.SelectedCells[4].Value.ToString();
            recordposition = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                string sql = "delete from tbl_bonus where bonus_id='" + label6.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clear();
                loaddata();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ins = "insert into tbl_bonus values('" + txtname.Text + "','" + txtdate.Text + "','"+txtstatus.Text+ "','"+txtamount.Text+"')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();

            /*  string insert = "insert into tbl_bonus values('" + txtname.Text+ "','"+txtdate.Text+ "','"+txtstatus.Text+ "','"+txtamount.Text+"')";
              MessageBox.Show(fn.InsertUpdateDelete(insert), "Save Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
              fn.InsertUpdateDelete(insert);
              txtname.Clear();
              txtstatus.Clear();
              txtamount.Clear();*/
        }


        private void clear()
        {
            txtname.Text = txtdate.Text = txtstatus.Text = txtamount.Text = string.Empty;
            txtname.Focus();
        }
    }
}
