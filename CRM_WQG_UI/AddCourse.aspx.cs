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
    public partial class AddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                bool isExist = new BCourseInfo().CheckCourse(txtId.Text);
                if (isExist)
                    Response.Write("<script>alert('该课程已存在！')</script>");
                else
                {
                    string[] sp = { txtId.Text, txtName.Text, txtTime.Text, txtScore.Text, txtExam.Text };
                    new BCourseInfo().InsertCourse(sp);
                    Response.Redirect("AdminCourseInfo.aspx");
                }
            }
        }
    }
}