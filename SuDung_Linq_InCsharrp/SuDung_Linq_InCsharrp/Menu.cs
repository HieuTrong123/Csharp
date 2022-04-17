using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDung_Linq_InCsharrp
{

    public static class Menu
    {
        enum menu
        {
            ThoatChuongTrinh, TaoDS,
            XuatDanhSachSinhVien, TimDiemTrungBinhCong, TimDanhSachSinhVienTheoTen,
            TimDanhSachSinhVienCoDiemTrungBinhMAX, TimDanhSachSinhVienCoTenX, ThongKeSoLuongSinhVienKhongDat, SapXepTangDanTheoTen,
            SapXepDanhSachGiamTheoChieuDaiCuaHoTen, SapXepGiamTheoDiemTrungBinhNeuDiemTBTrungSapGiamTheoHoSinhVien
        }
        static void XuatMenu()
        {
            Console.WriteLine("\n\n\t\t===============MENU===============");
            Console.WriteLine("0. Thoát chương trình.");            
            Console.WriteLine("1. Tao Danh Sach Sinh Vien");
            Console.WriteLine("2. Xuất danh sách sinh viên: sử dụng Padleft, Padright để căn lề.");
            Console.WriteLine("3. Tính điểm trung bình cộng.");
            Console.WriteLine("4. Tìm danh sách sinh viên theo tên.");
            Console.WriteLine("5. Tìm danh sách sinh viên có điểm trung bình max.");
            Console.WriteLine("6.Tìm danh sách sinh viên có tên x.");
            Console.WriteLine("7.Thống kê số lượng sinh viên có không đạt (điểm trung bình < 5.5).");
            Console.WriteLine("8.Sắp xếp danh sách sinh viên tăng theo tên.");
            Console.WriteLine("9.Sắp xếp danh sách sinh viên giảm dần theo chiều dài của họ tên");
            Console.WriteLine("10.Sắp xếp danh sách giảm theo điểm trung bình, nếu điểm trung bình trùng nhau thì sắp giảm theo họ sinh viên.");
           
            Console.WriteLine("\n\n\t\t===============MENU===============");
        }
        public static void XuLyMenu()
        {
            QuanLySInhVIen ql =new QuanLySInhVIen();
            List<SinhVien> ds = new List<SinhVien>();
            menu chon;
            while (true)
            {
                Console.Clear();
                XuatMenu();
                Console.WriteLine("nhap lua chon cua ban:");
                chon=(menu)int.Parse(Console.ReadLine());
                if (chon == menu.ThoatChuongTrinh)
                {
                    break;
                }
                else if(chon==menu.TaoDS)
                {
                    Console.WriteLine("1. Tao Danh Sach Sinh Vien");
                    ql.TaoDS(ds);
                    Console.ReadKey();
                }
                else if (chon == menu.XuatDanhSachSinhVien)
                {
                    Console.WriteLine("2. Xuất danh sách sinh viên: sử dụng Padleft, Padright để căn lề.");
                    ql.XemDS(ds);
                    Console.ReadKey();
                }
                else if (chon == menu.TimDiemTrungBinhCong)
                {
                    Console.WriteLine("3. Tính điểm trung bình cộng.");
                    Console.WriteLine("danh sach la: ");
                    ql.XemDS(ds);
                    Console.WriteLine($"diem trung binh cong la: {Math.Round(ql.TimTBC(ds),2)}");
                    Console.ReadKey();
                }
                else if (chon == menu.TimDanhSachSinhVienTheoTen)
                {
                    Console.WriteLine("4. Tìm danh sách sinh viên theo tên.");
                    Console.WriteLine("danh sach la: ");
                    ql.XemDS(ds);
                    string ten;
                    Console.WriteLine("nhap ten : ");
                    ten=Console.ReadLine();
                    Console.WriteLine("danh sach sau khi tim kiem la:");
                    ql.XemDS(ql.DanhSachTheoTen(ds, ten));
                    Console.ReadKey();
                }
                else if (chon == menu.TimDanhSachSinhVienCoDiemTrungBinhMAX)
                {
                    Console.WriteLine("5. Tìm danh sách sinh viên có điểm trung bình max.");
                    Console.WriteLine("danh sach la: ");
                    ql.XemDS(ds);
                    Console.WriteLine("danh sach sau khi tim kiem la:");
                    ql.XemDS(ql.DSDTBMAX(ds));
                    Console.ReadKey();
                }
                else if (chon == menu.TimDanhSachSinhVienCoTenX)
                {
                    Console.WriteLine("6.Tìm danh sách sinh viên có tên x.");
                    Console.WriteLine("danh sach la: ");
                    ql.XemDS(ds);
                    string hoTen;
                    Console.WriteLine("nhap ho ten can xet: ");
                    hoTen=Console.ReadLine();
                    Console.WriteLine("danh sach sau khi tim kiem la:");
                    ql.XemDS(ql.DSSVTenX(ds, hoTen));
                    Console.ReadKey();
                }
                else if (chon == menu.ThongKeSoLuongSinhVienKhongDat)
                {
                    Console.WriteLine("7.Thống kê số lượng sinh viên có không đạt (điểm trung bình < 5.5).");
                    Console.WriteLine("danh sach la: ");
                    ql.XemDS(ds);
                    Console.WriteLine("danh sach sau khi tim kiem la:");
                    ql.XemDS(ql.SVKhongDat(ds));
                    Console.ReadKey();
                }
                else if (chon == menu.SapXepTangDanTheoTen)
                {
                    Console.WriteLine("8.Sắp xếp danh sách sinh viên tăng theo tên.");
                    Console.WriteLine("danh sach la: ");
                    ql.XemDS(ds);
                    Console.WriteLine("danh sach sau khi tim kiem la:");
                    ql.XemDS(ql.SapTangTheoTen(ds));    
                    Console.ReadKey();
                }
                else if (chon == menu.SapXepDanhSachGiamTheoChieuDaiCuaHoTen)
                {
                    Console.WriteLine("9.Sắp xếp danh sách sinh viên giảm dần theo chiều dài của họ tên");
                    Console.WriteLine("danh sach la: ");
                    ql.XemDS(ds);
                    Console.WriteLine("danh sach sau khi tim kiem la:");
                    ql.XemDS(ql.SapGiamTheoCDHoTen(ds));
                    Console.ReadKey();
                }
                else if (chon == menu.SapXepGiamTheoDiemTrungBinhNeuDiemTBTrungSapGiamTheoHoSinhVien)
                {
                    Console.WriteLine("10.Sắp xếp danh sách giảm theo điểm trung bình, nếu điểm trung bình trùng nhau thì sắp giảm theo họ sinh viên.");
                    Console.WriteLine("danh sach la: ");
                    ql.XemDS(ds);
                    Console.WriteLine("danh sach sau khi tim kiem la:");
                    ql.SapGiamTheoDTB(ds);
                    ql.XemDS(ds);
                    Console.ReadKey();
                }


            }
        }
    }

    
}
