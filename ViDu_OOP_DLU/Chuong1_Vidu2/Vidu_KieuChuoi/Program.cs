using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_KieuChuoi
{
    internal class Program
    {
        static void Main()
        {
            DateTime dateTime = new DateTime(2022, 12, 13);
            Console.WriteLine($"date time : {dateTime.Day} / {dateTime.Month} / {dateTime.Year}");
            //int, float/double, bool, char, string
            //string hoten =  "   Nguyen Tran Huong Thi Lan Huong  ";
            //string ho, tenlot, ten;
            //Console.WriteLine("Ho ten:\"{0}\"", hoten);
            //Console.WriteLine("Chieu dai chuoi: {0}", hoten.Length);
            //Console.WriteLine("Bo khoang trang dau va cuoi:\"{0}\"", hoten.Trim());
            //Console.WriteLine("Vi tri xuat hien chuoi \"Huong\" cuoi cung la {0}", 
            //    hoten.LastIndexOf("Huong"));
            //Console.WriteLine("Vi tri xuat hien chuoi \"Huong\" la {0}",
            //   hoten.IndexOf("Huong"));

            //hoten = hoten.Trim();
            //Console.WriteLine("Chuoi con [0..6]: {0}", hoten.Substring(0, 6));
            //int k = 0;
            //do
            //{
            //    Console.Write("\nMoi ban nhap Ho ten:");
            //    hoten = Console.ReadLine();

            //    ho = LayHoSubstring(hoten);
            //    Console.WriteLine("Ho cua ban la: {0}", ho);

            //    ten = LayTen(hoten);
            //    Console.WriteLine("Ten cua ban la: {0}", ten);
            //    k++;
            //}while(k<3);

            //cat theo ky tu
            /*string[] ss = hoten.Split(' ');
            for (int i = 0; i < ss.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, ss[i]);
            }
            */

            Console.ReadKey();
        }

        static string LayHo(string hoten)
        {
            string[]ss=hoten.Split(' ');
            return ss[0];
        }

        static string LayHoSubstring(string hoten)
        {
            int vt = hoten.Trim().IndexOf(' ');
            string ho = hoten.Substring(0, vt);
            return ho;
        }
        static string LayTen(string hoten)
        {
            string[] ss = hoten.Split(' ');
            int n = ss.Length;
            return ss[n-1];
        }
    }
}
