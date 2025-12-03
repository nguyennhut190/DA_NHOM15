using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuyensonguyen
{
    public class DocNhomAnh
    {
        public string Doc(int nhom, TuDienAnh tuDien)
        {
            int tram = nhom / 100;
            int chuc = (nhom % 100) / 10;
            int donvi = nhom % 10;
            string ketQua = "";

            if (tram > 0) ketQua = tuDien.ChuSo[tram] + " Hundred";

            if (chuc > 1)
            {
                ketQua += (ketQua != "" ? " " : "") + tuDien.ChuSo[chuc] + "ty";
                if (donvi > 0) ketQua += " " + tuDien.ChuSo[donvi];
            }
            else if (chuc == 1)
            {
                ketQua += (ketQua != "" ? " " : "") + tuDien.Tu10Den19[donvi];
            }
            else if (donvi > 0)
            {
                ketQua += (ketQua != "" ? " " : "") + tuDien.ChuSo[donvi];
            }

            return ketQua.Trim();
        }
    }

}
