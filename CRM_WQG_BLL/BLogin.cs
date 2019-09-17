using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using CRM_WQG_DAL;
using System.Data;

namespace CRM_WQG_BLL
{
    public class BLogin
    {
        public bool CheckUser(string userId,string userPwd)
        {
            string strSql = "select * from tb_user where loginId=@userId and loginPwd=@userPwd";

            OleDbParameter[] sp = new OleDbParameter[2];
            sp[0] = new OleDbParameter("@userId", userId);
            sp[1] = new OleDbParameter("@userPwd", userPwd);

            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(strSql, sp);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckReg(string id)
        {
            string strSql = "select * from tb_user where loginId=@id";

            OleDbParameter sp = new OleDbParameter("@id", id);

            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(strSql, sp);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable CheckUser(string userId)
        {
            string strSql = "select * from tb_User where loginId=@userId";
            OleDbParameter sp = new OleDbParameter("@userId", userId);
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(strSql, sp);
            return dt;
        }
    }
}
