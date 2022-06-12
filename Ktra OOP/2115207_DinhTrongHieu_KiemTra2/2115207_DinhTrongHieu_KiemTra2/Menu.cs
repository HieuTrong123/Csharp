using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_KiemTra2
{
    public class Menu
    {
        enum menu
        {
            Thoat=1,NhapTuFile,XuatDS,TimAnPhamGiaMax,SapTangTheoTen
        }
        static void Menu_Chu()
        {
            Console.WriteLine("1.Thoát chương trình.");
            Console.WriteLine("2.Đọc danh sách ấn phẩm từ file dsanpham.txt");
            Console.WriteLine("3.Xuất danh sách ấn phẩm(có căn lề).");
            Console.WriteLine("4.Tìm ấn phẩm có giá lớn nhất.");
            Console.WriteLine("5.Sắp danh sách ấn phẩm tăng theo tên.");
        }
        public static void XuLyMenu()
        {
            DanhSachAnPham ds=new DanhSachAnPham();
            while (true)
            {
                Console.Clear();
                Menu_Chu();
                menu chon;
                Console.WriteLine("nhap lua chon cua ban: ");
                chon=(menu)int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case menu.Thoat:
                        Console.Clear();
                        Console.WriteLine("1.Thoát chương trình.");
                        Console.ReadKey();
                        return;
                    case menu.NhapTuFile:
                        Console.Clear();
                        Console.WriteLine("2.Đọc danh sách ấn phẩm từ file dsanpham.txt");
                        ds.NhapTuFile();
                        Console.ReadKey();
                        break;
                    case menu.XuatDS:
                        Console.Clear();
                        Console.WriteLine("3.Xuất danh sách ấn phẩm(có căn lề).");
                        Console.WriteLine(ds);
                        Console.ReadKey();
                        break;
                    case menu.TimAnPhamGiaMax:
                        Console.Clear();
                        Console.WriteLine("4.Tìm ấn phẩm có giá lớn nhất.");
                        Console.WriteLine("danh sách ban đầu là: ");
                        Console.WriteLine(ds);
                        Console.WriteLine("danh sách ấn phẩm có giá lớn nhất là: ");
                        Console.WriteLine(ds.DSAnPhamGiaMAX());
                        Console.ReadKey();
                        break;
                    case menu.SapTangTheoTen:
                        Console.Clear();
                        Console.WriteLine("5.Sắp danh sách ấn phẩm tăng theo tên.");
                        Console.WriteLine("danh sách ban đầu là: ");
                        Console.WriteLine(ds);
                        ds.SapXepTangTheoTen();
                        Console.WriteLine("danh sách ấn phẩm sau khi sắp tăng theo tên là: ");
                        Console.WriteLine(ds);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
