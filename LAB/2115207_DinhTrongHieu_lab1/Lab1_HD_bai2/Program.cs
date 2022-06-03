using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_HD_bai2
{
    internal class Program
    {
        static int length = 0;
        //Khai bao mang 1 chieu so nguyen, toi da 100 phan tu
        static int[] a = new int[100];
        static void XoaPhanTuDauTien(int x)
        {
            XoaPhanTuTaiViTri(TimViTriDauTien(x));
        }
        static int TimViTriDauTien(int x)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i] == x) return i;
            }
            return -1;
        }
        static void XoaPhanTuTaiViTri(int vt)
        {
            for (int i = vt; i < length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            length--;
        }
        static void NhapNgauNghien()
        {
            Console.WriteLine("nhap vao so phan tu cua mang ");
            length = int.Parse(Console.ReadLine());
            Random rd = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = rd.Next(0, 20);
            }
        }
        static void Nhap()
        {
            Console.WriteLine("nhap vao so phan tu cua mang");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static int TinhTong()
        {
            int tong = 0;
            for (int i = 0; i < length; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        static void Xuat()
        {
            Console.WriteLine("mang vua nhap la");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("\t" + a[i]);
            }
        }
        static void Main(string[] args)
        {
            NhapNgauNghien();
            Xuat();
            Console.WriteLine("\nTong cac phan tu la: " + TinhTong());
            int y = 0;
            Console.Write("\nNhap vao phan tu can xoa: ");
            y = int.Parse(Console.ReadLine());
            int vt = TimViTriDauTien(y);
            Console.WriteLine("Vi tri cua {0} la {1} ", y, vt);
            XoaPhanTuDauTien(y);
            Console.WriteLine("Mang sau khi xoa {0} tai vi tri dau tien", y);
            Xuat();
            Console.ReadKey();
        }
    }
}
