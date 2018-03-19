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
    public partial class question_option_mapping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                view_question_dropdown();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con.Open();
            string sql = "insert into [tbl_question_option_mapping](question_id,option_name,weightage)values('" + ddlquestion.SelectedItem.Value+ "','" + ddlopt.SelectedItem.Text + "','" + txtopt.Text + "')";
            SqlCommand cmd2 = new SqlCommand(sql, con);
            cmd2.ExecuteNonQuery();
        }


        public void view_question_dropdown()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_question", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ddlquestion.DataSource = dt;
            ddlquestion.DataTextField = "question_name";
            ddlquestion.DataValueField = "question_id";
            ddlquestion.DataBind();
            ddlquestion.Items.Insert(0, new ListItem("--Select question-", "0"));
        }

        protected void ddlquestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }

}