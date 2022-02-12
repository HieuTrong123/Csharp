using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HinhTron a = new HinhTron(5);
            Console.WriteLine(a.duongKinh);
            a.banKinh = 10;
            Console.WriteLine(a.duongKinh);
            Console.ReadKey();
        }
    }
}
