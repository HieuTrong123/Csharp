using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_Lab7
{
    public class Bao : IAnPham
    {
        float giaTien;
        string nhaXuatBan;
        string ten;
        public float GiaTien { get { return giaTien; } set { giaTien = value; } }

        public string NhaXuatBan { get { return nhaXuatBan; } set { nhaXuatBan = value; } }

        public string Ten { get { return ten; } set { ten = value; } }
        public Bao()
        {

        }
        public Bao(string line)
        {
            string[] s = line.Split(',');
            Ten = s[1];
            NhaXuatBan = s[2];

            GiaTien = float.Parse(s[3]);
        }
        public Bao(string ten,string nhaXuatBan,float giaTien)
        {
            this.Ten = ten;
            this.NhaXuatBan=nhaXuatBan;
            this.GiaTien = giaTien;
        }
        public override string ToString()
        {
            return $"{this.Ten}".PadRight(30) + $"{this.nhaXuatBan}".PadRight(30) + $"{this.GiaTien}".PadRight(10);
        }
    }
}
