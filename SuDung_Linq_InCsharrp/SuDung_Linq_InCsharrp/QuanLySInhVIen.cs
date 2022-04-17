using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SuDung_Linq_InCsharrp
{
    public class QuanLySInhVIen
    {
        public void TaoDS(List<SinhVien> ds)
        {
            try
            {
                using (var sr = new StreamReader("sinhvien.txt"))
                {
                    string temp;
                    while ((temp = sr.ReadLine()) != null)
                    {

                        var _temp = temp.Split(',');
                        var k = new SinhVien(_temp[0], _temp[1]
                            , int.Parse(_temp[2]), _temp[3], double.Parse(_temp[4]));
                        ds.Add(k);

                    }



                }
                Console.WriteLine("thanh cong!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("tao danh sach that bai!!!");
            }

        }
        public void XuatDongKe(char x)
        {
            Console.WriteLine();
            Console.Write(':');
            for (int i = 0; i < 69; i++)
            {
                Console.Write(x);
            }
            Console.Write(':');
            Console.WriteLine();
        }
        public void XuatTieuDe()
        {
            XuatDongKe('=');
            Console.WriteLine(':' + "ma so".PadRight(10) + ':' + "ho ten".PadRight(30) + ':' + "nam sinh".PadRight(8)
                + ':' + "lop".PadRight(6) + ':' + "diem TB".PadRight(6) + ':' + "xep loai".PadRight(8));
            XuatDongKe('=');
        }

        public void Xuat1SV(SinhVien sv)
        {


            Console.WriteLine(':' + sv.maSo.PadRight(10) + ':' + sv.hoTen.PadRight(30) + ':' + sv.namSinh.ToString().PadRight(8)
                + ':' + sv.lop.PadRight(6) + ':' + sv.diem.ToString().PadRight(6) + ':' + sv.xepLoai.PadRight(8));

        }
        public void XemDS(List<SinhVien> ds)
        {
            XuatTieuDe();
            foreach (SinhVien s in ds)
            {
                Xuat1SV(s);
            }
            XuatDongKe('=');
        }
        public double TimTBC(List<SinhVien> ds)
        {
            return ds.Average(p => p.diem);
        }
        public List<SinhVien> DanhSachTheoTen(List<SinhVien> ds, string ten)
        {
            var kq = from sv in ds where string.Compare(sv.Ten, ten) == 0 select sv;

            return kq.ToList();
        }
        public List<SinhVien> DSDTBMAX(List<SinhVien> ds)
        {
            var kq = from sv in ds where sv.diem == ds.Max(s => s.diem) select sv;
            return kq.ToList();
        }
        public List<SinhVien> DSSVTenX(List<SinhVien> ds, string hoTen)
        {
            var kq = from sv in ds where string.Compare(sv.hoTen, hoTen) == 0 select sv;

            return kq.ToList();
        }
        public List<SinhVien> SVKhongDat(List<SinhVien> ds)
        {
            var kq = from sv in ds where sv.diem < 5.5 select sv;
            return kq.ToList();
        }
        public List<SinhVien> SapTangTheoTen(List<SinhVien> ds)
        {
            var kq = from sv in ds orderby sv.Ten select sv;
            return kq.ToList();
        }
        public List<SinhVien> SapGiamTheoCDHoTen(List<SinhVien> ds)
        {
            var kq = from sv in ds orderby sv.hoTen.Length descending select sv;
            return kq.ToList();
        }
        public void SapGiamTheoDTB(List<SinhVien> ds)
        {

            ds.Sort((a1, a2) =>
            {
                if (a1.diem < a2.diem || a1.diem == a2.diem && string.Compare(a1.Ho, a2.Ho) < 0)
                    return 1;
                else
                    return -1;

            });

        }
    }
}
