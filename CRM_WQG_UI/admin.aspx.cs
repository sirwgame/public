using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRM_WQG_UI
{
    public partial class admin1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string id = txtId.Text;
                string pwd = txtPwd.Text;
                if (id == "admin" && pwd == "admin")
                {
                    Response.Redirect("StudentInfo.aspx");
                }
            }
        }
    }
}