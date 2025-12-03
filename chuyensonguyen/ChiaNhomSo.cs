using System.Collections.Generic;
namespace ChuyenSoNguyen
    {
   

    public class ChiaNhomSo
    {
        public List<int> Tach(long so)
        {
            List<int> dsNhom = new List<int>();
            if (so == 0)
            {
                dsNhom.Add(0);
                return dsNhom;
            }

            while (so > 0)
            {
                dsNhom.Add((int)(so % 1000));
                so /= 1000;
            }
            dsNhom.Reverse();
            return dsNhom;
        }
    }

}
