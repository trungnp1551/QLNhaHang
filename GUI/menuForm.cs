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
    public partial class menuForm : Form
    {
        BUS_Category bus_category = new BUS_Category();
        BUS_Menu bus_menu = new BUS_Menu();
        public menuForm()
        {
            InitializeComponent();
        }

        void loadDataDM()
        {
            dataGridViewDM.DataSource = bus_category.loadData().Tables[0];
        }

        void loadDataTD()
        {
            dataGridViewTD.DataSource = bus_menu.loadData().Tables[0];
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            loadDataDM();
            loadDataTD();
        }

        private void btAddDM_Click(object sender, EventArgs e)
        {
            if (txtMDM.ReadOnly == true)
                return;

            if (txtMDM.Text != "" && txtTDM.Text != "")
            {
                string madm = txtMDM.Text.ToString();
                string tendm = txtTDM.Text.ToString();
                string ghichu = txtGC.Text.ToString();

                DTO_Category category = new DTO_Category(madm, tendm, ghichu);
                
                DialogResult dlr = MessageBox.Show("Bạn muốn thêm danh mục " + tendm + " với mã: " + madm, "Thêm danh mục", MessageBoxButtons.YesNo);

                if (dlr == DialogResult.Yes)
                {
                    if (bus_category.addData(category))
                    {
                        txtMDM.ReadOnly = true;
                        btAddDMz.Text = "+";
                        loadDataDM();
                    }
                    else
                    {
                        MessageBox.Show("Mã danh mục đã tồn tại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập tên và mã danh mục cần thêm");
            }

        }

        private void dataGridViewDM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridViewDM.Rows[e.RowIndex];
            txtMDM.Text = row.Cells[0].Value.ToString();
            txtTDM.Text = row.Cells[1].Value.ToString();
            txtGC.Text = row.Cells[2].Value.ToString();
        }

        private void btDeleteDM_Click(object sender, EventArgs e)
        {
            if (txtMDM.ReadOnly == false)
                return;

            DialogResult dlr = MessageBox.Show("Bạn muốn xóa danh mục có mã: " + txtMDM.Text.ToString(), "Xóa danh mục", MessageBoxButtons.YesNo);

            if (dlr == DialogResult.Yes)
            {
                if (bus_category.deleteData(txtMDM.Text.ToString()))
                {
                    loadDataDM();
                }
                else
                {
                    MessageBox.Show("Danh mục có món ăn không thể xóa");
                }
            }
        }

        private void btAddDMz_Click(object sender, EventArgs e)
        {
            if (txtMDM.ReadOnly == true)
            { 
                txtMDM.ReadOnly = false;
                btAddDMz.Text = "X";
            }
            else
            {
                txtMDM.ReadOnly = true;
                btAddDMz.Text = "+";
                txtMDM.Text = "";
            }
        }

        private void btUpdateDM_Click(object sender, EventArgs e)
        {
            if (txtMDM.ReadOnly == false)
                return;

            if (txtMDM.Text.ToString() != "")
            {
                DTO_Category category = new DTO_Category(txtMDM.Text.ToString(), txtTDM.Text.ToString(), txtGC.Text.ToString());

                if (bus_category.updateData(category))
                {
                    loadDataDM();
                }
            }
            else
            {
                MessageBox.Show("Nhập mã danh mục cần chỉnh sửa");
            }
        }

        private void btAddMA_Click(object sender, EventArgs e)
        {
            if (txtMMA.Text == "" || txtTMA.Text == "" || txtDVT.Text == "" || txtGT.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin món ăn");
                return;
            }

            if (txtMDM.Text == "")
            {
                MessageBox.Show("Chọn danh mục của món ăn cần thêm");
                return;
            }

            DTO_Menu menu = new DTO_Menu(txtMMA.Text.ToString(), txtTMA.Text.ToString(), txtGT.Text.ToString(), txtDVT.Text.ToString(), txtMDM.Text.ToString(), "1");
            
            DialogResult dlr = MessageBox.Show("        Bạn muốn thêm \nTên: " + txtTMA.Text.ToString()
                        + "(Mã: " + txtMMA.Text.ToString()
                        + ")\nGiá: " + txtGT.Text.ToString() + "/" + txtDVT.Text.ToString()
                        + "\nDanh mục: " + txtTDM.Text.ToString(), "Thêm món ăn", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                if (bus_menu.addData(menu))
                {
                    loadDataTD();
                    txtMMA.ReadOnly = true;
                    btAddMAz.Text = "+";
                }
                else
                {
                    MessageBox.Show("Mã Món Ăn đã tồn tại");
                }
            }
        }

        private void dataGridViewTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridViewTD.Rows[e.RowIndex];

            txtMMA.Text = row.Cells[0].Value.ToString();
            txtTMA.Text = row.Cells[1].Value.ToString();
            txtGT.Text = row.Cells[2].Value.ToString();
            txtDVT.Text = row.Cells[3].Value.ToString();
            txtTDM.Text = row.Cells[4].Value.ToString();
            txtMDM.Text = row.Cells[5].Value.ToString();
        }

        private void btDeleteMA_Click(object sender, EventArgs e)
        {
            if (txtMMA.ReadOnly == false)
                return;

            DialogResult dlr = MessageBox.Show("Bạn muốn xóa món có mã: " + txtMMA.Text.ToString(), "Xóa món ăn", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                if (bus_menu.deleteData(txtMMA.Text.ToString()))
                {
                    loadDataTD();
                }
            }
        }

        private void btUpdateMA_Click(object sender, EventArgs e)
        {
            if (txtMMA.ReadOnly == false)
                return;

            if (txtMMA.Text != "")
            {
                DTO_Menu menu = new DTO_Menu(txtMMA.Text.ToString(), txtTMA.Text.ToString(), txtGT.Text.ToString(), txtDVT.Text.ToString(), txtMDM.Text.ToString(), "1");

                if (bus_menu.updateData(menu))
                {
                    loadDataTD();
                }
            }
            else MessageBox.Show("Nhập mã món ăn cần chỉnh sửa");
        }

        private void btAddMAz_Click(object sender, EventArgs e)
        {
            if (txtMMA.ReadOnly == true)
            {
                txtMMA.ReadOnly = false;
                btAddMAz.Text = "X";
            }
            else
            {
                txtMMA.ReadOnly = true;
                btAddMAz.Text = "+";
                txtMMA.Text = "";
            }

        }

        private void txtGT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
