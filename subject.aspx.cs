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
    public partial class subject : System.Web.UI.Page
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

                con.Close();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con.Open();
            string sql = "insert into tbl_subject(subject_code,subject_name,dept_id ,Course_id,scheme_id,batch_id,semester_id)values('" + txtsubjectcode.Text + "','" + txtsubject.Text + "','" + ddldept.SelectedItem.Value + "','" + ddlcourse.SelectedItem.Value + "','" + ddlscheme.SelectedItem.Value + "','" + ddlbatch.SelectedItem.Value + "','" + ddlsemester.SelectedItem.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();
            txtsubject.Text = "";

            ddlcourse.ClearSelection();
            ddldept.ClearSelection();
            ddlscheme.ClearSelection();
            ddlsemester.ClearSelection();
            Response.Write("<script>alert('Successfully Inserted')</script>");


        }

        
       

       
        protected void ddldept_SelectedIndexChanged1(object sender, EventArgs e)
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

        protected void ddlscheme_SelectedIndexChanged1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");

            con.Open();
            string com = "Select batch_id,batch_name from tbl_batch";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddlbatch.DataSource = dt;
            ddlbatch.DataTextField = "batch_name";
            ddlbatch.DataValueField = "batch_id";
            ddlbatch.DataBind();
            con.Close();
        }

        protected void ddlbatch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

       

        
       
       
        
        
      


        

        

        