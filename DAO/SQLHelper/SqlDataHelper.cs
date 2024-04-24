using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.SQLHelper
{
    public class SqlDataHelper
    {

        public static string strConnectionString = Properties.Settings.Default.QuanLyKhoHangConnectionString.ToString();


        public static SqlConnection Connect(string _strConnectionString)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(_strConnectionString);
                cn.Open();
            }
            catch { }

            return cn;
        }

        public static SqlConnection OpenConnection(SqlConnection _cn)
        {
            SqlConnection cn = null;
            try
            {
                if (_cn.State == System.Data.ConnectionState.Open)
                    _cn.Close();
                _cn.Open();
                cn = _cn;
            }
            catch { }
            return cn;
        }

        public static SqlConnection CloseConnection(SqlConnection _cn)
        {
            SqlConnection cn = null;
            try
            {
                if (_cn.State == System.Data.ConnectionState.Open)
                    cn = _cn;
                cn.Close();
            }
            catch { }
            return cn;
        }

        /// <summary>
        /// Lấy danh sách các dòng trong 1 bảng từ câu truy vấn
        /// </summary>
        /// <param name="_strSql">câu truy vấn sql</param>
        /// <param name="_cn">đối tượng SQLConnection</param>
        /// <returns></returns>
        public static DataTable GetDataToStringSQL(string _strSql, SqlConnection _cn)
        {
            DataTable dtResult = null;
            try
            {
                dtResult = new DataTable();
                _cn = OpenConnection(_cn);
                if (_cn.State == ConnectionState.Open)
                {
                    SqlDataAdapter da = new SqlDataAdapter(_strSql, _cn);
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dtResult);
                }
            }
            catch { }
            return dtResult;
        }

        /// <summary>
        /// Thực hiện câu truy vấn insert
        /// </summary>
        /// <param name="_strSql">câu truy vấn sql</param>
        /// <param name="_cn">đối tượng SQLConnection</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string _strSql, SqlConnection _cn)
        {
            int IDResult = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(_strSql, _cn);
                cmd.CommandType = CommandType.Text;
                OpenConnection(_cn);
                IDResult = cmd.ExecuteNonQuery();
                CloseConnection(_cn);
            }
            catch { }
            return IDResult;
        }

        /// <summary>
        /// Trả về giá trị của hàng đầu tiên
        /// </summary>
        /// <param name="_strSql">câu truy vấn sql</param>
        /// <param name="_cn">đối tượng SQLConnection</param>
        /// <returns></returns>
        public static int GetMaxID(string _strSql, SqlConnection _cn)
        {
            int IDResult = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(_strSql, _cn);
                cmd.CommandType = CommandType.Text;
                OpenConnection(_cn);
                IDResult = int.Parse(cmd.ExecuteScalar().ToString());
                CloseConnection(_cn);
            }
            catch { }
            return IDResult;
        }
    }
}
