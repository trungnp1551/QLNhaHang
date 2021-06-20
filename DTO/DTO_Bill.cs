using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Bill
    {
        private string maHoaDon;
        private string maBan;
        private string maNhanVien;
        private string tongHoaDon;
        private string thoiGian;

        public DTO_Bill(string mahd,string maban,string manv,string tonghd,string thoigian)
        {
            this.maHoaDon = mahd;
            this.maBan = maban;
            this.maNhanVien = manv;
            this.tongHoaDon = tonghd;
            this.thoiGian = thoigian;
        }

        public string MaHoaDon
        {
            set { this.maHoaDon = value; }
            get { return this.maHoaDon; }
        }
        public string MaBan
        {
            set { this.maBan = value; }
            get { return this.maBan; }
        }
        public string MaNhanVien
        {
            set { this.maNhanVien = value; }
            get { return this.maNhanVien; }
        }
        public string TongHoaDon
        {
            set { this.tongHoaDon = value; }
            get { return this.tongHoaDon; }
        }
        public string ThoiGian
        {
            set { this.thoiGian = value; }
            get { return this.thoiGian; }
        }
    }
}
