using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    public class HinhTron
    {
        public double banKinh;

        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
        }

        public double duongKinh { get { return banKinh * 2; } }

    }
    public class PhanSo
    {
        public int tuSo;
        public int mauSo;
        public PhanSo(int tuSo,int mauSo)
        {
           this.tuSo= tuSo;
            this.mauSo= mauSo;
        }
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", tuSo, mauSo);
        }
    }
}
