using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDung_Linq_InCsharrp
{
    public class SinhVien
    {
        public string maSo { get; set; }
        public string hoTen { get; set; }
        public int namSinh { get; set; }
        public string lop { get; set; }
        public double diem { get; set; }
        public string xepLoai
        {
            get
            {
                if (diem >= 9) return "xuat sac";
                else if (diem < 9 && diem >= 8.5) return "gioi";
                else if (diem >= 6.5 && diem < 8.5) return "kha";
                else if (diem >= 4.5 && diem < 6.5) return "trung binh";
                return "yeu";
            }
        }
        public string Ho
        {
            get
            {
                var kq = hoTen.Trim().Split(' ');
                return kq[0];
            }
        }
        public string Ten { get
            {
                var kq = hoTen.Trim().Split(' ');
                return kq[kq.Length - 1];
            } }
        public SinhVien(string maSo, string hoTen, int namSinh, string lop, double diem)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.lop = lop;
            this.diem = diem;

        }
    }
}
