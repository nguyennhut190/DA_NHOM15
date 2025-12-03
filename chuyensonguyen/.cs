using System;
using System.Windows.Forms;

namespace ChuyenSoNguyen
{
    public partial class Form1 : Form
    {
        private BoDongDoiSoThanhChu boChuyenDoi;

        public Form1()
        {
            InitializeComponent();
            boChuyenDoi = new BoDongDoiSoThanhChu();
            rdbViet.Checked = true; // Mặc định chọn Tiếng Việt
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string chuoiNhap = txtNumber.Text.Trim();

            if (!long.TryParse(chuoiNhap, out long so))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumber.Focus();
                return;
            }

            string ketQua = "";

            if (rdbViet.Checked && rdbAnh.Checked) // Trường hợp hiếm
            {
                string viet = boChuyenDoi.ChuyenTiengViet(chuoiNhap);
                string anh = boChuyenDoi.ChuyenTiengAnh(chuoiNhap);
                ketQua = $"Tiếng Việt: {viet}\r\nTiếng Anh: {anh}";
            }
            else if (rdbViet.Checked)
            {
                ketQua = boChuyenDoi.ChuyenTiengViet(chuoiNhap);
            }
            else if (rdbAnh.Checked)
            {
                ketQua = boChuyenDoi.ChuyenTiengAnh(chuoiNhap);
            }

            txtResult.Text = ketQua;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            txtResult.Clear();
            txtNumber.Focus();
        }

        private void lblExample_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ví dụ:\n" +
                "12345 → Mười hai nghìn ba trăm bốn mươi lăm\n" +
                "12345 → Twelve thousand three hundred forty-five",
                "Hướng dẫn",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
