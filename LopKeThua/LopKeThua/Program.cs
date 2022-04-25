using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopKeThua
{
    public abstract class HinhHoc
    {

        protected int canh;
        public HinhHoc(int canh)
        {
            this.canh = canh;
        }
        public virtual double DienTich()
        {
            return 0;
        }

    }
    public class HinhVuong : HinhHoc
    {

        public HinhVuong(int canh) : base(canh)
        {

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
        public HinhTron(int bk) : base(bk)
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
            HinhVuong hv = new HinhVuong(4);
            //hh = new HinhCN(5, 6);
           
            hh = hv;
            
            if (hh is HinhCN)
                Console.WriteLine($"s1={hh.DienTich()}");
            else  if (hh is HinhVuong)
                    Console.WriteLine($"s2={hh.DienTich()}");

            Console.ReadKey();
        }
    }
}
