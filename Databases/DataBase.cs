using System.Data;
using System.Data.SqlClient;

namespace StuGradeManSys.Databases
{
    internal static class DataBase
    {
        static string? ConnString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        static SqlConnection? conn = null;
        // 连接数据库
        public static bool Connect()
        {
            conn = new SqlConnection(ConnString);
            try
            {
                conn.Open();
                return true;
            } 
            catch (Exception)
            {
                return false;
            }
        }
        public static int ExecuteSql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                var rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static DataSet? Query(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // 与数据库断开连接
        public static void Disconnect()
        {
            if (conn != null && conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
}
