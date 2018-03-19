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
    public partial class batch_semester_mapping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");

            con.Open();
            string com = "Select semester_id,semester_name from tbl_semester";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddlsemester.DataSource = dt;
            ddlsemester.DataTextField = "semester_name";
            ddlsemester.DataValueField = "semester_id";
            ddlsemester.DataBind();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con.Open();
            string sql = "insert into tbl_batch_semester_mapping(batch_id,semester_id)values('" + ddlbatch.SelectedItem.Value + "','" + ddlsemester.SelectedItem.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();
            

            ddlbatch.ClearSelection();
            ddlsemester.ClearSelection();
            
            Response.Write("<script>alert('Successfully Inserted')</script>");
        }
    }
}