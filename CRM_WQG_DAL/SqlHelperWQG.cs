using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace CRM_WQG_DAL
{
    /// <summary>
    /// SqlHelper 仅供参考
    /// </summary>
    public static class SqlHelperWQG
    {
        #region 字段
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataAdapter sda;
        static DataSet ds;
        static DataTable dt;
        #endregion

        #region 打开数据库连接
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        private static void OpenConn()
        {
            if (con == null)
            {
                // 1:如果ConfigurationManager这个类调用不出来，请先在项目中添加引用：框架->System.Configuration;
                // Winform项目，需要在AppConfig配置中增加连接字符串配置(ConfigurationManager这个类需要在添加System.Configuration引用)
                /* 在App.Config配置文件的configuration节点下增加如下节点配置
                 <connectionStrings>
                     <add name="sqlCon" connectionString="data source =.; initial catalog=StudentInfo; uid = sa; pwd=888888"/>
                 </connectionStrings>
                */
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|//web.mdb;Jet OLEDB:Database Password=123456;Persist Security Info=True");
            }
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }
        #endregion

        #region 关闭数据库连接
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        private static void CloseCon()
        {
            //判断数据库能否打开
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        #endregion

        #region ExecuteNonQuerySql 执行添加，删除，修改操作
        /// <summary>
        /// 执行添加，删除，修改操作
        /// </summary>
        /// <param name="sql">需要执行的添删改SQL语句</param>
        public static void ExecuteNonQuerySql(string sql)
        {
            try
            {
                OpenConn();
                cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }
        }

        /// <summary>
        /// 执行添加，删除，修改 带单个参数
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">参数数组</param>
        public static void ExecuteNonQuerySql(string sql, OleDbParameter sp)
        {
            try
            {
                OpenConn();
                cmd = new OleDbCommand(sql, con);

                if (sp != null)
                {
                    cmd.Parameters.Add(sp);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }
        }

        /// <summary>
        /// 执行添加，删除，修改，带多个参数，以数组方式传递
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">参数数组</param>
        public static void ExecuteNonQuerySql(string sql, OleDbParameter[] sps)
        {
            try
            {
                OpenConn();
                cmd = new OleDbCommand(sql, con);

                if (sps != null)
                {
                    cmd.Parameters.AddRange(sps);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }
        }

        #endregion

        #region ExecuteDataTableSql 返回DataTable对象
        /// <summary>
        /// 执行不带参数的查询，返回DataTable对象
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <returns>返回DataTable</returns>
        public static DataTable ExecuteDataTableSql(string sql)
        {
            dt = new DataTable();

            try
            {
                OpenConn();

                sda = new OleDbDataAdapter(sql, con);

                sda.Fill(dt);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }

            return dt;
        }

        /// <summary>
        /// 执行带单个参数的查询 返回DataTable对象
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="sp">SqlParamter参数</param>
        /// <returns>返回DataTable</returns>
        public static DataTable ExecuteDataTableSql(string sql, OleDbParameter sp)
        {
            dt = new DataTable();

            try
            {
                OpenConn();

                sda = new OleDbDataAdapter(sql, con);

                if (sp != null)
                {
                    sda.SelectCommand.Parameters.Add(sp);
                }
                sda.Fill(dt);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }

            return dt;
        }

        /// <summary>
        /// 执行带多个参数的查询 返回DataTable对象
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="sp">SqlParamter参数数组</param>
        /// <returns>返回DataTable</returns>
        public static DataTable ExecuteDataTableSql(string sql, OleDbParameter[] sps)
        {
            dt = new DataTable();

            try
            {
                OpenConn();

                sda = new OleDbDataAdapter(sql, con);


                if (sps != null)
                {
                    // 给查询命令赋参数
                    sda.SelectCommand.Parameters.AddRange(sps);
                }

                sda.Fill(dt);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }

            return dt;
        }

        #endregion

        #region ExecuteDataSetSql 返回DataSet对象
        /// <summary>
        /// 执行不带参数的查询，返回DataSet对象
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteDataSetSql(string sql)
        {
            ds = new DataSet();

            try
            {
                OpenConn();

                sda = new OleDbDataAdapter(sql, con);

                sda.Fill(ds);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }

            return ds;
        }


        /// <summary>
        /// 执行带单个参数的查询，返回DataSet对象
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="sp">SqlParamter参数</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteDataSetSql(string sql, SqlParameter sp)
        {
            ds = new DataSet();

            try
            {
                OpenConn();

                sda = new OleDbDataAdapter(sql, con);

                if (sp != null)
                {
                    sda.SelectCommand.Parameters.Add(sp);
                }
                sda.Fill(ds);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }

            return ds;
        }


        /// <summary>
        /// 执行带多个参数的查询 返回DataSet对象
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="sp">SqlParamter参数数组</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteDataSetSql(string sql, SqlParameter[] sps)
        {
            ds = new DataSet();

            try
            {
                OpenConn();

                sda = new OleDbDataAdapter(sql, con);

                if (sps != null)
                {
                    sda.SelectCommand.Parameters.AddRange(sps);
                }
                sda.Fill(ds);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }

            return ds;
        }

        #endregion

        #region ExecuteScalarSql 返回查询结果的第一行，第一列的值
        /// <summary>
        /// 执行不带参数的查询，返回查询结果的第一行，第一列的值 
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="sp">查询语句</param>
        /// <returns>返回值为object类型</returns>
        public static object ExecuteScalarSql(string sql)
        {
            object obj = null;

            try
            {
                OpenConn();
                cmd = new OleDbCommand(sql, con);
                obj = cmd.ExecuteScalar();
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }

            return obj;
        }

        /// <summary>
        /// 执行单个参数的查询，返回查询结果的第一行，第一列的值 
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="sp">查询语句</param>
        /// <returns>返回值为object类型</returns>
        public static object ExecuteScalarSql(string sql, OleDbParameter sp)
        {
            object obj = null;

            try
            {
                OpenConn();
                cmd = new OleDbCommand(sql, con);

                if (sp != null)
                {
                    cmd.Parameters.Add(sp);
                }

                obj = cmd.ExecuteScalar();
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }

            return obj;
        }

        /// <summary>
        /// 执行带多个参数的查询，返回查询结果的第一行，第一列的值 
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="sp">查询语句</param>
        /// <returns>返回值为object类型</returns>
        public static object ExecuteScalarSql(string sql, OleDbParameter[] sps)
        {
            object obj = null;

            try
            {
                OpenConn();
                cmd = new OleDbCommand(sql, con);

                if (sps != null)
                {
                    cmd.Parameters.AddRange(sps);
                }
                obj = cmd.ExecuteScalar();
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                CloseCon();
            }

            return obj;
        }

        #endregion

        #region ExecuteDataReaderSql 返回OleDbDataReader

        /// <summary>
        /// 执行不带参数的查询，返回OleDbDataReader 
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="sp">查询语句</param>
        /// <returns>返回值为OleDbDataReader类型</returns>
        public static OleDbDataReader ExecuteDataReaderSql(string sql)
        {
            OleDbDataReader sdr = null;

            try
            {
                OpenConn();
                cmd = new OleDbCommand(sql, con);
                sdr = cmd.ExecuteReader();
            }
            catch (Exception exp)
            {
                throw exp;
            }

            return sdr;
        }

        /// <summary>
        /// 执行单个参数的查询，返回OleDbDataReader 
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="sp">查询语句</param>
        /// <returns>返回值为object类型</returns>
        public static OleDbDataReader ExecuteDataReaderSql(string sql, OleDbParameter sp)
        {
            OleDbDataReader sdr = null;

            try
            {
                OpenConn();
                cmd = new OleDbCommand(sql, con);
                cmd.Parameters.Add(sp);
                sdr = cmd.ExecuteReader();
            }
            catch (Exception exp)
            {
                throw exp;
            }

            return sdr;
        }

        /// <summary>
        /// 执行带多个参数的查询，返回OleDbDataReader 
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="sp">查询语句</param>
        /// <returns>返回值为object类型</returns>
        public static OleDbDataReader ExecuteDataReaderSql(string sql, OleDbParameter[] sps)
        {
            OleDbDataReader sdr = null;

            try
            {
                OpenConn();
                cmd = new OleDbCommand(sql, con);
                if (sps != null)
                {
                    cmd.Parameters.AddRange(sps);
                }
                sdr = cmd.ExecuteReader();
            }
            catch (Exception exp)
            {
                throw exp;
            }

            return sdr;
        }

        #endregion

 
    }

}