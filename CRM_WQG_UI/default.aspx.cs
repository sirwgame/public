using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRM_WQG_BLL;
using System.Text.RegularExpressions;

namespace CRM_WQG_UI
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ibtn_yzm.ImageUrl = "IdentifyingCode.aspx";
            if (IsPostBack)
            {
                string id = txtId.Text;
                string pwd = txtPwd.Text;
                if (id != "" && pwd != "")
                {
                    string code = txtIdentify.Text;
                    HttpCookie htco = Request.Cookies["ImageV"];
                    string scode = htco.Value.ToString();
                    if (code != scode)
                    {
                        Response.Write("<script>alert('验证码输入不正确！')</script>");
                    }
                    bool isExist = new BLogin().CheckUser(id, pwd);
                    if (isExist)
                    {
                        Session["id"] = id;
                        Response.Redirect("MyInfo.aspx");
                    }
                }
                else
                    Response.Write("<script>alert('学号或密码不能为空！')</script>");
            }
        }

        protected void txtPwd_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("^.{6,10}$");     
            if (!r.IsMatch(txtPwd.Text))
                Response.Write("<script>alert('学号输入不正确！')</script>");
        }

        protected void txtId_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]{8}$");     
            if (r.IsMatch(txtId.Text))
                Response.Write("<script>alert('密码输入不正确！')</script>");
        }
    }
}