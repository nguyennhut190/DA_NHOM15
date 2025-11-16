using System;

namespace ChuyenSoNguyen
{
    /// <summary>
    /// Lớp thực hiện chuyển đổi số nguyên sang chữ
    /// Hỗ trợ cả Tiếng Việt và Tiếng Anh
    /// </summary>
    public class ChuyenDoi
    {
        // Chữ số Tiếng Việt từ 0 → 9
        private string[] ChuSo = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

        // Đơn vị nhóm (nghìn, triệu, tỷ) Tiếng Việt
        private string[] DonVi = { "", "nghìn", "triệu", "tỷ" };

        // Chữ số Tiếng Anh từ 0 → 9
        private string[] ChuSoEn = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        // Đơn vị nhóm (Thousand, Million, Billion) Tiếng Anh
        private string[] DonViEn = { "", "Thousand", "Million", "Billion" };

        /// <summary>
        /// Chuyển số sang chữ Tiếng Việt
        /// </summary>
        public string ThucHienChuyenDoi(long number)
        {
            if (number == 0) return "Không"; // Số 0
            if (number < 0) return "Âm " + ThucHienChuyenDoi(-number); // Số âm

            string chuoi = number.ToString();
            int doDai = chuoi.Length;
            int viTriDonVi = 0; // Chỉ số nhóm (nghìn, triệu...)
            string ketQua = "";

            while (doDai > 0)
            {
                // Lấy nhóm 3 chữ số cuối
                int laySoBao = doDai >= 3 ? 3 : doDai;
                int viTriBatDau = doDai - laySoBao;
                int nhom = int.Parse(chuoi.Substring(viTriBatDau, laySoBao));

                // Cắt nhóm vừa lấy khỏi chuỗi
                chuoi = chuoi.Substring(0, viTriBatDau);
                doDai = chuoi.Length;

                if (nhom > 0)
                    ketQua = Doc3So(nhom, ChuSo) + " " + DonVi[viTriDonVi] + " " + ketQua;

                viTriDonVi++;
            }

            // Chuẩn hóa kết quả: xóa khoảng trắng thừa và viết hoa chữ cái đầu
            ketQua = ketQua.Trim();
            if (ketQua.Length > 0)
                ketQua = char.ToUpper(ketQua[0]) + ketQua.Substring(1);

            return ketQua;
        }

        /// <summary>
        /// Chuyển số sang chữ Tiếng Anh
        /// </summary>
        public string ThucHienChuyenDoiTiengAnh(long number)
        {
            if (number == 0) return "Zero";
            if (number < 0) return "Minus " + ThucHienChuyenDoiTiengAnh(-number);

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
                    ketQua = Doc3SoEn(nhom) + " " + DonViEn[viTriDonVi] + " " + ketQua;

                viTriDonVi++;
            }

            return ketQua.Trim();
        }

        /// <summary>
        /// Đọc nhóm 3 chữ số Tiếng Việt
        /// </summary>
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
                    ketQua += " lẻ"; // Ví dụ: 105 → "một trăm lẻ năm"
            }

            if (chuc > 1)
            {
                ketQua += " " + chu[chuc] + " mươi";
                if (donvi == 1) ketQua += " mốt";
                else if (donvi == 5) ketQua += " lăm";
                else if (donvi > 0) ketQua += " " + chu[donvi];
            }
            else if (chuc == 1)
            {
                ketQua += " mười";
                if (donvi == 5) ketQua += " lăm";
                else if (donvi > 0) ketQua += " " + chu[donvi];
            }
            else if (donvi > 0)
            {
                ketQua += " " + chu[donvi];
            }

            return ketQua.Trim();
        }

        /// <summary>
        /// Đọc nhóm 3 chữ số Tiếng Anh
        /// </summary>
        private string Doc3SoEn(int number)
        {
            string ketQua = "";
            int tram = number / 100;
            int chuc = (number % 100) / 10;
            int donvi = number % 10;

            if (tram > 0) ketQua = ChuSoEn[tram] + " Hundred";

            if (chuc > 1)
            {
                ketQua += (ketQua != "" ? " " : "") + ChuSoEn[chuc] + "ty";
                if (donvi > 0) ketQua += " " + ChuSoEn[donvi];
            }
            else if (chuc == 1)
            {
                string[] tu10Den19 = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                                       "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                ketQua += (ketQua != "" ? " " : "") + tu10Den19[donvi];
            }
            else if (donvi > 0)
            {
                ketQua += (ketQua != "" ? " " : "") + ChuSoEn[donvi];
            }

            return ketQua.Trim();
        }
    }
}
