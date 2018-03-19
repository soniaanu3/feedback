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
    public partial class Batch : System.Web.UI.Page
    {
      
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                view_dept_dropdown();
            }
        }
            public void view_dept_dropdown()
            {

                SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_dept", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddldept.DataSource = dt;
                ddldept.DataTextField = "dept_name";
                ddldept.DataValueField = "dept_id";
                ddldept.DataBind();

               
            }
        

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

       
        

        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Course(Course_name,Dept_id)values('" + txtcourse.Text + "','" + ddldept.SelectedItem.Value + "')", con);
            cmd.ExecuteNonQuery();

            txtcourse.Text = "";
            Response.Write("<script >alert('Successfully inserted')</Script>");
        }

        protected void ddldept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}