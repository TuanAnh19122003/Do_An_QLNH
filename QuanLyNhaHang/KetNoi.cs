using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    internal class KetNoi
    {
        string conStr = @"Data Source=DESKTOP-NGEA4UC\SQLEXPRESS;Initial Catalog=NhaHang;Integrated Security=True";
        SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }
        public DataSet laydulieu(string query)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(query, conn);
                dap.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public bool thucthi(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch
            {
                return true;
            }
        }
        public bool CapNhatMatKhau(string userName, string newPassword)
        {
            try
            {
                using (conn)
                {
                    conn.Open();

                    string query = "UPDATE Taikhoan SET Matkhau = @NewPassword WHERE Taikhoan = @UserName";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi khi cập nhật mật khẩu: " + ex.Message);
                return false;
            }
        }
        public DataSet LayDuLieuMonAn()
        {
            string query = "SELECT * FROM Monan";
            return laydulieu(query);
        }
    }
}
