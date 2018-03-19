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
    public partial class Feedback1 : System.Web.UI.Page
    {
        public int rowIndex;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");

                con.Open();
                string com = "Select *  from tbl_subject";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                ddlsubject1.DataSource = dt;
                ddlsubject1.DataTextField = "subject_code";
                ddlsubject1.DataValueField = "subjectid";
                ddlsubject1.DataBind();

                con.Close();
            }
        }

        protected void ddlsubject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");

            con.Open();
            SqlCommand cmd =new SqlCommand( "Select staff_id from tbl_subject_staff_mapping where subjectid='"+ddlsubject1.SelectedItem.Value+"'",con);
         
                
            

























































































































































































































































            
               
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

       