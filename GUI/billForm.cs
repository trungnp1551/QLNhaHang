using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class billForm : Form
    {
        BUS_Bill bus_bill = new BUS_Bill();
        BUS_BillDetails bus_billDetails = new BUS_BillDetails();

        public billForm()
        {
            InitializeComponent();
        }

        void loadDataHD()
        {
            dataGridViewHD.DataSource = bus_bill.loadData().Tables[0];
        }

        void loadDataCTHD(string mahoadon)
        {
            dataGridViewCTHD.DataSource = bus_billDetails.loadData(mahoadon).Tables[0];
        }

        private void billForm_Load(object sender, EventArgs e)
        {
            loadDataHD();
        }

        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridViewHD.Rows[e.RowIndex];

            string mahoadon = row.Cells["HDColumnMaHoaDon"].Value.ToString();
            lblTotal.Text = row.Cells["HDColumnTongHoaDon"].Value.ToString() + " VNĐ";
            loadDataCTHD(mahoadon);
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string ngay = dtmNgay.Text;
            string manhanvien;
            string giatrihoadon;

            if (chkNgay.Checked == true && chkMaNV.Checked == true && chkGiaTriHD.Checked == true) 
            {
                manhanvien = txtMaNhanVien.Text.ToString();
                giatrihoadon = txtGiaTriHD.Text.ToString();
                dataGridViewHD.DataSource = bus_bill.query(ngay, manhanvien, giatrihoadon).Tables[0];
                return;
            }

            if(chkNgay.Checked == true && chkMaNV.Checked == true)
            {
                manhanvien = txtMaNhanVien.Text.ToString();
                dataGridViewHD.DataSource = bus_bill.query(ngay, manhanvien).Tables[0];
                return;
            }
            if(chkNgay.Checked == true && chkGiaTriHD.Checked == true)
            {
                giatrihoadon = txtGiaTriHD.Text.ToString();
                dataGridViewHD.DataSource = bus_bill.query(ngay, giatrihoadon).Tables[0];
                return;
            }

            if(chkMaNV.Checked == true && chkGiaTriHD.Checked == true)
            {
                giatrihoadon = txtGiaTriHD.Text.ToString();
                manhanvien = txtMaNhanVien.Text.ToString();
                dataGridViewHD.DataSource = bus_bill.query(0, manhanvien, giatrihoadon).Tables[0];
                return;
            }

            if (chkNgay.Checked == true)
            {
                dataGridViewHD.DataSource = bus_bill.query(ngay).Tables[0];
                return;
            }

            if (chkMaNV.Checked == true)
            {
                manhanvien = txtMaNhanVien.Text.ToString();
                dataGridViewHD.DataSource = bus_bill.query(0, manhanvien).Tables[0];
                return;
            }

            if (chkGiaTriHD.Checked == true)
            {
                giatrihoadon = txtGiaTriHD.Text.ToString();
                if(giatrihoadon.Length == 0)
                {
                    giatrihoadon = "0";
                }
                dataGridViewHD.DataSource = bus_bill.query(0, 0, giatrihoadon).Tables[0];
                return;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            dtmNgay.Value = DateTime.Now;
            txtGiaTriHD.Text = "";
            txtMaNhanVien.Text = "";
            loadDataHD();
        }

        private void txtGiaTriHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
