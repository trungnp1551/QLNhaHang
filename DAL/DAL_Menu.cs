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
    public class DAL_Menu : DBConnect
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dataThucDon = new DataSet();

        public DataSet loadData()
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select MaMonAn, TenMonAn, GiaTien, DonViTinh, TenDanhMuc, TD.MaDanhMuc " +
                "from ThucDon TD,DanhMuc DM where TD.MaDanhMuc = DM.MaDanhMuc";
            adapter.SelectCommand = command;
            dataThucDon.Clear();
            adapter.Fill(dataThucDon);
            connection.Close();
            return dataThucDon;
        }

        public DataSet loadDataForServeForm()
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select MaMonAn, TenMonAn, GiaTien, DonViTinh, TenDanhMuc, TD.MaDanhMuc, SoLuong " +
                "from ThucDon TD,DanhMuc DM where TD.MaDanhMuc = DM.MaDanhMuc";
            adapter.SelectCommand = command;
            dataThucDon.Clear();
            adapter.Fill(dataThucDon);
            connection.Close();
            return dataThucDon;
        }

        public bool addData(DTO_Menu menu)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "insert into ThucDon values (@ma, @ten, @giatien, @dvt, @madm, @soluong)";
            command.Parameters.AddWithValue("@ma", menu.MaMonAn);
            command.Parameters.AddWithValue("@ten", menu.TenMonAn);
            command.Parameters.AddWithValue("@giatien", menu.GiaTien);
            command.Parameters.AddWithValue("@dvt", menu.DonViTinh);
            command.Parameters.AddWithValue("@madm", menu.MaDanhMuc);
            command.Parameters.AddWithValue("@soluong", menu.SoLuong);

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

        public bool updateData(DTO_Menu menu)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "update ThucDon set TenMonAn = @ten, GiaTien = @giatien, DonViTinh = @dvt, MaDanhMuc = @madm where MaMonAn = @ma";
            command.Parameters.AddWithValue("@ma", menu.MaMonAn);
            command.Parameters.AddWithValue("@ten", menu.TenMonAn);
            command.Parameters.AddWithValue("@giatien", menu.GiaTien);
            command.Parameters.AddWithValue("@dvt", menu.DonViTinh);
            command.Parameters.AddWithValue("@madm", menu.MaDanhMuc);

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

        public bool deleteData(string ma)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "delete from ThucDon where MaMonAn = @ma";
            command.Parameters.AddWithValue("@ma", ma);
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

        public bool setQuantity(string ma, string soluong)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "update ThucDon set SoLuong = @soluong where MaMonAn = @ma";
            command.Parameters.AddWithValue("@soluong", soluong);
            command.Parameters.AddWithValue("@ma", ma);

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
