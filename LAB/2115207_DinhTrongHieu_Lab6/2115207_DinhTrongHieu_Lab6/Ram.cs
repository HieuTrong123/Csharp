using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_Lab6
{
    public class Ram : IThietBi
    {
        double dungLuong;
        int gia;
        public double DungLuong { get { return dungLuong; } set { dungLuong = value;} }
        public int Gia => gia;
        public Ram()
        {

        }
        public Ram(int g,double td) {
            this.gia = g;
            this.dungLuong = td;
        }
        public override string ToString()
        {
            return String.Format("Ram gia={0}, dung luong={1}", gia, DungLuong);
        }
    }
}
