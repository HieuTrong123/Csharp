using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DInhTrongHieu_LAB04
{
    static class menu
    {
        enum _Menu
        {
            Thoat, ThemPs, NhapThuCong, NhapTuDong, DocFile, Xuat, RutGon, TimMauT, TimPsX, TongPs, TimMax, SapXepTang, SapXepGiam, ChenVT, XoaMotMin
                , XoaAllMin
        }

        static string[] MenuChu = new string[]{"Thoát chương trình.",
            "Thêm phân số vào danh sách.",
            "Nhập danh sách phân số từ bàn phím.",
            "Nhập danh sách cố định gồm 10 phân số.",
            "Đọc danh sách phân số từ file. Với dạng file danh sách phân số (dsphanso.txt) ",
            "Xuất danh sách phân số.",
            "Rút gọn danh sách phân số.",
            "Tìm danh sách phân số có mẫu = t.",
            "Tìm danh sách phân số = phân số x.",
            "Tính tổng danh sách phân số trả về số thực.",
            "Tìm danh sách phân số có giá trị Max.",
            "Sắp xếp danh sách phân số tăng.",
            "Sắp xếp danh sách phân số giảm dần.",
            "Chèn phân số tại vị trí index.",
            "Xóa phân số có giá trị nhỏ nhất.",
            "Xóa tất cả phân số có giá trị nhỏ nhất."};

        static void Menu()
        {
            for (int i = 0; i < MenuChu.Length; i++)
            {
                Console.WriteLine($"{i}. {MenuChu[i]}");
            };
        }
        public static void XuLyMenu()
        {
            QuanLyPhanSo ql = new QuanLyPhanSo();
            _Menu chon;
            while (true)
            {
                Console.Clear();
                Menu();
                Console.WriteLine("nhap lua chon cua ban: ");
                chon = (_Menu)int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine(MenuChu[(int)chon]);
                switch (chon)
                {
                    case _Menu.Thoat:
                        return;
                    case _Menu.ThemPs:
                        ql.NhapThuCong(1);
                        Console.ReadKey();
                        break;
                    case _Menu.NhapThuCong:
                        int So;
                        Console.WriteLine("nhap so luong phan so muon them: ");
                        So = int.Parse(Console.ReadLine());

                        ql.NhapThuCong(So);
                        Console.WriteLine("danh sach la: ");
                        ql.Xuat(ql.ds);
                        Console.ReadKey();
                        break;
                    case _Menu.NhapTuDong:
                        ql.NhapTuDong();
                        Console.WriteLine("danh sach la: ");
                        ql.Xuat(ql.ds);
                        Console.ReadKey();
                        break;
                    case _Menu.DocFile:
                        ql.DocFile();
                        Console.WriteLine("danh sach la: ");
                        ql.Xuat(ql.ds);
                        Console.ReadKey();
                        break;
                    case _Menu.Xuat:
                        ql.Xuat(ql.ds);
                        Console.ReadKey();
                        break;
                    case _Menu.RutGon:
                        Console.WriteLine("danh sach la: ");
                        ql.Xuat(ql.ds);
                        ql.RutGonDS();
                        Console.WriteLine("danh sach la: ");
                        ql.Xuat(ql.ds);
                        Console.ReadKey();

                        break;
                    case _Menu.TimMauT:
                        int mauSo;
                        Console.WriteLine("danh sach la: ");
                        ql.Xuat(ql.ds);
                        Console.WriteLine("nhap mau so can tim :");
                        mauSo = int.Parse(Console.ReadLine());
                        //ql.Xuat(ql.TimMauT(mauSo));
                        ql.TimMauT(mauSo);
                        Console.ReadKey();
                        break;
                    case _Menu.TimPsX:
                        Console.WriteLine("danh sach la: ");
                        ql.Xuat(ql.ds);
                        PhanSo x = new PhanSo();
                        x.Nhap();
                        Console.WriteLine("danh sach phan so x: ");
                        //ql.Xuat(ql.TimPsX(x));
                        ql.TimPsX(x);
                        Console.ReadKey();
                        break;
                    case _Menu.TongPs:
                        Console.WriteLine("danh sach la: ");
                        ql.Xuat(ql.ds);
                        Console.WriteLine($"tong phan so la: {Math.Round(ql.TongPs(), 2)}");
                        Console.ReadKey();
                        break;
                    case _Menu.TimMax:
                        Console.WriteLine("danh sach la: ");
                        ql.Xuat(ql.ds);
                        Console.WriteLine($"phan so max la: {ql.Max}");
                        Console.ReadKey();
                        break;
                    case _Menu.SapXepTang:
                        Console.WriteLine("danh sach ban dau la: ");
                        ql.Xuat(ql.ds);
                        Console.WriteLine("danh sach sau khi sap xep la: ");
                        ql.SapXepTang();
                        ql.Xuat(ql.ds);
                        Console.ReadKey();
                        break;
                    case _Menu.SapXepGiam:
                        Console.WriteLine("danh sach ban dau la: ");
                        ql.Xuat(ql.ds);
                        Console.WriteLine("danh sach sau khi sap xep la: ");
                        ql.SapXepGiam();
                        ql.Xuat(ql.ds);
                        Console.ReadKey();
                        break;
                    case _Menu.ChenVT:
                        Console.WriteLine("danh sach ban dau la: ");
                        ql.Xuat(ql.ds);
                        int vt;
                        PhanSo newPS = new PhanSo();
                        Console.WriteLine("nhap vi tri can them: ");
                        vt = int.Parse(Console.ReadLine());
                        newPS.Nhap();
                        ql.ds.Insert(vt, newPS);
                        Console.WriteLine("danh sach sau khi them: ");
                        ql.Xuat(ql.ds);
                        Console.ReadKey();
                        break;
                    case _Menu.XoaMotMin:
                        Console.WriteLine("danh sach ban dau la: ");
                        ql.Xuat(ql.ds);
                        ql.ds.Remove(ql.Min);
                        Console.WriteLine("danh sach sau khi xoa: ");
                        ql.Xuat(ql.ds);
                        Console.ReadKey();
                        break;
                    case _Menu.XoaAllMin:
                        Console.WriteLine("danh sach ban dau la: ");
                        ql.Xuat(ql.ds);
                        ql.XoaAllMin();
                        Console.WriteLine("danh sach sau khi xoa: ");
                        ql.Xuat(ql.ds);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
