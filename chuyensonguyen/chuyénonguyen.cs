using System;

namespace ChuyenSoNguyen
{
    /// <summary>
    /// Lớp lưu số nguyên cần chuyển và kết quả chuyển đổi sang chữ
    /// Hỗ trợ cả Tiếng Việt và Tiếng Anh
    /// </summary>
    public class ChuyenSoNguyen
    {
        // Biến lưu số nguyên cần chuyển
        private long m_soCanChuyen;

        // Biến lưu kết quả chuyển đổi sang Tiếng Việt
        private string m_ketQuaTiengViet;

        // Biến lưu kết quả chuyển đổi sang Tiếng Anh
        private string m_ketQuaTiengAnh;

        // Property để truy cập và gán số cần chuyển từ bên ngoài
        public long SoCanChuyen
        {
            get { return m_soCanChuyen; }
            set { m_soCanChuyen = value; }
        }

        // Property kết quả Tiếng Việt
        public string KetQuaTiengViet
        {
            get => m_ketQuaTiengViet;
            set => m_ketQuaTiengViet = value;
        }

        // Property kết quả Tiếng Anh
        public string KetQuaTiengAnh
        {
            get { return m_ketQuaTiengAnh; }
            set { m_ketQuaTiengAnh = value; }
        }
        /// Constructor mặc định, khởi tạo số = 0 và kết quả là chuỗi rỗng
        public ChuyenSoNguyen()
        {
            m_soCanChuyen = 0;
            m_ketQuaTiengViet = "";
            m_ketQuaTiengAnh = "";
        }

        
        public ChuyenSoNguyen(long soCanChuyen)
        {
            m_soCanChuyen = soCanChuyen;
            m_ketQuaTiengViet = "";
            m_ketQuaTiengAnh = "";
        }

        
        public void ChuyenTiengViet()
        {
            ChuyenDoi cd = new ChuyenDoi(); // Tạo đối tượng xử lý chuyển đổi
            m_ketQuaTiengViet = cd.ThucHienChuyenDoi(m_soCanChuyen); // Gọi phương thức chuyển đổi
        }

       
        public void ChuyenTiengAnh()
        {
            ChuyenDoi cd = new ChuyenDoi(); // Tạo đối tượng xử lý chuyển đổi
            m_ketQuaTiengAnh = cd.ThucHienChuyenDoiTiengAnh(m_soCanChuyen); // Gọi phương thức chuyển đổi
        }
    }
}
