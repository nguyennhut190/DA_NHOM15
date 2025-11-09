    namespace chuyensonguyen
    {
        partial class Form1
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                this.lblTitle = new System.Windows.Forms.Label();
                this.groupInput = new System.Windows.Forms.GroupBox();
                this.txtNumber = new System.Windows.Forms.TextBox();
                this.lblExample = new System.Windows.Forms.Label();
                this.groupResult = new System.Windows.Forms.GroupBox();
                this.txtResult = new System.Windows.Forms.TextBox();
                this.ChuyenDoi = new System.Windows.Forms.Button();
                this.btnClear = new System.Windows.Forms.Button();
                this.lblFooter = new System.Windows.Forms.Label();
                this.groupInput.SuspendLayout();
                this.groupResult.SuspendLayout();
                this.SuspendLayout();
                this.lblTitle.AutoSize = true;
                this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
                this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
                this.lblTitle.Location = new System.Drawing.Point(120, 20);
                this.lblTitle.Name = "lblTitle";
                this.lblTitle.Size = new System.Drawing.Size(321, 41);
                this.lblTitle.TabIndex = 0;
                this.lblTitle.Text = "ĐỌC SỐ THÀNH CHỮ";
                this.groupInput.Controls.Add(this.txtNumber);
                this.groupInput.Controls.Add(this.lblExample);
                this.groupInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                this.groupInput.Location = new System.Drawing.Point(30, 80);
                this.groupInput.Name = "groupInput";
                this.groupInput.Size = new System.Drawing.Size(540, 100);
                this.groupInput.TabIndex = 1;
                this.groupInput.TabStop = false;
                this.groupInput.Text = "Nhập số cần chuyển đổi";
                this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 14F);
                this.txtNumber.Location = new System.Drawing.Point(20, 50);
                this.txtNumber.Name = "txtNumber";
                this.txtNumber.Size = new System.Drawing.Size(500, 39);
                this.txtNumber.TabIndex = 0;
                this.lblExample.AutoSize = true;
                this.lblExample.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
                this.lblExample.ForeColor = System.Drawing.Color.Gray;
                this.lblExample.Location = new System.Drawing.Point(20, 25);
                this.lblExample.Name = "lblExample";
                this.lblExample.Size = new System.Drawing.Size(216, 20);
                this.lblExample.TabIndex = 1;
                this.lblExample.Text = "Ví dụ: 12345, 1000000, 999999...";
                this.lblExample.Click += new System.EventHandler(this.lblExample_Click); 
                this.groupResult.Controls.Add(this.txtResult);
                this.groupResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                this.groupResult.Location = new System.Drawing.Point(30, 260);
                this.groupResult.Name = "groupResult";
                this.groupResult.Size = new System.Drawing.Size(540, 150);
                this.groupResult.TabIndex = 2;
                this.groupResult.TabStop = false;
                this.groupResult.Text = "Kết quả"; 
                this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
                this.txtResult.Font = new System.Drawing.Font("Segoe UI", 12F);
                this.txtResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                this.txtResult.Location = new System.Drawing.Point(20, 30);
                this.txtResult.Multiline = true;
                this.txtResult.Name = "txtResult";
                this.txtResult.ReadOnly = true;
                this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                this.txtResult.Size = new System.Drawing.Size(500, 100);
                this.txtResult.TabIndex = 0;
                this.ChuyenDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
                this.ChuyenDoi.Cursor = System.Windows.Forms.Cursors.Hand;
                this.ChuyenDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ChuyenDoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
                this.ChuyenDoi.ForeColor = System.Drawing.Color.White;
                this.ChuyenDoi.Location = new System.Drawing.Point(130, 200);
                this.ChuyenDoi.Name = "ChuyenDoi";
                this.ChuyenDoi.Size = new System.Drawing.Size(160, 45);
                this.ChuyenDoi.TabIndex = 3;
                this.ChuyenDoi.Text = "Chuyển đổi";
                this.ChuyenDoi.UseVisualStyleBackColor = false;
                this.ChuyenDoi.Click += new System.EventHandler(this.btnConvert_Click);
                this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
                this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
                this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.btnClear.Location = new System.Drawing.Point(310, 200);
                this.btnClear.Name = "btnClear";
                this.btnClear.Size = new System.Drawing.Size(160, 45);
                this.btnClear.TabIndex = 4;
                this.btnClear.Text = "Xóa";
                this.btnClear.UseVisualStyleBackColor = false;
                this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
                this.lblFooter.Location = new System.Drawing.Point(0, 0);
                this.lblFooter.Name = "lblFooter";
                this.lblFooter.Size = new System.Drawing.Size(100, 23);
                this.lblFooter.TabIndex = 0;
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.White;
                this.ClientSize = new System.Drawing.Size(600, 470);
                this.Controls.Add(this.lblFooter);
                this.Controls.Add(this.btnClear);
                this.Controls.Add(this.ChuyenDoi);
                this.Controls.Add(this.groupResult);
                this.Controls.Add(this.groupInput);
                this.Controls.Add(this.lblTitle);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.Name = "Form1";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Đọc số thành chữ ";
                this.groupInput.ResumeLayout(false);
                this.groupInput.PerformLayout();
                this.groupResult.ResumeLayout(false);
                this.groupResult.PerformLayout();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.GroupBox groupInput;
            private System.Windows.Forms.TextBox txtNumber;
            private System.Windows.Forms.Label lblExample;
            private System.Windows.Forms.GroupBox groupResult;
            private System.Windows.Forms.TextBox txtResult;
            private System.Windows.Forms.Button ChuyenDoi;
            private System.Windows.Forms.Button btnClear;
            private System.Windows.Forms.Label lblFooter;
        }
    }