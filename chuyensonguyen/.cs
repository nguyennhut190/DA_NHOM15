using System;
using System.Windows.Forms;

namespace ChuyenSoNguyen
{
    public partial class Form1 : Form
    {
        // Tạo đối tượng để lưu số cần chuyển và kết quả
        private ChuyenSoNguyen csn;

        // Hàm khởi tạo Form
        public Form1()
        {
            InitializeComponent(); // Khởi tạo giao diện
            csn = new ChuyenSoNguyen(); // Khởi tạo đối tượng chuyển đổi
            rdbViet.Checked = true;     // Mặc định chọn Tiếng Việt
        }

        // Sự kiện khi nhấn nút "Chuyển đổi"
        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng nhập có phải là số nguyên hợp lệ không
            if (!long.TryParse(txtNumber.Text.Trim(), out long so))
            {
                MessageBox.Show(
                    "Vui lòng nhập một số nguyên hợp lệ!", // Thông báo lỗi
                    "Lỗi",                                   // Tiêu đề hộp thoại
                    MessageBoxButtons.OK,                     // Nút OK
                    MessageBoxIcon.Warning);                  // Icon cảnh báo
                txtNumber.Focus(); // Đặt con trỏ trở lại ô nhập số
                return;            // Dừng xử lý tiếp
            }

            // Gán số người dùng nhập cho đối tượng csn
            csn.SoCanChuyen = so;
            string ketQua = ""; // Biến lưu kết quả chuyển đổi

            // Nếu cả 2 radio đều được chọn (trường hợp cũ, hiện không dùng)
            if (rdbViet.Checked && rdbAnh.Checked)
            {
                csn.ChuyenTiengViet();   // Chuyển sang tiếng Việt
                csn.ChuyenTiengAnh();    // Chuyển sang tiếng Anh
                // Hiển thị kết quả cả hai ngôn ngữ
                ketQua = $"Tiếng Việt: {csn.KetQuaTiengViet}\r\nTiếng Anh: {csn.KetQuaTiengAnh}";
            }
            else if (rdbViet.Checked) // Nếu chọn Tiếng Việt
            {
                csn.ChuyenTiengViet();      // Chuyển sang tiếng Việt
                ketQua = csn.KetQuaTiengViet; // Lấy kết quả
            }
            else if (rdbAnh.Checked) // Nếu chọn Tiếng Anh
            {
                csn.ChuyenTiengAnh();        // Chuyển sang tiếng Anh
                ketQua = csn.KetQuaTiengAnh; // Lấy kết quả
            }

            // Hiển thị kết quả lên TextBox
            txtResult.Text = ketQua;
        }

        // Sự kiện khi nhấn nút "Xóa"
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Clear(); // Xóa nội dung ô nhập số
            txtResult.Clear(); // Xóa kết quả
            txtNumber.Focus(); // Đặt con trỏ trở lại ô nhập số
        }

        // Sự kiện khi click vào label "Ví dụ"
        private void lblExample_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại hướng dẫn ví dụ
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
