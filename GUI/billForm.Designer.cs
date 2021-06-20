namespace GUI
{
    partial class billForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewHD = new System.Windows.Forms.DataGridView();
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaTriHD = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.dtmNgay = new System.Windows.Forms.DateTimePicker();
            this.btFind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.CTHDColumnMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTHDColumnTenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTHDColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTHDColumnGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTHDColumnDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDColumnMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDColumnMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDColumnMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDColumnTongHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDColumnThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btReset = new System.Windows.Forms.Button();
            this.chkNgay = new System.Windows.Forms.CheckBox();
            this.chkMaNV = new System.Windows.Forms.CheckBox();
            this.chkGiaTriHD = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHD
            // 
            this.dataGridViewHD.AllowUserToAddRows = false;
            this.dataGridViewHD.AllowUserToDeleteRows = false;
            this.dataGridViewHD.AllowUserToResizeRows = false;
            this.dataGridViewHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HDColumnMaHoaDon,
            this.HDColumnMaBan,
            this.HDColumnMaNhanVien,
            this.HDColumnTongHoaDon,
            this.HDColumnThoiGian});
            this.dataGridViewHD.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewHD.Name = "dataGridViewHD";
            this.dataGridViewHD.ReadOnly = true;
            this.dataGridViewHD.RowHeadersVisible = false;
            this.dataGridViewHD.RowHeadersWidth = 62;
            this.dataGridViewHD.RowTemplate.Height = 28;
            this.dataGridViewHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHD.Size = new System.Drawing.Size(643, 339);
            this.dataGridViewHD.TabIndex = 0;
            this.dataGridViewHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHD_CellClick);
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.AllowUserToAddRows = false;
            this.dataGridViewCTHD.AllowUserToDeleteRows = false;
            this.dataGridViewCTHD.AllowUserToResizeRows = false;
            this.dataGridViewCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CTHDColumnMaHoaDon,
            this.CTHDColumnTenMonAn,
            this.CTHDColumnSoLuong,
            this.CTHDColumnGiaTien,
            this.CTHDColumnDonViTinh});
            this.dataGridViewCTHD.Location = new System.Drawing.Point(661, 83);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            this.dataGridViewCTHD.ReadOnly = true;
            this.dataGridViewCTHD.RowHeadersVisible = false;
            this.dataGridViewCTHD.RowHeadersWidth = 62;
            this.dataGridViewCTHD.Size = new System.Drawing.Size(592, 461);
            this.dataGridViewCTHD.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkGiaTriHD);
            this.groupBox1.Controls.Add(this.chkMaNV);
            this.groupBox1.Controls.Add(this.chkNgay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGiaTriHD);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.dtmNgay);
            this.groupBox1.Controls.Add(this.btReset);
            this.groupBox1.Controls.Add(this.btFind);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(12, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Truy xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "VNĐ";
            // 
            // txtGiaTriHD
            // 
            this.txtGiaTriHD.Location = new System.Drawing.Point(244, 121);
            this.txtGiaTriHD.Name = "txtGiaTriHD";
            this.txtGiaTriHD.Size = new System.Drawing.Size(121, 41);
            this.txtGiaTriHD.TabIndex = 3;
            this.txtGiaTriHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTriHD_KeyPress);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(244, 80);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(121, 41);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // dtmNgay
            // 
            this.dtmNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgay.Location = new System.Drawing.Point(244, 40);
            this.dtmNgay.Name = "dtmNgay";
            this.dtmNgay.Size = new System.Drawing.Size(209, 41);
            this.dtmNgay.TabIndex = 1;
            // 
            // btFind
            // 
            this.btFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btFind.Location = new System.Drawing.Point(493, 66);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(112, 44);
            this.btFind.TabIndex = 0;
            this.btFind.Text = "Tìm";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label4.Location = new System.Drawing.Point(263, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bảng Hóa Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label5.Location = new System.Drawing.Point(885, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bảng Chi Tiết Hóa Đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(949, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotal.Location = new System.Drawing.Point(1013, 554);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 36);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "VNĐ";
            // 
            // CTHDColumnMaHoaDon
            // 
            this.CTHDColumnMaHoaDon.DataPropertyName = "MaHoaDon";
            this.CTHDColumnMaHoaDon.HeaderText = "Mã hóa đơn";
            this.CTHDColumnMaHoaDon.MinimumWidth = 8;
            this.CTHDColumnMaHoaDon.Name = "CTHDColumnMaHoaDon";
            this.CTHDColumnMaHoaDon.ReadOnly = true;
            // 
            // CTHDColumnTenMonAn
            // 
            this.CTHDColumnTenMonAn.DataPropertyName = "TenMonAn";
            this.CTHDColumnTenMonAn.HeaderText = "Tên món ăn";
            this.CTHDColumnTenMonAn.MinimumWidth = 8;
            this.CTHDColumnTenMonAn.Name = "CTHDColumnTenMonAn";
            this.CTHDColumnTenMonAn.ReadOnly = true;
            // 
            // CTHDColumnSoLuong
            // 
            this.CTHDColumnSoLuong.DataPropertyName = "SoLuong";
            this.CTHDColumnSoLuong.HeaderText = "Số lượng";
            this.CTHDColumnSoLuong.MinimumWidth = 8;
            this.CTHDColumnSoLuong.Name = "CTHDColumnSoLuong";
            this.CTHDColumnSoLuong.ReadOnly = true;
            // 
            // CTHDColumnGiaTien
            // 
            this.CTHDColumnGiaTien.DataPropertyName = "GiaTien";
            this.CTHDColumnGiaTien.HeaderText = "Giá tiền";
            this.CTHDColumnGiaTien.MinimumWidth = 8;
            this.CTHDColumnGiaTien.Name = "CTHDColumnGiaTien";
            this.CTHDColumnGiaTien.ReadOnly = true;
            // 
            // CTHDColumnDonViTinh
            // 
            this.CTHDColumnDonViTinh.DataPropertyName = "DonViTinh";
            this.CTHDColumnDonViTinh.HeaderText = "Đơn vị tính";
            this.CTHDColumnDonViTinh.MinimumWidth = 8;
            this.CTHDColumnDonViTinh.Name = "CTHDColumnDonViTinh";
            this.CTHDColumnDonViTinh.ReadOnly = true;
            // 
            // HDColumnMaHoaDon
            // 
            this.HDColumnMaHoaDon.DataPropertyName = "MaHoaDon";
            this.HDColumnMaHoaDon.HeaderText = "Mã hóa đơn";
            this.HDColumnMaHoaDon.MinimumWidth = 8;
            this.HDColumnMaHoaDon.Name = "HDColumnMaHoaDon";
            this.HDColumnMaHoaDon.ReadOnly = true;
            // 
            // HDColumnMaBan
            // 
            this.HDColumnMaBan.DataPropertyName = "MaBan";
            this.HDColumnMaBan.HeaderText = "Mã Bán";
            this.HDColumnMaBan.MinimumWidth = 8;
            this.HDColumnMaBan.Name = "HDColumnMaBan";
            this.HDColumnMaBan.ReadOnly = true;
            // 
            // HDColumnMaNhanVien
            // 
            this.HDColumnMaNhanVien.DataPropertyName = "MaNhanVien";
            this.HDColumnMaNhanVien.HeaderText = "Mã Nhân Viên";
            this.HDColumnMaNhanVien.MinimumWidth = 8;
            this.HDColumnMaNhanVien.Name = "HDColumnMaNhanVien";
            this.HDColumnMaNhanVien.ReadOnly = true;
            // 
            // HDColumnTongHoaDon
            // 
            this.HDColumnTongHoaDon.DataPropertyName = "TongHoaDon";
            this.HDColumnTongHoaDon.HeaderText = "Tổng hóa đơn";
            this.HDColumnTongHoaDon.MinimumWidth = 8;
            this.HDColumnTongHoaDon.Name = "HDColumnTongHoaDon";
            this.HDColumnTongHoaDon.ReadOnly = true;
            // 
            // HDColumnThoiGian
            // 
            this.HDColumnThoiGian.DataPropertyName = "ThoiGian";
            this.HDColumnThoiGian.HeaderText = "Thời Gian";
            this.HDColumnThoiGian.MinimumWidth = 8;
            this.HDColumnThoiGian.Name = "HDColumnThoiGian";
            this.HDColumnThoiGian.ReadOnly = true;
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btReset.Location = new System.Drawing.Point(493, 116);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(112, 44);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // chkNgay
            // 
            this.chkNgay.AutoSize = true;
            this.chkNgay.Location = new System.Drawing.Point(50, 41);
            this.chkNgay.Name = "chkNgay";
            this.chkNgay.Size = new System.Drawing.Size(111, 40);
            this.chkNgay.TabIndex = 6;
            this.chkNgay.Text = "Ngày";
            this.chkNgay.UseVisualStyleBackColor = true;
            // 
            // chkMaNV
            // 
            this.chkMaNV.AutoSize = true;
            this.chkMaNV.Location = new System.Drawing.Point(50, 82);
            this.chkMaNV.Name = "chkMaNV";
            this.chkMaNV.Size = new System.Drawing.Size(220, 40);
            this.chkMaNV.TabIndex = 6;
            this.chkMaNV.Text = "Mã nhân viên";
            this.chkMaNV.UseVisualStyleBackColor = true;
            // 
            // chkGiaTriHD
            // 
            this.chkGiaTriHD.AutoSize = true;
            this.chkGiaTriHD.Location = new System.Drawing.Point(50, 125);
            this.chkGiaTriHD.Name = "chkGiaTriHD";
            this.chkGiaTriHD.Size = new System.Drawing.Size(237, 40);
            this.chkGiaTriHD.TabIndex = 6;
            this.chkGiaTriHD.Text = "Giá trị hóa đơn";
            this.chkGiaTriHD.UseVisualStyleBackColor = true;
            // 
            // billForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCTHD);
            this.Controls.Add(this.dataGridViewHD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "billForm";
            this.Text = "billForm";
            this.Load += new System.EventHandler(this.billForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHD;
        private System.Windows.Forms.DataGridView dataGridViewCTHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGiaTriHD;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.DateTimePicker dtmNgay;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTHDColumnMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTHDColumnTenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTHDColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTHDColumnGiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTHDColumnDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDColumnMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDColumnMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDColumnMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDColumnTongHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDColumnThoiGian;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.CheckBox chkGiaTriHD;
        private System.Windows.Forms.CheckBox chkMaNV;
        private System.Windows.Forms.CheckBox chkNgay;
    }
}