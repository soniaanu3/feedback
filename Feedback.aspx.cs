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
    public partial class Feedback : System.Web.UI.Page
    {
        public int rowIndex;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                viewsubjectdropdown(); 
            }
        }
        public void viewsubjectdropdown()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");

            con.Open();
            string com = "Select subject_code,subjectid  from tbl_subject";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddlsubject1.DataSource = dt;
            ddlsubject1.DataTextField = "subject_code";
            ddlsubject1.DataValueField = "subjectid";
            ddlsubject1.DataBind();

            con.Close();
        }
        protected void ddlsubject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");

            con.Open();
            string com = "select tbl_staff.staff_name from tbl_staff join tbl_subject_staff_mapping on tbl_staff.staff_id=tbl_subject_staff_mapping.staff_id where tbl_subject_staff_mapping.subjectid='"+ddlsubject1.SelectedValue+"'";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);

            DataTable dt = new DataTable();

            adpt.Fill(dt);
            if(dt.Rows.Count>0)
            {
                Label2.Text = dt.Rows[0]["staff_name"].ToString();
            }
           // DropDownList1.DataSource = dt;
           // DropDownList1.DataTextField = "staff_name";
           // //DropDownList1.DataValueField = "substaffmap_id";
           // DropDownList1.DataBind();
           //// Label2.Text = Convert.ToString(dt.Rows[0][0]);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Feedback;User ID=sa;Password=admin28");

            con.Open();

         
            
            string selectedItem = ddlsubject1.SelectedItem.Text;

            for (int i = ddlsubject1.Items.Count - 1; i >= 0; i--)
            {
                if (ddlsubject1.Items[i].Text == selectedItem) ddlsubject1.Items.RemoveAt(i);
            }

            if(ddlsubject1.Items.Count==1)
            {
                Response.Redirect("Webform3.aspx");
            }

            //viewsubjectdropdown();
            Label2.Text = "";
            
           
           
        }

        

       

      


  



        }
    }



        

        
