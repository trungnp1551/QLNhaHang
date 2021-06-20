namespace GUI
{
    partial class employeeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtmNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMatKhauDN = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.columnMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHoTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLuongThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.dtmNgayVaoLam);
            this.groupBox1.Controls.Add(this.dtmNgaySinh);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtHoTenNV);
            this.groupBox1.Controls.Add(this.txtMSNV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // dtmNgayVaoLam
            // 
            this.dtmNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgayVaoLam.Location = new System.Drawing.Point(244, 263);
            this.dtmNgayVaoLam.Name = "dtmNgayVaoLam";
            this.dtmNgayVaoLam.Size = new System.Drawing.Size(225, 37);
            this.dtmNgayVaoLam.TabIndex = 7;
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.CustomFormat = "";
            this.dtmNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmNgaySinh.Location = new System.Drawing.Point(244, 146);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(225, 37);
            this.dtmNgaySinh.TabIndex = 4;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(244, 302);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(225, 37);
            this.txtLuong.TabIndex = 8;
            this.txtLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuong_KeyPress);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(244, 224);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(225, 37);
            this.txtChucVu.TabIndex = 6;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(244, 185);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(225, 37);
            this.txtCMND.TabIndex = 5;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(244, 68);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(225, 37);
            this.txtHoTenNV.TabIndex = 2;
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(244, 29);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(225, 37);
            this.txtMSNV.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lương tháng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày vào làm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "CMND/CCCD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox2.Location = new System.Drawing.Point(12, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin liên lạc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(244, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 37);
            this.txtEmail.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(244, 64);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(225, 37);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(244, 26);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(225, 37);
            this.txtSDT.TabIndex = 9;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(575, 475);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(121, 45);
            this.btReset.TabIndex = 14;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(702, 475);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(121, 45);
            this.btAdd.TabIndex = 15;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(829, 475);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(121, 45);
            this.btUpdate.TabIndex = 16;
            this.btUpdate.Text = "Sửa";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(956, 476);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(121, 45);
            this.btDelete.TabIndex = 17;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.AllowUserToAddRows = false;
            this.dataGridViewNhanVien.AllowUserToDeleteRows = false;
            this.dataGridViewNhanVien.AllowUserToResizeRows = false;
            this.dataGridViewNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMaNhanVien,
            this.columnHoTenNhanVien,
            this.columnGioiTinh,
            this.columnNgaySinh,
            this.columnCMND,
            this.columnChucVu,
            this.columnNgayVaoLam,
            this.columnLuongThang,
            this.columnSoDienThoai,
            this.columnDiaChi,
            this.columnEmail,
            this.columnTenDangNhap,
            this.columnMatKhau});
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(512, 12);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.ReadOnly = true;
            this.dataGridViewNhanVien.RowHeadersVisible = false;
            this.dataGridViewNhanVien.RowHeadersWidth = 62;
            this.dataGridViewNhanVien.RowTemplate.Height = 28;
            this.dataGridViewNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(754, 422);
            this.dataGridViewNhanVien.TabIndex = 0;
            this.dataGridViewNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMatKhauDN);
            this.groupBox3.Controls.Add(this.txtTenDN);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox3.Location = new System.Drawing.Point(12, 526);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 106);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tài khoản hệ thống";
            // 
            // txtMatKhauDN
            // 
            this.txtMatKhauDN.Location = new System.Drawing.Point(244, 64);
            this.txtMatKhauDN.Name = "txtMatKhauDN";
            this.txtMatKhauDN.Size = new System.Drawing.Size(225, 37);
            this.txtMatKhauDN.TabIndex = 13;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(244, 30);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(225, 37);
            this.txtTenDN.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 30);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mật khẩu đăng nhập";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(251, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tài khoản đăng nhập";
            // 
            // columnMaNhanVien
            // 
            this.columnMaNhanVien.DataPropertyName = "MaNhanVien";
            this.columnMaNhanVien.HeaderText = "Mã nhân viên";
            this.columnMaNhanVien.MinimumWidth = 8;
            this.columnMaNhanVien.Name = "columnMaNhanVien";
            this.columnMaNhanVien.ReadOnly = true;
            this.columnMaNhanVien.Width = 153;
            // 
            // columnHoTenNhanVien
            // 
            this.columnHoTenNhanVien.DataPropertyName = "HoTenNhanVien";
            this.columnHoTenNhanVien.HeaderText = "Họ tên nhân viên";
            this.columnHoTenNhanVien.MinimumWidth = 8;
            this.columnHoTenNhanVien.Name = "columnHoTenNhanVien";
            this.columnHoTenNhanVien.ReadOnly = true;
            this.columnHoTenNhanVien.Width = 137;
            // 
            // columnGioiTinh
            // 
            this.columnGioiTinh.DataPropertyName = "GioiTinh";
            this.columnGioiTinh.HeaderText = "Giới tính";
            this.columnGioiTinh.MinimumWidth = 8;
            this.columnGioiTinh.Name = "columnGioiTinh";
            this.columnGioiTinh.ReadOnly = true;
            this.columnGioiTinh.Width = 78;
            // 
            // columnNgaySinh
            // 
            this.columnNgaySinh.DataPropertyName = "NgaySinh";
            this.columnNgaySinh.HeaderText = "Ngày sinh";
            this.columnNgaySinh.MinimumWidth = 8;
            this.columnNgaySinh.Name = "columnNgaySinh";
            this.columnNgaySinh.ReadOnly = true;
            this.columnNgaySinh.Width = 116;
            // 
            // columnCMND
            // 
            this.columnCMND.DataPropertyName = "CMND";
            this.columnCMND.HeaderText = "CMND";
            this.columnCMND.MinimumWidth = 8;
            this.columnCMND.Name = "columnCMND";
            this.columnCMND.ReadOnly = true;
            this.columnCMND.Width = 99;
            // 
            // columnChucVu
            // 
            this.columnChucVu.DataPropertyName = "ChucVu";
            this.columnChucVu.HeaderText = "Chức vụ";
            this.columnChucVu.MinimumWidth = 8;
            this.columnChucVu.Name = "columnChucVu";
            this.columnChucVu.ReadOnly = true;
            this.columnChucVu.Width = 104;
            // 
            // columnNgayVaoLam
            // 
            this.columnNgayVaoLam.DataPropertyName = "NgayVaoLam";
            this.columnNgayVaoLam.HeaderText = "Ngày vào làm";
            this.columnNgayVaoLam.MinimumWidth = 8;
            this.columnNgayVaoLam.Name = "columnNgayVaoLam";
            this.columnNgayVaoLam.ReadOnly = true;
            this.columnNgayVaoLam.Width = 117;
            // 
            // columnLuongThang
            // 
            this.columnLuongThang.DataPropertyName = "LuongThang";
            this.columnLuongThang.HeaderText = "Lương tháng";
            this.columnLuongThang.MinimumWidth = 8;
            this.columnLuongThang.Name = "columnLuongThang";
            this.columnLuongThang.ReadOnly = true;
            this.columnLuongThang.Width = 134;
            // 
            // columnSoDienThoai
            // 
            this.columnSoDienThoai.DataPropertyName = "SoDienThoai";
            this.columnSoDienThoai.HeaderText = "Số điện thoại";
            this.columnSoDienThoai.MinimumWidth = 8;
            this.columnSoDienThoai.Name = "columnSoDienThoai";
            this.columnSoDienThoai.ReadOnly = true;
            this.columnSoDienThoai.Width = 139;
            // 
            // columnDiaChi
            // 
            this.columnDiaChi.DataPropertyName = "DiaChi";
            this.columnDiaChi.HeaderText = "Địa chỉ";
            this.columnDiaChi.MinimumWidth = 8;
            this.columnDiaChi.Name = "columnDiaChi";
            this.columnDiaChi.ReadOnly = true;
            this.columnDiaChi.Width = 73;
            // 
            // columnEmail
            // 
            this.columnEmail.DataPropertyName = "Email";
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.MinimumWidth = 8;
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            this.columnEmail.Width = 90;
            // 
            // columnTenDangNhap
            // 
            this.columnTenDangNhap.DataPropertyName = "TenDangNhap";
            this.columnTenDangNhap.HeaderText = "Tên đăng nhập";
            this.columnTenDangNhap.MinimumWidth = 8;
            this.columnTenDangNhap.Name = "columnTenDangNhap";
            this.columnTenDangNhap.ReadOnly = true;
            this.columnTenDangNhap.Width = 154;
            // 
            // columnMatKhau
            // 
            this.columnMatKhau.DataPropertyName = "MatKhauDangNhap";
            this.columnMatKhau.HeaderText = "Mật khẩu";
            this.columnMatKhau.MinimumWidth = 8;
            this.columnMatKhau.Name = "columnMatKhau";
            this.columnMatKhau.ReadOnly = true;
            this.columnMatKhau.Width = 110;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(244, 107);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(225, 38);
            this.cbGioiTinh.TabIndex = 3;
            // 
            // employeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "employeeForm";
            this.Text = "employeeForm";
            this.Load += new System.EventHandler(this.employeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMatKhauDN;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHoTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLuongThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMatKhau;
        private System.Windows.Forms.ComboBox cbGioiTinh;
    }
}