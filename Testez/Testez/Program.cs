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
    class HCN : IHInhHoc
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
    public class HinhVuong:HinhHoc
    {
        public HinhVuong(int chieuDai,int chieuRong):base()
        {
            
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            WriteLine($"chieu dai cua chuoi la {this.chieuDai} \nchieu rong cua chuoi la {this.chieuRong}");
        }
    }
   
    class Program
    {

       static void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b= temp;

        }
        static void Main(string[] args)
        {
            
            
            
            //Console.ForegroundColor = ConsoleColor.Blue;
            
            
            //HinhVuong h = new HinhVuong(5, 5);
            //int a = 5, b = 6;
            //WriteLine($"a = {a},b={b}");
            //Swap(ref a,ref b);
            //WriteLine($"a = {a},b={b}");
           

            ReadKey();
        }
    }
}
