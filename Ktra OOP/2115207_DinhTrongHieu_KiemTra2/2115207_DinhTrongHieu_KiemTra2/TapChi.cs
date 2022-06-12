using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_KiemTra2
{
    public class TapChi:IAnPham
    {
        public string DiaChi;
        float giaTien;
        string nhaXuatBan;
        string ten;
        public float GiaTien
        {
            get { return giaTien; }
            set { giaTien = value; }
        }
        public string NhaXuatBan { get { return nhaXuatBan; } set { nhaXuatBan = value; } }

        public string Ten { get { return ten; } set { ten = value; } }
        public TapChi()
        {

        }
        public TapChi(string t,string nhaXB,float giaTien,string diaChi)
        {
            this.DiaChi = diaChi;
            this.ten = t;
            this.NhaXuatBan= nhaXB;
            this.giaTien = giaTien;
        }
        public override string ToString()
        {
            return $"{this.nhaXuatBan.PadRight(20)} {this.ten.PadRight(20)}  {this.giaTien.ToString().PadRight(10)} {this.DiaChi.PadRight(20)}";
        }
    }
}
