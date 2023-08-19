using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;

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
       

    }
   
}
