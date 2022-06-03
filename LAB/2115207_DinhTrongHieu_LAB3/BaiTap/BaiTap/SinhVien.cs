using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class SinhVien
    {
        public string maSo;
        private string hoTen;
        private double diemTB;
        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }
            set
            {
                ngaySinh = value;
            }
        }
        public double DiemTB
        {
            get { return diemTB; }
            set
            {
                if (value < 0)
                {
                    diemTB = 0;
                }
                else if (value > 10)
                {
                    diemTB = 10;
                }
                diemTB = value;
            }
        }
        public string Ho
        {
            get
            {
                var x = hoTen.Trim().Split(' ');
                return x[0];
            }
        }
        public string ten
        {
            get { var x = hoTen.Trim().Split(' '); return x[x.Length - 1]; }
        }
        public string HoTen
        {
            get
            {

                var x = ChuanHoa(hoTen);
                return x;

            }
            set { hoTen = value; }
        }
        public SinhVien()
        {

        }
        public SinhVien(string maSo, string hoTen, double diemTB, DateTime ngaySinh)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.diemTB = diemTB;
            this.ngaySinh = ngaySinh;

        }
        public override string ToString()
        {
            return $"ma so sinh vien la: {maSo}\nho ten sinh vien la: {this.HoTen} \nngay sinh sinh vien la: {this.NgaySinh}\ndiem trung binh sinh vien la: {this.DiemTB} ";
        }
        public void NhapThongTinSinhVien()
        {
            int day, month, year;
            Console.WriteLine("nhap ma so sinh vien:");
            maSo = Console.ReadLine();
            Console.WriteLine("nhap ho ten sinh vien:");
            hoTen = Console.ReadLine();
            Console.WriteLine("nhap ngay sinh cua sunh vien(year,month,day):");
            Console.WriteLine("day:");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("month:");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("year:");
            year = int.Parse(Console.ReadLine());
            ngaySinh = new DateTime(year, month, day);
            Console.WriteLine("nhap diem trung binh cua sinh vien:");
            diemTB = double.Parse(Console.ReadLine());
        }

        private string ChuanHoa(string hoTen)
        {
            string ketQua = "";
            var x = hoTen.Trim().Split(' ');
            foreach (var temp in x)
            {
                if (temp.Length > 1)
                {
                    var t = temp.ToUpper().Trim();
                    var y = t.Substring(1, t.Length - 1);
                    var z = t.Replace(y, y.ToLower());
                    ketQua += z + " ";
                }
                else 
                {
                    if(temp.Length != 0)
                    {
                        var z = temp.ToUpper();
                        ketQua += z + " ";
                    }
                   
                }
            }
            return ketQua.Trim();
        }
    }
}
