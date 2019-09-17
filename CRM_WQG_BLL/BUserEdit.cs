using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using CRM_WQG_DAL;

namespace CRM_WQG_BLL
{
    public class BUserEdit
    {
        public DataTable SearchUser(string userId)
        {
            string str = "select * from tb_User where userId=@id";
            OleDbParameter sp = new OleDbParameter("@id", userId);
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(str, sp);
            return dt;
        }
        public void EditUser(string[] str)
        {
            string strSql = "update tb_user set loginId=@loginId,loginPwd=@loginPwd,name=@name,age=@age,sex=@sex,phone=@phone,address=@address,createDate=now() where userId=@id";
            OleDbParameter[] sp = new OleDbParameter[8];
            sp[0] = new OleDbParameter("@loginId", str[0]);
            sp[1] = new OleDbParameter("@loginPwd", str[1]);
            sp[2] = new OleDbParameter("@name", str[2]);
            sp[3] = new OleDbParameter("@age", str[3]);
            sp[4] = new OleDbParameter("@sex", str[4]);
            sp[5] = new OleDbParameter("@phone", str[5]);
            sp[6] = new OleDbParameter("@address", str[6]);
            sp[7] = new OleDbParameter("@id", str[7]);
            SqlHelperWQG.ExecuteNonQuerySql(strSql, sp);
        }
    }
}
