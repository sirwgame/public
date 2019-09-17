using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CRM_WQG_DAL;
using System.Data.OleDb;

namespace CRM_WQG_BLL
{
    public class BCourseInfo
    {
        public DataTable AllCourseInfo()
        {
            string sql = "select * from tb_Course";
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(sql);
            return dt;
        }

        public DataTable CourseList()
        {
            string sql = "select * from courselist";
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(sql);
            return dt;
        }

        public DataTable CourseListAll()
        {
            string sql = "select studentName,courseNum,courseName,courseTime,courseScore,courseExam from courselist";
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(sql);
            return dt;
        }

        public DataTable CourseListByName(string name,string MyName)
        {
            string sql = "select * from courselist where courseName=@name and studentName=@myName";
            OleDbParameter[] sp = new OleDbParameter[2];
            sp[0]=new OleDbParameter("@name", name);
            sp[1]=new OleDbParameter("@myName",MyName);
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(sql, sp);
            return dt;
        }

        public DataTable CourseListById(string id)
        {
            DataTable dt = new BLogin().CheckUser(id);
            string MyName = "";
            if (dt.Rows.Count > 0)
                MyName = dt.Rows[0]["name"].ToString();
            string sql = "select * from courselist where studentName=@myName";
            OleDbParameter sp = new OleDbParameter("@myName", MyName);
            DataTable dtb = SqlHelperWQG.ExecuteDataTableSql(sql, sp);
            return dtb;
        }

        private DataTable CourseInfo(string name)
        {
            string sql = "select * from tb_Course where courseName=@name";
            OleDbParameter sp = new OleDbParameter("@name",name);
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(sql,sp);
            return dt;
        }

        public DataTable CourseInfoById(string id)
        {
            string sql = "select * from tb_Course where courseNum=@id";
            OleDbParameter sp = new OleDbParameter("@id", id);
            DataTable dt = SqlHelperWQG.ExecuteDataTableSql(sql, sp);
            return dt;
        }

        public void DeleteCourse(string name,string id)
        {
            string strSql = "delete from courselist where studentName=@name and courseNum=@id";
            OleDbParameter[] sp = new OleDbParameter[2];
            sp[0] = new OleDbParameter("@name",name);
            sp[1] = new OleDbParameter("@id",id);
            SqlHelperWQG.ExecuteNonQuerySql(strSql, sp);
        }

        public void DeleteCourseById(string id)
        {
            string strSql = "delete from tb_Course where courseNum=@id";
            OleDbParameter sp = new OleDbParameter("@id", id);
            SqlHelperWQG.ExecuteNonQuerySql(strSql, sp);
        }

        public void InsertCourse(string name,string MyName)
        {
            string str = "INSERT INTO courselist VALUES(@courseNum,@courseName,@courseTime,@courseScore,@courseExam,@myName)";
            DataTable dt0 = this.CourseInfo(name);
            OleDbParameter[] sp = new OleDbParameter[6];
            sp[0] = new OleDbParameter("@courseNum", dt0.Rows[0]["courseNum"]);
            sp[1] = new OleDbParameter("@courseName", dt0.Rows[0]["courseName"]);
            sp[2] = new OleDbParameter("@courseTime", dt0.Rows[0]["courseTime"]);
            sp[3] = new OleDbParameter("@courseScore", dt0.Rows[0]["courseScore"]);
            sp[4] = new OleDbParameter("@courseExam", dt0.Rows[0]["courseExam"]);
            sp[5] = new OleDbParameter("@myName", MyName);
            SqlHelperWQG.ExecuteNonQuerySql(str, sp);
        }

        public void InsertCourse(string[] s)
        {
            string str = "INSERT INTO tb_Course VALUES(@courseNum,@courseName,@courseTime,@courseScore,@courseExam)";
            OleDbParameter[] sp = new OleDbParameter[5];
            sp[0] = new OleDbParameter("@courseNum", s[0]);
            sp[1] = new OleDbParameter("@courseName", s[1]);
            sp[2] = new OleDbParameter("@courseTime", s[2]);
            sp[3] = new OleDbParameter("@courseScore", s[3]);
            sp[4] = new OleDbParameter("@courseExam", s[4]);
            SqlHelperWQG.ExecuteNonQuerySql(str, sp);
        }

        public bool CheckCourse(string id)
        {
            DataTable dt = this.CourseInfoById(id);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void UpdateCourse(string[] s)
        {
            string str = "update courselist set courseName=@courseName,courseTime=@courseTime,courseScore=@courseScore,courseExam=@courseExam where courseNum=@courseNum";
            OleDbParameter[] sp = new OleDbParameter[5];
            sp[0] = new OleDbParameter("@courseName", s[0]);
            sp[1] = new OleDbParameter("@courseTime", s[1]);
            sp[2] = new OleDbParameter("@courseScore", s[2]);
            sp[3] = new OleDbParameter("@courseExam", s[3]);
            sp[4] = new OleDbParameter("@courseNum", s[4]);
            SqlHelperWQG.ExecuteNonQuerySql(str, sp);
        }
    }
}
