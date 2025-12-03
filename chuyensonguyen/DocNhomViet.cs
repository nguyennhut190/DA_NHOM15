using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuyensonguyen
{
    public class DocNhomViet
    {
        public string Doc(int nhom, TuDienViet tuDien)
        {
            int tram = nhom / 100;
            int chuc = (nhom % 100) / 10;
            int donvi = nhom % 10;
            string ketQua = "";

            if (tram > 0)
            {
                ketQua = tuDien.ChuSo[tram] + " trăm";
                if (chuc == 0 && donvi > 0) ketQua += " lẻ";
            }

            if (chuc > 1)
            {
                ketQua += " " + tuDien.ChuSo[chuc] + " mươi";
                if (donvi == 1) ketQua += " mốt";
                else if (donvi == 5) ketQua += " lăm";
                else if (donvi > 0) ketQua += " " + tuDien.ChuSo[donvi];
            }
            else if (chuc == 1)
            {
                ketQua += " mười";
                if (donvi == 5) ketQua += " lăm";
                else if (donvi > 0) ketQua += " " + tuDien.ChuSo[donvi];
            }
            else if (donvi > 0)
            {
                ketQua += " " + tuDien.ChuSo[donvi];
            }

            return ketQua.Trim();
        }
    }

}
