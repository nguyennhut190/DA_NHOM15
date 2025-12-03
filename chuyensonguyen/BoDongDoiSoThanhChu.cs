using chuyensonguyen;
using ChuyenSoNguyen;
using System;
using System.Collections.Generic;

public class BoDongDoiSoThanhChu
{
    private KiemTraNhap kiemTra = new KiemTraNhap();
    private ChiaNhomSo chiaNhom = new ChiaNhomSo();

    private TuDienViet tuDienViet = new TuDienViet();
    private DocNhomViet docViet = new DocNhomViet();

    private TuDienAnh tuDienAnh = new TuDienAnh();
    private DocNhomAnh docAnh = new DocNhomAnh();

    public string ChuyenTiengViet(string chuoiNhap)
    {
        if (!kiemTra.KiemTra(chuoiNhap))
            return "Đầu vào không hợp lệ";

        long so = kiemTra.SoNguyen;
        if (so == 0) return "Không";
        if (so < 0) return "Âm " + ChuyenTiengViet((-so).ToString());

        List<int> dsNhom = chiaNhom.Tach(so);
        string ketQua = "";
        int viTri = dsNhom.Count - 1;

        foreach (int nhom in dsNhom)
        {
            if (nhom > 0)
            {
                ketQua += docViet.Doc(nhom, tuDienViet) + " " + tuDienViet.DonVi[viTri] + " ";
            }
            viTri--;
        }

        ketQua = ketQua.Trim();
        return char.ToUpper(ketQua[0]) + ketQua.Substring(1);
    }

    public string ChuyenTiengAnh(string chuoiNhap)
    {
        if (!kiemTra.KiemTra(chuoiNhap))
            return "Invalid input";

        long so = kiemTra.SoNguyen;
        if (so == 0) return "Zero";
        if (so < 0) return "Minus " + ChuyenTiengAnh((-so).ToString());

        List<int> dsNhom = chiaNhom.Tach(so);
        string ketQua = "";
        int viTri = dsNhom.Count - 1;

        foreach (int nhom in dsNhom)
        {
            if (nhom > 0)
            {
                ketQua += docAnh.Doc(nhom, tuDienAnh) + " " + tuDienAnh.DonVi[viTri] + " ";
            }
            viTri--;
        }

        return ketQua.Trim();
    }
}
