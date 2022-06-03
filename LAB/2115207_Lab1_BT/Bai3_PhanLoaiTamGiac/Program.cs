using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_PhanLoaiTamGiac
{
    internal class Program
    {
        static int PhanLoaiTamgiac(double a, double b, double c)
        {
            int kq = 0;
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    kq = 1;
                }
                else
                {
                    if (a == b || b == c || c == a)
                    {
                        if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                        {
                            kq = 4;
                        }
                        else
                        {
                            kq = 2;

                        }
                    }
                    else
                    {

                        if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                        {
                            kq = 3;
                        }
                        else
                        {
                            kq = 5;
                        }
                    }
                }

            }
            return kq;
        }
        static void ThongBao(int LoaiTg, double a, double b, double c)
        {
            switch (LoaiTg)
            {
                case 0:
                    Console.WriteLine($"{a} +  ,  {b}  ,  {c} ,\nKhong phai 3 canh cua tam giac");
                    break;
                case 1:
                    Console.WriteLine($"{a}  ,  {b}  ,   {c}   ,  \nla do dai ba canh tam giac deu");
                    break;
                case 2:
                    Console.WriteLine($" {a}  ,  {b}  ,  {c} , \nla do dai 3 canh tam giac can");
                    break;
                case 3:
                    Console.WriteLine($" {a}  ,  {b}  ,  {c}  , \nla do dai 3 canh tam giac vuong");
                    break;
                case 4:
                    Console.WriteLine($" {a}  ,  {b}  ,  {c}  , \nla do dai 3 canh tam giac vuong can");
                    break;
                case 5:
                    Console.WriteLine($" {a}  ,  {b}  ,  {c}  , \nKhong phai 3 canh cua tam giac thuong");
                    break;


            }
        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("nhap do dai a:");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("nhap do dai b:");
            b =double.Parse(Console.ReadLine());
            Console.WriteLine("nhap do dai c:");
            c =double.Parse(Console.ReadLine());
            int ketQua=PhanLoaiTamgiac(a,b,c);
            ThongBao(ketQua, a, b, c);
            Console.ReadKey();
        }

    }
}
