using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_KiemTra1
{
    internal class Program
    {
        enum Menu
        {
            Thoat,
            TaoDaySo,
            XuatDaySo,
            DemX,
            InCauTraLoiPBRefOut,
            SapDaySoTang,
            TimSoNTLonNhat,
            SapXepDayTheoTT
        }
        static void TaoDaySo(int[] a, int n)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(-20, 20);
            }
        }
        static void XuatDaySo(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]}\t");             
            }
            Console.WriteLine();
        }
        static int DemX(int[] a, int n, int x)
        {
            int dem = 0;
            int kq = 0;
            for(int i = 0; i < n; i++)
            {
                if(a[i] == x)
                {
                    kq = 1;
                    break;
                }
            }
            if(kq == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[i] == x)
                    {
                        dem++;
                    }
                }
            }
            else
            {
                Console.WriteLine("khong ton tai x trong mang");
            }
            


            return dem;
        }
        static void HoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void SapXepTangDan(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        HoanVi(ref a[i], ref a[j]);
                    }
                }
            }
        }
        static bool KiemTraSoNT(int n)
        {

            if (n < 2)
            {
                return false;
            }
            else
            {
                if (n == 2)
                {
                    return true;
                }
                else
                {
                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        static int TimSoNTLonNhat(int[] a, int n)
        {
            int max = 0;
            int kq = 0;
            for (int i = 0; i < n; i++)
            {
                if (KiemTraSoNT(a[i]) == true)
                {
                    max = a[i];
                    kq = 1;
                    break;
                }

            }
            if (kq != 0)
            {

                for (int j = 0; j < n; j++)
                {
                    if (max < a[j] && KiemTraSoNT(a[j]) == true)
                    {
                        max = a[j];
                    }
                }

            }
            else
            {
                Console.WriteLine("mang khong tin tai so nguyen to!!");
            }
            return max;
        }
        static void SapXepTheoTT(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > 0 && a[j] < 0 || a[i] > 0 && a[j] == 0 ||
                        a[i] < 0 && a[j] == 0 || a[i] > 0 && a[j] > 0 && a[i] < a[j] ||
                        a[i] < 0 && a[j] < 0 && a[i] > a[j])
                    {
                        HoanVi(ref a[i], ref a[j]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n=0;
            Menu luaChon;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t==============MENU==============");
                Console.WriteLine($"chon {(int)Menu.Thoat} de {Menu.Thoat}");
                Console.WriteLine($"chon {(int)Menu.TaoDaySo} de {Menu.TaoDaySo}");
                Console.WriteLine($"chon {(int)Menu.XuatDaySo} de {Menu.XuatDaySo}");
                Console.WriteLine($"chon {(int)Menu.DemX} de {Menu.DemX}");
                Console.WriteLine($"chon {(int)Menu.InCauTraLoiPBRefOut} de {Menu.InCauTraLoiPBRefOut}");
                Console.WriteLine($"chon {(int)Menu.SapDaySoTang} de {Menu.SapDaySoTang}");
                Console.WriteLine($"chon {(int)Menu.TimSoNTLonNhat} de {Menu.TimSoNTLonNhat}");
                Console.WriteLine($"chon {(int)Menu.SapXepDayTheoTT} de {Menu.SapXepDayTheoTT}");
                Console.WriteLine("\n\n\t\t==============MENU==============");
                Console.WriteLine("nhap lua chon cua ban: ");
                luaChon = (Menu)int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case Menu.Thoat:
                        return;

                    case Menu.TaoDaySo:
                        Console.WriteLine("nhap so phan tu cua mang: ");
                        n = int.Parse(Console.ReadLine());
                        TaoDaySo(a, n);
                        Console.WriteLine("mang da duoc tao!!");
                        Console.ReadKey();
                        break;
                    case Menu.XuatDaySo:
                        XuatDaySo(a, n);
                        Console.ReadKey();
                        break;
                    case Menu.DemX:
                        int x;
                        Console.WriteLine("mang la: ");
                        XuatDaySo(a, n);
                        Console.WriteLine("nhap x: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine($"so lan xuat hien cua {x} la {DemX(a, n, x)}");
                        Console.ReadKey();
                        break;
                    case Menu.InCauTraLoiPBRefOut:
                        Console.WriteLine("tu khoa ref phai duoc khoi tao gia tri truoc khi goi phuong thuc");
                        Console.WriteLine("tu khoa out phai duoc khoi tao gia tri ben trong phuong thuc");
                        Console.ReadKey();
                        break;
                    case Menu.SapDaySoTang:
                        Console.WriteLine("danh sach truoc khi sap xep la: ");
                        XuatDaySo(a, n);
                        Console.WriteLine("danh sach sau khi sap xep la: ");
                        SapXepTangDan(a, n);
                        XuatDaySo(a, n);
                        Console.ReadKey();
                        break;
                    case Menu.TimSoNTLonNhat:
                        Console.WriteLine("mang la: ");
                        XuatDaySo(a, n);
                        Console.WriteLine($"so nguyen to lon nhat trong mang la {TimSoNTLonNhat(a, n)}");
                        Console.ReadKey();
                        break;
                    case Menu.SapXepDayTheoTT:
                        Console.WriteLine("danh sach ban dau:");
                        XuatDaySo(a, n);
                        Console.WriteLine("danh sach sau khi sap xep la:");
                        SapXepTheoTT(a, n);

                        XuatDaySo(a, n);
                        Console.ReadKey();
                        break;
                }
            }



        }
    }
}
