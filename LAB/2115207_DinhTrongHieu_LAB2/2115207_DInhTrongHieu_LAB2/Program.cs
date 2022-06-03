using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DInhTrongHieu_LAB2
{
    internal class Program
    {
        enum Menu
        {
            Thoat,
            NhapDanhSachHT,
            NhapDSCoDinh,
            XuatDanhSachHT,
            InDSTheoHo,
            DemTheoTen,
            ChuanHoaDS,
            DemSoNguoiTenXKhongPhanBietHoaThuong,
            XuatDSInHoa,
            TimHoTenCoChieuDaiLonNhat,
            TimHoTenCoChieuDaiNhoNhat,
            SapXepDanhSachTangTheoHo,
            SapXepDanhSachGiamTheoTen

        }
        static string[] dshoten = new string[100];
        static int length = 0;
        static void Main(string[] args)
        {
            int luaChon;

            while (true)
            {
                Console.Clear();
                XuatMenu();
                luaChon = ChonMenu();
                XuLyMenu((Menu)luaChon);
            }
        }
        static void XuatKeNgang(char kt, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(kt);
            Console.WriteLine();
        }
        static string LayTen(string hoTen)
        {
            var temp = hoTen.Trim();
            var temp1 = temp.Split(' ');

            return temp1[temp1.Length - 1];
        }
        static int XuLyDemTem(string ten)
        {
            int dem = 0;
            foreach (var temp in dshoten)
            {
                if (ten.ToLower() == LayTen(temp.ToLower()))
                {
                    dem++;
                }
            }
            return dem;
        }
        static void XuatMenu()
        {
            XuatKeNgang('-', 40);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.Thoat, Menu.Thoat);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.NhapDanhSachHT, Menu.NhapDanhSachHT);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.NhapDSCoDinh, Menu.NhapDSCoDinh);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.XuatDanhSachHT, Menu.XuatDanhSachHT);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.InDSTheoHo, Menu.InDSTheoHo);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.DemTheoTen, Menu.DemTheoTen);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.ChuanHoaDS, Menu.ChuanHoaDS);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.DemSoNguoiTenXKhongPhanBietHoaThuong, Menu.DemSoNguoiTenXKhongPhanBietHoaThuong);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.XuatDSInHoa, Menu.XuatDSInHoa);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.TimHoTenCoChieuDaiLonNhat, Menu.TimHoTenCoChieuDaiLonNhat);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.TimHoTenCoChieuDaiNhoNhat, Menu.TimHoTenCoChieuDaiNhoNhat);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.SapXepDanhSachGiamTheoTen, Menu.SapXepDanhSachGiamTheoTen);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.SapXepDanhSachTangTheoHo, Menu.SapXepDanhSachTangTheoHo);


            XuatKeNgang('-', 40);
        }
        static int ChonMenu()
        {
            int chon;
            do
            {
                Console.Write("\nNhap chon [{0}...{1}]:",
                (int)Menu.Thoat, (int)Menu.DemTheoTen);
                chon = int.Parse(Console.ReadLine());
                if ((int)Menu.Thoat <= chon && chon <= (int)Menu.SapXepDanhSachGiamTheoTen)
                    break;
            } while (true);
            return chon;
        }
        static string ChuanHoa(string hoTen)
        {
            string m;
            string ketQua = "";
            var temp = hoTen.Trim().Split(' ');
            foreach (var t in temp)
            {
              
                var l = t.ToUpper();
                var k = l.Substring(1, l.Length - 1);
                m = l.Replace(k, k.ToLower());
                ketQua += m + ' ';

            }
            return ketQua;
        }

        static void XuLyMenu(Menu m)
        {
            string hotim;
            switch (m)
            {
                case Menu.Thoat:
                    Console.WriteLine("Thoat chuong trinh");
                    return;
                case Menu.NhapDanhSachHT:
                    Console.WriteLine("Nhap danh sach ho ten");
                    NhapDS();
                    break;
                case Menu.NhapDSCoDinh:
                    Console.WriteLine("Da nhap co dinh danh sach ho ten");
                    NhapCoDinh();
                    break;
                case Menu.XuatDanhSachHT:
                    Console.WriteLine("Danh sach ho ten");
                    XuatDS();
                    break;
                case Menu.InDSTheoHo:
                    XuatDS();
                    Console.Write("\nNhap ho can tim:");
                    hotim = Console.ReadLine();
                    Console.WriteLine("\nDanh sach co ho: {0}", hotim);
                    InDSTheoHo(hotim);
                    break;
                case Menu.DemTheoTen:
                    string ten;
                    Console.WriteLine("nhap ten can dem : ");
                    ten = Console.ReadLine();
                    Console.WriteLine($"so ten {ten} trong danh sach la : { XuLyDemTem(ten)}");
                    break;
                case Menu.ChuanHoaDS:

                    Console.WriteLine("danh sach ban dau: ");
                    XuatDS();
                    for (int i = 0; i < dshoten.Length; i++)
                    {
                        dshoten[i] = ChuanHoa(dshoten[i]);
                    }
                    Console.WriteLine("danh sach sau khi chuan hoa:");
                    XuatDS();

                    break;
                case Menu.DemSoNguoiTenXKhongPhanBietHoaThuong:
                    string ten1;
                    Console.WriteLine("nhap ten can dem : ");
                    ten1 = Console.ReadLine();
                    Console.WriteLine($"so ten {ten1} trong danh sach la : {XuLyDemTem(ten1)}");
                    break;
                case Menu.XuatDSInHoa:
                    Console.WriteLine("danh sach ban dau:");
                    for(int i = 0;i < dshoten.Length; i++)
                    {
                        dshoten[i]=dshoten[i].ToUpper();
                    }
                    Console.WriteLine("danh sach in hoa:");
                    XuatDS();
                    break;
                case Menu.TimHoTenCoChieuDaiLonNhat:
                    for (int i = 0; i < dshoten.Length; i++)
                    {
                        dshoten[i] = ChuanHoa(dshoten[i]);
                    }
                    Console.WriteLine("danh sach:");
                    XuatDS();
                    int max = dshoten[0].Length;
                    for(int i = 1; i < dshoten.Length; i++)
                    {
                        if(dshoten[i].Length > max)
                        {
                            max = dshoten[i].Length;
                        }
                    }
                    foreach(var temp in dshoten)
                    {
                        if(temp.Length == max)
                        {
                            Console.WriteLine($"ho ten lon nhat la {temp} voi {temp.Length} tu ");
                        }
                    }
                    break;
                case Menu.TimHoTenCoChieuDaiNhoNhat:
                    for (int i = 0; i < dshoten.Length; i++)
                    {
                        dshoten[i] = ChuanHoa(dshoten[i]);
                    }
                    Console.WriteLine("danh sach:");
                    XuatDS();
                    int min = dshoten[0].Length;
                    for (int i = 1; i < dshoten.Length; i++)
                    {
                        if (dshoten[i].Length > min)
                        {
                            min = dshoten[i].Length;
                        }
                    }
                    foreach (var temp in dshoten)
                    {
                        if (temp.Length == min)
                        {
                            Console.WriteLine($"ho ten nho nhat la {temp} voi {temp.Length} tu ");
                        }
                    }
                    break;
                case Menu.SapXepDanhSachGiamTheoTen:
                    Console.WriteLine("danh sach ban dau la: ");
                    XuatDS();
                    for(int i=0; i < dshoten.Length; i++)
                    {
                        for(int j = i; j < dshoten.Length; j++)
                        {
                            string a = LayTen(dshoten[i]);
                            string b = LayTen(dshoten[j]);
                            if (string.Compare(a,b)<0)
                            {
                                
                                HoanVI(ref dshoten[i], ref dshoten[j]);
                            }
                        }
                    }
                    Console.WriteLine("danh sach sau khi sap xep: ");
                    XuatDS();
                    break;
                case Menu.SapXepDanhSachTangTheoHo:
                    Console.WriteLine("danh sach ban dau la: ");
                    XuatDS();
                    for (int i = 0; i < dshoten.Length; i++)
                    {
                        for (int j = i; j < dshoten.Length; j++)
                        {
                            string a = LayHo(dshoten[i]);
                            string b = LayHo(dshoten[j]);
                            if (string.Compare(a,b)>0)
                            {

                                HoanVI(ref dshoten[i], ref dshoten[j]);
                            }
                        }
                    }
                    Console.WriteLine("danh sach sau khi sap xep: ");
                    XuatDS();
                    break;
            }
            Console.ReadKey();
        }
        static void HoanVI<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void NhapDS()
        {
            Console.Write("Nhap chieu dai danh sach:");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("Nhap ho ten thu {0}:", i + 1);
                dshoten[i] = Console.ReadLine();
            }
        }
        static void NhapCoDinh()
        {
            dshoten = new string[] {
" Cao Anh tu ",
"Nguyen quoc Khanh ",
"Phan bao Linh",
" Le Hoang Bao",
"Nguyen Lan Huong",
"Phan Anh",
" Le Tran nguyen quoc Khanh",
"Do Thi Huong",
"Nguyen thi thuy Anh",
"le Viet anh "
};
            length = 10;
        }
        static void XuatDS()
        {
            XuatKeNgang('=', 43);
            Console.WriteLine("|{0}|{1}|", "STT".ToString().PadRight(5), "Ho ten".PadLeft(35));
            XuatKeNgang('=', 43);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("|{0}|{1}|", (i + 1).ToString().PadRight(5),
                dshoten[i].PadRight(35));
            }
            XuatKeNgang('=', 43);
        }
        static string LayHo(string hoten)
        {
            string[] ss = hoten.Trim().Split(' ');
            return ss[0];
        }
        static void InDSTheoHo(string hotim)
        {
            int d = 0;
            for (int i = 0; i < length; i++)
            {
                if (LayHo(dshoten[i]).ToLower() == hotim.ToLower())
                    Console.WriteLine("{0}\t{1}", ++d, dshoten[i]);
            }
        }
    }
}
