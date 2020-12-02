using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace API_Student.DAL
{
    public class DBHelper
    {
        static string sql = "Data Source=.;Initial Catalog=DB_Student_2;Integrated Security=True";

        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public static List<T> GetList<T>(string strsql)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                conn.Open();
                SqlDataAdapter Sda = new SqlDataAdapter(strsql, conn);
                var dt = new DataTable();
                Sda.Fill(dt);
                string str = JsonConvert.SerializeObject(dt);
                List<T> list = JsonConvert.DeserializeObject<List<T>>(str);
                return list;
            }
        }
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string strsql)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                conn.Open();
                SqlCommand scm = new SqlCommand(sql);
                return scm.ExecuteNonQuery();
            }
        }

        #region 存储过程
        public static List<T> Proc_GetList<T>(string strsql,SqlParameter[] paras = null)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                SqlCommand cmd = new SqlCommand();
                //给命令对象指定 要执行的存储的过程
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                if (paras!=null)
                cmd.Parameters.AddRange(paras);                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string str = JsonConvert.SerializeObject(dt);
                List<T> list = JsonConvert.DeserializeObject<List<T>>(str);
                return list;
            }
        }
        #endregion
    }
}