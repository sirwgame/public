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
    public partial class EditStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"].ToString();
                DataTable dt = new BUserInfo().SearchUser(id);
                txtId.Text = dt.Rows[0]["userId"].ToString();
                txtStuId.Text = dt.Rows[0]["loginId"].ToString();
                txtPwd.Text = dt.Rows[0]["loginPwd"].ToString();
                txtName.Text = dt.Rows[0]["name"].ToString();
                txtAge.Text = dt.Rows[0]["age"].ToString();
                txtSex.Text = dt.Rows[0]["sex"].ToString();
                txtPhone.Text = dt.Rows[0]["phone"].ToString();
                txtAddress.Text = dt.Rows[0]["address"].ToString();
            }
            else {
                string[] sp = { txtStuId.Text, txtPwd.Text, txtName.Text, txtAge.Text, txtSex.Text, txtPhone.Text, txtAddress.Text, txtId.Text};
                new BUserEdit().EditUser(sp);
                Response.Redirect("StudentInfo.aspx");
            }
        }
    }
}