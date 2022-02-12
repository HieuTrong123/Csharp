using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DSLKDCSharp
{

    class QuanLySinhVien
    {
        public class SinhVien
        {
            public string maSV { get; set; }
            public string hoTen { get; set; }
            public int namSinh { get; set; }
            public string lop { get; set; }
            public double diem { get; set; }
            public string xepLoai { get; set; }

            
                        

        }

        public void NhapDanhSachSinhVien(List<SinhVien> ds)
        {
            String line = "";
            using (StreamReader sr = new StreamReader("sinhvien.txt"))
            {
               

                while ((line = sr.ReadLine()) != null)
                {
                    
                    var sinhvien = line.Split(',');
                    var sv = new SinhVien();
                    sv.maSV=(sinhvien[0]);
                    sv.hoTen = sinhvien[1];
                    sv.namSinh = int.Parse(sinhvien[2]);
                    sv.lop = sinhvien[3];
                    sv.diem = double.Parse(sinhvien[4]);
                    sv.xepLoai = "chua xet";
                    ds.Add(sv);
                }

                Console.WriteLine("thanh cong");
            }

        }
        public void XuatMotSV(SinhVien sv)
        {
            Console.Write(':' + sv.maSV.PadRight(10)
            +':' + sv.hoTen.PadRight(30)
            +':' + sv.namSinh.ToString().PadRight(10)
            +':' + sv.lop.PadRight(10)
            +':' + sv.diem.ToString().PadRight(5)
            +':' + sv.xepLoai.PadRight(10)
            +':');
        }
        public void XuatTieuDe()
        {
           
            XuatDongKe('=');
            Console.Write(':' + "ma sv".PadRight(10)
            + ':' + "ho ten".PadRight(30)
            + ':' + "nam sinh".PadRight(10)
            + ':' + "lop".PadRight(10)
            + ':' + "diem".PadRight(5)
            + ':' + "xep loai".PadRight(10)
            + ':');
           
            XuatDongKe('=');
        }
        public void XuatDongKe(char x)
        {
            Console.WriteLine();
            Console.Write(':');
            for (int i = 0; i < 80; i++)
            {
                Console.Write(x);
            }
            Console.Write(':');
            Console.Write('\n');
        }
        public void XuatDanhSach(List<SinhVien> ds)
        {
            XuatTieuDe();
            for (int i = 0; i < ds.Count; i++)
            {
                XuatMotSV(ds[i]);
                Console.Write("\n");
                if ((i + 1) % 5 == 0)
                {
                    XuatDongKe('-');
                   
                }
            }
            
            XuatDongKe('=');
        }
      public void XepLoai1SV(SinhVien sv)
        {
            if (sv.diem >= 8.5)
            {
                sv.xepLoai = string.Copy("xuat sac");
            }
            else if (sv.diem < 8.5 && sv.diem >= 6.5)
            {
                sv.xepLoai = String.Copy("kha");
            }
            else if (sv.diem < 6.5 && sv.diem >= 4.5)
            {
                sv.xepLoai = string.Copy("tbinh");
            }
            else if (sv.diem < 4.5 && sv.diem >= 3.5)
            {
                sv.xepLoai = string.Copy("yeu");
            }
            else
            {
                sv.xepLoai = string.Copy("kem");
            }
        }
        public SinhVien NhapSVTuBanPhim()
        {
            SinhVien sv=new SinhVien();
            Console.WriteLine("\nNhap ma so sinh vien");
            sv.maSV = Console.ReadLine();
            Console.WriteLine("\nNhap ho ten sinh vien");
            sv.hoTen = Console.ReadLine();
            Console.WriteLine("\nNhap lop sinh vien");
            sv.lop = Console.ReadLine();
            Console.WriteLine("\nNhap nam sinh sinh vien");
            sv.namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap diem sinh vien");
            sv.diem = double.Parse(Console.ReadLine());
            XepLoai1SV(sv);
            return sv;
        }
    }
}
