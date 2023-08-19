using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Login
{

    internal class function
    {
        
       /* string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename|DataDirectory|Database1.mdf;Integrated Security=True";
        public SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        public static SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True");

        public string getmessage { get; set; }

        public bool connect()
        {
            try
            {
                cn.Open();
                getmessage = "Connected Successfully";
                return true;
            }
            catch(Exception)
            {
                getmessage = "Connection Failed";
                return false;
            } 
        }
        public bool disconnected()
        {
            try
            {
                cn.Close();
                return true; 
            }
            catch(Exception)
            {
                return false; 
            }
        }
        public string InsertUpdateDelete(string query)
        {
            string ret = "";
            string allquery=query.ToLower();      
            

            try
            {
                
                cmd.Connection = cn;
                connect();
                cmd.ExecuteNonQuery();
                cmd.CommandText = query;
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
                ret = getmessage = "Failed to execute" +query+"\n resion :" + ex.Message;
            }
            finally { disconnected(); }
            return ret;
        }
        public string Gridview(string query,DataGridView dgv)
        {
            dt = new DataTable();
            string strt;
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = query.ToLower();
                connect();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dgv.DataSource = dt;
                dgv.Refresh();
                strt = "Code Execute Successfully(Gridview()=>function.cs)";
            }
            catch(Exception ex) 
            {
                strt = "Failed(Gridview()=>function.cs:)" + ex.Message;
            }
            finally { disconnected() ; }
            dt = null;
            return strt;
                
   
        }*/
    }
   
}
