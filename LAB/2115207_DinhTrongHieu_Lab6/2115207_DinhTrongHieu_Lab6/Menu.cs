using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_Lab6
{
    internal class Menu
    {
        enum menu
        {
            Thoat=1, NhapDS, XuatDS, TimMTGiaMAX, DSMT2ThanhRam, SapTheoGia, TongGiaMT, SapGiamTheoTen
                , TimMTCoGiaRamMAX, TimMTCoGiaRamMIN, TimMTCPUMAX, TimMTCPUMIN, TimMTLinhKienMAX,
            XoaMTTruoc2000, ChenMTVaoTruocVTi, NhapDSFIle
        }
        public static void XuLyMenu()
        {
            string[] menuChu =
            {
"1. Thoát chương trình.",
"2. Nhập danh sách ít nhất 5 máy tính.",
"3. Xuất danh sách máy tính.",
"4. Tìm máy tính có giá lớn nhất.",
"5. Tìm danh sách máy tính có 2 thanh Ram.",
"6. Hiển thị các máy tính theo giá.",
"7. Tính tổng giá của danh sách máy tính.",
"8. Sắp xếp danh sách máy tính có giảm theo tên.",
"9. Tìm các máy tính có giá Ram cao nhất;","10. thất nhấp.",
"11.Tìm các máy tính CPU cao nhất;","12. CPU thấp nhất.",
"13.Tìm các máy tính có nhiều linh kiện nhất.",
"14.Xóa các máy tính sản xuất trước năm 2000.",
"15.Chèn máy tính(mt) vào danh sách trước vị trí vào vị trí i.",
"16.Nhập danh sách máy tính từ file dsmaytinh.txt"
            };
            menu chon;
            QuanLyMayTinh ql=new QuanLyMayTinh();
            while (true)
            {
                Console.Clear();
                foreach(string ch in menuChu)
                {
                    Console.WriteLine(ch);
                }
                Console.WriteLine("hay nhap lua chon cua ban: ");
                chon = (menu)int.Parse(Console.ReadLine());
                Console.WriteLine(menuChu[((int)chon)-1]);
                switch (chon)
                {
                    case menu.Thoat:
                        return;
                    case menu.NhapDS:
                        ql.NhapCD();
                        Console.WriteLine((int)menu.NhapDSFIle);
                        Console.ReadKey();
                        break;
                    case menu.XuatDS:
                        Console.WriteLine(ql);
                        
                        Console.ReadKey();
                        break;
                    case menu.TimMTGiaMAX:
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        Console.WriteLine("danh sach mt gia tri max : ");
                        ql.XuatDS(ql.GiaMAX());
                        Console.ReadKey();
                        break;
                    case menu.DSMT2ThanhRam:
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        Console.WriteLine("danh sach mt 2 thanh RAM : ");
                        ql.XuatDS(ql.mt2ThanhRam());
                        Console.ReadKey();
                        break;
                    case menu.SapTheoGia:
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        Console.WriteLine("danh sach mt : ");
                        ql.SapTheoGia();
                        Console.ReadKey();
                        break;
                    case menu.TongGiaMT:
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        Console.WriteLine($"tong gia: {ql.TongGia}");

                        Console.ReadKey();
                        break;
                    case menu.SapGiamTheoTen:
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        Console.WriteLine("danh sach mt sau khi sap xep : ");
                        ql.SapXepGiamTheoTen();
                        Console.WriteLine(ql);
                        Console.ReadKey();
                        break;
                    case menu.TimMTCoGiaRamMAX:
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        Console.WriteLine("danh sach mt gia RAM max : ");
                        ql.XuatDS(ql.GiaRamMAX());
                        Console.ReadKey();
                        break;
                    case menu.TimMTCoGiaRamMIN:
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        Console.WriteLine("danh sach mt gia RAM min : ");
                        ql.XuatDS(ql.GiaRamMIN());
                        Console.ReadKey();
                        break;
                    case menu.TimMTCPUMAX:
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        Console.WriteLine("danh sach mt gia CPU max : ");
                        ql.XuatDS(ql.GiaCPUMAX());
                        Console.ReadKey();
                        break;
                    case menu.TimMTCPUMIN:
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        Console.WriteLine("danh sach mt gia CPU min : ");
                        ql.XuatDS(ql.GiaCPUMIN());
                        Console.ReadKey();
                        break;
                    case menu.TimMTLinhKienMAX:
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        Console.WriteLine("danh cach mt co  nhieu thiet bi nhat la: ");
                        ql.XuatDS(ql.MayLinhKienMAX());
                        Console.ReadKey();
                        break;
                    case menu.XoaMTTruoc2000:
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        ql.XoaMTTruoc2000();
                        Console.WriteLine("danh sach mt sau khi xoa : ");
                        Console.WriteLine(ql);
                        Console.ReadKey();
                        break;
                    case menu.ChenMTVaoTruocVTi:
                        int vt;
                        MayTinh mt=new MayTinh();
                        Console.WriteLine("danh sach mt : ");
                        Console.WriteLine(ql);
                        Console.WriteLine("nhap vi tri index can them: ");
                        vt=int.Parse(Console.ReadLine());
                        ql.NhapMTBanPhim(mt);
                        ql.ThemVTi(vt, mt);
                        Console.WriteLine("danh sach mt sau khi them: ");
                        Console.WriteLine(ql);
                        Console.ReadKey();
                        break;
                    case menu.NhapDSFIle:
                        
                        ql.NhapFile();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
