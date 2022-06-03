using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class QuanLySinhVien
    {
        public SinhVien[] ds;

        int n;
        public int SoSV
        {
            get { return n; }
            set { n = value; }
        }
        public double DiemTBMAX
        {
            get
            {
                double max = ds[0].DiemTB;
                for (int i = 1; i < SoSV; i++)
                {
                    if (ds[i].DiemTB > max)
                    {
                        max = ds[i].DiemTB;
                    }
                }
                return max;
            }
        }
        public void DanhSachDiemTBMAX()
        {
            XuatTieuDe();
            for (int i = 0; i < SoSV; i++)
            {
                if (ds[i].DiemTB == DiemTBMAX)
                {
                    XuatMotSinhVien(ds[i]);
                }
            }
            XuatDongKe('=');
        }
        public double DiemTBMIN
        {
            get
            {
                double min = ds[0].DiemTB;
                for (int i = 1; i < SoSV; i++)
                {
                    if (ds[i].DiemTB < min)
                    {
                        min = ds[i].DiemTB;
                    }
                }
                return min;
            }
        }
        public void DanhSachSVTenX(string tenX)
        {
            XuatTieuDe();
            for (int i = 0; i < SoSV; i++)
            {
                if (string.Compare(ds[i].ten, tenX) == 0)
                {
                    XuatMotSinhVien(ds[i]);
                }

            }
            XuatDongKe('=');
        }
        public void DanhSachSVKhongDat()
        {
            XuatTieuDe();
            for (int i = 0; i < SoSV; i++)
            {
                if (ds[i].DiemTB < 5.5)
                {
                    XuatMotSinhVien(ds[i]);
                }

            }
            XuatDongKe('=');
        }
        public void SapXepTheoTen()
        {
            int j;
            SinhVien x;
            for (int i = 1; i < SoSV; i++)
            {
                x = ds[i];
                for (j = i - 1; j >= 0 && string.Compare(ds[j].ten, x.ten) > 0; j--)
                {
                    ds[j + 1] = ds[j];
                }
                ds[j + 1] = x;
            }
        }

        public void SapXepTheoHo()
        {
            int j;
            SinhVien x;
            for (int i = 1; i < SoSV; i++)
            {
                x = ds[i];
                for (j = i - 1; j >= 0 && string.Compare(ds[j].Ho, x.Ho) < 0; j--)
                {
                    ds[j + 1] = ds[j];
                }
                ds[j + 1] = x;
            }
        }
        public void ChenSVTaiVT()
        {
            SinhVien newSV = new SinhVien();
            int vt;
            newSV.NhapThongTinSinhVien();
            Console.WriteLine("nhap vi tri can chen sinh vien: ");
            vt = int.Parse(Console.ReadLine());
            Chen(vt, newSV);
        }

        void Xoa(int vt)
        {
            for(int i = vt + 1; i < SoSV; i++)
            {
                ds[i - 1] = ds[i];
            }
            SoSV--;
        }
        void Chen(int vt,SinhVien newSV)
        {
            for(int i = SoSV - 1; i >= vt; i--)
            {
                ds[i + 1] = ds[i];
            }
            ds[vt] = newSV;
            SoSV++;
        }
        public void XoaSinhVienCoMaSo(string maSoSV)
        {
            for (int i = 0; i < SoSV; i++)
            {
                if(string.Compare(ds[i].maSo, maSoSV) == 0)
                {
                    Xoa(i);
                    i--;
                }
              
            }
        }
        public void XoaSinhVienDauTienCoTenX(string ten)
        {
            for (int i = 0; i < SoSV; i++)
            {
                if (string.Compare(ds[i].ten, ten) == 0)
                {
                    Xoa(i);
                    break;
                }

            }
        }
        public void XoaSinhVienALLCoTenX(string ten)
        {
            for (int i = 0; i < SoSV; i++)
            {

                if (string.Compare(ds[i].ten, ten) == 0)
                {
                    Xoa(i);
                    i--;
                }

            }
        }
        public void SapXepChieuDaiHoTen()
        {
            int j;
            SinhVien x;
            for (int i = 1; i < SoSV; i++)
            {
                x = ds[i];
                for (j = i - 1; j >= 0 && (ds[j].HoTen.Length < x.HoTen.Length); j--)
                {
                    ds[j + 1] = ds[j];
                }
                ds[j + 1] = x;
            }
        }

        public void NhapDanhSach()
        {
            int SoSV2;
            Console.WriteLine("nhap so luong sinh vien can them:");
            SoSV2 = int.Parse(Console.ReadLine());
            int n = this.SoSV + SoSV2;
            for (int i = this.SoSV; i < n; i++)
            {
                Console.WriteLine("nhap sinh vien thu : {0}",i+1);
                SinhVien newSV = new SinhVien();
                newSV.NhapThongTinSinhVien();
                ds[this.SoSV++] = newSV;

            }
        }

        public void ThemMotSinHVien()
        {

            SinhVien newSV = new SinhVien();
            newSV.NhapThongTinSinhVien();
            for (int i = 0; i < SoSV; i++)
            {
                if (string.Compare(newSV.maSo, ds[i].maSo) == 0)
                    while (string.Compare(newSV.maSo, ds[i].maSo) == 0)
                    {
                        Console.WriteLine("ma so bi trung voi sinh vien :");
                        XuatMotSinhVien(ds[i]);
                        Console.WriteLine("hay nhap lai: ");
                        newSV.maSo = Console.ReadLine();

                    }

            }
            ds[SoSV++] = newSV;

        }
        public void NhapDanhSachCoDinh()
        {

            ds[SoSV++] = new SinhVien("211548", "Nguyen Van Anh", 8.8, new DateTime(2002, 2, 19));
            ds[SoSV++] = new SinhVien("215479", "Nguyen Van Bao", 6.5, new DateTime(2003, 4, 19));
            ds[SoSV++] = new SinhVien("211549", "Nguyen Van Canh", 7.8, new DateTime(2002, 8, 1));
            ds[SoSV++] = new SinhVien("211550", "Nguyen Van Dung", 6.8, new DateTime(2003, 5, 5));
            ds[SoSV++] = new SinhVien("211551", "Nguyen  tran Van Anh ", 5.8, new DateTime(2003, 2, 12));
            ds[SoSV++] = new SinhVien("211552", "tran Van Bao", 8.8, new DateTime(2003, 12, 12));
            ds[SoSV++] = new SinhVien("211553", "Nguyen truong Van Bich", 3.8, new DateTime(2003, 11, 11));
            ds[SoSV++] = new SinhVien("211554", "Nguyen Van Anh", 5.8, new DateTime(2003, 1, 1));
            ds[SoSV++] = new SinhVien("211555", "Nguyen Van Nam", 2.8, new DateTime(2003, 11, 12));
            ds[SoSV++] = new SinhVien("211556", "Nguyen Van Anh", 10, new DateTime(2001, 9, 3));
            Console.WriteLine("da khoi tao 10 sinh vien vao danh sach!!");
        }
        public void DanhSachTheoTen(string hoTen)
        {
            Console.WriteLine("danh sach tim duoc la: ");
            XuatTieuDe();
            for (int i = 0;i < SoSV; i++)
            {
                if (string.Compare(ds[i].HoTen, hoTen) == 0)
                {
                    XuatMotSinhVien(ds[i]);
                    if ((i + 1) % 5 == 0)
                    {
                        XuatDongKe('-');
                    }
                }
            }

            XuatDongKe('=');
        }

        private void XuatDongKe(char x)
        {
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
                Console.Write(x);
            Console.WriteLine();
        }
        public void SapTheoDTBvaHoSinhVien()
        {
            
            int j;
            SinhVien x;

            for (int i = 1; i < SoSV; i++)
            {
                x = ds[i];
                for (j = i - 1; j >= 0&& (ds[j].DiemTB < x.DiemTB || ds[j].DiemTB == ds[i].DiemTB && string.Compare(ds[j].Ho, ds[i].Ho) < 0); j--)
                {
                    ds[j + 1] = ds[j];
                }
                ds[j + 1] = x;
            }
        }
        private void XuatTieuDe()
        {
            XuatDongKe('=');
            Console.WriteLine("ma so SV".PadRight(10) + "ho ten".PadRight(30) + "ngay Sinh".PadRight(20) + "diem TB".PadRight(10));
            XuatDongKe('=');
        }
        private void XuatMotSinhVien(SinhVien sv)
        {
            Console.WriteLine(sv.maSo.PadRight(10) + sv.HoTen.PadRight(30) + $"{sv.NgaySinh.Day}/{sv.NgaySinh.Month}/{sv.NgaySinh.Year}".PadRight(20) + sv.DiemTB.ToString().PadRight(10));
        }
        public void XuatDanhSach()
        {
            XuatTieuDe();
            for (int i = 0; i < SoSV; i++)
            {
                XuatMotSinhVien(ds[i]);
                if ((i + 1) % 5 == 0)
                {
                    XuatDongKe('-');
                }
            }
            XuatDongKe('=');
        }
        public double TinhDiemTrungBinhCong()
        {
            double tong = 0;
            int dem = 0;
            for (int i = 0; i < SoSV; i++)
            {
                tong += ds[i].DiemTB;
                dem++;
            }
            return tong / (double)dem;
        }
        public QuanLySinhVien()
        {
            
        }
        public QuanLySinhVien(string a)
        {
            this.ds = new SinhVien[100];
            this.n = 0;
            Console.WriteLine(a);
        }
    }
}
