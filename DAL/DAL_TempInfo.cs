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
    public class DAL_TempInfo : DBConnect
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dataInfo = new DataSet();

        public DataSet loadData(string maban)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select td.MaMonAn, tttt.TenMonAn, tttt.SoLuong, tttt.GiaTien, td.DonViTinh " +
                "from ThongTinTamThoi tttt, ThucDon td where td.TenMonAn = tttt.TenMonAn and tttt.MaBan = @maban";
            command.Parameters.AddWithValue("@maban", maban);
            adapter.SelectCommand = command;
            dataInfo.Clear();
            adapter.Fill(dataInfo);
            connection.Close();
            return dataInfo;
        }

        public bool addData(DTO_TempInfo tempInfo)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "DECLARE @soluong int set @soluong = (" +
                "select tttt.SoLuong from ThongTinTamThoi tttt where tttt.MaMonAn = @mamonan and tttt.MaBan = @maban ) " +
                "if @soluong > 0 update ThongTinTamThoi set SoLuong = @soluong + 1 where MaMonAn = @mamonan and MaBan = @maban " +
                "else insert into ThongTinTamThoi values(@maban, @mamonan, @tenmonan ,1, @giatien ,2)";
            command.Parameters.AddWithValue("@maban", tempInfo.MaBan);
            command.Parameters.AddWithValue("@mamonan", tempInfo.MaMonAn);
            command.Parameters.AddWithValue("@tenmonan", tempInfo.TenMonAn);
            command.Parameters.AddWithValue("@giatien", tempInfo.GiaTien);

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

        public bool deleteData(string maban)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "delete from ThongTinTamThoi where MaBan = @maban";
            command.Parameters.AddWithValue("@maban", maban);

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

        public bool deleteOne(string maban, string mamonan)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "DECLARE @soluong int set @soluong = (" +
                "select tttt.SoLuong from ThongTinTamThoi tttt where tttt.MaMonAn = @mamonan and tttt.MaBan = @maban) " +
                "if @soluong = 1 delete from ThongTinTamThoi where MaBan = @maban and MaMonAn = @mamonan " +
                "else update ThongTinTamThoi set SoLuong = @soluong - 1 where MaMonAn = @mamonan and MaBan = @maban ";
            command.Parameters.AddWithValue("@maban", maban);
            command.Parameters.AddWithValue("@mamonan", mamonan);

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

        public bool checkEmptyTable(string maban)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select count (distinct tttt.MaMonAn) from ThongTinTamThoi tttt where tttt.MaBan = @maban";
            command.Parameters.AddWithValue("@maban", maban);

            if((int)command.ExecuteScalar() == 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool checkExist(string maban)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select count(*) from ThongTinTamThoi where MaBan = @maban ";
            command.Parameters.AddWithValue("@maban", maban);
            if ((int)command.ExecuteScalar() != 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool checkPaymentStatus(string maban)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select TrangThaiThanhToan from ThongTinTamThoi where MaBan = @maban ";
            command.Parameters.AddWithValue("@maban", maban);
            if ((int)command.ExecuteScalar() == 0) 
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool confirmPayment(string maban)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "update ThongTinTamThoi set TrangThaiThanhToan = 0 where MaBan = @maban ";
            command.Parameters.AddWithValue("@maban", maban);

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

        public bool checkConfirm(string maban, string mamonan)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select TrangThaiThanhToan from ThongTinTamThoi where MaBan = @maban and MaMonAn = @mamonan";
            command.Parameters.AddWithValue("@maban", maban);
            command.Parameters.AddWithValue("@mamonan", mamonan);

            if ((int)command.ExecuteScalar() == 1) 
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool confirmTable(string maban)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "update ThongTinTamThoi set TrangThaiThanhToan = 1 where MaBan = @maban";
            command.Parameters.AddWithValue("@maban", maban);
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
