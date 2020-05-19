using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows;
using System.Windows.Forms;
namespace QuanLyBanHang
{
    class DAO
    {
        public static SqlConnection conn;
        public static string connectionString = "Data Source=huuphuoccao\\sqlexpress;Initial Catalog=CSLT2;Integrated Security=True";
        public static void OpenConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            if(conn.State == System.Data.ConnectionState.Closed)
                try
                {
                    conn.Open();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
        public static void CloseConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            if (conn.State == System.Data.ConnectionState.Open)
                try
                {
                    conn.Close();
                    MessageBox.Show("Đóng kết nối thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
    }
}
