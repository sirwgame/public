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
    public partial class UpdateInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Session["id"].ToString();
                DataTable dt = new BUserInfo().SearchUserById(id);
                txtStuId.Text = dt.Rows[0]["loginId"].ToString();
                txtName.Text = dt.Rows[0]["name"].ToString();
                txtAge.Text = dt.Rows[0]["age"].ToString();
                txtSex.Text = dt.Rows[0]["sex"].ToString();
                txtPhone.Text = dt.Rows[0]["phone"].ToString();
                txtAddress.Text = dt.Rows[0]["address"].ToString();
            }
            else
            {
                string[] sp = { txtStuId.Text, txtPwd.Text, txtName.Text, txtAge.Text, txtSex.Text, txtPhone.Text, txtAddress.Text, Session["id"].ToString() };
                new BUserEdit().EditUser(sp);
                Response.Redirect("MyInfo.aspx");
            }
        }
    }
}