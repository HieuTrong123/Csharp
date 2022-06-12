using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_KiemTra2
{
    public class Sach : IAnPham
    {
        float giaTien;
        string nhaXuatBan;
        public int soTrang;
        string ten;
        public float GiaTien
        {
            get { return giaTien; }
            set { giaTien = value; }
        }
        public string NhaXuatBan {get { return nhaXuatBan; } set { nhaXuatBan = value;} }

        public string Ten { get { return ten; } set { ten = value; } }
        public Sach()
        {

        }
        public Sach(string t,string nhaXB,float giaTien,int soTrang)
        {
            this.Ten = t;
            this.NhaXuatBan=nhaXB;
            this.GiaTien = giaTien;
            this.soTrang = soTrang;
        }
        public override string ToString()
        {
            return $"{this.nhaXuatBan.PadRight(20)} {this.ten.PadRight(20)}  {this.giaTien.ToString().PadRight(10)} {this.soTrang.ToString().PadRight(20)}";
        }
    }
}
