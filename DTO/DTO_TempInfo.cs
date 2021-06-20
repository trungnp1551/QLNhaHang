using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TempInfo
    {
        private string maBan;
        private string maMonAn;
        private string tenMonAn;
        private string soLuong;
        private string giaTien;
        private string trangThaiThanhToan;

        public DTO_TempInfo(string maban, string ma, string ten, string soluong, string gia, string trangthai)
        {
            this.maBan = maban;
            this.maMonAn = ma;
            this.tenMonAn = ten;
            this.soLuong = soluong;
            this.giaTien = gia;
            this.trangThaiThanhToan = trangthai;
        }
        public string MaBan
        {
            set { this.maBan = value; }
            get { return this.maBan; }
        }
        public string MaMonAn
        {
            set { this.maMonAn = value; }
            get { return this.maMonAn; }
        }
        public string TenMonAn
        {
            set { this.tenMonAn = value; }
            get { return this.tenMonAn; }
        }
        public string SoLuong
        {
            set { this.soLuong = value; }
            get { return this.soLuong; }
        }
        public string GiaTien
        {
            set { this.giaTien = value; }
            get { return this.giaTien; }
        }
        public string TrangThaiThanhToan
        {
            set { this.trangThaiThanhToan = value; }
            get { return this.trangThaiThanhToan; }
        }
    }
}
