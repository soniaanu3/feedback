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
    public partial class batch1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");

                con.Open();
                string com = "Select dept_id,dept_name from tbl_dept";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                ddldept.DataSource = dt;
                ddldept.DataTextField = "dept_name";
                ddldept.DataValueField = "dept_id";
                ddldept.DataBind();

                
            }
        }



        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_batch where scheme_id='" + ddlscheme.SelectedItem.Value + "' and batch_name='" + txtbatchname.Text + "' ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Write("<script  >alert('Already Exist')</script>");

            }
            else
            {

                string sql = "insert into [tbl_batch] (batch_name,scheme_id) values('" + txtbatchname.Text + "','" + ddlscheme.SelectedItem.Value + "')";
                SqlCommand cmd2 = new SqlCommand(sql, con);
                cmd2.ExecuteNonQuery();
                //viewgrid();
                Response.Write("<script  >alert('Successfully Inserted')</script>");


            }
        }

        protected void ddldept_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");

            con.Open();
            string com = "Select Course_id,Course_name from Course";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddlcourse.DataSource = dt;
            ddlcourse.DataTextField = "Course_name";
            ddlcourse.DataValueField = "Course_id";
            ddlcourse.DataBind();
            con.Close();
        }

       

        protected void ddlcourse_SelectedIndexChanged1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");

            con.Open();
            string com = "Select scheme_id,scheme_name from tbl_scheme";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddlscheme.DataSource = dt;
            ddlscheme.DataTextField = "scheme_name";
            ddlscheme.DataValueField = "scheme_id";
            ddlscheme.DataBind();
            con.Close();
        }

        
    }
}
       