using System;

namespace chuyensonguyen
{
    public class ChuyenSoNguyen
    {
        private long m_soCanChuyen;
        private string m_ketQua;
        public long SoCanChuyen
        {
            get { return m_soCanChuyen; }
            set { m_soCanChuyen = value; }
        }
        public string KetQua
        {
            get { return m_ketQua; }
            set { m_ketQua = value; }
        }
        public ChuyenSoNguyen()
        {
            m_soCanChuyen = 0;
            m_ketQua = "";
        }
        public ChuyenSoNguyen(long soCanChuyen)
        {
            m_soCanChuyen = soCanChuyen;
            m_ketQua = "";
        }
    }
}
       