using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Collections;

namespace XMLUnitTest
{
    public static class SqlHelper
    {
        private static readonly string sqlConnFRS = "Server=127.0.0.1;Database=HRInsurance;User Id=sa;Password=rich123456;";
        //public static string SqlConnCIS
        //{
        //    get { return SqlHelper.sqlConnCIS; }
        //}   

        //public static string SqlConnOA
        //{
        //    get { return SqlHelper.sqlConnOA; }
        //} 


        public static string SqlConnFRS
        {
            get { return sqlConnFRS; }
        }


        public static DataRow ExecuteDataRow(string connectionString, CommandType commandType, string commandText, params SqlParameter[] parms)
        {
            DataSet ds = ExecuteDataset(connectionString, commandType, commandText, parms);
            if (ds == null) return null;
            if (ds.Tables.Count == 0) return null;
            if (ds.Tables[0].Rows.Count == 0) return null;
            return ds.Tables[0].Rows[0];
        }

        public static DataTable ExecuteDataTableByPage(string connectionString, CommandType commandType, string tableName, string fields, string orderby, string order, int startIndex, int endIndex, string where)
        {
            DataSet ds = null;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    StringBuilder commandText = new StringBuilder();
                    commandText.Append("WITH RES_Data AS (SELECT ");
                    if (!string.IsNullOrEmpty(fields))
                        commandText.Append(fields);
                    else
                        commandText.Append("*");
                    commandText.Append(",ROW_NUMBER() OVER (ORDER BY " + orderby);
                    if (!string.IsNullOrEmpty(order))
                        commandText.Append(" " + order);
                    commandText.Append(") AS 'RowNumber' FROM " + tableName);
                    if (!string.IsNullOrEmpty(where))
                        commandText.Append(where);
                    commandText.Append(")SELECT * FROM RES_Data WHERE RowNumber BETWEEN " + startIndex + " AND " + endIndex);
                    ds = ExecuteDataset(cn, commandType, commandText.ToString(), null);
                }
                catch
                {
                    return null;
                }
            }
            if (ds == null) return null;
            if (ds.Tables.Count == 0) return null;
            return ds.Tables[0];
        }

        public static DataTable ExecuteDataTable(string connectionString, CommandType commandType, string commandText, params SqlParameter[] parms)
        {
            DataSet ds = ExecuteDataset(connectionString, commandType, commandText, parms);
            if (ds == null) return null;
            if (ds.Tables.Count == 0) return null;
            return ds.Tables[0];
        }

        public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            DataSet ds = null;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    ds = ExecuteDataset(cn, commandType, commandText, commandParameters);
                }
                catch
                {
                    return null;
                }
            }
            return ds;
        }

        private static DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            //create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandTimeout = 300 * 6;
            PrepareCommand(cmd, connection, null, commandText, commandParameters);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.Parameters.Clear();
            return ds;
        }

        private static string[] ExecuteDataTablePrimarykey(SqlConnection connection, CommandType commandType, string tableName)
        {
            string[] pKeys = null;
            string commandText = "select top 1 * from " + tableName;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandTimeout = 300;
            PrepareCommand(cmd, connection, null, commandText, null);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.Parameters.Clear();
            if (ds.Tables[0].PrimaryKey.Length > 0)
            {
                pKeys = new string[ds.Tables[0].PrimaryKey.Length];
                for (int i = 0; i < pKeys.Length; i++)
                {
                    pKeys[i] = ds.Tables[0].PrimaryKey[i].ToString();
                }
            }
            return pKeys;
        }

        public static string[] ExecuteDataTablePrimarykey(string connectionString, CommandType commandType, string tableName)
        {
            string[] pKeys = null;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    pKeys = ExecuteDataTablePrimarykey(cn, commandType, tableName);
                }
                catch
                {
                    return null;
                }
            }
            return pKeys;
        }

        private static int ExecuteNonQuery(SqlTransaction trans, string cmdText, params SqlParameter[] paras)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 600;
            PrepareCommand(cmd, trans.Connection, trans, cmdText, paras);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText, params SqlParameter[] parms)
        {
            int result = 0;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    //call the overload that takes a connection in place of the connection string
                    result = ExecuteNonQuery(cn, commandType, commandText, parms);
                }
                catch
                {
                    return 0;
                }
            }
            return result;
        }

        public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            //create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandTimeout = 60 * 30;
            PrepareCommand(cmd, connection, null, commandText, commandParameters);
            int result = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return result;
        }

        public static void ExecuteNonQuery(string connectionString, List<string> lstCommandText)
        {
            if (lstCommandText.Count < 1)
                return;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        foreach (string commandText in lstCommandText)
                        {
                            if (string.IsNullOrWhiteSpace(commandText))
                                continue;
                            SqlCommand cmd = new SqlCommand(commandText, con, trans);
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                    }
                }
            }
        }

        public static void ExecuteNonQuery(string connectionString, string[] lstCommandText)
        {
            if (lstCommandText.Length < 1)
                return;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        foreach (string commandText in lstCommandText)
                        {
                            if (string.IsNullOrWhiteSpace(commandText))
                                continue;
                            SqlCommand cmd = new SqlCommand(commandText, con, trans);
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                    }
                }
            }
        }

        public static int ExecuteNonQueryInTransaction(string connectionString, string commandText)
        {
            int i = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(commandText))
                        {
                            SqlCommand cmd = new SqlCommand(commandText, con, trans);
                            cmd.CommandTimeout = 1800;
                            i = cmd.ExecuteNonQuery();
                            trans.Commit();
                        }
                    }
                    catch
                    {
                        trans.Rollback();
                    }
                }
            }
            return i;
        }

        public static SqlDataReader ExecuteReader(string connectionString, string commandText, params SqlParameter[] commandParameters)
        {
            //return Sql.Data.SqlClient.SqlHelper.ExecuteReader(connectionString, commandText, commandParameters);
            return ExecuteReader(connectionString, CommandType.Text, commandText, commandParameters);
        }

        public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlDataReader reader = null;
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                cn.Open();
                reader = ExecuteReader(cn, commandType, commandText, commandParameters);
            }
            catch
            {
                cn.Close();
                cn.Dispose();
                return null;
            }
            return reader;
        }

        public static SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandTimeout = 60;
            PrepareCommand(cmd, connection, null, commandText, commandParameters);
            SqlDataReader dr;
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            cmd.Parameters.Clear();
            return dr;
        }

        public static object ExecuteScalar(SqlConnection connection, string commandText)
        {
            return ExecuteScalar(connection, commandText, null);
        }
        public static object ExecuteScalar(string connectionString, string commandText)
        {
            return ExecuteScalar(connectionString, commandText, null);
        }
        public static object ExecuteScalar(SqlConnection connection, string commandText, params SqlParameter[] commandParameters)
        {
            return ExecuteScalar(connection, CommandType.Text, commandText, commandParameters);
        }
        public static object ExecuteScalar(string connectionString, string commandText, params SqlParameter[] commandParameters)
        {
            return ExecuteScalar(connectionString, CommandType.Text, commandText, commandParameters);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="commandType"></param>
        /// <param name="commandText"></param>
        /// <param name="commandParameters"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            object result = null;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    //call the overload that takes a connection in place of the connection string
                    result = ExecuteScalar(cn, commandType, commandText, commandParameters);
                }
                catch
                {
                    return null;
                }
            }
            return result;
        }

        public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandTimeout = 60;
            PrepareCommand(cmd, connection, null, commandText, commandParameters);
            object result = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return result;
        }

        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            //判断数据库连接状态
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            //判断是否需要事物处理
            if (trans != null)
                cmd.Transaction = trans;
            //      cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int ExecuteProcedure(string name)
        {
            SqlConnection cn = new SqlConnection();
            int result = 0;
            try
            {
                cn.Open();
                //call the overload that takes a connection in place of the connection string
                result = ExecuteNonQuery(cn, CommandType.StoredProcedure, name, null);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
            return result;
        }
    }
}
