using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phanso a=new phanso();
            a.Xuat();
            phanso b = a;
            b.tu = 100;
            b.Xuat();
            a.Xuat();
            Console.ReadKey();
        }
    }
}
