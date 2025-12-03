using System;

namespace ChuyenSoNguyen
{
    public class KiemTraNhap
    {
        public long SoNguyen { get; private set; }

        public bool KiemTra(string chuoiNhap)
        {
            chuoiNhap = chuoiNhap.Trim();
            if (!long.TryParse(chuoiNhap, out long so))
                return false;

            SoNguyen = so;
            return true;
        }
    }

}
