using chuyensonguyen;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ChuyenSoThanhChu
{
    public partial class Form1 : Form
    {
        xuly xuLy = new xuly();

        public Form1()
        {
            InitializeComponent();
            rdbTiengViet.Checked = true;
        }

        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtNhapSo.Text.Trim(), out long giaTri))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SoNguyen so = new SoNguyen(giaTri);

            if (rdbTiengViet.Checked)
                txtKetQua.Text = xuLy.ChuyenSangTiengViet(so);
            else
                txtKetQua.Text = xuLy.ChuyenSangTiengAnh(so);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapSo.Clear();
            txtKetQua.Clear();
            txtNhapSo.Focus();
        }
        List<string> danhSachLuu = new List<string>();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhapSo.Text) || string.IsNullOrWhiteSpace(txtKetQua.Text))
            {
                MessageBox.Show("Chưa có dữ liệu để lưu");
                return;
            }

            string dongLuu = txtNhapSo.Text + " → " + txtKetQua.Text;

            danhSachLuu.Add(dongLuu);
            lstDaLuu.Items.Add(dongLuu);
        }
        
        private void lstDaLuu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDaLuu.SelectedIndex >= 0)
            {
                txtKetQua.Text = lstDaLuu.SelectedItem.ToString();
            }
        }
        private void btnXoaLuu_Click(object sender, EventArgs e)
        {
            if (lstDaLuu.SelectedIndex >= 0)
            {
                lstDaLuu.Items.RemoveAt(lstDaLuu.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Chọn mục cần xóa!", "Thông báo");
            }
        }
    }
}