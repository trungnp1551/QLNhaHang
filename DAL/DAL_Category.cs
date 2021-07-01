using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Category : DBConnect
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dataDanhMuc = new DataSet();

        public DataSet loadData()
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from DanhMuc order by MaDanhMuc";
            adapter.SelectCommand = command;
            dataDanhMuc.Clear();
            adapter.Fill(dataDanhMuc);
            connection.Close();
            return dataDanhMuc;
        }

        public bool addData(DTO_Category category)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "insert into DanhMuc values (@madm, @tendm , @ghichu)";
            command.Parameters.AddWithValue("@madm", category.MaDanhMuc);
            command.Parameters.AddWithValue("@tendm", category.TenDanhMuc);
            command.Parameters.AddWithValue("@ghichu", category.GhiChu);
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

        public bool updateData(DTO_Category category)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "update DanhMuc set TenDanhMuc = @tendm, GhiChu = @ghichu where MaDanhMuc = @madm";
            command.Parameters.AddWithValue("@madm", category.MaDanhMuc);
            command.Parameters.AddWithValue("@tendm", category.TenDanhMuc);
            command.Parameters.AddWithValue("@ghichu", category.GhiChu);
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

        public bool deleteData(string madm)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "delete from DanhMuc where MaDanhMuc = @madm";
            command.Parameters.AddWithValue("@madm", madm);
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
