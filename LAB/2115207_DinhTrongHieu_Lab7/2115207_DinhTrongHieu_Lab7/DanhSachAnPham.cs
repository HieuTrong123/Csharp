using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _2115207_DinhTrongHieu_Lab7
{
    public delegate int SoSanh(object a, object b);
    public enum KieuSapXep
    {
        TangTheoTen,TangTheoGia,GiamTheoNam
    }
    public class DanhSachAnPham:IComparer<IAnPham>
    {
        List<IAnPham> collection;
        KieuSapXep kieu;
        public DanhSachAnPham()
        {
            collection = new List<IAnPham>();
        }
        public IAnPham this[int index]
        {
            get { return collection[index]; }
            set { collection[index] = value; }
        }
        public int Count
        {
            get { return collection.Count; }
        }
        public int Compare(IAnPham x, IAnPham y)
        {
            if (kieu == KieuSapXep.TangTheoTen)
                return x.Ten.CompareTo(y.Ten);
            return x.GiaTien.CompareTo(y.GiaTien);
        }
        public void Them(IAnPham ap)
        {
            collection.Add(ap);
        }
        public void NhapTuFile()
        {
            string path = @"dsanpham.txt";
            StreamReader sr = new StreamReader(path);
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                string[] s = str.Split(',');
                if (s[0] == "Sach")
                    Them(new Sach(str));
                if (s[0] == "Bao")
                    Them(new Bao(str));
                if (s[0] == "Tap chi")
                    Them(new TapChi(str));
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            XuatTieuDe();
            foreach (var item in collection)
            {
                sb.Append(item + "\n");
            }
            return sb.ToString();
        }
        public DanhSachAnPham TimAnPhamCoGiaCaoNhat()
        {
            float max = collection.Max(x => x.GiaTien);
            DanhSachAnPham kq = new DanhSachAnPham();
            kq.collection = collection.FindAll(x => x.GiaTien == max);
            return kq;
        }
        public DanhSachAnPham TimAnPhamCoGiaThapNhat()
        {
            float max = collection.Min(x => x.GiaTien);
            DanhSachAnPham kq = new DanhSachAnPham();
            kq.collection = collection.FindAll(x => x.GiaTien == max);
            return kq;
        }
        public void XoaAnPhamGiaMin()
        {
            float min = collection.Min(x => x.GiaTien);
            collection.RemoveAll(e=>e.GiaTien==min);
        }
        public IAnPham NhapTuBanPhim()
        {
            string loaiAnPham;
            string ten, nxb;
            float gia;
            Console.WriteLine("nhap loai an pham muon them");
            loaiAnPham=Console.ReadLine();
            Console.WriteLine("nhap ten sp:");
             ten= Console.ReadLine();
            Console.WriteLine("nhap NXB: ");
            nxb= Console.ReadLine();
            Console.WriteLine("nhap gia sp");
            gia= float.Parse(Console.ReadLine());
            if (string.Compare(loaiAnPham, "Bao")==0){
                return new Bao(ten,nxb,gia);
            }
            else if (string.Compare(loaiAnPham, "TapChi") == 0)
            {
                string diachi;
                Console.WriteLine("nhap dia chi tap chi:");
                diachi=Console.ReadLine();
                return new TapChi(ten,nxb,gia,diachi);
            }
            else
            {
                int soTrang;
                Console.WriteLine("nhap so trang sach:");
                soTrang=int.Parse(Console.ReadLine());
                return new Sach(ten,nxb,gia,soTrang);
            }
        }
        public void InSert(int i)
        {
            
            collection.Insert(i, NhapTuBanPhim());
        }
        public void SapXepTheoTen()
        {
            kieu = KieuSapXep.TangTheoTen;
            collection.Sort(this);
        }
        public void SapXepTheoGia()
        {
            kieu = KieuSapXep.TangTheoGia;
            collection.Sort(this);
        }

        DanhSachAnPham TimAnPhamTheoGiaTien(int x)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            kq.collection = collection.FindAll(a => a.GiaTien == x);
            return kq;
        }
        public void XuatTheoGia()
        {
            var kq = collection.GroupBy(e => e.GiaTien);
            foreach(var k in kq)
            {
                Console.WriteLine("gia: {0}",k.Key);
                foreach(var sp in k)
                {
                    Console.WriteLine(sp);
                }
            }
        }
        public void SapXep(SoSanh ss)
        {
            for (int i = 0; i < this.collection.Count - 1; i++)
                for (int j = i + 1; j < this.collection.Count; j++)
                    if (ss(this.collection[i], this.collection[j]) == 1)
                    {
                        IAnPham a = this.collection[i];
                        this.collection[i] = this.collection[j];
                        this.collection[j] = a;
                    }
        }
        public DanhSachAnPham DSAPNXBx(string nhaXuatBan)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            kq.collection = collection.FindAll((e) => string.Compare(e.NhaXuatBan, nhaXuatBan) == 0);
            return kq;
        }
        public float TongGia()
        {
            return collection.Sum(e => e.GiaTien);
        }
        void XuatTieuDe()
        {
            Console.WriteLine("ten".PadRight(30) + "NXB".PadRight(30) + "gia".PadRight(10) + "dia chi/So trang".PadRight(10));
            for (int i = 0; i < 80; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}
