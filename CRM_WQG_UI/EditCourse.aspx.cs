using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CRM_WQG_BLL;

namespace CRM_WQG_UI
{
    public partial class EditCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"].ToString();
                DataTable dt = new BCourseInfo().CourseInfoById(id);
                txtId.Text = dt.Rows[0]["courseNum"].ToString();
                txtName.Text = dt.Rows[0]["courseName"].ToString();
                txtTime.Text = dt.Rows[0]["courseTime"].ToString();
                txtScore.Text = dt.Rows[0]["courseScore"].ToString();
                txtExam.Text = dt.Rows[0]["courseExam"].ToString();
            }
            else
            {
                string[] sp = { txtName.Text, txtTime.Text, txtScore.Text, txtExam.Text, txtId.Text };
                new BCourseInfo().UpdateCourse(sp);
                Response.Redirect("AdminCourseInfo.aspx");
            }
        }
    }
}