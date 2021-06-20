using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DTO;

namespace DAL
{
    public class DAL_Bill : DBConnect
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dataHoaDon = new DataSet();

        public DataSet loadData()
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon order by ThoiGian";
            adapter.SelectCommand = command;
            dataHoaDon.Clear();
            adapter.Fill(dataHoaDon);
            connection.Close();
            return dataHoaDon;
        }

        public bool addData(DTO_Bill bill)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "insert into HoaDon values (@mahd, @maban, @manhanvien, @tongtien, getdate())";
            command.Parameters.AddWithValue("@mahd", bill.MaHoaDon);
            command.Parameters.AddWithValue("@maban", bill.MaBan);
            command.Parameters.AddWithValue("@manhanvien", bill.MaNhanVien);
            command.Parameters.AddWithValue("@tongtien", bill.TongHoaDon);

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

        public int countingBills()
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select COUNT(*) from HoaDon";
            int count = (int)command.ExecuteScalar();
            connection.Close();
            return count;
        }

        public DataSet query(string ngay, string manv, string giatrihd)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon where ThoiGian > @daungay " +
                    "and ThoiGian < @cuoingay and MaNhanVien = @manhanvien " +
                    "and TongHoaDon >= @giatrihoadon";
            command.Parameters.AddWithValue("@daungay", ngay + " 0:0:0");
            command.Parameters.AddWithValue("@cuoingay", ngay + " 23:59:59");
            command.Parameters.AddWithValue("@manhanvien", manv);
            command.Parameters.AddWithValue("@giatrihoadon", giatrihd);
            adapter.SelectCommand = command;
            dataHoaDon.Clear();
            adapter.Fill(dataHoaDon);
            connection.Close();
            return dataHoaDon;
        }

        public DataSet query(string ngay, string giatrihd)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon where ThoiGian > @daungay " +
                    "and ThoiGian < @cuoingay and TongHoaDon > @giatrihoadon";
            command.Parameters.AddWithValue("@daungay", ngay + " 0:0:0");
            command.Parameters.AddWithValue("@cuoingay", ngay + " 23:59:59");
            command.Parameters.AddWithValue("@giatrihoadon", giatrihd);
            adapter.SelectCommand = command;
            dataHoaDon.Clear();
            adapter.Fill(dataHoaDon);
            connection.Close();
            return dataHoaDon;
        }

        public DataSet query(int fixbug, string manv, string giatrihd)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon where MaNhanVien = @manhanvien and TongHoaDon > @giatrihoadon";
            command.Parameters.AddWithValue("@manhanvien", manv);
            command.Parameters.AddWithValue("@giatrihoadon", giatrihd);
            adapter.SelectCommand = command;
            dataHoaDon.Clear();
            adapter.Fill(dataHoaDon);
            connection.Close();
            return dataHoaDon;
        }

        public DataSet query(int fixbug, int fixbug1, string giatrihd)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon where TongHoaDon > @giatrihoadon";
            command.Parameters.AddWithValue("@giatrihoadon", giatrihd);
            adapter.SelectCommand = command;
            dataHoaDon.Clear();
            adapter.Fill(dataHoaDon);
            connection.Close();
            return dataHoaDon;
        }
    }
}
