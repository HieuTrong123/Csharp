using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TongHopQuanLy
{
    internal class QuanLySInhVien
    {
        public delegate void ChangeCollor();
        public event ChangeCollor cl = null;
        public void TaoDS(List<SinhVien> ds)
        {
            try
            {
                using (var sr = new StreamReader("Sinhvien.txt"))
                {
                    string temp;
                    while ((temp = sr.ReadLine()) != null)
                    {

                        var _temp = temp.Split(',');
                        var k = new SinhVien(_temp[0], _temp[1]
                            , int.Parse(_temp[2]), _temp[3], double.Parse(_temp[4]));
                        ds.Add(k);

                    }



                }
                Console.WriteLine("thanh cong!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("tao danh sach that bai!!!");
            }

        }
        public void XuatDongKe(char x)
        {
            Console.WriteLine();
            Console.Write(':');
            for (int i = 0; i < 69; i++)
            {
                Console.Write(x);
            }
            Console.Write(':');
            Console.WriteLine();
        }
        public void XuatTieuDe()
        {
            XuatDongKe('=');
            Console.WriteLine(':' + "ma so".PadRight(10) + ':' + "ho ten".PadRight(30) + ':' + "nam sinh".PadRight(8)
                + ':' + "lop".PadRight(6) + ':' + "diem TB".PadRight(6) + ':' + "xep loai".PadRight(8));
            XuatDongKe('=');
        }

        public void Xuat1SV(SinhVien sv)
        {

            cl?.Invoke();
            Console.WriteLine(':' + sv.maSo.PadRight(10) + ':' + sv.hoTen.PadRight(30) + ':' + sv.namSinh.ToString().PadRight(8)
                + ':' + sv.lop.PadRight(6) + ':' + sv.diem.ToString().PadRight(6) + ':' + sv.xepLoai.PadRight(8));
           
        }
        public void XemDS(List<SinhVien> ds)
        {
            XuatTieuDe();
            foreach (SinhVien s in ds)
            {
                Xuat1SV(s);
            }
            XuatDongKe('=');
        }
        public string NanTen1SV(SinhVien sv)
        {
            string m;
            string ketQua = "";
            var temp = sv.hoTen.Trim().Split(' ');
            foreach (var t in temp)
            {
                if (t != "")
                {
                    try
                    {
                        var l = t.Trim().ToUpper();
                        var k = l.Substring(1, l.Length - 1);
                        m = l.Replace(k, k.ToLower());
                        ketQua += m + ' ';

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }

            }
            return ketQua;
        }
        public void NanTenSinhVienCoMaSo(string maSo, List<SinhVien> ds)
        {
            foreach (SinhVien s in ds)
            {
                if (string.Compare(s.maSo, maSo) == 0)
                {
                    s.hoTen = NanTen1SV(s);
                }
            }
        }
        public void TimDiemTBMax(List<SinhVien> ds)
        {
            double max = ds[0].diem;
            foreach (SinhVien s in ds)
            {
                if (s.diem > max)
                {
                    max = s.diem;
                }

            }
            var temp = ds.FindAll(
                (e) =>
                {
                    return (e.diem == max);
                });
            Console.WriteLine($"danh sach hoc sinh co diem max {max} la:");
            XuatTieuDe();
            foreach (SinhVien s in temp)
            {
                Xuat1SV(s);
            }
            XuatDongKe('=');
        }
        public void _ChangeColor(List<SinhVien> ds)
        {
            Console.WriteLine("danh sach sau do la: ");
            XuatTieuDe();
            foreach (SinhVien s in ds)
            {
                if (string.Compare(s.xepLoai, "yeu") == 0)
                {
                    cl += () =>
                      {
                          Console.ForegroundColor = ConsoleColor.DarkRed;
                      };
                    
                }
                else if(string.Compare(s.xepLoai, "trung binh") == 0)
                {
                    cl += () =>
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    };
                }
                else if (string.Compare(s.xepLoai, "xuat sac") == 0)
                {
                    cl += () =>
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    };
                }
                else
                {
                    cl += () =>
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    };
                   
                    
                }
                Xuat1SV(s);
                

            }
            cl = null;
            
            Console.ForegroundColor = ConsoleColor.White;
            XuatDongKe('=');
        }

    }

}
