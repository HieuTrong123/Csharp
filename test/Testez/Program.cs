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
    class PhanSo
    {
        public int tuSo;
        public int mauSo;
        public int this[int i]
        {
            set
            {
                if (i == 0)
                {
                    tuSo = value;
                }
                else if (i == 1)
                {
                    mauSo = value;
                }
            }
            get
            {
                switch (i)
                {
                    case 0: return tuSo;
                    case 1: return mauSo;
                }
                return 0;
            }
        }
        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        public override string ToString()
        {

            Console.WriteLine("da overide lai Tostring");
            return $"gia tri phan so la {tuSo}/{mauSo}";
        }
        public void Print()
        {
            Console.WriteLine($"gia tri phan so la {tuSo}/{mauSo}");
        }
        public static PhanSo operator - (PhanSo a,PhanSo b) => new PhanSo(b.tuSo+a.tuSo,a.mauSo +b.mauSo);
        
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
            //int b=5;
            //ref int a = ref b;
            //a = 6;
            //Console.WriteLine(b);
            Console.BackgroundColor=ConsoleColor.DarkMagenta;
            Console.ForegroundColor=ConsoleColor.Yellow;
            
            PhanSo a = new PhanSo(3, 4);
            PhanSo b=new PhanSo(5, 4);
            
            b[0] = 1;
            b[1] = 2;

            Console.WriteLine(a-b);
          //==================================================================
            //PhanSo a = new PhanSo(3, 4);
            //a[0] = 1;
            //a[1] = 2;
            //a.Print();
            //Console.WriteLine(a.ToString());
            //PhanSo b = new PhanSo(3, 5);
          //==================================================================

            //Console.WriteLine($"This Nam: {ThoiGian.nam.ToString()})");
            //ThoiGian.nam = 2002;
            //Console.WriteLine("This Nam: {0}",
            //ThoiGian.nam.ToString());
          //================================================================
            ////Console.ForegroundColor = ConsoleColor.Blue;


            //HinhVuong h = new HinhVuong(5, 5);

            //int a = 5, b = 6;
            //WriteLine($"a = {a},b={b}");
            //Swap(ref a,ref b);
            //WriteLine($"a = {a},b={b}");


            ReadKey();
        }
    }
}
