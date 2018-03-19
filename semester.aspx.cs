using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace WebApplication1
{
    public partial class semester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from tbl_semester where semester_name='" + txtsemester.Text + "'", con1);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Write("<script  >alert('Already Exist')</script>");

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
                con.Open();
                SqlCommand cmd2 = new SqlCommand("insert into tbl_semester(semester_name)values('" + txtsemester.Text + "')", con);
                cmd2.ExecuteNonQuery();

                //txtdept.Text = "";
                Response.Write("<script >alert('Successfully inserted')</Script>");
            }
        }
    }
}
