using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_MangMotChieu
{
    public class QuanLyMangMotChieu
    {
        public void NhapTuDong(int[] a, int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(-20, 20);
            }


        }
        public void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i].ToString().PadRight(5));
            }
        }
        public int TimMax(int[] a, int n)
        {
            return a.Max();
        }
        public int DemX(int[] a, int n, int x)
        {
            int dem = 0;
            foreach (var i in a)
            {
                if (i == x)
                {
                    dem++;
                }
            }
            return dem;
        }
        public void ThayXBangY(int[] a, int n, int x, int y)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    a[i] = y;
                }
            }

        }
        void Swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b; b = tmp;
        }
        public void DaoNguocMang(int[] a, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                Swap(ref a[i], ref a[n - i - 1]);
            }
        }
        public void Xoa(int[] a, ref int n, int vt)
        {
            for (int i = vt + 1; i < n; i++)
            {
                a[i - 1] = a[i];
            }
            n--;
        }
        public void XoaX(int[] a, int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    Xoa(a, ref n, i);
                    i--;
                }
            }
        }
        public void SapXepTangDan(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        public void ChenX(int[] a, ref int n, int x, int vt)
        {
            for (int i = n - 1; i >= vt; i--)
            {
                a[i + 1] = a[i];
            }
            a[vt] = x;
            n++;
        }
        public bool KiemTra(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == 0 && a[i] == 1) return true;
            }
            return false;
        }
        public void SapXep0oDau(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > 0 && a[j] < 0 || a[i] > 0 && a[j] == 0 ||
                        a[i] < 0 && a[j] == 0 || a[i] > 0 && a[j] > 0 && a[i] > a[j] ||
                        a[i] < 0 && a[j] < 0 && a[i] < a[j])
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
    }

    public class Program
    {

        enum Menu
        {
            ketThuc, NhapMang, XuatMang, TimMax, DemX, thayXBangY, DaoNguoc, XoaAll, SapTang,
            SapXep0oDau, ChenX, KiemTraMang
        }






        static void Main(string[] args)
        {
            QuanLyMangMotChieu ql = new QuanLyMangMotChieu();
            int[] a = new int[100];
            int n = 0;
            int x;
            Menu luaChon;
            while (true)
            {
                Console.Clear();
                Console.Write("\n\n\t\t=========MENU=========\n");
                Console.Write($"\n{(int)Menu.ketThuc}.ket thuc chuong trinh");
                Console.Write($"\n{(int)Menu.NhapMang}.nhap mang");
                Console.Write($"\n{(int)Menu.XuatMang}.xuat mang");
                Console.Write($"\n{(int)Menu.TimMax}.tim phan tu lon nhat trong mang");
                Console.Write($"\n{(int)Menu.DemX}.dem so lan xuat hien cua x trong mang");
                Console.Write($"\n{(int)Menu.thayXBangY}.thay the phan tu x bang phan tu y trong mang");
                Console.Write($"\n{(int)Menu.DaoNguoc}.dao nguoc mang");
                Console.Write($"\n{(int)Menu.XoaAll}.xoa tat ca phan tu x trong mang");
                Console.Write($"\n{(int)Menu.SapTang}.sap tang cac phan tu trong mang");
                Console.Write($"\n{(int)Menu.SapXep0oDau}.sap cac phan tu sao cho so 0 o dau mang so am o giua giam dan va so duong o cuoi tang dan");
                Console.Write($"\n{(int)Menu.ChenX}.chen phan tu x vao mang tai 1 vi tri cho truoc");
                Console.Write($"\n{(int)Menu.KiemTraMang}.kiem tra mang co chua phan tu 0 va 1 hay khong");
                Console.Write("\n\n\t\t=========MENU=========\n");
                Console.WriteLine("\nNhap lua chon cua ban: ");
                luaChon = (Menu)int.Parse(Console.ReadLine());
                if (luaChon == Menu.ketThuc)
                {
                    break;
                }
                else if (luaChon == Menu.NhapMang)
                {
                    Console.Write("\n1.nhap mang");
                    Console.WriteLine("\nNhap so phan tu cua mang: ");
                    n = int.Parse(Console.ReadLine());
                    ql.NhapTuDong(a, n);
                    Console.ReadKey();
                }
                else if (luaChon == Menu.XuatMang)
                {

                    Console.WriteLine("\n2.xuat mang");
                    ql.XuatMang(a, n);
                    Console.ReadKey();
                }
                else if (luaChon == Menu.TimMax)
                {
                    Console.Write("\n3.tim phan tu lon nhat trong mang");
                    Console.WriteLine($"\ngia tri lon nhat cua mang la {ql.TimMax(a, n)}");
                    Console.ReadKey();
                }
                else if (luaChon == Menu.DemX)
                {
                    Console.Write("\n4.dem so lan xuat hien cua x trong mang");

                    Console.WriteLine("\nNhap gia tri cua x :");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine($"so lan xua hien cua {x} la: {ql.DemX(a, n, x)}");

                    Console.ReadKey();
                }
                else if (luaChon == Menu.thayXBangY)
                {
                    Console.Write("\n5.thay the phan tu x bang phan tu y trong mang");
                    int y;
                    Console.WriteLine("\nNhap gia tri cua x :");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nNhap gia tri cua y :");
                    y = int.Parse(Console.ReadLine());
                    ql.ThayXBangY(a, n, x, y);
                    Console.ReadKey();
                }
                else if (luaChon == Menu.DaoNguoc)
                {
                    Console.Write("\n6.dao nguoc mang");
                    Console.WriteLine("\nmang ban dau la:");
                    ql.XuatMang(a, n);
                    Console.WriteLine("\nmang sau khi dao la");
                    ql.DaoNguocMang(a, n);
                    ql.XuatMang(a, n);
                    Console.ReadKey();
                }
                else if (luaChon == Menu.XoaAll)
                {
                    Console.Write("\n7.xoa tat ca phan tu x trong mang");
                    Console.WriteLine("\nNhap gia tri cua x :");
                    x = int.Parse(Console.ReadLine());
                    ql.XoaX(a, n, x);
                    Console.WriteLine("\nMang sau khi xoa la: ");
                    ql.XuatMang(a, n);
                    Console.ReadKey();
                }
                else if (luaChon == Menu.SapTang)
                {
                    Console.Write("\n8.sap tang cac phan tu trong mang");
                    ql.SapXepTangDan(a, n);
                    Console.WriteLine("\ndanh sach sau khi sap xep la: ");
                    ql.XuatMang(a, n);
                    Console.ReadKey();
                }
                else if (luaChon == Menu.SapXep0oDau)
                {

                    Console.Write("\n9.sap cac phan tu sao cho so 0 o dau mang so am o giua giam dan va so duong o cuoi tang dan");
                    Console.WriteLine("mang ban dau la: ");
                    ql.XuatMang(a, n);
                    Console.WriteLine("\nmang luc sau khi sap xep la: ");
                    ql.SapXep0oDau(a, n);
                    ql.XuatMang(a, n);



                    Console.ReadKey();
                }
                else if (luaChon == Menu.ChenX)
                {
                    Console.Write("\n10.chen phan tu x vao mang tai 1 vi tri cho truoc");
                    int vt;
                    Console.WriteLine("\nNhap gia tri cua x :");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nNhap vt :");
                    vt = int.Parse(Console.ReadLine());
                    ql.ChenX(a, ref n, x, vt);
                    Console.ReadKey();
                }
                else if (luaChon == Menu.KiemTraMang)
                {
                    Console.Write("\n11.kiem tra mang co chua phan tu 0 va 1 hay khong");
                    Console.WriteLine($"\n{ql.KiemTra(a, n)}");

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nlua chon khong ton tai hay nhap lai");
                    Console.ReadKey();
                }
            }

        }
    }
}

