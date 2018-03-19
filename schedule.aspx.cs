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
    public partial class schedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                view_batch_dropdown();


            }
        }

        public void view_semester_dropdown()
        {


            ddlsemester.Items.Insert(0, new ListItem("--Select Sem--", "0"));
        }
        

        public void view_batch_dropdown()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_batch", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ddlbatch.DataSource = dt;
            ddlbatch.DataTextField = "batch_name";
            ddlbatch.DataValueField = "batch_id";
            ddlbatch.DataBind();
            ddlbatch.Items.Insert(0, new ListItem("--Select batch-", "0"));


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");
            con1.Open();
            string sql = "insert into [tbl_schedule](batch_id,semester_id,login_date)values('" + ddlbatch.SelectedItem.Value + "','" + ddlsemester.SelectedItem.Text + "','" + txtdate.Text + "')";
            SqlCommand cmd2 = new SqlCommand(sql, con1);
            cmd2.ExecuteNonQuery();
        }
    }
}