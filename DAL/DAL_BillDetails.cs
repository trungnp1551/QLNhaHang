using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_BillDetails : DBConnect
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dataChiTietHoaDon = new DataSet();

        public DataSet loadData(string mahd)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from ChiTietHoaDon where MaHoaDon = @mahoadon ";
            command.Parameters.AddWithValue("@mahoadon", mahd);
            adapter.SelectCommand = command;
            dataChiTietHoaDon.Clear();
            adapter.Fill(dataChiTietHoaDon);
            connection.Close();
            return dataChiTietHoaDon;
        }

        public bool addData(DTO_BillDetails billDetails)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "insert into ChiTietHoaDon values (@mahd, @tenmonan, @soluong, @giatien, @donvitinh )";
            command.Parameters.AddWithValue("@mahd", billDetails.MaHoaDon);
            command.Parameters.AddWithValue("@tenmonan", billDetails.TenMonAn);
            command.Parameters.AddWithValue("@soluong", billDetails.SoLuong);
            command.Parameters.AddWithValue("@giatien", billDetails.GiaTien);
            command.Parameters.AddWithValue("@donvitinh", billDetails.DonViTinh);

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }

    }
}
