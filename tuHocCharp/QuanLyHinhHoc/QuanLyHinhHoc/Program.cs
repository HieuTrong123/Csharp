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
            PhanSo a = new PhanSo(1, 2);
            a.Xuat();
            PhanSo b = a;
            b.tuSo = 100;
            b.Xuat();
            a.Xuat();

            Console.ReadKey();
        }
    }
}
