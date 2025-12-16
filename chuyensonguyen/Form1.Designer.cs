namespace ChuyenSoThanhChu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhap = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.rdbTiengViet = new System.Windows.Forms.RadioButton();
            this.rdbTiengAnh = new System.Windows.Forms.RadioButton();
            this.btnChuyenDoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lstDaLuu = new System.Windows.Forms.ListBox();
            this.btnXoaLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(14, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(526, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHƯƠNG TRÌNH CHUYỂN SỐ THÀNH CHỮ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(34, 64);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(108, 16);
            this.lblNhap.TabIndex = 1;
            this.lblNhap.Text = "Nhập số nguyên:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(34, 192);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(55, 16);
            this.lblKetQua.TabIndex = 7;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(171, 61);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(285, 22);
            this.txtNhapSo.TabIndex = 2;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(34, 213);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetQua.Size = new System.Drawing.Size(479, 106);
            this.txtKetQua.TabIndex = 8;
            // 
            // rdbTiengViet
            // 
            this.rdbTiengViet.AutoSize = true;
            this.rdbTiengViet.Location = new System.Drawing.Point(171, 101);
            this.rdbTiengViet.Name = "rdbTiengViet";
            this.rdbTiengViet.Size = new System.Drawing.Size(89, 20);
            this.rdbTiengViet.TabIndex = 3;
            this.rdbTiengViet.TabStop = true;
            this.rdbTiengViet.Text = "Tiếng Việt";
            this.rdbTiengViet.UseVisualStyleBackColor = true;
            // 
            // rdbTiengAnh
            // 
            this.rdbTiengAnh.AutoSize = true;
            this.rdbTiengAnh.Location = new System.Drawing.Point(297, 101);
            this.rdbTiengAnh.Name = "rdbTiengAnh";
            this.rdbTiengAnh.Size = new System.Drawing.Size(89, 20);
            this.rdbTiengAnh.TabIndex = 4;
            this.rdbTiengAnh.TabStop = true;
            this.rdbTiengAnh.Text = "Tiếng Anh";
            this.rdbTiengAnh.UseVisualStyleBackColor = true;
            // 
            // btnChuyenDoi
            // 
            this.btnChuyenDoi.Location = new System.Drawing.Point(171, 139);
            this.btnChuyenDoi.Name = "btnChuyenDoi";
            this.btnChuyenDoi.Size = new System.Drawing.Size(114, 32);
            this.btnChuyenDoi.TabIndex = 5;
            this.btnChuyenDoi.Text = "Chuyển đổi";
            this.btnChuyenDoi.UseVisualStyleBackColor = true;
            this.btnChuyenDoi.Click += new System.EventHandler(this.btnChuyenDoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(343, 139);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 32);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(320, 344);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 30);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu kết quả";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lstDaLuu
            // 
            this.lstDaLuu.FormattingEnabled = true;
            this.lstDaLuu.ItemHeight = 16;
            this.lstDaLuu.Location = new System.Drawing.Point(37, 344);
            this.lstDaLuu.Name = "lstDaLuu";
            this.lstDaLuu.Size = new System.Drawing.Size(231, 180);
            this.lstDaLuu.TabIndex = 9;
            this.lstDaLuu.SelectedIndexChanged += new System.EventHandler(this.lstDaLuu_SelectedIndexChanged);
            // 
            // btnXoaLuu
            // 
            this.btnXoaLuu.Location = new System.Drawing.Point(320, 402);
            this.btnXoaLuu.Name = "btnXoaLuu";
            this.btnXoaLuu.Size = new System.Drawing.Size(150, 35);
            this.btnXoaLuu.TabIndex = 10;
            this.btnXoaLuu.Text = "Xóa đã lưu";
            this.btnXoaLuu.UseVisualStyleBackColor = true;
            this.btnXoaLuu.Click += new System.EventHandler(this.btnXoaLuu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 552);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lstDaLuu);
            this.Controls.Add(this.btnXoaLuu);
            this.Controls.Add(this.btnChuyenDoi);
            this.Controls.Add(this.rdbTiengAnh);
            this.Controls.Add(this.rdbTiengViet);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển số thành chữ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.RadioButton rdbTiengViet;
        private System.Windows.Forms.RadioButton rdbTiengAnh;
        private System.Windows.Forms.Button btnChuyenDoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ListBox lstDaLuu;
        private System.Windows.Forms.Button btnXoaLuu;
    }
}