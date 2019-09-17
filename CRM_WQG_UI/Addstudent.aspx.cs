using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRM_WQG_BLL;

namespace CRM_WQG_UI
{
    public partial class Addstudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string id = txtStuId.Text;
                string pwd = txtPwd.Text;
                string name = txtName.Text;
                string age = txtAge.Text;
                string sex = txtSex.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                if (id == "" || pwd == "" || name == "" || age == "" || sex == "" | phone == "" || address == "")
                    Response.Write("<script>alert('信息输入不完整，请检查所有信息！')</script>");
                else
                {
                    bool isExist = new BLogin().CheckReg(id);
                    if (isExist)
                        Response.Write("<script>alert('该学号已存在！')</script>");
                    else
                    {
                        string[] str = { id, pwd, name, age, sex, phone, address };
                        bool foo = new BUserAdd().UserAdd(str);
                        if (foo)
                        {
                            Response.Redirect("StudenInfo.aspx");
                        }
                        else
                            Response.Write("<script>alert('添加失败，请检查原因！')</script>");
                    }
                }
            }
        }
    }
}