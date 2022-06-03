using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_QuanLyMayTinh
{
    class Ram : IThietBi
    {
        private int gia;
        private float dungluong;

        public int Gia
        {
            get { return gia; }
        }
        public float DungLuong
        {
            get { return dungluong; }
            set { dungluong = value; }
        }
        public Ram()
        {

        }

        public Ram(int g, float td)
        {
            this.gia = g;
            this.DungLuong = td;
        }
        public override string ToString()
        {
            return String.Format("Ram gia={0}, dung luong={1}", gia, DungLuong);
        }
    }
}