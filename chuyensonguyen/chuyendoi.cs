using System;

namespace chuyensonguyen
{
    public class chuyendoi
    {
        public string ThucHienChuyenDoi(long number)
        {
            if (number == 0)
                return "Không";

            if (number < 0)
                return "Âm " + ThucHienChuyenDoi(-number);

            string[] chu = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] donVi = { "", "nghìn", "triệu", "tỷ" };

            string chuoi = number.ToString();
            int doDai = chuoi.Length;
            int viTriDonVi = 0;
            string ketQua = "";

            while (doDai > 0)
            {
                int laySoBao = doDai >= 3 ? 3 : doDai;
                int viTriBatDau = doDai - laySoBao;
                int nhom = int.Parse(chuoi.Substring(viTriBatDau, laySoBao));

                chuoi = chuoi.Substring(0, viTriBatDau);
                doDai = chuoi.Length;

                if (nhom > 0)
                {
                    string docNhom = Doc3So(nhom, chu);
                    ketQua = docNhom + " " + donVi[viTriDonVi] + " " + ketQua;
                }

                viTriDonVi++;
            }

            ketQua = ketQua.Trim();
            if (ketQua.Length > 0)
                ketQua = char.ToUpper(ketQua[0]) + ketQua.Substring(1);

            return ketQua;
        }

        private string Doc3So(int number, string[] chu)
        {
            int tram = number / 100;
            int chuc = (number % 100) / 10;
            int donvi = number % 10;
            string ketQua = "";

            if (tram > 0)
            {
                ketQua = chu[tram] + " trăm";
                if (chuc == 0 && donvi > 0)
                    ketQua += " lẻ";
            }

            if (chuc > 1)
            {
                ketQua += " " + chu[chuc] + " mươi";
                if (donvi == 1)
                    ketQua += " mốt";
                else if (donvi == 5)
                    ketQua += " lăm";
                else if (donvi > 0)
                    ketQua += " " + chu[donvi];
            }
            else if (chuc == 1)
            {
                ketQua += " mười";
                if (donvi == 5)
                    ketQua += " lăm";
                else if (donvi > 0)
                    ketQua += " " + chu[donvi];
            }
            else if (donvi > 0)
            {
                ketQua += " " + chu[donvi];
            }

            return ketQua.Trim();
        }
    }
}
