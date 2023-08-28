using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;
using System.Xml.Linq;

namespace Login
{
    internal class Class1
    {

        public static SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True");
        public string getmessage { get; set; }
        public string InsertUpdateDelete(string query)
        {
            string ret = "";
            string allquery = query.ToLower();
            try
            {
                if (allquery.ToLower().Contains("insert"))
                {
                    ret = getmessage = "Inserted Successfully";
                }
                else if (allquery.ToLower().Contains("update") && allquery.ToLower().Contains("set"))
                {
                    ret = getmessage = "Updated Successfully";
                }
                else if (allquery.ToLower().Contains("delete"))
                {
                    ret = getmessage = "Deleted Successfully";
                }

            }
            catch (Exception ex)
            {
                ret = getmessage = "Failed to execute" + query + "\n resion :" + ex.Message;
            }
            finally { disconnected(); }
            return ret;
        }
        public bool disconnected()
        {
            try
            {
                cn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
       /* public string getSingleValueAsArraybyIndex(string query, out List<string> columndata, int index)
        {
            List<string> data = new List<string>();
            string ret;
            SqlDataReader myreader;
            try
            {
                
                while(myreader.Read())
                {
                    data.Add();
                }
            }

        }
        public void fillcombox(string query, ComboBox cmb)
        {
            int i = 0;
            List<string> list = new List<string>();
            getSingleValueAsArraybyIndex(query, out list, 0);
            foreach (string val in list)
            {
                if (val.Length > 0)
                {
                    cmb.Items.Add(val);
                    i++;
                }
            }
            if (i > 0)
            {
                cmb.SelectedIndex = i;
            }
        }*/
      /* public getsinglevaluesinglecolumn(string query,out string columndata,int index)
        {
            string ret = null;
            try
            {

            }
            catch (Exception ex)
            {
                
            }
        }*/
    }
    
}
