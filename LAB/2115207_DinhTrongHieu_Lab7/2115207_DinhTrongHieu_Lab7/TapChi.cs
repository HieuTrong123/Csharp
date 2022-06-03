using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_Lab7
{
    public class TapChi : IAnPham
    {
        public string diaChi;
        float giaTien;
        string nhaXuatBan;
        string ten;
        public float GiaTien { get { return giaTien; } set { giaTien = value; } }

        public string NhaXuatBan { get { return nhaXuatBan; } set { nhaXuatBan = value; } }

        public string Ten { get { return ten; } set { ten = value; } }
        public TapChi()
        {

        }
        public TapChi(string line)
        {
            string[] s = line.Split(',');
            Ten = s[1];
            NhaXuatBan = s[2];
            GiaTien = int.Parse(s[3]);
            diaChi = s[4];
        }
        public TapChi(string ten, string nhaXuatBan,float giaTien,string diaChi)
        {
            this.ten = ten;
            this.nhaXuatBan=nhaXuatBan;
            this.giaTien=giaTien;
            this.diaChi=diaChi;
        }
        public override string ToString()
        {
            return $"{this.Ten}".PadRight(30) + $"{this.NhaXuatBan}".PadRight(30) + $"{this.GiaTien}".PadRight(10) + $"{this.diaChi}".PadRight(10);
        }
    }
}
