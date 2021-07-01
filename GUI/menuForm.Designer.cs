namespace GUI
{
    partial class menuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTDM = new System.Windows.Forms.TextBox();
            this.txtMDM = new System.Windows.Forms.TextBox();
            this.txtGC = new System.Windows.Forms.TextBox();
            this.txtTMA = new System.Windows.Forms.TextBox();
            this.txtMMA = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.btAddDM = new System.Windows.Forms.Button();
            this.btUpdateDM = new System.Windows.Forms.Button();
            this.btDeleteDM = new System.Windows.Forms.Button();
            this.btAddMA = new System.Windows.Forms.Button();
            this.btUpdateMA = new System.Windows.Forms.Button();
            this.btDeleteMA = new System.Windows.Forms.Button();
            this.dataGridViewDM = new System.Windows.Forms.DataGridView();
            this.ColumnMDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTD = new System.Windows.Forms.DataGridView();
            this.ColumnMMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAddDMz = new System.Windows.Forms.Button();
            this.btAddMAz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(91, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(679, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH THỰC ĐƠN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên danh mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(542, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã món ăn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(542, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên món ăn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(867, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Đơn vị tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(867, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Giá tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1123, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "VNĐ";
            // 
            // txtTDM
            // 
            this.txtTDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDM.Location = new System.Drawing.Point(184, 114);
            this.txtTDM.Name = "txtTDM";
            this.txtTDM.Size = new System.Drawing.Size(260, 30);
            this.txtTDM.TabIndex = 2;
            // 
            // txtMDM
            // 
            this.txtMDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMDM.Location = new System.Drawing.Point(184, 78);
            this.txtMDM.Name = "txtMDM";
            this.txtMDM.ReadOnly = true;
            this.txtMDM.Size = new System.Drawing.Size(260, 30);
            this.txtMDM.TabIndex = 2;
            // 
            // txtGC
            // 
            this.txtGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGC.Location = new System.Drawing.Point(184, 150);
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(260, 30);
            this.txtGC.TabIndex = 2;
            // 
            // txtTMA
            // 
            this.txtTMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTMA.Location = new System.Drawing.Point(658, 117);
            this.txtTMA.Name = "txtTMA";
            this.txtTMA.Size = new System.Drawing.Size(185, 30);
            this.txtTMA.TabIndex = 2;
            // 
            // txtMMA
            // 
            this.txtMMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMA.Location = new System.Drawing.Point(658, 77);
            this.txtMMA.Name = "txtMMA";
            this.txtMMA.ReadOnly = true;
            this.txtMMA.Size = new System.Drawing.Size(185, 30);
            this.txtMMA.TabIndex = 2;
            // 
            // txtGT
            // 
            this.txtGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGT.Location = new System.Drawing.Point(976, 114);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(141, 30);
            this.txtGT.TabIndex = 2;
            this.txtGT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGT_KeyPress);
            // 
            // txtDVT
            // 
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(976, 78);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(201, 30);
            this.txtDVT.TabIndex = 2;
            // 
            // btAddDM
            // 
            this.btAddDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddDM.Location = new System.Drawing.Point(34, 206);
            this.btAddDM.Name = "btAddDM";
            this.btAddDM.Size = new System.Drawing.Size(132, 43);
            this.btAddDM.TabIndex = 3;
            this.btAddDM.Text = "Thêm";
            this.btAddDM.UseVisualStyleBackColor = true;
            this.btAddDM.Click += new System.EventHandler(this.btAddDM_Click);
            // 
            // btUpdateDM
            // 
            this.btUpdateDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateDM.Location = new System.Drawing.Point(172, 206);
            this.btUpdateDM.Name = "btUpdateDM";
            this.btUpdateDM.Size = new System.Drawing.Size(132, 43);
            this.btUpdateDM.TabIndex = 3;
            this.btUpdateDM.Text = "Chỉnh sửa";
            this.btUpdateDM.UseVisualStyleBackColor = true;
            this.btUpdateDM.Click += new System.EventHandler(this.btUpdateDM_Click);
            // 
            // btDeleteDM
            // 
            this.btDeleteDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteDM.Location = new System.Drawing.Point(310, 206);
            this.btDeleteDM.Name = "btDeleteDM";
            this.btDeleteDM.Size = new System.Drawing.Size(132, 43);
            this.btDeleteDM.TabIndex = 3;
            this.btDeleteDM.Text = "Xóa";
            this.btDeleteDM.UseVisualStyleBackColor = true;
            this.btDeleteDM.Click += new System.EventHandler(this.btDeleteDM_Click);
            // 
            // btAddMA
            // 
            this.btAddMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddMA.Location = new System.Drawing.Point(638, 206);
            this.btAddMA.Name = "btAddMA";
            this.btAddMA.Size = new System.Drawing.Size(132, 43);
            this.btAddMA.TabIndex = 3;
            this.btAddMA.Text = "Thêm";
            this.btAddMA.UseVisualStyleBackColor = true;
            this.btAddMA.Click += new System.EventHandler(this.btAddMA_Click);
            // 
            // btUpdateMA
            // 
            this.btUpdateMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateMA.Location = new System.Drawing.Point(776, 206);
            this.btUpdateMA.Name = "btUpdateMA";
            this.btUpdateMA.Size = new System.Drawing.Size(132, 43);
            this.btUpdateMA.TabIndex = 3;
            this.btUpdateMA.Text = "Chỉnh sửa";
            this.btUpdateMA.UseVisualStyleBackColor = true;
            this.btUpdateMA.Click += new System.EventHandler(this.btUpdateMA_Click);
            // 
            // btDeleteMA
            // 
            this.btDeleteMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteMA.Location = new System.Drawing.Point(914, 206);
            this.btDeleteMA.Name = "btDeleteMA";
            this.btDeleteMA.Size = new System.Drawing.Size(132, 43);
            this.btDeleteMA.TabIndex = 3;
            this.btDeleteMA.Text = "Xóa";
            this.btDeleteMA.UseVisualStyleBackColor = true;
            this.btDeleteMA.Click += new System.EventHandler(this.btDeleteMA_Click);
            // 
            // dataGridViewDM
            // 
            this.dataGridViewDM.AllowUserToAddRows = false;
            this.dataGridViewDM.AllowUserToDeleteRows = false;
            this.dataGridViewDM.AllowUserToResizeRows = false;
            this.dataGridViewDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewDM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMDM,
            this.ColumnTDM,
            this.ColumnGC});
            this.dataGridViewDM.Location = new System.Drawing.Point(12, 281);
            this.dataGridViewDM.Name = "dataGridViewDM";
            this.dataGridViewDM.ReadOnly = true;
            this.dataGridViewDM.RowHeadersVisible = false;
            this.dataGridViewDM.RowHeadersWidth = 62;
            this.dataGridViewDM.RowTemplate.Height = 28;
            this.dataGridViewDM.Size = new System.Drawing.Size(482, 351);
            this.dataGridViewDM.TabIndex = 4;
            this.dataGridViewDM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDM_CellClick);
            // 
            // ColumnMDM
            // 
            this.ColumnMDM.DataPropertyName = "MaDanhMuc";
            this.ColumnMDM.HeaderText = "Mã Danh Mục";
            this.ColumnMDM.MinimumWidth = 8;
            this.ColumnMDM.Name = "ColumnMDM";
            this.ColumnMDM.ReadOnly = true;
            // 
            // ColumnTDM
            // 
            this.ColumnTDM.DataPropertyName = "TenDanhMuc";
            this.ColumnTDM.HeaderText = "Tên Danh Mục";
            this.ColumnTDM.MinimumWidth = 8;
            this.ColumnTDM.Name = "ColumnTDM";
            this.ColumnTDM.ReadOnly = true;
            // 
            // ColumnGC
            // 
            this.ColumnGC.DataPropertyName = "GhiChu";
            this.ColumnGC.HeaderText = "Ghi Chú";
            this.ColumnGC.MinimumWidth = 8;
            this.ColumnGC.Name = "ColumnGC";
            this.ColumnGC.ReadOnly = true;
            // 
            // dataGridViewTD
            // 
            this.dataGridViewTD.AllowUserToAddRows = false;
            this.dataGridViewTD.AllowUserToDeleteRows = false;
            this.dataGridViewTD.AllowUserToResizeRows = false;
            this.dataGridViewTD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMMA,
            this.ColumnTMA,
            this.ColumnGT,
            this.ColumnDVT,
            this.column,
            this.Column1});
            this.dataGridViewTD.Location = new System.Drawing.Point(547, 281);
            this.dataGridViewTD.Name = "dataGridViewTD";
            this.dataGridViewTD.ReadOnly = true;
            this.dataGridViewTD.RowHeadersVisible = false;
            this.dataGridViewTD.RowHeadersWidth = 62;
            this.dataGridViewTD.Size = new System.Drawing.Size(719, 351);
            this.dataGridViewTD.TabIndex = 4;
            this.dataGridViewTD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTD_CellClick);
            // 
            // ColumnMMA
            // 
            this.ColumnMMA.DataPropertyName = "MaMonAn";
            this.ColumnMMA.HeaderText = "Mã Món Ăn";
            this.ColumnMMA.MinimumWidth = 8;
            this.ColumnMMA.Name = "ColumnMMA";
            this.ColumnMMA.ReadOnly = true;
            // 
            // ColumnTMA
            // 
            this.ColumnTMA.DataPropertyName = "TenMonAn";
            this.ColumnTMA.HeaderText = "Tên Món Ăn";
            this.ColumnTMA.MinimumWidth = 8;
            this.ColumnTMA.Name = "ColumnTMA";
            this.ColumnTMA.ReadOnly = true;
            // 
            // ColumnGT
            // 
            this.ColumnGT.DataPropertyName = "GiaTien";
            this.ColumnGT.HeaderText = "Giá Tiền (VNĐ)";
            this.ColumnGT.MinimumWidth = 8;
            this.ColumnGT.Name = "ColumnGT";
            this.ColumnGT.ReadOnly = true;
            // 
            // ColumnDVT
            // 
            this.ColumnDVT.DataPropertyName = "DonViTinh";
            this.ColumnDVT.HeaderText = "Đơn Vị Tính";
            this.ColumnDVT.MinimumWidth = 8;
            this.ColumnDVT.Name = "ColumnDVT";
            this.ColumnDVT.ReadOnly = true;
            // 
            // column
            // 
            this.column.DataPropertyName = "TenDanhMuc";
            this.column.HeaderText = "Tên Danh Mục";
            this.column.MinimumWidth = 8;
            this.column.Name = "column";
            this.column.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDanhMuc";
            this.Column1.HeaderText = "Mã Danh Mục";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // btAddDMz
            // 
            this.btAddDMz.Location = new System.Drawing.Point(450, 75);
            this.btAddDMz.Name = "btAddDMz";
            this.btAddDMz.Size = new System.Drawing.Size(28, 28);
            this.btAddDMz.TabIndex = 5;
            this.btAddDMz.Text = "+";
            this.btAddDMz.UseVisualStyleBackColor = true;
            this.btAddDMz.Click += new System.EventHandler(this.btAddDMz_Click);
            // 
            // btAddMAz
            // 
            this.btAddMAz.Location = new System.Drawing.Point(1183, 75);
            this.btAddMAz.Name = "btAddMAz";
            this.btAddMAz.Size = new System.Drawing.Size(28, 28);
            this.btAddMAz.TabIndex = 5;
            this.btAddMAz.Text = "+";
            this.btAddMAz.UseVisualStyleBackColor = true;
            this.btAddMAz.Click += new System.EventHandler(this.btAddMAz_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.btAddMAz);
            this.Controls.Add(this.btAddDMz);
            this.Controls.Add(this.dataGridViewTD);
            this.Controls.Add(this.dataGridViewDM);
            this.Controls.Add(this.btDeleteMA);
            this.Controls.Add(this.btUpdateMA);
            this.Controls.Add(this.btDeleteDM);
            this.Controls.Add(this.btAddMA);
            this.Controls.Add(this.btUpdateDM);
            this.Controls.Add(this.btAddDM);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtMMA);
            this.Controls.Add(this.txtMDM);
            this.Controls.Add(this.txtGC);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.txtTMA);
            this.Controls.Add(this.txtTDM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "menuForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuForm";
            this.Load += new System.EventHandler(this.menuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTDM;
        private System.Windows.Forms.TextBox txtMDM;
        private System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.TextBox txtTMA;
        private System.Windows.Forms.TextBox txtMMA;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Button btAddDM;
        private System.Windows.Forms.Button btUpdateDM;
        private System.Windows.Forms.Button btDeleteDM;
        private System.Windows.Forms.Button btAddMA;
        private System.Windows.Forms.Button btUpdateMA;
        private System.Windows.Forms.Button btDeleteMA;
        private System.Windows.Forms.DataGridView dataGridViewDM;
        private System.Windows.Forms.DataGridView dataGridViewTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGC;
        private System.Windows.Forms.Button btAddDMz;
        private System.Windows.Forms.Button btAddMAz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}