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
    public class DAL_Employee : DBConnect
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dataNhanVien = new DataSet();
        
        public DataSet loadData()
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from NhanVien";
            adapter.SelectCommand = command;
            dataNhanVien.Clear();
            adapter.Fill(dataNhanVien);
            connection.Close();
            return dataNhanVien;
        }

        public bool addData(DTO_Employee employee)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "insert into NhanVien values(@manv,@hotennv,@gioitinh," +
                            "@ngaysinh,@cmnd,@chucvu,@ngayvaolam,@luong ,@sdt,@diachi," +
                            "@email,@tendangnhap,@mkdangnhap)";

            command.Parameters.AddWithValue("@manv", employee.MaNhanVien);
            command.Parameters.AddWithValue("@hotennv", employee.HoTenNhanVien);
            command.Parameters.AddWithValue("@gioitinh", employee.GioiTinh);
            command.Parameters.AddWithValue("@ngaysinh", employee.NgaySinh);
            command.Parameters.AddWithValue("@cmnd", employee.CMND);
            command.Parameters.AddWithValue("@chucvu", employee.ChucVu);
            command.Parameters.AddWithValue("@ngayvaolam", employee.NgayVaoLam);
            command.Parameters.AddWithValue("@luong", employee.LuongThang);
            command.Parameters.AddWithValue("@sdt", employee.SoDienThoai);
            command.Parameters.AddWithValue("@diachi", employee.DiaChi);
            command.Parameters.AddWithValue("@email", employee.Email);
            command.Parameters.AddWithValue("@tendangnhap", employee.TenDangNhap);
            command.Parameters.AddWithValue("@mkdangnhap", employee.MatKhau);

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

        public bool updateData(DTO_Employee employee)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "update NhanVien set HoTenNhanVien = @hotennv, GioiTinh = @gioitinh," +
                "NgaySinh = @ngaysinh, CMND = @cmnd ,ChucVu = @chucvu, NgayVaoLam = @ngayvaolam," +
                "LuongThang = @luong, SoDienThoai = @sdt, DiaChi = @diachi, Email = @email," +
                "TenDangNhap = @tendangnhap, MatKhauDangNhap = @mkdangnhap where MaNhanVien = @manv";

            command.Parameters.AddWithValue("@manv", employee.MaNhanVien);
            command.Parameters.AddWithValue("@hotennv", employee.HoTenNhanVien);
            command.Parameters.AddWithValue("@gioitinh", employee.GioiTinh);
            command.Parameters.AddWithValue("@ngaysinh", employee.NgaySinh);
            command.Parameters.AddWithValue("@cmnd", employee.CMND);
            command.Parameters.AddWithValue("@chucvu", employee.ChucVu);
            command.Parameters.AddWithValue("@ngayvaolam", employee.NgayVaoLam);
            command.Parameters.AddWithValue("@luong", employee.LuongThang);
            command.Parameters.AddWithValue("@sdt", employee.SoDienThoai);
            command.Parameters.AddWithValue("@diachi", employee.DiaChi);
            command.Parameters.AddWithValue("@email", employee.Email);
            command.Parameters.AddWithValue("@tendangnhap", employee.TenDangNhap);
            command.Parameters.AddWithValue("@mkdangnhap", employee.MatKhau);
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

        public bool deleteData(string manv)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "delete from NhanVien where MaNhanVien = @manv";
            command.Parameters.AddWithValue("@manv", manv);
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

        public bool login(string username,string password)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select COUNT(*) from NhanVien where TenDangNhap = @username and MatKhauDangNhap = @password";
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            if ((int)command.ExecuteScalar() == 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public string getIdUser(string username)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select nv.MaNhanVien from NhanVien nv where nv.TenDangNhap = @username";
            command.Parameters.AddWithValue("@username", username);

            return command.ExecuteScalar().ToString();
        }
    }
}
