namespace GUI
{
    partial class payForm
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
            this.rtxtGiaTien = new System.Windows.Forms.RichTextBox();
            this.rtxtMonAn = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTienTra = new System.Windows.Forms.TextBox();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.btXuatHoaDon = new System.Windows.Forms.Button();
            this.lblMaBan = new System.Windows.Forms.Label();
            this.rtxtSoLuong = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKTT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtGiaTien
            // 
            this.rtxtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtGiaTien.Location = new System.Drawing.Point(382, 118);
            this.rtxtGiaTien.Name = "rtxtGiaTien";
            this.rtxtGiaTien.ReadOnly = true;
            this.rtxtGiaTien.Size = new System.Drawing.Size(177, 318);
            this.rtxtGiaTien.TabIndex = 0;
            this.rtxtGiaTien.Text = "";
            // 
            // rtxtMonAn
            // 
            this.rtxtMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMonAn.Location = new System.Drawing.Point(12, 118);
            this.rtxtMonAn.Name = "rtxtMonAn";
            this.rtxtMonAn.ReadOnly = true;
            this.rtxtMonAn.Size = new System.Drawing.Size(268, 318);
            this.rtxtMonAn.TabIndex = 0;
            this.rtxtMonAn.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tiền trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tiền thừa";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(131, 452);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(170, 37);
            this.txtTongTien.TabIndex = 3;
            // 
            // txtTienTra
            // 
            this.txtTienTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienTra.Location = new System.Drawing.Point(130, 501);
            this.txtTienTra.Name = "txtTienTra";
            this.txtTienTra.Size = new System.Drawing.Size(170, 37);
            this.txtTienTra.TabIndex = 3;
            this.txtTienTra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTienTra_KeyDown);
            this.txtTienTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienTra_KeyPress);
            // 
            // txtTienThua
            // 
            this.txtTienThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThua.Location = new System.Drawing.Point(130, 558);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.ReadOnly = true;
            this.txtTienThua.Size = new System.Drawing.Size(170, 37);
            this.txtTienThua.TabIndex = 3;
            // 
            // btXuatHoaDon
            // 
            this.btXuatHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXuatHoaDon.Location = new System.Drawing.Point(349, 549);
            this.btXuatHoaDon.Name = "btXuatHoaDon";
            this.btXuatHoaDon.Size = new System.Drawing.Size(210, 46);
            this.btXuatHoaDon.TabIndex = 4;
            this.btXuatHoaDon.Text = "Xuất hóa đơn";
            this.btXuatHoaDon.UseVisualStyleBackColor = true;
            this.btXuatHoaDon.Click += new System.EventHandler(this.btXuatHoaDon_Click);
            // 
            // lblMaBan
            // 
            this.lblMaBan.AutoSize = true;
            this.lblMaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBan.Location = new System.Drawing.Point(204, 23);
            this.lblMaBan.Name = "lblMaBan";
            this.lblMaBan.Size = new System.Drawing.Size(170, 53);
            this.lblMaBan.TabIndex = 1;
            this.lblMaBan.Text = "Bàn 15";
            // 
            // rtxtSoLuong
            // 
            this.rtxtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSoLuong.Location = new System.Drawing.Point(286, 118);
            this.rtxtSoLuong.Name = "rtxtSoLuong";
            this.rtxtSoLuong.ReadOnly = true;
            this.rtxtSoLuong.Size = new System.Drawing.Size(88, 318);
            this.rtxtSoLuong.TabIndex = 0;
            this.rtxtSoLuong.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 36);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kiểu thanh toán:";
            // 
            // lblKTT
            // 
            this.lblKTT.AutoSize = true;
            this.lblKTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKTT.Location = new System.Drawing.Point(343, 488);
            this.lblKTT.Name = "lblKTT";
            this.lblKTT.Size = new System.Drawing.Size(128, 36);
            this.lblKTT.TabIndex = 1;
            this.lblKTT.Text = "Tiền mặt";
            // 
            // payForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 644);
            this.Controls.Add(this.btXuatHoaDon);
            this.Controls.Add(this.txtTienThua);
            this.Controls.Add(this.txtTienTra);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKTT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMaBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtSoLuong);
            this.Controls.Add(this.rtxtMonAn);
            this.Controls.Add(this.rtxtGiaTien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "payForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payForm";
            this.Load += new System.EventHandler(this.payForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtGiaTien;
        private System.Windows.Forms.RichTextBox rtxtMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTienTra;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.Button btXuatHoaDon;
        private System.Windows.Forms.Label lblMaBan;
        private System.Windows.Forms.RichTextBox rtxtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKTT;
    }
}