using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class serveForm : Form
    {
        BUS_Menu bus_menu = new BUS_Menu();
        BUS_TempInfo bus_tempInfo = new BUS_TempInfo();
        BUS_Bill bus_bill = new BUS_Bill();
        BUS_BillDetails bus_billDetails = new BUS_BillDetails();

        public serveForm()
        {
            InitializeComponent();
        }
        public string manhanvien;

        void loadDataMenu()
        {
            dataGridViewMenu.DataSource = bus_menu.loadDataForServeForm().Tables[0];
        }

        void loadDataInfo(string maban)
        {
            dataGridViewInfo.DataSource = bus_tempInfo.loadData(maban).Tables[0];
        }

        private void serveForm_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = "Mã nhân viên: " + manhanvien;
            loadDataMenu();
            setColorTable(1);
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridViewMenu.Rows[e.RowIndex];

            int soluong = (row.Cells["menuColumnSoluong"].Value.ToString() == "True") ? 0 : 1;
            string ma = row.Cells["menuColumnMaMonAn"].Value.ToString();

            if (e.ColumnIndex == 6 && bus_menu.setQuantity(ma, soluong.ToString())) 
            {
                loadDataMenu();
            }

        }

        void setColorTable(int floor)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (!bus_tempInfo.checkEmptyTable((floor * 10 + i).ToString())) 
                {
                    switch (i)
                    {
                        case 1:
                            btTable1.BackColor = Color.Red;
                            break;
                        case 2:
                            btTable2.BackColor = Color.Red;
                            break;
                        case 3:
                            btTable3.BackColor = Color.Red;
                            break;
                        case 4:
                            btTable4.BackColor = Color.Red;
                            break;
                        case 5:
                            btTable5.BackColor = Color.Red;
                            break;
                    };
                }
                else
                {
                    switch (i)
                    {
                        case 1:
                            btTable1.BackColor = Color.FromArgb(192, 255, 192);
                            break;
                        case 2:
                            btTable2.BackColor = Color.FromArgb(192, 255, 192);
                            break;
                        case 3:
                            btTable3.BackColor = Color.FromArgb(192, 255, 192);
                            break;
                        case 4:
                            btTable4.BackColor = Color.FromArgb(192, 255, 192);
                            break;
                        case 5:
                            btTable5.BackColor = Color.FromArgb(192, 255, 192);
                            break;
                    };

                }
            }

        }

        private void btFloor1_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "1";
            txtTable.Text = "";
            setColorTable(1);
        }

        private void btFloor2_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "2";
            txtTable.Text = "";
            setColorTable(2);
        }

        private void btFloorVIP_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "3";
            txtTable.Text = "";
            setColorTable(3);
        }

        private void btTable1_Click(object sender, EventArgs e)
        {
            txtTable.Text = "1";
            string maban = txtFloor.Text + txtTable.Text;
            loadDataInfo(maban);
        }

        private void btTable2_Click(object sender, EventArgs e)
        {
            txtTable.Text = "2";
            string maban = txtFloor.Text + txtTable.Text;
            loadDataInfo(maban);
        }

        private void btTable3_Click(object sender, EventArgs e)
        {
            txtTable.Text = "3";
            string maban = txtFloor.Text + txtTable.Text;
            loadDataInfo(maban);
        }

        private void btTable4_Click(object sender, EventArgs e)
        {
            txtTable.Text = "4";
            string maban = txtFloor.Text + txtTable.Text;
            loadDataInfo(maban);
        }

        private void btTable5_Click(object sender, EventArgs e)
        {
            txtTable.Text = "5";
            string maban = txtFloor.Text + txtTable.Text;
            loadDataInfo(maban);
        }

        private void dataGridViewMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (txtFloor.Text == "" || txtTable.Text == "")
            {
                MessageBox.Show("Chọn khu vực và bàn bạn muốn");
                return;
            }

            DataGridViewRow row = dataGridViewMenu.Rows[e.RowIndex];
            string soluong = row.Cells["menuColumnSoLuong"].Value.ToString();
            if(soluong == "False")
            {
                MessageBox.Show("Món đã hết hàng");
                return;
            }
            string maban = txtFloor.Text + txtTable.Text;
            string tenmonan = row.Cells["menuColumnTenMonAn"].Value.ToString();
            string mamonan = row.Cells["menuColumnMaMonAn"].Value.ToString();
            string giatien = row.Cells["menuColumnGiaTien"].Value.ToString();

            DTO_TempInfo tempInfo = new DTO_TempInfo(maban, mamonan, tenmonan, "1", giatien, "0");
            if (bus_tempInfo.addData(tempInfo))
            {
                loadDataInfo(maban);
            }
            loadDataInfo(maban);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtFloor.Text == "" || txtTable.Text == "")
            {
                MessageBox.Show("Chọn khu vực và bàn bạn muốn");
                return;
            }
            string maban = txtFloor.Text + txtTable.Text;
            if (bus_tempInfo.confirmTable(maban))
            {
                setColorTable(int.Parse(txtFloor.Text));
            }
            //bật màu bàn hiện tại

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            if (txtFloor.Text == "" || txtTable.Text == "")
            {
                MessageBox.Show("Chọn khu vực và bàn bạn muốn");
                return;
            }
            string maban = txtFloor.Text + txtTable.Text;

            if (!bus_tempInfo.checkExist(maban)) return;

            if (!bus_tempInfo.checkPaymentStatus(maban)) 
            {
                if (MessageBox.Show("Bàn chưa được thanh toán, bạn có muốn reset?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes) 
                {
                    return;
                }
            }
            else
            {
                string tenmonan;
                int soluong;
                int giatien;
                string donvitinh;

                //////add hoa don, chi tiet hoa don
                string hd = "hd" + (bus_bill.countingBills() + 1);
                int tongtien = 0;

                int soluongrow = (int)dataGridViewInfo.RowCount;
                for (int i = 0; i < soluongrow; i++)
                {
                    tenmonan = dataGridViewInfo.Rows[i].Cells["infoColumnTenMonAn"].Value.ToString();
                    soluong = (int)dataGridViewInfo.Rows[i].Cells["infoColumnSoLuong"].Value;
                    giatien = (int)dataGridViewInfo.Rows[i].Cells["infoColumnGiaTien"].Value;
                    donvitinh = dataGridViewInfo.Rows[i].Cells["infoColumnDonViTinh"].Value.ToString();

                    DTO_BillDetails billDetails = new DTO_BillDetails(hd, tenmonan, soluong.ToString(), giatien.ToString(), donvitinh);

                    bus_billDetails.addData(billDetails);
                    
                    tongtien += giatien * soluong;
                }

                DTO_Bill bill = new DTO_Bill(hd, maban, manhanvien, tongtien.ToString(), "");
                bus_bill.addData(bill);
            }

            if (bus_tempInfo.deleteData(maban))
            {
                loadDataInfo(maban);
                setColorTable(int.Parse(txtFloor.Text));
            }
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            if (txtFloor.Text == "" || txtTable.Text == "")
            {
                MessageBox.Show("Chọn khu vực và bàn bạn muốn");
                return;
            }
            string maban = txtFloor.Text + txtTable.Text;

            if (bus_tempInfo.checkEmptyTable(maban)) return;

            if (rdoATM.Checked == false && rdoCash.Checked == false && rdoMomo.Checked == false)
            {
                MessageBox.Show("Chọn hình thức bạn muốn thanh toán");
                return;
            }

            payForm form = new payForm();
            form.maban = txtFloor.Text + txtTable.Text;
            int soluongrow = (int)dataGridViewInfo.RowCount;
            for (int i = 0; i < soluongrow; i++)
            {
                form.strMonAn[i] = dataGridViewInfo.Rows[i].Cells["infoColumnTenMonAn"].Value.ToString();
                form.strGiaTien[i] = dataGridViewInfo.Rows[i].Cells["infoColumnGiaTien"].Value.ToString();
                form.strSoLuong[i] = dataGridViewInfo.Rows[i].Cells["infoColumnSoLuong"].Value.ToString();
            }            
            form.Show();
        }

        private void dataGridViewInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (txtFloor.Text == "" || txtTable.Text == "")
            {
                MessageBox.Show("Chọn khu vực và bàn bạn muốn");
                return;
            }
            DataGridViewRow row = dataGridViewInfo.Rows[e.RowIndex];

            string maban = txtFloor.Text + txtTable.Text;
            string mamonan = row.Cells["infoColumnMaMonAn"].Value.ToString();

            if (bus_tempInfo.checkConfirm(maban, mamonan))
            {
                MessageBox.Show("Món ăn đã được xác nhận, không được xóa!");
                return;
            }
            
            if(bus_tempInfo.deleteOne(maban, mamonan))
            {
                loadDataInfo(maban);
            }
        }
    }
}
