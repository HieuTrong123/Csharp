using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_Lab5
{
    internal class Menu
    {
        enum menu
        {
            Thoat = 1, NhapDS, XuatDS, TimDTMax, DSHVDTNhoNhat, SapTangDT, TongDtHinhTron, SapTangHinhTron, DsDTNhoHonX,
            DemSoLuongHinh, XoaTatCaLoaiHinh, ChenHinhTron, XoaHinhVuongDtMin, SapHinhHocttt, SapTamGiacGiam, XoaTGDTMin
        }
        public static void XuatMenu()
        {
            Console.WriteLine("1.Thoát chương trình.");
            Console.WriteLine("2.Nhập danh sách hình học ít nhất 3 hình vuông, 3 hình chữ nhật và 3 hình tròn.");
            Console.WriteLine("3.Xuất danh sách hình học.");
            Console.WriteLine("4.Tìm hình có diện tích lớn nhất.");
            Console.WriteLine("5.Tìm danh sách hình vuông có diện tích nhỏ nhất.");
            Console.WriteLine("6.Hiển thị các hình theo chiều tăng diện tích.");
            Console.WriteLine("7.Tính tổng diện tích hình tròn có trong danh sách.");
            Console.WriteLine("8.Sắp xếp danh sách hình tròn tăng dần theo diện tích(các hình khác giữ nguyên vị trí).");
            Console.WriteLine("9.Tìm danh sách hình có diện tích nhỏ hơn x(x nhập từ bàn phím).");
            Console.WriteLine("10.Đếm số lượng hình theo LoaiHinh.");
            Console.WriteLine("11.Xóa tất cả các hình theo LoaiHinh có trong danh sách.");
            Console.WriteLine("12.Chèn hình tròn trước vị trí hình cuối cùng có diện tích lớn nhất.");
            Console.WriteLine("13.Xóa hình vuông có diện tích nhỏ nhất.");
            Console.WriteLine("14.Sắp xếp danh sách hình học theo thứ tự:");
            Console.WriteLine("\tHình tròn đứng đầu và giảm dần theo diện tích.");
            Console.WriteLine("\tTiếp theo là các hình khác tăng dần theo diện tích.");
            Console.WriteLine("15.Sắp xếp hình tam giác giảm dần theo diện tích(các hình khác giữ nguyên vị trí).");
            Console.WriteLine("16.Xóa hình tam giác có diện tích nhỏ nhất.");
        }
        public static void XuLyMenu()
        {
            QuanLyHinhHoc ql = new QuanLyHinhHoc();
            menu chon;
            while (true)
            {
               
                Console.Clear();
                XuatMenu();
                Console.WriteLine("nhap lua chon cua ban: ");
                chon = (menu)int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case menu.Thoat:
                        Console.Clear();
                        Console.WriteLine("1.Thoát chương trình.");
                        return;
                    case menu.NhapDS:
                        Console.Clear();
                        Console.WriteLine("2.Nhập danh sách hình học ít nhất 3 hình vuông, 3 hình chữ nhật và 3 hình tròn.");

                        ql.NhapDS();

                        Console.WriteLine("danh sach duoc tao la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        Console.ReadKey();
                        break;
                    case menu.XuatDS:
                        Console.Clear();
                        Console.WriteLine("3.Xuất danh sách hình học.");

                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        Console.ReadKey();
                        break;
                    case menu.TimDTMax:
                        Console.Clear();
                        Console.WriteLine("4.Tìm hình có diện tích lớn nhất.");

                        Console.WriteLine("danh sach ban dau la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });

                        Console.WriteLine("\n\n\t\thinh co dien tich lon nhat la: ");
                        ql.TimDTMax().ForEach(e => Console.WriteLine(e));
                        Console.ReadKey();
                        break;
                    case menu.DSHVDTNhoNhat:
                        Console.Clear();
                        Console.WriteLine("5.Tìm danh sách hình vuông có diện tích nhỏ nhất.");

                        Console.WriteLine("danh sach ban dau la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });

                        Console.WriteLine("\n\n\t\thinh hình vuông có diện tích nhỏ nhất la: ");
                        ql.TimDtHVMin().ForEach(e => Console.WriteLine(e));
                        Console.ReadKey();
                        break;
                    case menu.SapTangDT:
                        Console.Clear();
                        Console.WriteLine("6.Hiển thị các hình theo chiều tăng diện tích.");

                        Console.WriteLine("danh sach ban dau la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });

                        Console.WriteLine("danh sach sau khi sao xep la: ");
                        ql.SapXepTangDt();
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        Console.ReadKey();
                        break;
                    case menu.TongDtHinhTron:
                        Console.Clear();
                        Console.WriteLine("7.Tính tổng diện tích hình tròn có trong danh sách.");

                        Console.WriteLine("danh sach ban dau la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });

                        Console.WriteLine($"tong dien tich hinh tron la: {ql.TongDtHinhTron()}");
                        Console.ReadKey();
                        break;
                    case menu.SapTangHinhTron:
                        Console.Clear();
                        Console.WriteLine("8.Sắp xếp danh sách hình tròn tăng dần theo diện tích(các hình khác giữ nguyên vị trí).");

                        Console.WriteLine("danh sach ban dau la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        ql.SapTangHinhTron();

                        Console.WriteLine("danh sach sau khi sao xep la: ");

                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        Console.ReadKey();
                        break;
                    case menu.DsDTNhoHonX:
                        Console.Clear();
                        Console.WriteLine("9.Tìm danh sách hình có diện tích nhỏ hơn x(x nhập từ bàn phím).");

                        Console.WriteLine("danh sach ban dau la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        double x;
                        Console.WriteLine("nhap x: ");
                        x = double.Parse(Console.ReadLine());
                        ql.HinhDTNhoHonX(x).ForEach(e => Console.WriteLine(e));
                        Console.ReadKey();
                        break;
                    case menu.DemSoLuongHinh:
                        Console.Clear();
                        Console.WriteLine("10.Đếm số lượng hình theo LoaiHinh.");

                        Console.WriteLine("danh sach ban dau la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });

                        Console.WriteLine("\n\n\t\tDanh Sach cac thong ke: ");
                        ql.DemSoLuongHinhTheoLoai();
                        Console.ReadKey();
                        break;
                    case menu.XoaTatCaLoaiHinh:
                        Console.Clear();
                        Console.WriteLine("11.Xóa tất cả các hình theo LoaiHinh có trong danh sách.");

                        Console.WriteLine("danh sach ban dau la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });

                        ql.XoaLoaiHinh();

                        Console.WriteLine("danh sach sau khi xoa la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        Console.ReadKey();
                        break;
                    case menu.ChenHinhTron:
                        Console.Clear();
                        Console.WriteLine("12.Chèn hình tròn trước vị trí hình cuối cùng có diện tích lớn nhất.");
                        Console.WriteLine("danh sach ban dau la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        double bk;

                        Console.WriteLine("nhap ban kinh hinh tron muon them: ");
                        bk = double.Parse(Console.ReadLine());
                        HinhTron ht = new HinhTron(bk);
                        ql.ChenHinhTron(ht);

                        Console.WriteLine("danh sach sau khi chen hinh tron la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        Console.ReadKey();
                        break;
                    case menu.XoaHinhVuongDtMin:
                        Console.Clear();
                        Console.WriteLine("13.Xóa hình vuông có diện tích nhỏ nhất.");

                        Console.WriteLine("danh sach ban dau la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        ql.XoaHinhVuongDtMin();
                        Console.WriteLine("danh sach sau khi xoa la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        Console.ReadKey();
                        break;
                    case menu.SapHinhHocttt:
                        Console.Clear();
                        Console.WriteLine("14.Sắp xếp danh sách hình học theo thứ tự:");
                        Console.WriteLine("\tHình tròn đứng đầu và giảm dần theo diện tích.");
                        Console.WriteLine("\tTiếp theo là các hình khác tăng dần theo diện tích.");

                        Console.WriteLine("danh sach ban dau la: ");

                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        ql.SapXepTTT();

                        Console.WriteLine("danh sach sau khi sap xep la: ");

                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        Console.ReadKey();
                        break;

                    case menu.SapTamGiacGiam:
                        Console.Clear();
                        Console.WriteLine("15.Sắp xếp hình tam giác giảm dần theo diện tích(các hình khác giữ nguyên vị trí).");

                        Console.WriteLine("danh sach ban dau la: ");

                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        ql.SapTangHinhTG();

                        Console.WriteLine("danh sach sau khi sap xep la: ");

                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        Console.ReadKey();
                        break;
                    case menu.XoaTGDTMin:
                        Console.Clear();
                        Console.WriteLine("16.Xóa hình tam giác có diện tích nhỏ nhất.");

                        Console.WriteLine("danh sach ban dau la: ");
                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        ql.XoaHinhTGDtMin();

                        Console.WriteLine("danh sach sau khi xoa la: ");

                        ql.ds.ForEach(e => { Console.WriteLine(e); Console.ForegroundColor = ConsoleColor.White; });
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
