using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class employeeForm : Form
    {
        BUS_Employee bus_employee = new BUS_Employee();

        public employeeForm()
        {
            InitializeComponent();
        }

        void loadDataNhanVien()
        {
            dataGridViewNhanVien.DataSource = bus_employee.loadData().Tables[0];
        }

        private void employeeForm_Load(object sender, EventArgs e)
        {
            loadDataNhanVien();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMSNV.Text = "";
            txtHoTenNV.Text = "";
            cbGioiTinh.Text = "";
            txtCMND.Text = "";
            txtChucVu.Text = "";
            txtLuong.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtTenDN.Text = "";
            txtMatKhauDN.Text = "";
            dtmNgaySinh.Value = DateTime.Now;
            dtmNgayVaoLam.Value = DateTime.Now;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtMSNV.Text == "" || txtHoTenNV.Text == "" || cbGioiTinh.Text == ""
                || txtCMND.Text == "" || txtChucVu.Text == "" || txtLuong.Text == ""
                || txtSDT.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == ""
                || txtTenDN.Text == "" || txtMatKhauDN.Text == "") 
            {
                MessageBox.Show("Điền đầy đủ thông tin");
                return;
            }

            string manv = txtMSNV.Text.ToString();
            string hotennv = txtHoTenNV.Text.ToString();
            string gioitinh = cbGioiTinh.Text.ToString();
            string cmnd = txtCMND.Text.ToString();
            string chucvu = txtChucVu.Text.ToString();
            string luong = txtLuong.Text.ToString();
            string sdt = txtSDT.Text.ToString();
            string diachi = txtDiaChi.Text.ToString();
            string email = txtEmail.Text.ToString();
            string ngaysinh = dtmNgaySinh.Text.ToString();
            string ngayvaolam = dtmNgayVaoLam.Text.ToString();
            string tendangnhap = txtTenDN.Text.ToString();
            string mkdangnhap = txtMatKhauDN.Text.ToString();

            DTO_Employee employee = new DTO_Employee(manv, hotennv, gioitinh, ngaysinh, cmnd, chucvu, ngayvaolam, luong, sdt, diachi, email, tendangnhap, mkdangnhap);

            if (bus_employee.addData(employee))
            {
                loadDataNhanVien();
            }
            else
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (txtMSNV.Text == "" || txtHoTenNV.Text == "" || cbGioiTinh.Text == ""
                || txtCMND.Text == "" || txtChucVu.Text == "" || txtLuong.Text == ""
                || txtSDT.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == ""
                || txtTenDN.Text == "" || txtMatKhauDN.Text == "") 
            {
                MessageBox.Show("Điền đầy đủ thông tin");
                return;
            }

            string manv = txtMSNV.Text.ToString();
            string hotennv = txtHoTenNV.Text.ToString();
            string gioitinh = cbGioiTinh.Text.ToString();
            string cmnd = txtCMND.Text.ToString();
            string chucvu = txtChucVu.Text.ToString();
            string luong = txtLuong.Text.ToString();
            string sdt = txtSDT.Text.ToString();
            string diachi = txtDiaChi.Text.ToString();
            string email = txtEmail.Text.ToString();
            string ngaysinh = dtmNgaySinh.Text.ToString();
            string ngayvaolam = dtmNgayVaoLam.Text.ToString();
            string tendangnhap = txtTenDN.Text.ToString();
            string mkdangnhap = txtMatKhauDN.Text.ToString();

            DTO_Employee employee = new DTO_Employee(manv, hotennv, gioitinh, ngaysinh, cmnd, chucvu, ngayvaolam, luong, sdt, diachi, email, tendangnhap, mkdangnhap);

            if (bus_employee.updateData(employee)) 
            {
                loadDataNhanVien();
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(txtMSNV.Text == "")
            {
                MessageBox.Show("Chọn nhân viên cần xóa");
                return;
            }
            string manv = txtMSNV.Text.ToString();
            if (bus_employee.deleteData(manv))
            {
                loadDataNhanVien();
                btReset_Click(sender, e);
            }
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridViewNhanVien.Rows[e.RowIndex];

            txtMSNV.Text = row.Cells["columnMaNhanVien"].Value.ToString();
            txtHoTenNV.Text = row.Cells["columnHoTenNhanVien"].Value.ToString();
            cbGioiTinh.Text = row.Cells["columnGioiTinh"].Value.ToString();
            txtCMND.Text = row.Cells["columnCMND"].Value.ToString();
            txtChucVu.Text = row.Cells["columnChucVu"].Value.ToString();
            txtLuong.Text = row.Cells["columnLuongThang"].Value.ToString();
            txtSDT.Text = row.Cells["columnSoDienThoai"].Value.ToString();
            txtDiaChi.Text = row.Cells["columnDiaChi"].Value.ToString();
            txtEmail.Text = row.Cells["columnEmail"].Value.ToString();
            txtTenDN.Text = row.Cells["columnTenDangNhap"].Value.ToString();
            txtMatKhauDN.Text = row.Cells["columnMatKhau"].Value.ToString();
            dtmNgaySinh.Value = Convert.ToDateTime(row.Cells["columnNgaySinh"].Value.ToString());
            dtmNgayVaoLam.Value = Convert.ToDateTime(row.Cells["columnNgayVaoLam"].Value.ToString());
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
