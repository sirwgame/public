using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using CRM_WQG_DAL;

namespace CRM_WQG_UI
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from tb_user where loginId=20152401";
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(sql);
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["name"].ToString();
            }
        }
    }
}