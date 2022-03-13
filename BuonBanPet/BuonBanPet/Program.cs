using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BuonBanPet
{

    public interface IBanPet
    {
        void XuatThongTinKhachHang(List<Buyer> ds_buyer);
        void BanVatNuoi(List<BanPet> ds, List<Buyer> ds_buyer);
        void TaoDanhSachPet(string fileName, List<BanPet> ds);
        void XuatDanhSachPet(List<BanPet> ds);
        void ThemPet(List<BanPet> ds);
        void FixPet(List<BanPet> ds, string canSua, int x);
    }
    public class Buyer
    {
        public string Name { get; set; }
        public int namSinh { get; set; }
        public string diaChi { get; set; }
        public int soTienHT { get; set; }
        public List<BanPet> ds_Pet;
    }
    public class BanPet
    {
        public string Name { get; set; }
        public string nguonGoc { get; set; }
        public string loai { get; set; }
        public string tuoiTho { get; set; }
        public string gioiTinh { get; set; }
        public string canNang { get; set; }
        public int gia { get; set; }
        public BanPet(string Name, string nguonGoc, string loai,
            string tuoiTho, string gioiTinh, string canNang, int gia)
        {
            this.Name = Name;
            this.gia = gia;
            this.nguonGoc = nguonGoc;
            this.loai = loai;
            this.tuoiTho = tuoiTho;
            this.canNang = canNang;
            this.gioiTinh = gioiTinh;
        }
    }
    public class QuanLyPet : IBanPet
    {
        void XuatThongTin1KhachHang(Buyer b)
        {
            Console.WriteLine($"ho ten : {b.Name}");
            Console.WriteLine($"nam sinh : {b.namSinh}");
            Console.WriteLine($"dia chi : {b.diaChi}");
            Console.WriteLine("so pet da thanh toan la:");
            foreach (var x in b.ds_Pet)
            {
                Console.WriteLine($"da thanh toan thanh cong {x.loai} {x.Name} ");
            }
        }
        public void XuatThongTinKhachHang(List<Buyer> ds_buyer)
        {
            int temp = 1;
            foreach (var x in ds_buyer)
            {
                Console.WriteLine($"\n\n\t\tKHACH HANG THU {temp} la : ");
                temp++;
                XuatThongTin1KhachHang(x);
                Console.WriteLine();
            }
        }
        public void BanVatNuoi(List<BanPet> ds, List<Buyer> ds_buyer)
        {
            int i;
            int temp = 1;
            Buyer buyer = new Buyer();
            DateTime dt = DateTime.Now;
            buyer.ds_Pet = new List<BanPet>();

            Console.WriteLine("nhap ten nguoi mua :");
            buyer.Name = Console.ReadLine();


            do
            {
                Console.WriteLine("nhap nam sinh nguoi mua: ");

                buyer.namSinh = int.Parse(Console.ReadLine());
                if(buyer.namSinh > dt.Year)
                {
                    Console.WriteLine("nam sinh khong hop le hay nhap lai!!");
                }
            }while(buyer.namSinh > dt.Year);
           


            Console.WriteLine("nhap dia chi thuong tru: ");
            buyer.diaChi = Console.ReadLine();


            while (temp == 1)
            {
                Console.Clear();
                Console.WriteLine("danh sach hien tai la: ");
                XuatDanhSachPet(ds);

                Console.WriteLine($"\n\n\t\tnhap vi tri Pet voi thu tu tu {0} den {ds.Count - 1} :");
                i = int.Parse(Console.ReadLine());


                Console.WriteLine($"thu cung thu {i} la: ");
                XuatTieuDe();
                XuatMotPet(ds[i]);
                XuatDongKe('=');
                int tienDu;
                do
                {

                    Console.WriteLine("nhap so tien de thanh toan Pet : ");
                    buyer.soTienHT = int.Parse(Console.ReadLine());


                    tienDu = (int)buyer.soTienHT - ds[i].gia;
                    if (tienDu < 0)
                    {
                        char kyTuThoat;
                        Console.WriteLine($"so tien hien tai la {buyer.soTienHT} khong du de thuc hien thanh toan so tien {ds[i].gia} cua Pet {ds[i].Name}");
                        Console.WriteLine("ban co muon nhap lai so tien thanh toan khong (nhap mot ky tu bat ky neu co ,neu khong thi nhap x): ");
                        kyTuThoat = char.Parse(Console.ReadLine());
                        if (kyTuThoat == 'x')
                        {
                            temp = 0;
                        }
                    }
                } while (tienDu < 0 && temp == 1);


                if (tienDu >= 0)
                {

                    buyer.ds_Pet.Add(ds[i]);
                    Console.WriteLine($"thanh toan thanh cong pet {ds[i].Name} !!");
                    Console.WriteLine($"so tien du la: {tienDu}");
                    char kyTuThoat;
                    Console.WriteLine("ban co muon mua pet nua khong (nhap mot ky tu bat ky de tiep tuc mua ,neu khong thi nhap x): ");
                    kyTuThoat = char.Parse(Console.ReadLine());
                    if (kyTuThoat == 'x')
                    {
                        temp = 0;
                    }

                }
                ds.RemoveAt(i);
            }
            ds_buyer.Add(buyer);

        }

        public delegate void ChangeCollor();
        public event ChangeCollor cl = null;
        public void ThemPet(List<BanPet> ds)
        {
            string name, nguonGoc, canNang, loai, tuoiTho, gioiTinh;
            int gia;
            Console.WriteLine("nhap ten Pet:");
            name = Console.ReadLine();
            Console.WriteLine("nhap nguon goc Pet:");
            nguonGoc = Console.ReadLine();
            Console.WriteLine("nhap loai cua Pet:");
            loai = Console.ReadLine();
            Console.WriteLine("nhap tuoi tho cua Pet:");
            tuoiTho = Console.ReadLine();
            Console.WriteLine("nhap can nang cua Pet:");
            canNang = Console.ReadLine();
            Console.WriteLine("nhap gioi tinh Pet:");
            gioiTinh = Console.ReadLine();
            Console.WriteLine("nhap gia cua Pet:");
            gia = int.Parse(Console.ReadLine());
            BanPet petNew = new BanPet(name, nguonGoc, loai, tuoiTho,
                gioiTinh, canNang, gia);
            ds.Add(petNew);
        }
        public void FixPet(List<BanPet> ds, string canSua, int x)
        {
            if (string.Compare(canSua, "ten") == 0)
            {
                Console.WriteLine("sua ten Pet:");
                ds[x].Name = Console.ReadLine();
            }
            else if (string.Compare(canSua, "nguon goc") == 0)
            {
                Console.WriteLine("sua nguon goc Pet:");
                ds[x].nguonGoc = Console.ReadLine();
            }
            else if (string.Compare(canSua, "loai") == 0)
            {
                Console.WriteLine("sua loai cua Pet:");
                ds[x].loai = Console.ReadLine();
            }

            else if (string.Compare(canSua, "tuoi tho") == 0)
            {
                Console.WriteLine("sua tuoi tho cua Pet:");
                ds[x].tuoiTho = Console.ReadLine();
            }

            else if (string.Compare(canSua, "can nang") == 0)
            {
                Console.WriteLine("sua can nang cua Pet:");
                ds[x].canNang = Console.ReadLine();
            }

            else if (string.Compare(canSua, "gioi tinh") == 0)
            {
                Console.WriteLine("sua gioi tinh Pet:");
                ds[x].gioiTinh = Console.ReadLine();
            }

            else if (string.Compare(canSua, "gia") == 0)
            {
                Console.WriteLine("sua gia cua Pet:");
                ds[x].gia = int.Parse(Console.ReadLine());
            }

        }
        private void XuatDongKe(char x)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write(':');
            for (int i = 0; i < 110; i++)
            {
                Console.Write(x);

            }
            Console.Write(':');
            Console.WriteLine();
        }
        private void XuatTieuDe()
        {

            XuatDongKe('=');
            Console.WriteLine(':' + "ten".PadRight(20) + ':' + "nguon goc".PadRight(20) + ':' + "loai".PadRight(20)
                + ':' + "tuoi tho".PadRight(10) + ':' + "gioi tinh".PadRight(10) + ':' + "can nang".PadRight(12) + ':' + "gia".PadRight(10));
            XuatDongKe('=');
        }

        private void ChuyenColor(BanPet pet)
        {
            if (pet.gia >= 10000000)
            {
                cl += () =>
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                };
            }
            else if (pet.gia <= 5000000)
            {
                cl += () =>
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                };
            }
            else
            {
                cl += () =>
                {
                    Console.ForegroundColor = ConsoleColor.White;
                };
            }

        }
        private void XuatMotPet(BanPet pet)
        {
            ChuyenColor(pet);
            cl?.Invoke();
            Console.WriteLine(':' + pet.Name.PadRight(20) + ':' + pet.nguonGoc.PadRight(20) + ':' + pet.loai.PadRight(20)
               + ':' + pet.tuoiTho.PadRight(10) + ':' + pet.gioiTinh.PadRight(10) + ':' + pet.canNang.PadRight(12) + ':' + pet.gia.ToString().PadRight(10));

        }

        public void XuatDanhSachPet(List<BanPet> ds)
        {
            int temp = 0;
            XuatTieuDe();
            foreach (BanPet pet in ds)
            {
                XuatMotPet(pet);
                temp++;
                if (temp % 5 == 0)
                {
                    XuatDongKe('-');
                }
            }
            XuatDongKe('=');
        }
        public void TaoDanhSachPet(string fileName, List<BanPet> ds)
        {

            try
            {

                using (var filein = new StreamReader(fileName))
                {
                    string temp = "";
                    while ((temp = filein.ReadLine()) != null)
                    {
                        var tam = temp.Split(',');
                        var _temp = new BanPet(tam[0], tam[1],
                            tam[2], tam[3], tam[4], tam[5], int.Parse(tam[6]));
                        ds.Add(_temp);
                    }
                }
                Console.WriteLine("thanh cong!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("thai bai!!");
            }
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            List<BanPet> ds = new List<BanPet>();
            IBanPet ql = new QuanLyPet();
            List<Buyer> ds_buyer = new List<Buyer>();

            int? luaChon;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t========MENU========");
                Console.WriteLine("0.ket thuc chuong trinh");
                Console.WriteLine("1.tao danh sach vat nuoi");
                Console.WriteLine("2.xem danh sach vat nuoi");
                Console.WriteLine("3.them vat nuoi");
                Console.WriteLine("4.sua vat nuoi");
                Console.WriteLine("5.xep vat nuoi theo tung loai");
                Console.WriteLine("6.ban vat nuoi");
                Console.WriteLine("7.xem danh sach vat nuoi da duoc ban");
                Console.WriteLine("\n\n\t\t========MENU========");


                Console.WriteLine("\n\nnhap lua chon cua ban: ");
                luaChon = int.Parse(Console.ReadLine());


                switch (luaChon)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("1.tao danh sach vat nuoi");
                        string fileName;
                        Console.WriteLine("nhap ten file chua thong tin Pet (pet.txt): ");
                        fileName = Console.ReadLine();
                        ql.TaoDanhSachPet(fileName, ds);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("2.xem danh sach vat nuoi");
                        ql.XuatDanhSachPet(ds);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("3.them vat nuoi");
                        ql.ThemPet(ds);
                        Console.WriteLine("danh sach sau khi them la: ");
                        ql.XuatDanhSachPet(ds);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("4.sua vat nuoi");
                        int vt;
                        Console.WriteLine($"nhap vi tri cua pet can sua(tu 0 den {ds.Count - 1}:");
                        vt = int.Parse(Console.ReadLine());
                        string canSua;
                        Console.WriteLine("nhap thong tin du lieu can sua (gom: ten,nguon goc,gioi tinh,can nang,tuoi tho,loai,gia): ");
                        canSua = Console.ReadLine();
                        ql.FixPet(ds, canSua, vt);
                        Console.WriteLine("xuat danh sach sau khi chinh sua thong tin Pet:");
                        ql.XuatDanhSachPet(ds);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("5.xep vat nuoi theo tung loai");
                        ds.Sort(
                            (a1, a2) =>
                            {
                                if (a1.loai == a2.loai)
                                    return 0;
                                if (string.Compare(a1.loai, a2.loai) > 0)
                                    return 1;
                                return -1;
                            }
                            );
                        Console.WriteLine("danh sach sau khi sap xep la: ");
                        ql.XuatDanhSachPet(ds);
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("6.ban vat nuoi");
                        ql.BanVatNuoi(ds, ds_buyer);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("7.xem danh sach vat nuoi da duoc ban");
                        ql.XuatThongTinKhachHang(ds_buyer);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("lua chon cua ban nhap khong ton tai hay nhap lai!!");
                        break;
                }
            }

        }
    }
}
