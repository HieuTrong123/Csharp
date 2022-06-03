using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_QuanLyMayTinh
{
    class QuanLyMayTinh
    {
        List<MayTinh> dsMayTinh;
        #region Dong goi thuoc tinh
        public int Count
        {
            get { return this.dsMayTinh.Count; }
        }
        public MayTinh this[int index]
        {
            get { return this.dsMayTinh[index]; }
        }
        #endregion

        public QuanLyMayTinh()
        {
            this.dsMayTinh = new List<MayTinh>();
        }
        public void Them(MayTinh mt)
        {
            this.dsMayTinh.Add(mt);
        }

        public void NhapCD()
        {
            MayTinh mt = new MayTinh("MT02", new DateTime(2020, 10, 13), "Sony");
            mt.ThemTB(new CPU(100, 3.0f));
            mt.ThemTB(new Ram(30, 32));
            Them(mt);

            mt = new MayTinh("MT01", new DateTime(2021, 10, 5), "HP");
            mt.ThemTB(new CPU(200, 3.5f));
            mt.ThemTB(new CPU(500, 5.0f));
            mt.ThemTB(new Ram(30, 32));
            mt.ThemTB(new Ram(100, 128));
            mt.ThemTB(new Ram(50, 32));
            Them(mt);
        }
        public override string ToString()
        {
            string s = "Danh sach may tinh:\n";

            foreach (var mt in this.dsMayTinh)
                s += mt;
            return s;
        }
        public void SapGiamTheoGia()
        {
            for (int i = 0; i < this.Count-1; i++)
                for (int j = i+1; j < this.Count; j++)
                {
                    bool dk = this.dsMayTinh[i].Gia < this.dsMayTinh[j].Gia;
                    if (dk)
                    {
                        MayTinh t = dsMayTinh[i];
                        dsMayTinh[i] = dsMayTinh[j];
                        dsMayTinh[j] = t;
                    }
                }            
        }
    }
}
