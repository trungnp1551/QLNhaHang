using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Menu
    {
        private string maMonAn;
        private string tenMonAn;
        private string giaTien;
        private string donViTinh;
        private string maDanhMuc;
        private string soLuong;

        public DTO_Menu(string maMA, string ten, string gia, string dvt, string maDM, string soluong)
        {
            this.maMonAn = maMA;
            this.tenMonAn = ten;
            this.giaTien = gia;
            this.donViTinh = dvt;
            this.maDanhMuc = maDM;
            this.soLuong = soluong;
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
        public string MaDanhMuc
        {
            set { this.maDanhMuc = value; }
            get { return this.maDanhMuc; }
        }
        public string SoLuong
        {
            set { this.soLuong = value; }
            get { return this.soLuong; }
        }
    }
}
