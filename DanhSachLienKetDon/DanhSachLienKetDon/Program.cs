using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace DanhSachLienKetDon
{
    internal class Program
    {
        private struct SinhVien
        {
            public string maSV;
            public string hoTen;
            public int namSinh;
            public string lop;
            public double diem;
            public string xepLoai;
        }
        static void Main(string[] args)
        {
            XuLyMenu();
            

            Console.ReadKey();
        }
      
        static void Menu()
        {
           
            WriteLine("\n\n\t\t======MENU========");
            Console.WriteLine("0.ket thuc chuong trinh");
            Console.WriteLine("1.tao thong tin sinh vien tu file");
            Console.WriteLine("2.xem thong tin sinh vien");
            Console.WriteLine("3.xuat bang diem co day du xep loai sinh vien");
            Console.WriteLine("4.tim sinh vien co diem cao nhat");
            Console.WriteLine("5.xuat danh sach sinh vien co hoc luc cho truoc va thuoc lop CTK39 ");
            Console.WriteLine("6.them mot sinh vien tai vi tri cho truoc");
            Console.WriteLine("7.xoa mot sinh vien tai vi tri cho truoc");          
            Console.WriteLine("8.sap xep theo lop");
            Console.WriteLine("\n\n\t\t======MENU========");
        }
        static void NhapDanhSachSinhVien(SinhVien[] ds, ref int n)
        {
            try
            {
                String line = "";
                using (StreamReader sr = new StreamReader("Sinhvien.txt"))
                {


                    while ((line = sr.ReadLine()) != null)
                    {

                        var sinhvien = line.Split(',');
                        ds[n].maSV = sinhvien[0];
                        ds[n].hoTen = sinhvien[1];
                        ds[n].namSinh = int.Parse(sinhvien[2]);
                        ds[n].lop = sinhvien[3];
                        ds[n].diem = double.Parse(sinhvien[4]);
                        ds[n].xepLoai = "";
                        n++;
                    }

                    Console.WriteLine("Thanh cong!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("that bai!!");
            }

            
        }
        static void XuatMotSV(SinhVien sv)
        {
            Console.Write('|'+sv.maSV.PadRight(10));
            Console.Write('|' + sv.hoTen.PadRight(30));
            Console.Write('|' + sv.namSinh.ToString().PadRight(10));
            Console.Write('|' + sv.lop.PadRight(10));
            Console.Write('|' + sv.diem.ToString().PadRight(5));
            Console.Write('|' + sv.xepLoai.PadRight(10));
            Console.Write('|');
        }
        static void XuatTieuDe()
        {
            XuatDongKe('=');
            Console.Write('|' + "ma sv".PadRight(10));
            Console.Write('|' + "ho ten".PadRight(30));
            Console.Write('|' + "nam sinh".PadRight(10));
            Console.Write('|' + "lop".PadRight(10));
            Console.Write('|' + "diem".PadRight(5));
            Console.Write('|' + "xep loai".PadRight(10));
            Console.Write('|');
           XuatDongKe('=');
        }
        static void XuatDongKe(char x)
        {
            Console.Write('\n');
            Console.Write('|');
            for (int i = 0; i < 80; i++)
            {
                Console.Write(x);
            }
            Console.Write('|');
            Console.Write('\n');
        }
        static void HoanVi(ref SinhVien a,ref SinhVien b)  
        {
            var temp = a;
            a = b;
            b = temp;
        }

        static void XuatDanhSach(SinhVien[] ds,int n)
        {
            XuatTieuDe();
            for (int i = 0; i < n; i++)
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
        static void XepLoai1SV(ref SinhVien sv)
        {
            if (sv.diem >= 8.5)
            {
                sv.xepLoai = string.Copy("xuat sac");
            }
            else if(sv.diem <8.5&&sv.diem >= 6.5)
            {
                sv.xepLoai = String.Copy("kha");
            }
            else if(sv.diem<6.5&&sv.diem >= 4.5)
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
        static void TimSVDiemCaoNhat(SinhVien[] ds,int n)
        {
            double max=ds[0].diem;
          
            for(int i = 1; i < n; i++)
            {
                if(ds[i].diem > max)
                {
                    max=ds[i].diem;
                }
            }
            XuatTieuDe();
            for(int i = 0; i < n; i++)
            {
                if (ds[i].diem == max)
                {
                    XuatMotSV(ds[i]);
                    Console.WriteLine();

                }
            }
            XuatDongKe('=');

           
        }
        static void TimKiemSinhVienLopCTK39CoHocLuc(SinhVien[] ds,int n,string hocLuc)
        {
            XuatTieuDe();
            for(int i = 0; i < n; i++)
            {
                if (string.Compare(ds[i].xepLoai, hocLuc) == 0 && string.Compare(ds[i].lop, "CTK39") == 0)
                {
                    XuatMotSV(ds[i]);
                    Console.WriteLine();
                }
            }
            XuatDongKe('=');
        }
        static void ThemSV(SinhVien[] ds,ref int n,SinhVien sv,int vt)
        {
            
            for(int i = n-1; i >= vt; i--)
            {
                ds[i + 1] = ds[i];
            }
            ds[vt] = sv;
            n++;
        }
        static void XoaSV(SinhVien[] ds,ref int n,int vt)
        {
            for(int i = vt + 1; i < n; i++)
            {
                ds[i-1]=ds[i];
            }
            n--;
        }
        static SinhVien NhapSVTuBanPhim(ref SinhVien sv)
        {
            Console.WriteLine("\nNhap ma so sinh vien");
            sv.maSV=Console.ReadLine();
            Console.WriteLine("\nNhap ho ten sinh vien");
            sv.hoTen = Console.ReadLine();
            Console.WriteLine("\nNhap lop sinh vien");
            sv.lop = Console.ReadLine();
            Console.WriteLine("\nNhap nam sinh sinh vien");
            sv.namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap diem sinh vien");
            sv.diem = double.Parse(Console.ReadLine());
            XepLoai1SV(ref sv);
            return sv;
        }
        static void SapXepTheoLop(SinhVien[] ds,int n)
        {
            for( int i = 0; i < n-1; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if (string.Compare(ds[i].lop, ds[j].lop) > 0)
                    {
                        HoanVi(ref ds[i],ref ds[j]);
                    }
                }
            }
        }
        static void XuLyMenu()
        {
            int luaChon;
            int vt;
            SinhVien[] ds = new SinhVien[100];
            int n = 0;
            string hocLuc;
            while (true)
            {
                Console.Clear();
                Menu();
                Console.WriteLine("\nNhap lua chon cua ban : ");
                luaChon = int.Parse(Console.ReadLine());
                if (luaChon == 0)
                {
                    break;
                }
                else if (luaChon == 1)
                {
                    Console.WriteLine("1.tao thong tin sinh vien tu file");
                    NhapDanhSachSinhVien(ds, ref n);
                    Console.ReadKey();
                }
                else if (luaChon == 2)
                {
                    Console.WriteLine("2.xem thong tin sinh vien");
                    XuatDanhSach(ds,n);
                    Console.ReadKey();
                }
                else if (luaChon == 3)
                {
                    Console.WriteLine("3.xuat bang diem co day du xep loai sinh vien");
                   for(int i = 0; i < n; i++)
                    {
                        XepLoai1SV(ref ds[i]);

                    }
                    XuatDanhSach(ds, n);

                    Console.ReadKey();
                }
                else if (luaChon == 4)
                {
                    Console.WriteLine("4.tim sinh vien co diem cao nhat");
                    TimSVDiemCaoNhat(ds, n);
                    Console.ReadKey();
                }
                else if (luaChon == 5)
                {
                    Console.WriteLine("5.xuat danh sach sinh vien co hoc luc cho truoc va thuoc lop CTK39 ");
                    Console.WriteLine("\nNhap hoc luc sinh vien: ");
                    hocLuc=Console.ReadLine();
                    TimKiemSinhVienLopCTK39CoHocLuc(ds, n, hocLuc);
                    
                    Console.ReadKey();
                }
                else if (luaChon == 6)
                {
                    Console.WriteLine("6.them mot sinh vien tai vi tri cho truoc");
                   
                   
                    SinhVien sv=new SinhVien();
                    Console.WriteLine("\nNhap vi tri can them: ");
                    vt = int.Parse(Console.ReadLine());
                    NhapSVTuBanPhim(ref sv);
                    ThemSV(ds,ref n,sv,vt);
                    Console.WriteLine("\nDanh sach sau khi them la: ");
                    XuatDanhSach(ds, n);
                    Console.ReadKey();
                }
                else if (luaChon == 7)
                {
                    Console.WriteLine("7.xoa mot sinh vien tai vi tri cho truoc");
                    Console.WriteLine("\nNhap vi tri can xoa: ");
                    vt = int.Parse(Console.ReadLine());
                    XoaSV(ds,ref n,vt);
                    Console.WriteLine("\nDanh sach sau khi xoa la: ");
                    XuatDanhSach(ds, n);
                    Console.ReadKey();
                }
                else if(luaChon == 8)
                {
                    Console.WriteLine("8.sap xep theo lop");
                   
                    Console.WriteLine("\nDanh Sach ban dau la : ");
                    XuatDanhSach(ds, n);
                    
                    SapXepTheoLop(ds, n);
                    Console.WriteLine("\ndanh sach sau khi sap xep la: ");
                    XuatDanhSach(ds, n);
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("lua chon khong ton tai hay nhap lai!");
                    Console.ReadKey();
                }
            }
        }
        
    }
}
