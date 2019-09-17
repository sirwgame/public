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
    public partial class MyInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string loginId = Session["id"].ToString();
                DataTable dt = new BLogin().CheckUser(loginId);

                if (dt.Rows.Count > 0)
                {
                    lblMyID.Text = dt.Rows[0]["loginId"].ToString();
                    lblMyAge.Text = dt.Rows[0]["age"].ToString();
                    lblMyName.Text = dt.Rows[0]["name"].ToString();
                    lblMySex.Text = dt.Rows[0]["sex"].ToString();
                    lblMyAddress.Text = dt.Rows[0]["address"].ToString();
                    lblMyPhone.Text = dt.Rows[0]["phone"].ToString();
                }
                Session["MyName"] = lblMyName.Text;
            }
        }
    }
}