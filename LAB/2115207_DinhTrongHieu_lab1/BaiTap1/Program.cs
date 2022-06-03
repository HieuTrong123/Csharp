using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class Program
    {
        static void PTBacNhat(int a, int b)
        {
            float x;
            if (a == 0)
            {
                if (b != 0)
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
                else
                {
                    Console.WriteLine("phuong trinh vo so nghiem");
                }
            }
            else
            {
                x = -b / a;
                Console.WriteLine($"nghiem PT:{a}x + {b} = 0 la: {x} ");
            }
        }
        static int TinhTong(int n)
        {
            int kq = 0;
            for (int i = 1; i <= n; i++)
            {
                kq += i;

            }
            return kq;
        }
        static void Main(string[] args)
        {
            #region Test GTPB1: ax + b =0
            int a = 1, b;
            Console.Write("Nhap a:");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhap b:");
            b = int.Parse(Console.ReadLine());

            PTBacNhat(a, b);

            #endregion


            #region Test tinh tong: 1+2+...+n
            int n;
            Console.Write("Nhap n:");
            n = int.Parse(Console.ReadLine());

            Console.Write("Tong = 1+...+{0}={1}", n, TinhTong(n));

            #endregion

            Console.ReadKey();
        }
    }
}
