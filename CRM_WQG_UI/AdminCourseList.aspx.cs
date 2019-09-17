using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRM_WQG_BLL;

namespace CRM_WQG_UI
{
    public partial class AdminCourseList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvUser.DataSource = new BCourseInfo().CourseListAll();
            gvUser.DataBind();
        }

        protected void gvUser_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteCourse")
            {
                string[] estr = e.CommandArgument.ToString().Split(',');
                new BCourseInfo().DeleteCourse(estr[0], estr[1]);
                gvUser.DataSource = new BCourseInfo().CourseListAll();
                gvUser.DataBind();
            }
        }

        protected void gvUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUser.PageIndex = e.NewPageIndex;
            //重新绑定GridView数据的函数
            gvUser.DataSource = new BCourseInfo().CourseListAll();
            gvUser.DataBind();
            // 得到该控件
            GridView theGrid = sender as GridView;
            int newPageIndex = 0;
            if (e.NewPageIndex == -3)
            {
                //点击了Go按钮
                TextBox txtNewPageIndex = null;

                //GridView较DataGrid提供了更多的API，获取分页块可以使用BottomPagerRow 或者TopPagerRow，当然还增加了HeaderRow和FooterRow
                GridViewRow pagerRow = theGrid.BottomPagerRow;

                if (pagerRow != null)
                {
                    //得到text控件
                    txtNewPageIndex = pagerRow.FindControl("txtNewPageIndex") as TextBox;
                }
                if (txtNewPageIndex != null)
                {
                    //得到索引
                    newPageIndex = int.Parse(txtNewPageIndex.Text) - 1;
                }
            }
            else
            {
                //点击了其他的按钮
                newPageIndex = e.NewPageIndex;
            }
            //防止新索引溢出
            newPageIndex = newPageIndex < 0 ? 0 : newPageIndex;
            newPageIndex = newPageIndex >= theGrid.PageCount ? theGrid.PageCount - 1 : newPageIndex;

            //得到新的值
            theGrid.PageIndex = newPageIndex;

            //重新绑定
            gvUser.DataSource = new BCourseInfo().CourseListAll();
            gvUser.DataBind();
        }
    }
}