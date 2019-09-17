using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CRM_WQG_DAL;
using System.Data.OleDb;

namespace CRM_WQG_BLL
{
    public class BUserInfo
    {
        public DataTable UserInfo()
        {
            string sql = "select * from tb_user";
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(sql);
            return dt;
        }

        public DataTable SearchUserById(string id)
        {
            string sql = "select * from tb_user where loginId=@id";
            OleDbParameter sp = new OleDbParameter();
            sp.ParameterName = "@id";
            sp.Value = id;
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(sql, sp);
            return dt;
        }

        public DataTable SearchUser(string id)
        {
            string sql = "select * from tb_user where userId=@name";
            OleDbParameter sp = new OleDbParameter();
            sp.ParameterName = "@name";
            sp.Value = id;
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(sql, sp);
            return dt;
        }
        public void DeleteUser(string userId)
        {
            string strSql = "delete from tb_user where userId=@id";
            OleDbParameter sp = new OleDbParameter("@id", userId);
            SqlHelperWQG.ExecuteNonQuerySql(strSql, sp);
        }
        public DataTable AllQueryUser(string name)
        {
            string str = "select * from tb_user where name=@name";
            OleDbParameter sp = new OleDbParameter("@name", name);
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(str, sp);
            return dt;
        }
        public void initPassword()
        {
            string str = "update tb_user set loginPwd='888888'";
            SqlHelperWQG.ExecuteNonQuerySql(str);
        }
    }
}
