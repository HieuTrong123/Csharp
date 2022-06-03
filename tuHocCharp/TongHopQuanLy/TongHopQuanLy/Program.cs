using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TongHopQuanLy
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
        public SinhVien(string maSo, string hoTen, int namSinh, string lop, double diem)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.lop = lop;
            this.diem = diem;

        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<SinhVien> ds = new List<SinhVien>();

            QuanLySInhVien ql = new QuanLySInhVien();
            int luaChon;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t=============MENU=============");
                Console.WriteLine("0,ket thuc chuong trinh");
                Console.WriteLine("1.tao danh sach");
                Console.WriteLine("2.xem danh sach");
                Console.WriteLine("3.nan tem sinh vien co ma so sinh vien cho truoc");
                Console.WriteLine("4.tim sinh vien co diem trung binh lon nhat");
                Console.WriteLine("5.sap xep sinh vien theo lop");
                Console.WriteLine("6.doi mau thong tin cua cac sinh vien co hoc luc kem thanh mau red");
                Console.WriteLine("7.xoa sinh vien co ma so xho truoc");
                Console.WriteLine("8.them sinh vien vao vi tri cho truoc");
                Console.WriteLine("9.xoa sinh vien co hoc luc yeu");
                Console.WriteLine("\n\n\t\t=============MENU=============");
                Console.WriteLine("nhap lua chon cua ban: ");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("1.tao danh sach");
                        ql.TaoDS(ds);

                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("2.xem danh sach");
                        ql.XemDS(ds);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("3.nan tem sinh vien co ma so sinh vien cho truoc");
                        string maSo;
                        Console.WriteLine("nhap ma so sinh vien can nan ten");
                        maSo = Console.ReadLine();
                        ql.NanTenSinhVienCoMaSo(maSo, ds);
                        Console.WriteLine($"xem danh sach sau khi nan ten sinh vien co ma so : {maSo} :");
                        ql.XemDS(ds);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("4.tim sinh vien co diem trung binh lon nhat");
                        ql.TimDiemTBMax(ds);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("5.sap xep sinh vien theo lop");
                        ds.Sort(
                            (a, b) =>
                        {
                            if (string.Compare(a.lop, b.lop) > 0) return 1;
                            if (string.Compare(a.lop, b.lop) == 0) return 0;
                            return -1;
                        });
                        Console.WriteLine("danh sach sau khi sap xep theo lop la: ");
                        ql.XemDS(ds);
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("6.doi mau thong tin cac sinh vien co hoc luc kem thanh mau red");
                        Console.WriteLine("danh sach sinh vien truoc khi chuyen la: ");
                        ql.XemDS(ds);
                        ql._ChangeColor(ds);
                        


                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("7.xoa sinh vien co ma so cho truoc");
                        Console.WriteLine("danh sach ban dau la: ");
                        ql.XemDS(ds);
                        int vt;
                        Console.WriteLine("nhap vi tri sinh vien ban muon xoa: ");
                        vt = int.Parse(Console.ReadLine());
                        ds.RemoveAt(vt);
                        Console.WriteLine("danh sach sau khi xoa la: ");
                        ql.XemDS(ds);
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("8.them sinh vien vao vi tri cho truoc");
                        Console.WriteLine("nhap ma so sinh vien: ");
                        string _maSo = Console.ReadLine();
                        Console.WriteLine("nhap ho ten sinh vien: ");
                        string _hoTen = Console.ReadLine();
                        Console.WriteLine("nhap nam sinh sinh vien: ");
                        int _namSinh = int.Parse(Console.ReadLine());
                        Console.WriteLine("nhap lop sinh vien: ");
                        string _lop = Console.ReadLine();
                        Console.WriteLine("nhap diem sinh vien: ");
                        double _diem = double.Parse(Console.ReadLine());
                        SinhVien newST = new SinhVien(_maSo, _hoTen
                            , _namSinh, _lop, _diem);
                        ds.Add(newST);
                        Console.WriteLine("danh sach sau khi them la:");
                        ql.XemDS(ds);
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine("9.xoa sinh vien co hoc luc yeu");
                        Console.WriteLine("danh sach ban dau la: ");
                        ql.XemDS(ds);
                        var temp = ds.RemoveAll((e) =>
                          {
                              return string.Compare(e.xepLoai, "yeu") == 0;
                          });
                        Console.WriteLine("danh sach sau khi xoa la :");
                        ql.XemDS(ds);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("lua chon khong ton tai hay nhap lai!!!");
                        break;
                }
            }
            
        }

    }
}
