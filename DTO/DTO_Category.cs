using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Category
    {
        private string maDanhMuc;
        private string tenDanhMuc;
        private string ghiChu;

        public DTO_Category(string ma, string ten, string ghichu)
        {
            this.maDanhMuc = ma;
            this.tenDanhMuc = ten;
            this.ghiChu = ghichu;
        }

        public string MaDanhMuc
        {
            set { this.maDanhMuc = value; }
            get { return this.maDanhMuc; }
        }
        public string TenDanhMuc
        {
            set { this.tenDanhMuc = value; }
            get { return this.tenDanhMuc; }
        }
        public string GhiChu
        {
            set { this.ghiChu = value; }
            get { return this.ghiChu; }
        }
    }
}
