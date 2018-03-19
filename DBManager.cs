using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace WebApplication1
{
    public class DBManager
    {
        public SqlConnection connect()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Feedback"].ToString());
            return con;
        }

        public DataTable GetDataTableInline(string qry)
        {
            SqlConnection con=connect();
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public int InsertRecord(string qry)
        {
            SqlConnection con = connect();
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            int ret=cmd.ExecuteNonQuery();
            con.Close();
            return ret;
           
        }
    }
}