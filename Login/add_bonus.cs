using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        int rowcount, recordposition = -1, id = 0;
        public static SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True");
      
        public add_bonus()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void add_bonus_Load(object sender, EventArgs e)
        {
          
          loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (recordposition >= 0)
            {
                string sql = "update tbl_bonus set name='" + txtname.Text + "',date='" + txtdate.Text + "' ,status='" + txtstatus.Text + "',amount='" + txtamount.Text + "' where bonus_id='" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clear();
                loaddata();
                recordposition = -1;
                id = 0;
            }
            else
            {
                MessageBox.Show("Please select record!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            clear();
            
        }

        private void loaddata()
        {
            string sql = "select * from tbl_bonus";
            SqlDataAdapter da = new SqlDataAdapter(sql,cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvbonus.DataSource = dt;
        }

        private void dgvbonus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hello");

        }

        private void dgvbonus_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void dgvbonus_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "insert into tbl_bonus values('" + txtname.Text + "','" + txtdate.Text + "','"+txtstatus.Text+ "','"+txtamount.Text+"')";
            SqlDataAdapter da = new SqlDataAdapter(sql,cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Record Inserted!", "DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
             txtname.Clear();
              txtstatus.Clear();
              txtamount.Clear();

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
