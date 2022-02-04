using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DanhSachLienKetDon
{
    internal class Program
    {
        private struct SinhVien
        {
            public string maSV;
            public string hoTen;
            public string namSinh;
            public string lop;
            public string diem;
        }
        static void Main(string[] args)
        {
            XuLyMenu();

            Console.ReadKey();
        }
        static void XuatMotSinhVien(SinhVien sv)
        {

        }
        static void Menu()
        {
            Console.WriteLine("\n\n\t\t======MENU========");
            Console.WriteLine("0.ket thuc chuong trinh");
            Console.WriteLine("1.tao thong tin sinh vien tu file");
            Console.WriteLine("2.xem thong tin sinh vien");
            Console.WriteLine("3.xuat bang diem co day du xep loai sinh vien");
            Console.WriteLine("4.tim sinh vien co diem cao nhat");
            Console.WriteLine("5.xuat danh sach sinh vien co hoc luc cho truoc");
            Console.WriteLine("6.them mot sinh vien tai vi tri cho truoc");
            Console.WriteLine("7.xoa mot sinh vien tai vi tri cho truoc");
            Console.WriteLine("\n\n\t\t======MENU========");
        }
        static void NhapDanhSachSinhVien(SinhVien[] ds, ref int n)
        {
            String line = "";
            using (StreamReader sr = new StreamReader("Sinhvien.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    var sinhvien = line.Split(',');
                    ds[n].maSV = sinhvien[0];
                    ds[n].hoTen = sinhvien[1];
                    ds[n].namSinh = sinhvien[2];
                    ds[n].lop = sinhvien[3];
                    ds[n].diem = sinhvien[4];
                    n++;
                }
                Console.WriteLine("thanh cong");
            }
        }
        static void XuatMotSV(SinhVien sv)
        {
            Console.Write(':'+sv.maSV.PadRight(10));
            Console.Write(':' + sv.hoTen.PadRight(30));
            Console.Write(':' + sv.namSinh.PadRight(10));
            Console.Write(':' + sv.lop.PadRight(10));
            Console.Write(':' + sv.diem.PadRight(5));
            Console.Write(':');
        }
        static void XuatTieuDe()
        {
            XuatDongKe('=');
            Console.Write(':' + "ma sv".PadRight(10));
            Console.Write(':' + "ho ten".PadRight(30));
            Console.Write(':' + "nam sinh".PadRight(10));
            Console.Write(':' + "lop".PadRight(10));
            Console.Write(':' + "diem".PadRight(5));
            Console.Write(':');
            XuatDongKe('=');
        }
        static void XuatDongKe(char x)
        {
            Console.Write('\n');
            Console.Write(':');
            for (int i = 0; i < 69; i++)
            {
                Console.Write(x);
            }
            Console.Write(':');
            Console.Write('\n');
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
        static void XuLyMenu()
        {
            int luaChon;
            SinhVien[] ds = new SinhVien[100];
            int n = 0;
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
                    Console.ReadKey();
                }
                else if (luaChon == 4)
                {
                    Console.WriteLine("4.tim sinh vien co diem cao nhat");
                    Console.ReadKey();
                }
                else if (luaChon == 5)
                {
                    Console.WriteLine("5.xuat danh sach sinh vien co hoc luc cho truoc");
                    Console.ReadKey();
                }
                else if (luaChon == 6)
                {
                    Console.WriteLine("6.them mot sinh vien tai vi tri cho truoc");
                    Console.ReadKey();
                }
                else if (luaChon == 7)
                {
                    Console.WriteLine("7.xoa mot sinh vien tai vi tri cho truoc");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("lua chon khong ton tai hay nhap lai!");
                    Console.ReadKey();
                }
            }
        }
        static void NhapFile()
        {

        }
    }
}
