using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Testez
{
    
    interface IHInhHoc
    {
        double ChuVi();
        double DienTich();

        

    }
    public class HCN : IHInhHoc
    {
        public double ChuVi()
        {
            throw new NotImplementedException();
        }

        public double DienTich()
        {
            throw new NotImplementedException();
        }
    }



    public abstract class HinhHoc
    {


        public int chieuDai;
        public int chieuRong;
        public HinhHoc()
        {
            WriteLine("loc den dui");

        }

    }
    public class HinhVuong : HinhHoc
    {
        public static int a;
        public HinhVuong(int chieuDai, int chieuRong) : base()
        {
            
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            WriteLine($"chieu dai cua chuoi la {this.chieuDai} \nchieu rong cua chuoi la {this.chieuRong}");
        }
    }
    public class ThoiGian
    {
        static ThoiGian()
        {
            DateTime dt = DateTime.Now;
            
            nam = dt.Year;
            thang = dt.Month;
            ngay = dt.Day;
            gio = dt.Hour;
            phut = dt.Minute;
            giay = dt.Second;
        }
        public static int nam;
        public static int thang;
        public static int ngay;
        public static int gio;
        public static int phut;
        public static int giay;
    }
    class Program
    {

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }
        static void Main(string[] args)
        {

            
            
            Console.WriteLine($"This Nam: {ThoiGian.nam.ToString()})");
            ThoiGian.nam = 2002;
            Console.WriteLine("This Nam: {0}",
            ThoiGian.nam.ToString());
            //Console.ForegroundColor = ConsoleColor.Blue;

            
            HinhVuong h = new HinhVuong(5, 5);
            
            //int a = 5, b = 6;
            //WriteLine($"a = {a},b={b}");
            //Swap(ref a,ref b);
            //WriteLine($"a = {a},b={b}");


            ReadKey();
        }
    }
}
