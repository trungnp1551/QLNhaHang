namespace GUI
{
    partial class mainscreenForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainscreenForm));
            this.btServerForm = new System.Windows.Forms.Button();
            this.btMenuForm = new System.Windows.Forms.Button();
            this.btBill = new System.Windows.Forms.Button();
            this.btEmployeeForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btServerForm
            // 
            this.btServerForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServerForm.Location = new System.Drawing.Point(206, 420);
            this.btServerForm.Name = "btServerForm";
            this.btServerForm.Size = new System.Drawing.Size(389, 98);
            this.btServerForm.TabIndex = 0;
            this.btServerForm.Text = "Phục vụ khách hàng";
            this.btServerForm.UseVisualStyleBackColor = true;
            this.btServerForm.Click += new System.EventHandler(this.btServerForm_Click);
            // 
            // btMenuForm
            // 
            this.btMenuForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenuForm.Location = new System.Drawing.Point(663, 420);
            this.btMenuForm.Name = "btMenuForm";
            this.btMenuForm.Size = new System.Drawing.Size(389, 98);
            this.btMenuForm.TabIndex = 0;
            this.btMenuForm.Text = "Quản lý kho hàng";
            this.btMenuForm.UseVisualStyleBackColor = true;
            this.btMenuForm.Click += new System.EventHandler(this.btMenuForm_Click);
            // 
            // btBill
            // 
            this.btBill.Enabled = false;
            this.btBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBill.Location = new System.Drawing.Point(206, 534);
            this.btBill.Name = "btBill";
            this.btBill.Size = new System.Drawing.Size(389, 98);
            this.btBill.TabIndex = 0;
            this.btBill.Text = "Quản lý hóa đơn";
            this.btBill.UseVisualStyleBackColor = true;
            this.btBill.Click += new System.EventHandler(this.btBill_Click);
            // 
            // btEmployeeForm
            // 
            this.btEmployeeForm.Enabled = false;
            this.btEmployeeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployeeForm.Location = new System.Drawing.Point(663, 534);
            this.btEmployeeForm.Name = "btEmployeeForm";
            this.btEmployeeForm.Size = new System.Drawing.Size(389, 98);
            this.btEmployeeForm.TabIndex = 0;
            this.btEmployeeForm.Text = "Quản lý nhân viên";
            this.btEmployeeForm.UseVisualStyleBackColor = true;
            this.btEmployeeForm.Click += new System.EventHandler(this.btEmployeeForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 110);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quán Ăn Gia Đình";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 30);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // lblQuyen
            // 
            this.lblQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblQuyen.Location = new System.Drawing.Point(1018, 9);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(166, 30);
            this.lblQuyen.TabIndex = 3;
            this.lblQuyen.Text = "Mã nhân viên";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(12, 602);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(111, 30);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "Đăng xuất";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // mainscreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEmployeeForm);
            this.Controls.Add(this.btBill);
            this.Controls.Add(this.btMenuForm);
            this.Controls.Add(this.btServerForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "mainscreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainscreenForm_FormClosed);
            this.Load += new System.EventHandler(this.mainscreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btServerForm;
        private System.Windows.Forms.Button btMenuForm;
        private System.Windows.Forms.Button btBill;
        private System.Windows.Forms.Button btEmployeeForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btBack;
    }
}

