﻿using System;
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
    public partial class add_designation : Form
    {
        int rowcount, recordposition = -1, id = 0;
        Class1 cls1 = new Class1();
        public add_designation()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_designation_Load(object sender, EventArgs e)
        {
            loaddata();
            label6.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();      
            setting setting = new setting();    
            setting.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbl_designation(designation_name,date,status,salary)values('" + txtname.Text + "','" + txtdate.Text + "','" + txtstatus.Text + "','" + txtsalary.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show(cls1.InsertUpdateDelete(ins), "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cls1.InsertUpdateDelete(ins);
            clear();
            loaddata();
        }

        private void dgvdesignation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dgvdesignation.SelectedCells[0].Value.ToString();
            txtname.Text = dgvdesignation.SelectedCells[1].Value.ToString();
            txtdate.Text = dgvdesignation.SelectedCells[2].Value.ToString();
            txtstatus.Text = dgvdesignation.SelectedCells[3].Value.ToString();
            txtsalary.Text = dgvdesignation.SelectedCells[4].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql = "update tbl_designation set designation_name ='" + txtname.Text + "',date ='" + txtdate.Text + "',status ='" + txtstatus.Text + "',salary ='" + txtsalary.Text + "' where designation_id = '" + label6.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.loaddata();
            clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbl_designation where designation_id='" + label6.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clear();
            loaddata();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void loaddata()
        {
            string sql = "select * from tbl_designation";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rowcount = dt.Rows.Count;
            dgvdesignation.DataSource = dt;
        }
        private void clear()
        {
            txtname.Text = txtdate.Text = txtstatus.Text = txtsalary.Text = string.Empty;
            txtname.Focus();
        }
    }
}
