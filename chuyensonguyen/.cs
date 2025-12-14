using chuyensonguyen;
using System;
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
    }
}
