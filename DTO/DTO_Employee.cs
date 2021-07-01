using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee
    {
        private string maNhanVien;
        private string hoTenNhanVien;
        private string gioiTinh;
        private string ngaySinh;
        private string cmnd;
        private string chucVu;
        private string ngayVaoLam;
        private string luongThang;
        private string soDienThoai;
        private string diaChi;
        private string email;
        private string tenDangNhap;
        private string matKhau;

        public DTO_Employee(string ma, string ten, string gioitinh, string ngaysinh,
           string _cmnd, string chucvu, string ngayvaolam, string luong,
            string sdt, string diachi, string _email, string tendn, string mk)
        {
            this.maNhanVien = ma;
            this.hoTenNhanVien = ten;
            this.gioiTinh = gioitinh;
            this.ngaySinh = ngaysinh;
            this.cmnd = _cmnd;
            this.chucVu = chucvu;
            this.NgayVaoLam = ngayvaolam;
            this.luongThang = luong;
            this.soDienThoai = sdt;
            this.diaChi = diachi;
            this.email = _email;
            this.tenDangNhap = tendn;
            this.matKhau = mk;
        }

        public string MaNhanVien
        {
            set { this.maNhanVien = value; }
            get { return this.maNhanVien; }
        }
        public string HoTenNhanVien
        {
            set { this.hoTenNhanVien = value; }
            get { return this.hoTenNhanVien; }
        }
        public string GioiTinh
        {
            set { this.gioiTinh = value; }
            get { return this.gioiTinh; }
        }
        public string NgaySinh
        {
            set { this.ngaySinh = value; }
            get { return this.ngaySinh; }
        }
        public string CMND
        {
            set { this.cmnd = value; }
            get { return this.cmnd; }
        }
        public string ChucVu
        {
            set { this.chucVu = value; }
            get { return this.chucVu; }
        }
        public string NgayVaoLam
        {
            set { this.ngayVaoLam = value; }
            get { return this.ngayVaoLam; }
        }
        public string LuongThang
        {
            set { this.luongThang = value; }
            get { return this.luongThang; }
        }
        public string SoDienThoai
        {
            set { this.soDienThoai = value; }
            get { return this.soDienThoai; }
        }
        public string DiaChi
        {
            set { this.diaChi = value; }
            get { return this.diaChi; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public string TenDangNhap
        {
            set { this.tenDangNhap = value; }
            get { return this.tenDangNhap; }
        }
        public string MatKhau
        {
            set { this.matKhau = value; }
            get { return this.matKhau; }
        }
    }
}
