using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_QuanLyMayTinh
{
    class CPU : IThietBi
    {
        private int gia;
        private float tocdo;

        public int Gia
        {
            get { return gia; }
        }
        public float TocDo
        { 
            get { return tocdo; } 
            set { tocdo = value; }
        }
        public CPU()
        {

        }

        public CPU(int g, float td)
        {
            this.gia = g;
            this.TocDo = td;
        }
        public override string ToString()
        {
            return String.Format("CPU gia={0}, tocdo={1}", gia, TocDo);
        }
    }
}
