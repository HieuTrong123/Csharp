using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_Lab7
{
    public class Sach : IAnPham
    {
        float giaTien;
        string nhaXuatBan;
        public int SoTrang;
        string ten;
        public float GiaTien { get { return giaTien; } set { giaTien = value; } }

        public string NhaXuatBan { get { return nhaXuatBan; } set { nhaXuatBan = value; } }

        public string Ten { get { return ten; } set { ten = value; } }
        public Sach()
        {

        }
        public Sach(string line)
        {
            string[] s = line.Split(',');
            Ten = s[1];
            NhaXuatBan = s[2];
            SoTrang = int.Parse(s[3]);
            GiaTien = float.Parse(s[4]);
        }
        public Sach(string ten ,string nhaXuatBan,float giaTien,int SoTrang)
        {
            this.ten = ten;
            this.NhaXuatBan=nhaXuatBan;
            this.giaTien = giaTien;
            this.SoTrang = SoTrang;
        }
        public override string ToString()
        {
            return $"{this.Ten}".PadRight(30) + $"{this.nhaXuatBan} ".PadRight(30) + $"{this.giaTien}".PadRight(10) + $"{this.SoTrang}".PadRight(10);
        }
    }
}
