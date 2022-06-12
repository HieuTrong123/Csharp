using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2115207_DinhTrongHieu_KiemTra2
{
    internal class DanhSachAnPham
    {
        public List<IAnPham> ds;
        public DanhSachAnPham()
        {
            ds = new List<IAnPham>();
        }
        public IAnPham this[int i]
        {
            get { return ds[i]; }
            set { ds[i] = value; }
        }
        void XuatTieuDe()
        {
            Console.WriteLine($"{"nha xuat ban".PadRight(20)} {"ten".PadRight(20)}  {"gia tien".PadRight(10)} {"so trang/dia chi".PadRight(20)}");
        }
        public override string ToString()
        {
            XuatTieuDe();
            string kq = "";
            foreach (IAnPham anPham in ds)
            {
                kq = kq + anPham + "\n";
            }
            return kq;
        }
        public void NhapTuFile()
        {
            try
            {
                StreamReader rd = new StreamReader("dsanpham.txt");
                string t = "";
                while ((t = rd.ReadLine()) != null)
                {
                    var temp = t.Trim().Split(',');
                    if (string.Compare(temp[0], "Tap chi") == 0)
                    {
                        ds.Add(new TapChi(temp[1], temp[2], float.Parse(temp[3]), temp[4]));
                    }
                    else
                    {
                        ds.Add(new Sach(temp[1], temp[2], float.Parse(temp[3]), int.Parse(temp[4])));
                    }
                }
                Console.WriteLine("nhap thanh cong!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public DanhSachAnPham DSAnPhamGiaMAX()
        {
            float giaMAX = ds.Max(e => e.GiaTien);
            DanhSachAnPham kq=new DanhSachAnPham();
            kq.ds = ds.FindAll(e => e.GiaTien == giaMAX);
            return kq;
        }
        public void SapXepTangTheoTen()
        {
            ds.Sort((e1, e2) =>
            {
                //if (string.Compare(e1.Ten, e2.Ten) > 0)
                //    return 1;
                //return -1;
                return e1.Ten.CompareTo(e2.Ten);
            });
        }
    }
}
