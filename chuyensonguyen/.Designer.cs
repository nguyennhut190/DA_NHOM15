namespace ChuyenSoNguyen
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdbViet;
        private System.Windows.Forms.RadioButton rdbAnh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblExample = new System.Windows.Forms.Label();
            this.rdbViet = new System.Windows.Forms.RadioButton();
            this.rdbAnh = new System.Windows.Forms.RadioButton();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupInput.SuspendLayout();
            this.groupResult.SuspendLayout();
            this.SuspendLayout();

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblTitle.Location = new System.Drawing.Point(50, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐỌC SỐ THÀNH CHỮ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.groupInput.Controls.Add(this.txtNumber);
            this.groupInput.Controls.Add(this.lblExample);
            this.groupInput.Controls.Add(this.rdbViet);
            this.groupInput.Controls.Add(this.rdbAnh);
            this.groupInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupInput.Location = new System.Drawing.Point(30, 70);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(540, 130);
            this.groupInput.TabIndex = 1;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Nhập số và chọn ngôn ngữ";

            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNumber.Location = new System.Drawing.Point(20, 45);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(500, 39);
            this.txtNumber.TabIndex = 0;

            this.lblExample.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblExample.ForeColor = System.Drawing.Color.Gray;
            this.lblExample.Location = new System.Drawing.Point(20, 25);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(300, 20);
            this.lblExample.TabIndex = 1;
            this.lblExample.Text = "Ví dụ: 12345, 1000000, 999999...";
            this.lblExample.Click += new System.EventHandler(this.lblExample_Click);

            this.rdbViet.Checked = true;
            this.rdbViet.Location = new System.Drawing.Point(42, 90);
            this.rdbViet.Name = "rdbViet";
            this.rdbViet.Size = new System.Drawing.Size(177, 34);
            this.rdbViet.TabIndex = 2;
            this.rdbViet.TabStop = true;
            this.rdbViet.Text = "Tiếng Việt";

            this.rdbAnh.Location = new System.Drawing.Point(304, 90);
            this.rdbAnh.Name = "rdbAnh";
            this.rdbAnh.Size = new System.Drawing.Size(164, 34);
            this.rdbAnh.TabIndex = 3;
            this.rdbAnh.Text = "Tiếng Anh";

            this.groupResult.Controls.Add(this.txtResult);
            this.groupResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupResult.Location = new System.Drawing.Point(30, 234);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(540, 150);
            this.groupResult.TabIndex = 2;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Kết quả";

            this.txtResult.BackColor = System.Drawing.Color.FromArgb(240, 255, 240);
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtResult.ForeColor = System.Drawing.Color.FromArgb(0, 128, 0);
            this.txtResult.Location = new System.Drawing.Point(20, 44);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(500, 100);
            this.txtResult.TabIndex = 0;

            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(130, 390);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(160, 45);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Chuyển đổi";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(310, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 45);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đọc số thành chữ";
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
