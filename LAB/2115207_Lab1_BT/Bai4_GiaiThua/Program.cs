using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_GiaiThua
{
    internal class Program
    {
        static int GiaiThua(int n)
        {
            if (n == 0) return 1;
            else
            {
                return n * GiaiThua(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n:");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine($"giai thua cua {n} la {GiaiThua(n)}");
            Console.ReadKey();
        }
    }
}
