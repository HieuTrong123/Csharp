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
}
