using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2115207_DinhTrongHieu_Lab6
{
    public class QuanLyMayTinh
    {
        List<MayTinh> dsMayTinh;
        #region Dong goi thuoc tinh

        public int Count
        {
            get { return this.dsMayTinh.Count; }
        }
        public MayTinh this[int index]
        {
            get { return this.dsMayTinh[index]; }
        }
        #endregion

        public QuanLyMayTinh()
        {
            this.dsMayTinh = new List<MayTinh>();
        }
        public void Them(MayTinh mt)
        {
            this.dsMayTinh.Add(mt);
        }

        public void NhapCD()
        {
            MayTinh mt = new MayTinh("MT02", new DateTime(2020, 10, 13), "Sony");
            mt.ThemTB(new CPU(100, 3.0f));
            mt.ThemTB(new Ram(30, 32));
            Them(mt);

            mt = new MayTinh("MT01", new DateTime(2021, 10, 5), "HP");
            mt.ThemTB(new CPU(200, 3.5f));
            mt.ThemTB(new CPU(500, 5.0f));
            mt.ThemTB(new Ram(30, 32));
            mt.ThemTB(new Ram(100, 128));
            mt.ThemTB(new Ram(50, 32));
            Them(mt);
        }
        public override string ToString()
        {
            string s = "Danh sach may tinh:\n";

            foreach (var mt in this.dsMayTinh)
                s += mt;
            return s;
        }
        public void XuatDS(List<MayTinh> ds)
        {
            foreach (var temp in ds)
            {
                Console.WriteLine(temp);
            }
        }
        public void SapGiamTheoGia()
        {
            for (int i = 0; i < this.Count - 1; i++)
                for (int j = i + 1; j < this.Count; j++)
                {
                    bool dk = this.dsMayTinh[i].Gia < this.dsMayTinh[j].Gia;
                    if (dk)
                    {
                        MayTinh t = dsMayTinh[i];
                        dsMayTinh[i] = dsMayTinh[j];
                        dsMayTinh[j] = t;
                    }
                }
        }
        public List<MayTinh> GiaMAX()
        {
            int MAX = this.dsMayTinh.Max(k => k.Gia);
            return this.dsMayTinh.FindAll(e => e.Gia == MAX);
        }   
        public void NhapFile()
        {
            try
            {
                StreamReader sr = new StreamReader("dsmaytinh.txt");
                string t = "";
                while ((t = sr.ReadLine()) != null)
                {
                    int n;
                    MayTinh may = new MayTinh();
                    var temp = t.Trim().Split('*');
                    var temp1 = temp[3].Split('/');
                    may = new MayTinh(temp[1], new DateTime(int.Parse(temp1[2]), int.Parse(temp1[0]), int.Parse(temp1[1])), temp[2]);
                    n = int.Parse(sr.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        t = sr.ReadLine();
                        var temp2 = t.Trim().Split('*');
                        if (string.Compare(temp2[0], "CPU") == 0)
                        {
                            may.ThemTB(new CPU(int.Parse(temp2[2]), double.Parse(temp2[1])));
                        }
                        else
                        {
                            may.ThemTB(new Ram(int.Parse(temp2[2]), double.Parse(temp2[1])));

                        }
                    }
                    this.dsMayTinh.Add(may);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public List<MayTinh> mt2ThanhRam()
        {
            List<MayTinh> kq = new List<MayTinh>();
            foreach (var t in this.dsMayTinh)
            {
                int dem = 0;
                for (int i = 0; i < t.SoTB; i++)
                {
                    if (t[i] is Ram)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    kq.Add(t);
                }
            }
            return kq;
        }
        public void SapTheoGia()
        {

            var kq = this.dsMayTinh.GroupBy(x => x.Gia);
            foreach (var t in kq)
            {
                Console.WriteLine($"gia :{t.Key}");
                foreach (var v in t)
                {
                    Console.WriteLine(v);
                }
            }
        }
        public int TongGia
        {
            get => this.dsMayTinh.Sum(x => x.Gia);
        }
        public void SapXepGiamTheoTen()
        {
            this.dsMayTinh.Sort((e1, e2) =>
            {
                if (string.Compare(e1.Ten, e2.Ten) < 0)
                    return 1;
                return -1;
            });
        }
        public List<MayTinh> GiaRamMAX()
        {
            List<MayTinh> kq = new List<MayTinh>();
            int max = 0;

            foreach (var t in this.dsMayTinh)
            {
                for (int i = 0; i < t.SoTB; i++)
                {
                    if (t[i] is Ram && t[i].Gia > max)
                    {
                        max = t[i].Gia;
                    }
                }
            }
            foreach (var t in this.dsMayTinh)
            {
                for (int i = 0; i < t.SoTB; i++)
                {
                    if (t[i] is Ram && t[i].Gia == max)
                    {
                        kq.Add(t);
                        break;
                    }
                }
            }
            return kq;
        }
        public List<MayTinh> GiaRamMIN()
        {
            List<MayTinh> kq = new List<MayTinh>();
            int min = this.dsMayTinh[0].Gia;

            foreach (var t in this.dsMayTinh)
            {
                for (int i = 0; i < t.SoTB; i++)
                {
                    if (t[i] is Ram && t[i].Gia < min)
                    {
                        min = t[i].Gia;
                    }
                }
            }
            foreach (var t in this.dsMayTinh)
            {
                for (int i = 0; i < t.SoTB; i++)
                {
                    if (t[i] is Ram && t[i].Gia == min)
                    {
                        kq.Add(t);
                        break;
                    }
                }
            }
            return kq;
        }
        public List<MayTinh> GiaCPUMAX()
        {
            List<MayTinh> kq = new List<MayTinh>();
            int max = 0;

            foreach (var t in this.dsMayTinh)
            {
                for (int i = 0; i < t.SoTB; i++)
                {
                    if (t[i] is CPU && t[i].Gia > max)
                    {
                        max = t[i].Gia;
                    }
                }
            }
            foreach (var t in this.dsMayTinh)
            {
                for (int i = 0; i < t.SoTB; i++)
                {
                    if (t[i] is CPU && t[i].Gia == max)
                    {
                        kq.Add(t);
                        break;
                    }
                }
            }
            return kq;
        }
        public List<MayTinh> GiaCPUMIN()
        {
            List<MayTinh> kq = new List<MayTinh>();
            int min = this.dsMayTinh[0].Gia;

            foreach (var t in this.dsMayTinh)
            {
                for (int i = 0; i < t.SoTB; i++)
                {
                    if (t[i] is CPU && t[i].Gia < min)
                    {
                        min = t[i].Gia;
                    }
                }
            }
            foreach (var t in this.dsMayTinh)
            {
                for (int i = 0; i < t.SoTB; i++)
                {
                    if (t[i] is CPU && t[i].Gia == min)
                    {
                        kq.Add(t);
                        break;
                    }
                }
            }
            return kq;
        }
        public List<MayTinh> MayLinhKienMAX()
        {
            List<MayTinh> kq = new List<MayTinh>();
            int max = 0;
            foreach (var t in this.dsMayTinh)
            {
                if (t.SoTB > max) { max = t.SoTB; }
            }
            foreach (var t in this.dsMayTinh)
            {
                if (t.SoTB == max) { kq.Add(t); }
            }
            return kq;
        }
        public void XoaMTTruoc2000()
        {
            this.dsMayTinh.RemoveAll((e) => e.NamSX <= 2000);
        }
        public void ThemVTi(int i, MayTinh nmt)
        {
            this.dsMayTinh.Insert(i, nmt);
        }
        public void NhapMTBanPhim(MayTinh mt)
        {
            int day, month, year, soTB;
            string thietBi;
            Console.WriteLine("nhap ma so may tinh:");
            mt.MaSo = Console.ReadLine();
            Console.WriteLine("nhap ngay san xuat:");
            Console.WriteLine("day:");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("month:");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("year:");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ten may:");
            mt.Ten = Console.ReadLine();
            Console.WriteLine("nhap so thiet bi:");
            soTB = int.Parse(Console.ReadLine());
            for (int i = 0; i < soTB; i++)
            {
                int gia;
                Console.WriteLine("nhap loai thiet bi:");
                thietBi = Console.ReadLine();
                Console.WriteLine("nhap gia: ");
                gia = int.Parse(Console.ReadLine());
                if (string.Compare(thietBi, "CPU") == 0)
                {
                    int tocDo;
                    Console.WriteLine("nhap toc do:");
                    tocDo = int.Parse(Console.ReadLine());
                    mt.ThemTB(new CPU(gia, tocDo));
                }
                else if (string.Compare(thietBi, "Ram") == 0)
                {
                    int dungLuong;
                    Console.WriteLine("nhap dung luong:");
                    dungLuong = int.Parse(Console.ReadLine());
                    mt.ThemTB(new Ram(gia, dungLuong));
                }

            }
        }
    }
}
