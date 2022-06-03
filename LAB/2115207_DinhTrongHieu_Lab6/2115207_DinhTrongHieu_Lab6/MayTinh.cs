using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_Lab6
{
    public class MayTinh
    {
        private List<IThietBi> dsThietBi;
        string maso;
        DateTime ngaysx;
        string ten;
        #region Thuoc tinh
        public string Ten { get=>ten; set { ten = value; } }
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }

        public int NamSX
        {
            get { return this.ngaysx.Year; }
        }
        public int SoTB
        {
            get { return this.dsThietBi.Count; }
        }
        public IThietBi this[int index]
        {
            get { return this.dsThietBi[index]; }
            set { this.dsThietBi[index] = value; }
        }

        public int Gia
        {
            get { return this.TongGia(); }
        }
        #endregion
        #region Phuong thuc
        public MayTinh()
        {
            this.dsThietBi = new List<IThietBi>();
        }

        public MayTinh(string ms, DateTime ngay, string t)
        {
            this.dsThietBi = new List<IThietBi>();
            this.MaSo = ms;
            this.ngaysx = ngay;
            this.ten = t;
        }

        public MayTinh(string ms, DateTime ngay, string t, List<IThietBi> dstb)
        {
            this.dsThietBi = dstb;
            this.MaSo = ms;
            this.ngaysx = ngay;
            this.ten = t;
        }

        public void ThemTB(IThietBi tb)
        {
            this.dsThietBi.Add(tb);
        }

        //public void NhapCD()
        //{
        //    ThemTB(new CPU(200, 5.3f));
        //    ThemTB(new Ram(40, 16));
        //    ThemTB(new Ram(50, 32));

        //}

        public override string ToString()
        {
            string s = string.Format("\nMay tinh {0}\t{1}\t{2}\t{3}\n\tDanh sach thiet bi:", this.maso, this.ten, this.ngaysx, this.Gia);
            foreach (var tb in this.dsThietBi)
                s += "\n\t" + tb;
            return s;
        }

        private int TongGia()
        {
            int s = 0;
            foreach (var tb in this.dsThietBi)
            {
                s += tb.Gia;
            }
            return s;
        }
        #endregion
    }
}
