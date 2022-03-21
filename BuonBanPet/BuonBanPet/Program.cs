using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BuonBanPet
{
    public class TongThuNhap
    {
        public string tenMatHang { get; set; }
        public int thuNhap { get; set; }
        public string loaiMatHang { get; set; }
        public string xuatSu { get; set; }

        public TongThuNhap(string tenMatHang, int thuNhap,
            string loaiMatHang, string XuatSu)
        {
            this.xuatSu = XuatSu;
            this.thuNhap = thuNhap;
            this.loaiMatHang = loaiMatHang;
            this.tenMatHang = tenMatHang;
        }

    }


    public class MatHangBanChay
    {
        public int tongSoKuong { get; set; }
        public string tenMatHang { get; set; }
        public string loaiMatHang { get; set; }
        public string xuatSu { get; set; }
        public MatHangBanChay(int tongSoLuong, string tenMatHang,
            string loaiMatHang, string xuatSu)
        {
            this.loaiMatHang = loaiMatHang;
            this.tongSoKuong = tongSoLuong;
            this.xuatSu = xuatSu;
            this.tenMatHang = tenMatHang;
        }
    }
    public interface IBanPet
    {
        void XuatThongTinKhachHang(List<Buyer> ds_buyer);
        void BanVatNuoi(List<BanPet> ds, List<Buyer> ds_buyer,
            List<TongThuNhap> tongThuNhap, List<MatHangBanChay> matHangBanChay);
        void TaoDanhSachPet(string fileName, List<BanPet> ds);
        void XuatDanhSachPet(List<BanPet> ds);
        void ThemPet(List<BanPet> ds);
        void FixPet(List<BanPet> ds, string canSua, int x);
        void XuatDSThuNhap(List<TongThuNhap> tongThuNhap);
        void XuatDSBanChay(List<MatHangBanChay> matHangBanChay);
    }
    public class PetDuocThanhToan
    {
       public string Name { get; set; }
        public string loai { get; set; }
        public string suatXu { get; set; }
        public int soLuongDaThanhToan { get; set; }
        public PetDuocThanhToan(string Name,string loai,string XuatSu,int soLuongThanhToan)
        {
            this.Name = Name;
            this.suatXu = XuatSu;
            this.soLuongDaThanhToan= soLuongThanhToan;
            this.loai = loai;
        }
    }
    public class Buyer
    {
        public string Name { get; set; }
        public int namSinh { get; set; }
        public string diaChi { get; set; }
        public int soTienHT { get; set; }
        

        public List<PetDuocThanhToan> ds_PetThanhToan;
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
        public int soLuong { get; set; }
        public int soLuongPet { get; set; }
        public BanPet(string Name, string nguonGoc, string loai,
            string tuoiTho, string gioiTinh, string canNang, int gia, int soLuong)
        {
            this.Name = Name;
            this.gia = gia;
            this.nguonGoc = nguonGoc;
            this.loai = loai;
            this.tuoiTho = tuoiTho;
            this.canNang = canNang;
            this.gioiTinh = gioiTinh;
            this.soLuong = soLuong;
        }
    }
    public class QuanLyPet : IBanPet
    {
        
        void XuatThongTin1KhachHang(Buyer b)
        {

            File.AppendAllText("quanlykhachhang.txt", $"ho ten : {b.Name}\n");
            File.AppendAllText("quanlykhachhang.txt", $"nam sinh : {b.namSinh}\n");
            File.AppendAllText("quanlykhachhang.txt", $"dia chi : {b.diaChi}\n");
            File.AppendAllText("quanlykhachhang.txt", "so pet da thanh toan la :\n");
            foreach (var x in b.ds_PetThanhToan)
            {
                File.AppendAllText("quanlykhachhang.txt", $"{x.soLuongDaThanhToan} pet {x.loai} {x.suatXu} {x.Name}\n");
            }
           
        }
        private List<PetDuocThanhToan> XuLyPetDuocThanhToan(List<PetDuocThanhToan> petDuocThanhToan)
        {
            List<PetDuocThanhToan> pets = new List<PetDuocThanhToan>();
            for(int i = 0; i < petDuocThanhToan.Count; i++)
            {
                PetDuocThanhToan p;
                int x = petDuocThanhToan[i].soLuongDaThanhToan;
                for(int j = i + 1; j < petDuocThanhToan.Count; j++)
                {
                    if(petDuocThanhToan[i].Name==petDuocThanhToan[j].Name
                       && petDuocThanhToan[i].loai == petDuocThanhToan[j].loai
                       && petDuocThanhToan[i].suatXu == petDuocThanhToan[j].suatXu)
                    {
                        x +=  petDuocThanhToan[j].soLuongDaThanhToan;
                        petDuocThanhToan.Remove(petDuocThanhToan[j]);
                        j--;
                    }
                    
                }
                p = new PetDuocThanhToan(petDuocThanhToan[i].Name, petDuocThanhToan[i].loai, petDuocThanhToan[i].suatXu, x);
                pets.Add(p);
            }

            return pets;

        }
        
            
        
        public void XuatThongTinKhachHang(List<Buyer> ds_buyer)
        {
            int month, day;
            DateTime dt = DateTime.Now;
            int year = dt.Year;
            month = dt.Month;
            day = dt.Day;
            
            File.AppendAllText("banchay.txt", $"\n\n\t\t\tmat hang ban chay nhat ngay {day} thang {month} nam {year}:\n");
            int temp = 1;
            foreach (var x in ds_buyer)
            {
                x.ds_PetThanhToan=XuLyPetDuocThanhToan(x.ds_PetThanhToan);
                File.AppendAllText("quanlykhachhang.txt", $"\n\n\t\tKHACH HANG THU {temp} la : \n");
                temp++;
                XuatThongTin1KhachHang(x);
                Console.WriteLine();
            }
            Console.WriteLine("da luu thong tin khach hang vao file quanlykhachhang.txt");
        }
        private List<TongThuNhap> XuLyThuNhap (List<TongThuNhap> tongThuNhap)
        {
            List<TongThuNhap> NewTongThuNhap=new List<TongThuNhap>();
            for(int i = 0; i < tongThuNhap.Count; i++)
            {
                TongThuNhap NewTongThuNhap1;
                int x = tongThuNhap[i].thuNhap;
                for(int j = i + 1; j < tongThuNhap.Count; j++)
                {
                    if (tongThuNhap[i].tenMatHang == tongThuNhap[j].tenMatHang
                        && tongThuNhap[i].loaiMatHang == tongThuNhap[j].loaiMatHang
                        && tongThuNhap[i].xuatSu == tongThuNhap[j].xuatSu)
                    {
                        x += tongThuNhap[j].thuNhap;
                        tongThuNhap.Remove(tongThuNhap[j]);
                        j--;
                    }
                }
                NewTongThuNhap1=new TongThuNhap(tongThuNhap[i].tenMatHang,x,tongThuNhap[i].loaiMatHang,tongThuNhap[i].xuatSu);
                NewTongThuNhap.Add(NewTongThuNhap1);
            }

            return NewTongThuNhap;
        }

        public void XuatDSThuNhap(List<TongThuNhap> tongThuNhap)
        {
            int month, day;
            DateTime dt = DateTime.Now;
            int year = dt.Year;
            month = dt.Month;
            day = dt.Day;
            tongThuNhap=XuLyThuNhap(tongThuNhap);
                File.AppendAllText("TongThuNhap.txt", $"\n\n\t\t\tdoanh thu ngay {day} thang {month} nam {year}:\n");

                for (int i = 0; i < tongThuNhap.Count; i++)
                {

                    File.AppendAllText("TongThuNhap.txt", $"\n\n\t\t=======Mat Hang thu {i + 1}========\n");
                    File.AppendAllText("TongThuNhap.txt", $"ten: {tongThuNhap[i].tenMatHang}\n");
                    File.AppendAllText("TongThuNhap.txt", $"xuat su: {tongThuNhap[i].xuatSu}\n");
                    File.AppendAllText("TongThuNhap.txt", $"loai: {tongThuNhap[i].loaiMatHang}\n");
                    File.AppendAllText("TongThuNhap.txt", $"thu nhap: {tongThuNhap[i].thuNhap}\n");
                }
                Console.WriteLine("danh sach da duoc luu trong file TongThuNhap.txt");
            

        }
        private List<MatHangBanChay> XuLyMang(List<MatHangBanChay> matHangBanChay)
        {
            List<MatHangBanChay> NewListMatHangBanChay=new List<MatHangBanChay>();

           
            for (int i = 0;i < matHangBanChay.Count; i++)
            {
                MatHangBanChay NewMatHang;
                int x = matHangBanChay[i].tongSoKuong;
                for (int j = i+1;j< matHangBanChay.Count; j++)
                {
                    if (matHangBanChay[i].tenMatHang == matHangBanChay[j].tenMatHang
                        && matHangBanChay[i].loaiMatHang == matHangBanChay[j].loaiMatHang
                        && matHangBanChay[i].xuatSu == matHangBanChay[j].xuatSu)
                    {
                        x += matHangBanChay[j].tongSoKuong;
                        matHangBanChay.Remove(matHangBanChay[j]);
                        j--;
                    }
                }
                NewMatHang = new MatHangBanChay(x
                           , matHangBanChay[i].tenMatHang, matHangBanChay[i].loaiMatHang, matHangBanChay[i].xuatSu);
                NewListMatHangBanChay.Add(NewMatHang);
            }
   
            return NewListMatHangBanChay;
        }
        public void XuatDSBanChay(List<MatHangBanChay> matHangBanChay)
        {
            int month, day;
            DateTime dt = DateTime.Now;
            int year = dt.Year;
            month = dt.Month;
            day = dt.Day;
            matHangBanChay = XuLyMang(matHangBanChay);
            File.AppendAllText("banchay.txt", $"\n\n\t\t\tmat hang ban chay nhat ngay {day} thang {month} nam {year}:\n");
            for (int i = 0; i < matHangBanChay.Count; i++)
            {
                File.AppendAllText("banchay.txt", $"\n\n\t\t=======Mat Hang thu {i + 1}========\n");
                File.AppendAllText("banchay.txt", $"ten: {matHangBanChay[i].tenMatHang}\n");
                File.AppendAllText("banchay.txt", $"xuat su: {matHangBanChay[i].xuatSu}\n");
                File.AppendAllText("banchay.txt", $"loai: {matHangBanChay[i].loaiMatHang}\n");
                File.AppendAllText("banchay.txt", $"so mat hang duoc ban: {matHangBanChay[i].tongSoKuong}\n");

            }
            Console.WriteLine("danh sach da duoc luu trong file banchay.txt");



        }
        public void BanVatNuoi(List<BanPet> ds, List<Buyer> ds_buyer,
            List<TongThuNhap> tongThuNhap, List<MatHangBanChay> matHangBanChay)
        {
            int i = 0;
            int temp = 1;
            int soLuongPet = 0;
            Buyer buyer = new Buyer();
            DateTime dt = DateTime.Now;
            buyer.ds_PetThanhToan = new List<PetDuocThanhToan>();

            Console.WriteLine("nhap ten nguoi mua :");
            buyer.Name = Console.ReadLine();


            do
            {
                Console.WriteLine("nhap nam sinh nguoi mua: ");

                buyer.namSinh = int.Parse(Console.ReadLine());
                if (buyer.namSinh > dt.Year && buyer.namSinh < 0)
                {
                    Console.WriteLine("nam sinh khong hop le hay nhap lai!!");
                }
            } while (buyer.namSinh > dt.Year && buyer.namSinh < 0);



            Console.WriteLine("nhap dia chi thuong tru: ");
            buyer.diaChi = Console.ReadLine();
            Console.WriteLine("\n\n\t\t====Thong Tin Nguoi Dung Da duoc Xac Nhan====");

            while (temp == 1)
            {
                Console.Clear();
                Console.WriteLine("danh sach hien tai la: ");
                XuatDanhSachPet(ds);

                Console.WriteLine($"\n\n\t\tnhap vi tri Pet voi thu tu tu {0} den {ds.Count - 1} :");
                i = int.Parse(Console.ReadLine());


                Console.WriteLine($"thu cung thu {i} la: ");
                XuatTieuDe();
                XuatMotPet(ds[i], i);
                XuatDongKe('=');
                int tienDu;
                do
                {


                    Console.WriteLine("nhap so tien de thanh toan Pet : ");
                    buyer.soTienHT = int.Parse(Console.ReadLine());


                    do
                    {
                        Console.WriteLine($"nhap so luong pet {ds[i].Name} can mua:");
                        soLuongPet = int.Parse(Console.ReadLine());
                        if (soLuongPet > ds[i].soLuong)
                        {
                            char kyTuThoat;
                            Console.WriteLine("so luong pet khong du de dap ung yeu cau !!");
                            Console.WriteLine("ban co muon nhap lai so luong khong (enter neu co va 1 ky tu bat ky de dung lai");
                            kyTuThoat = char.Parse(Console.ReadLine() == "" ? "y" : "x");
                            if (kyTuThoat == 'x')
                            {
                                temp = 0;
                            }
                        }
                    } while (soLuongPet > ds[i].soLuong && temp == 1);



                    tienDu = (int)buyer.soTienHT - ds[i].gia * soLuongPet;
                    
                   
                    if (tienDu < 0)
                    {
                        char kyTuThoat;
                        Console.WriteLine($"so tien hien tai la {buyer.soTienHT} khong du de thuc hien thanh toan so tien {ds[i].gia * soLuongPet} cua {soLuongPet} Pet {ds[i].Name}");
                        Console.WriteLine("ban co muon nhap lai so tien thanh toan khong (enter de tiep tuc va ky tu bat ky de dung la i): ");
                        kyTuThoat = char.Parse(Console.ReadLine() == "" ? "y" : "x");
                        if (kyTuThoat == 'x')
                        {
                            temp = 0;
                        }
                    }
                } while (tienDu < 0 && temp == 1);


                if (tienDu >= 0)
                {
                    TongThuNhap tongThu = new TongThuNhap(ds[i].Name,
                        (soLuongPet * ds[i].gia), ds[i].loai, ds[i].nguonGoc);
                    tongThuNhap.Add(tongThu);
                    MatHangBanChay hangBanChay = new MatHangBanChay(soLuongPet, ds[i].Name,
                        ds[i].loai, ds[i].nguonGoc);
                    matHangBanChay.Add(hangBanChay);
                    PetDuocThanhToan petDuocThanhToan = new PetDuocThanhToan(ds[i].Name, ds[i].loai, ds[i].nguonGoc, soLuongPet);
                    buyer.ds_PetThanhToan.Add(petDuocThanhToan);
                    ds[i].soLuong -= soLuongPet;


                    Console.WriteLine($"thanh toan thanh cong pet {ds[i].Name} !!");
                    Console.WriteLine($"so tien du la: {tienDu}");
                    char kyTuThoat;
                    Console.WriteLine("ban co muon mua pet nua khong (nhap mot " +
                        "enter neu co va ky tu bat ky de dung lai!): ");
                    kyTuThoat = char.Parse(Console.ReadLine()==""?"y":"x");
                    if (kyTuThoat == 'x')
                    {
                        temp = 0;
                    }



                }

            }
            ds_buyer.Add(buyer);

        }

        public delegate void ChangeCollor();
        public event ChangeCollor cl = null;
        public void ThemPet(List<BanPet> ds)
        {
            string name, nguonGoc, canNang, loai, tuoiTho, gioiTinh;
            int gia, soLuong;
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
            Console.WriteLine("nhap so luong cua Pet:");
            soLuong = int.Parse(Console.ReadLine());
            BanPet petNew = new BanPet(name, nguonGoc, loai, tuoiTho,
                gioiTinh, canNang, gia, soLuong);
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
            else if (string.Compare(canSua, "so luong") == 0)
            {
                Console.WriteLine("sua so luong cua Pet:");
                ds[x].soLuong = int.Parse(Console.ReadLine());
            }

        }
        private void XuatDongKe(char x)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write(':');
            for (int i = 0; i < 120; i++)
            {
                Console.Write(x);

            }
            Console.Write(':');
            Console.WriteLine();
        }
        private void XuatTieuDe()
        {

            XuatDongKe('=');
            Console.WriteLine(':' + "stt".PadRight(2) + ':' + "ten".PadRight(20) + ':' + "nguon goc".PadRight(20) + ':' + "loai".PadRight(20)
                + ':' + "tuoi tho".PadRight(10) + ':' + "gioi tinh".PadRight(10) + ':' + "can nang".PadRight(12) + ':' + "gia".PadRight(10) + ':' + "so luong".PadRight(8));
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
        private void XuatMotPet(BanPet pet, int temp)
        {

            ChuyenColor(pet);
            cl?.Invoke();
            Console.WriteLine(':' + temp.ToString().PadRight(2) + ':' + pet.Name.PadRight(20) + ':' + pet.nguonGoc.PadRight(20) + ':' + pet.loai.PadRight(20)
               + ':' + pet.tuoiTho.PadRight(10) + ':' + pet.gioiTinh.PadRight(10) + ':' + pet.canNang.PadRight(12) + ':' + pet.gia.ToString().PadRight(10) + ':' + pet.soLuong.ToString().PadRight(8));

        }

        public void XuatDanhSachPet(List<BanPet> ds)
        {
            int temp = 0;
            XuatTieuDe();
            foreach (BanPet pet in ds)
            {
                XuatMotPet(pet, temp);
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
                            tam[2], tam[3], tam[4], tam[5], int.Parse(tam[6]), int.Parse(tam[7]));
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
            List<TongThuNhap> tongThuNhap = new List<TongThuNhap>();
            List<BanPet> ds = new List<BanPet>();
            IBanPet ql = new QuanLyPet();
            List<Buyer> ds_buyer = new List<Buyer>();
            List<MatHangBanChay> matHangBanChay = new List<MatHangBanChay>();
            int luaChon;
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
                Console.WriteLine("8.xuat tong doanh thu tung mat hang cac ngay");
                Console.WriteLine("9.xuat mat hang ban chay nhat");
                Console.WriteLine("10.xoa pet");
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
                        Console.WriteLine("danh sach ban dau la:");
                        ql.XuatDanhSachPet(ds);
                        Console.WriteLine($"nhap vi tri cua pet can sua(tu 0 den {ds.Count - 1}):");
                        vt = int.Parse(Console.ReadLine());
                        string canSua;
                        Console.WriteLine("nhap thong tin du lieu can sua (gom: ten,nguon goc,gioi tinh,can nang,tuoi tho,loai,gia,so luong): ");
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
                        ql.BanVatNuoi(ds, ds_buyer, tongThuNhap, matHangBanChay);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("7.xem danh sach vat nuoi da duoc ban");
                        ql.XuatThongTinKhachHang(ds_buyer);
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("8.luu tong doanh thu tung mat hang cac ngay ra file");
                        ql.XuatDSThuNhap(tongThuNhap);
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine("9.luu mat hang ban chay nhat ra file");
                        ql.XuatDSBanChay(matHangBanChay);
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.WriteLine("10.xoa pet");
                        string Name,loai,nguonGoc;
                        Console.WriteLine("nhap ten pet can xoa: ");
                        Name=Console.ReadLine();
                        Console.WriteLine("nhap nguon goc pet: ");
                        nguonGoc=Console.ReadLine();
                        Console.WriteLine("nhap loai pet: ");
                        loai=Console.ReadLine();
                        ds.RemoveAll((a) =>
                        {
                            return (a.Name==Name&&a.nguonGoc==nguonGoc&&a.loai==loai);
                        });
                        Console.WriteLine("danh sach sau khi xoa la: ");
                        ql.XuatDanhSachPet(ds);
                        break;

                    default:
                        Console.WriteLine("lua chon cua ban nhap khong ton tai hay nhap lai!!");
                        break;
                }
            }

        }
    }
}
