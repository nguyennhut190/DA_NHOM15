using chuyensonguyen;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenSoThanhChu
{
    public class xuly
    {
        private tudientiengviet tuDienViet = new tudientiengviet();
        private tudientienganh tuDienAnh = new tudientienganh();
        // chuyen doi tieng viet
        public string ChuyenSangTiengViet(SoNguyen so)
        {
            if (so.GiaTri == 0) return "Không";
            if (so.GiaTri < 0)
                return "Âm " + ChuyenSangTiengViet(new SoNguyen(-so.GiaTri));

            List<int> nhom = TachNhom(so.GiaTri);
            string ketQua = "";
            int viTri = nhom.Count - 1;

            foreach (int n in nhom)
            {
                if (n > 0)
                    ketQua += DocNhomViet(n) + " " + tuDienViet.DonVi[viTri] + " ";
                viTri--;
            }

            return VietHoaChuCaiDau(ketQua.Trim());
        }

        //chuyen doi tieng anh
        public string ChuyenSangTiengAnh(SoNguyen so)
        {
            if (so.GiaTri == 0) return "Zero";
            if (so.GiaTri < 0)
                return "Minus " + ChuyenSangTiengAnh(new SoNguyen(-so.GiaTri));

            List<int> nhom = TachNhom(so.GiaTri);
            string ketQua = "";
            int viTri = nhom.Count - 1;

            foreach (int n in nhom)
            {
                if (n > 0)
                    ketQua += DocNhomAnh(n) + " " + tuDienAnh.DonVi[viTri] + " ";
                viTri--;
            }

            return VietHoaChuCaiDau(ketQua.Trim());
        }


        private List<int> TachNhom(long so)
        {
            List<int> ds = new List<int>();
            while (so > 0)
            {
                ds.Add((int)(so % 1000));
                so /= 1000;
            }
            ds.Reverse();
            return ds;
        }

        private string DocNhomViet(int n)
        {
            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int donVi = n % 10;
            string kq = "";

            if (tram > 0)
            {
                kq += tuDienViet.ChuSo[tram] + " trăm";
                if (chuc == 0 && donVi > 0) kq += " lẻ";
            }

            if (chuc > 1)
            {
                kq += " " + tuDienViet.ChuSo[chuc] + " mươi";
                if (donVi == 1) kq += " mốt";
                else if (donVi == 5) kq += " lăm";
                else if (donVi > 0) kq += " " + tuDienViet.ChuSo[donVi];
            }
            else if (chuc == 1)
            {
                kq += " mười";
                if (donVi > 0) kq += " " + tuDienViet.ChuSo[donVi];
            }
            else if (donVi > 0)
            {
                kq += " " + tuDienViet.ChuSo[donVi];
            }

            return kq.Trim();
        }

        private string DocNhomAnh(int n)
        {
            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int donVi = n % 10;
            string kq = "";

            if (tram > 0)
                kq += tuDienAnh.ChuSo[tram] + " hundred";

            if (chuc > 1)
            {
                kq += " " + tuDienAnh.ChuSo[chuc] + "ty";
                if (donVi > 0) kq += " " + tuDienAnh.ChuSo[donVi];
            }
            else if (chuc == 1)
            {
                kq += " " + tuDienAnh.Tu10Den19[donVi];
            }
            else if (donVi > 0)
            {
                kq += " " + tuDienAnh.ChuSo[donVi];
            }

            return kq.Trim();
        }

        private string VietHoaChuCaiDau(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
