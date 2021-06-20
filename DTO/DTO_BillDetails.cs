using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BillDetails
    {
        private string maHoaDon;
        private string tenMonAn;
        private string soLuong;
        private string giaTien;
        private string donViTinh;

        public DTO_BillDetails(string ma, string ten, string soluong, string gia, string dvt)
        {
            this.maHoaDon = ma;
            this.tenMonAn = ten;
            this.soLuong = soluong;
            this.giaTien = gia;
            this.donViTinh = dvt;
        }
        public string MaHoaDon
        {
            set { this.maHoaDon = value; }
            get { return this.maHoaDon; }
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
        public string DonViTinh
        {
            set { this.donViTinh = value; }
            get { return this.donViTinh; }
        }
    }
}
