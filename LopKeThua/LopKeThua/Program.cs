using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LopKeThua
{
    public abstract class HinhHoc
    {

        public int canh;
      
        public virtual double DienTich()
        {
            return 0;
        }

    }
    public class HinhVuong : HinhHoc
    {
        public int temp;
        public HinhVuong(int canh) 
        {
            this.canh = canh;
        }
        public override double DienTich()
        {
            
            return this.canh * this.canh;
        }
    }
    public class HinhCN : HinhVuong
    {
        int rong;
        public HinhCN(int rong, int dai) : base(dai)
        {
            this.rong = rong;
        }
        public override double DienTich()
        {
            return this.rong * this.canh;
        }

    }
    public class HinhTron : HinhHoc
    {
        public HinhTron(int bk)
        {

        }
        public override double DienTich()
        {
            return Math.PI*this.canh*this.canh;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            HinhHoc hh = new HinhVuong(3);
            Console.WriteLine(hh.canh);
            HinhVuong hv = new HinhVuong(4);
            Console.WriteLine(hh.canh);
            hh = new HinhCN(5, 6);
            Console.WriteLine(hh.canh);

            Console.ReadKey();
        }
    }
}
