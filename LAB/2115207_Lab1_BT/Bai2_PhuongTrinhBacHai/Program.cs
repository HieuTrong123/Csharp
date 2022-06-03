using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_PhuongTrinhBacHai
{
    internal class Program
    {
        static void GiaiPhuongTrinhBacHai(double a, double b, double c)
        {
            double delta, x;
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("\nPhuong trinh vo nghiem! ");
            }
            else if (delta == 0.0)
            {
                x = -b / (2 * a);
                Console.WriteLine("\nPhuong trinh co nghiem kep x = " + x);
            }
            else
            {
                Console.WriteLine("\nPhuong trinh co hai nghiem phan biet ");
                x = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.Write("x1 = " + x);
                x = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine(" va x2 = " + x);
            }

        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("nhap a: ");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("nhap b: ");
            b =double.Parse(Console.ReadLine());
            Console.WriteLine("nhap c: ");
            c =double.Parse(Console.ReadLine());
            GiaiPhuongTrinhBacHai(a, b, c);
            Console.ReadKey();
        }
    }
}
