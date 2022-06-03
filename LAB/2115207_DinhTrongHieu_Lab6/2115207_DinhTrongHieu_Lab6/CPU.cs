using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_Lab6
{
    public class CPU : IThietBi
    {
        int gia;
        double tocDo;
        public double TocDo { get { return tocDo; } set { tocDo = value; } }
        public int Gia => gia;
        public CPU()
        {

        }
        public CPU(int g,double td)
        {
            this.gia = g;
            this.tocDo = td;
        }
        public override string ToString()
        {
            return String.Format("CPU gia={0}, tocdo={1}", gia, TocDo);
        }
    }
}
