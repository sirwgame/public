using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using CRM_WQG_DAL;

namespace CRM_WQG_BLL
{
    public class BUserAdd
    {
        public bool UserAdd(string[] str)
        {
            string strSql = "insert into tb_user([loginId],[loginPwd],[name],[age],[sex],[phone],[address],[createDate]) values(@loginId,@loginPwd,@name,@age,@sex,@phone,@address,now())";
            OleDbParameter[] sp = new OleDbParameter[7];
            sp[0] = new OleDbParameter("@loginId", str[0]);
            sp[1] = new OleDbParameter("@loginPwd", str[1]);
            sp[2] = new OleDbParameter("@name", str[2]);
            sp[3] = new OleDbParameter("@age", str[3]);
            sp[4] = new OleDbParameter("@sex", str[4]);
            sp[5] = new OleDbParameter("@phone", str[5]);
            sp[6] = new OleDbParameter("@address", str[6]);
            SqlHelperWQG.ExecuteNonQuerySql(strSql, sp);
            return true;
        }
    }
}
