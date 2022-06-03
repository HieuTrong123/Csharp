using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_Lab5
{
    public abstract class HinhHoc
    {
        protected double canh;
        public double Canh { get { return canh; }}
        public HinhHoc(double canh)
        {
            this.canh = canh;
        }
        public abstract double TinhDT();
   
    }
    public class HinhVuong : HinhHoc
    {
        public HinhVuong(double canh) : base(canh) { }
        public override double TinhDT()
        {
            return this.Canh * this.Canh;
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return $"dien tich hinh vuong co canh: {this.Canh} la: {this.TinhDT()}";
        }
    }
    public class HinhTron : HinhHoc
    {
        public HinhTron(double bk) : base(bk)
        {

        }
        public override double TinhDT()
        {
            return (double)Math.Round(Math.PI * this.canh * this.canh, 2);
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            return String.Format("Hinh Tron bk={0}, S={1}", this.Canh, TinhDT());
        }
    }
    class HinhCN : HinhVuong
    {
        private float rong;
        public HinhCN(float rong, float dai) : base(dai)
        {
            this.rong = rong;
        }
        public override double TinhDT()
        {
            return this.rong * this.canh;
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return String.Format("Hinh chu nhat ({0}, {1}), s={2}", this.rong, this.canh, TinhDT());
        }
    }
    public class HinhTG : HinhHoc
    {
        double canhDay, canhBen1;
        double duongCao { get
            {
                double p=(this.canhDay+this.canhBen1+this.Canh)/2;
                return 2*Math.Sqrt((p*(p-this.Canh)*(p-this.canhDay)*(p-this.canhBen1)))/this.canhDay;
            } }
        public HinhTG(double canhDay, double canhBen1, double canhben2) : base(canhben2)
        {
            this.canhDay = canhDay;
            this.canhBen1 = canhBen1;
        }
        public override double TinhDT()
        {
            return (this.canhDay*this.duongCao)/2;
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return $"tam giac co canh 3 canh la : ({this.canhBen1},{this.Canh},{this.canhDay}) co dien tich la: {Math.Round(this.TinhDT(),2)}";
        }
    }

}
