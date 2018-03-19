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
    public partial class scheme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                view_dept_dropdown();
               
                
            }
            ddlcourse.Items.Insert(0, new ListItem("--select course--"));
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
            ddldept.DataSource=dt;
            ddldept.DataTextField = "dept_name";
            ddldept.DataValueField = "dept_id";
            ddldept.DataBind();
            ddldept.Items.Insert(0, new ListItem("--Select Department-", "0"));


        }

        public void view_course_dropdown()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Course where Dept_id=" + Convert.ToInt32(ddldept.SelectedItem.Value.ToString()), con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ddlcourse.DataSource = dt;
            
            ddlcourse.DataTextField = "Course_name";
            ddlcourse.DataValueField = "Course_id";
            ddlcourse.DataBind();
            ddlcourse.Items.Insert(0, new ListItem("--Select Course", "0"));
            
        }
       

        protected void SUBMIT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_scheme(scheme_name,Course_id, dept_id)values('" + txtscheme.Text + "','" + ddlcourse.SelectedItem.Value + "','" + ddldept.SelectedItem.Value + "')", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response.Write("<script >alert('Successfully inserted')</Script>");

        }
        protected void ddldept_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Course where Dept_id='"+ddldept.SelectedItem.Value+"'", con);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //ddldept.DataSource = dt;
            //ddldept.DataTextField =  "Course_name";
            //ddldept.DataValueField = "Dept_id";
            //ddldept.DataBind();
            view_course_dropdown();

        }

        protected void ddlcourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        
    }
}