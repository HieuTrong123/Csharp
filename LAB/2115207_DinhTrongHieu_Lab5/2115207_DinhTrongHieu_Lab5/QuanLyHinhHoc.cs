using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_Lab5
{
    public class QuanLyHinhHoc
    {
        enum LoaiHinh
        {
            Tatca, HinhTron, HinhVuong, HinhCN, HinhTG
        }
        public List<HinhHoc> ds = new List<HinhHoc>();
        public List<HinhHoc> this[int i]
        {
            get
            {
                switch ((LoaiHinh)i)
                {
                    case LoaiHinh.Tatca:
                        return ds;
                    case LoaiHinh.HinhVuong:
                        return ds.FindAll(e => e is HinhVuong && !(e is HinhCN));
                    case LoaiHinh.HinhCN:
                        return ds.FindAll(e => e is HinhCN);
                    case LoaiHinh.HinhTron:
                        return ds.FindAll(e => e is HinhTron);
                    case LoaiHinh.HinhTG:
                        return ds.FindAll(e => e is HinhTG);
                    default:
                        throw new Exception("hinh khong ton tai!!");
                }

            }

        }
        public void NhapDS()
        {
            ds.Add(new HinhVuong(3));
            ds.Add(new HinhVuong(8));
            ds.Add(new HinhTron(6));
            ds.Add(new HinhVuong(8));
            ds.Add(new HinhCN(3, 4));
            ds.Add(new HinhCN(5, 6));
            ds.Add(new HinhCN(3, 2));
            ds.Add(new HinhTron(4));
            ds.Add(new HinhTron(5));
            ds.Add(new HinhTron(6));
            ds.Add(new HinhTG(3, 4, 5));
            ds.Add(new HinhTG(3, 3, 3));
            ds.Add(new HinhTG(3, 3, 5));
            ds.Add(new HinhTG(3, 2, 2));
            ds.Add(new HinhTG(5, 4, 7));
        }
        public List<HinhHoc> TimDTMax()
        {
            double max = ds.Max((e) => e.TinhDT());
            var kq = ds.FindAll((e) =>
              {
                  return e.TinhDT() == max;
              });
            return kq;
        }
        public List<HinhHoc> TimDtHVMin()
        {
            var HV = ds.FindAll((e) => e is HinhVuong && !(e is HinhCN));
            double min = HV.Min((e) => e.TinhDT());
            var kq = HV.FindAll((e) =>
            {
                return e.TinhDT() == min;
            });
            return kq;
        }
        public void SapXepTangDt()
        {
            ds.Sort((e1, e2) =>
            {
                if (e1.TinhDT() > e2.TinhDT())
                    return 1;
                return -1;
            });

        }
        public double TongDtHinhTron()
        {
            var HT = ds.FindAll(e => e is HinhTron);
            return HT.Sum(e => e.TinhDT());
        }
        public void SapTangHinhTron()
        {
            //ds.Sort((e1, e2) =>
            //{
            //    if (e1 is HinhTron && e1 is HinhTron && e1.TinhDT() > e2.TinhDT())
            //        return 1;
            //    return -1;
            //});
            
            for (int i=0; i<ds.Count; i++)
            {
                
                for(int j =i+1; j<ds.Count; j++)
                {
                    if (ds[i] is HinhTron && ds[j] is HinhTron && ds[i].TinhDT() > ds[j].TinhDT())
                    {
                        HinhHoc x = ds[i];
                        ds[i] = ds[j];
                        ds[j] = x;
                    }
                   
                }
            }

        }
        public List<HinhHoc> HinhDTNhoHonX(double x)
        {
            var kq = ds.FindAll((e) => e.TinhDT() < x);
            return kq;
        }
        public void DemSoLuongHinhTheoLoai()
        {
            Console.WriteLine($"so luong {LoaiHinh.Tatca} hinh la {this[(int)LoaiHinh.Tatca].Count}");
            Console.WriteLine($"so luong {LoaiHinh.HinhVuong} hinh la {this[(int)LoaiHinh.HinhVuong].Count}");
            Console.WriteLine($"so luong {LoaiHinh.HinhTG} hinh la {this[(int)LoaiHinh.HinhTG].Count}");
            Console.WriteLine($"so luong {LoaiHinh.HinhCN} la {this[(int)LoaiHinh.HinhCN].Count}");
            Console.WriteLine($"so luong {LoaiHinh.HinhTron} la {this[(int)LoaiHinh.HinhTron].Count}");
        }
        public void XoaLoaiHinh()
        {
            Console.WriteLine($"nhap {(int)LoaiHinh.Tatca} de xoa {LoaiHinh.Tatca}");
            Console.WriteLine($"nhap {(int)LoaiHinh.HinhCN} de xoa {LoaiHinh.HinhCN}");
            Console.WriteLine($"nhap {(int)LoaiHinh.HinhVuong} de xoa {LoaiHinh.HinhVuong}");
            Console.WriteLine($"nhap {(int)LoaiHinh.HinhTG} de xoa {LoaiHinh.HinhTG}");
            Console.WriteLine($"nhap {(int)LoaiHinh.HinhTron} de xoa {LoaiHinh.HinhTron}");
            LoaiHinh chon;
            Console.WriteLine("nhap loai hinh ban muon xoa: ");
            chon = (LoaiHinh)int.Parse(Console.ReadLine());

            foreach (var t in this[(int)chon])
            {
                ds.RemoveAll(x => { return x==t; });
            }
        }
        public void ChenHinhTron(HinhTron ht)
        {
            double max=ds.Max(e=>e.TinhDT());
            int index=ds.FindLastIndex(x =>x.TinhDT()==max);
            ds.Insert(index, ht);

        }
        public void XoaHinhVuongDtMin()
        {
            var hv=ds.FindAll(u=>u is HinhVuong&&!(u is HinhCN));
            double min = hv.Min(x => x.TinhDT());
            ds.RemoveAll(e => e is HinhVuong&&!(e is HinhCN) && e.TinhDT() == min );
        }
        public void SapXepTTT()
        {
            ds.Sort((e1, e2) =>
            {
                if (!(e1 is HinhTron) && e2 is HinhTron ||
                e1 is HinhTron && e2 is HinhTron && e1.TinhDT() < e2.TinhDT() ||
                !(e1 is HinhTron) && !(e2 is HinhTron)&& e1.TinhDT() > e2.TinhDT())
                    return 1;
                return -1;
            });
        }
        public void SapTangHinhTG()
        {
            //ds.Sort((e1, e2) =>
            //{
            //    if (e1 is HinhTron && e1 is HinhTron && e1.TinhDT() > e2.TinhDT())
            //        return 1;
            //    return -1;
            //});

            for (int i = 0; i < ds.Count; i++)
            {

                for (int j = i + 1; j < ds.Count; j++)
                {
                    if (ds[i] is HinhTG && ds[j] is HinhTG && ds[i].TinhDT() < ds[j].TinhDT())
                    {
                        HinhHoc x = ds[i];
                        ds[i] = ds[j];
                        ds[j] = x;
                    }

                }
            }

        }
        public void XoaHinhTGDtMin()
        {
            var hv = ds.FindAll(u => u is HinhTG);
            double min = hv.Min(x => x.TinhDT());
            ds.RemoveAll(e => e is HinhTG && e.TinhDT() == min);
        }
    }

}
