using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_Lab7
{
    public class Menu
    {
        enum menu
        {
            Thoat = 1, NhapTuFile, XuatDS, TimAnPhamGiaMAX, DSAPNXBx, HienThiAPTHeoGia, TinhTongGiaTien,
            SapGiamTheoTenGia, SapTangTheoTenGia, TimAPCoGiaMin, XoaAPGiaMin, ChenAPTruoci
        }
        public static void XuLyMenu()
        {
            DanhSachAnPham ql=new DanhSachAnPham();
            while (true)
            {
                menu Chon;
                Console.Clear();
                Console.WriteLine("1.Thoát chương trình.");
                Console.WriteLine("2.Đọc danh sách ấn phẩm từ file dsanpham.txt");
                Console.WriteLine("3.Xuất danh sách ấn phẩm(có căn lề).");
                Console.WriteLine("4.Tìm ấn phẩm có giá lớn nhất.");
                Console.WriteLine("5.Tìm danh sách ấn phẩm thuộc nhà xuất bản x.");
                Console.WriteLine("6.Hiển thị các ấn phấm theo giá.");
                Console.WriteLine("7.Tính tổng giá tiền của danh sách ấn phẩm.");
                Console.WriteLine("8.Sắp xếp danh sách ấn phẩm giảm theo tên, giảm theo giá(sử dụng delegate).");
                Console.WriteLine("9.Sắp xếp danh sách ấn phẩm tăng theo tên, tăng theo giá(sử dụng IComparer)");
                Console.WriteLine("10.Tìm các ấn phẩm có giá thấp nhất.");
                Console.WriteLine("11.Xóa tất cả ấn phẩm có giá thấp nhất.");
                Console.WriteLine("12.Chèn ấn phẩm vào danh sách ấn phẩm trước vị trí i");
                Console.WriteLine("nhap lua chon cua ban: ");
                Chon = (menu)int.Parse(Console.ReadLine());
                switch (Chon)
                {
                    case menu.Thoat:
                        return;
                    case menu.NhapTuFile:
                        Console.WriteLine("2.Đọc danh sách ấn phẩm từ file dsanpham.txt");
                        ql.NhapTuFile();
                        Console.ReadKey();
                        break;
                    case menu.XuatDS:
                        Console.WriteLine("3.Xuất danh sách ấn phẩm(có căn lề).");
                       
                        
                        Console.WriteLine(ql);
                        Console.ReadKey();
                        break;
                    case menu.TimAnPhamGiaMAX:
                        Console.WriteLine("4.Tìm ấn phẩm có giá lớn nhất.");
                        Console.WriteLine("\ndanh sach ban dau la:");
                        Console.WriteLine(ql);
                        Console.WriteLine("\ndanh sach an pham gia lon nhat:");
                        Console.WriteLine(ql.TimAnPhamCoGiaCaoNhat());
                        Console.ReadKey();
                        break;
                    case menu.DSAPNXBx:
                        Console.WriteLine("5.Tìm danh sách ấn phẩm thuộc nhà xuất bản x.");
                        string nxb;
                        Console.WriteLine("\ndanh sach ban dau la:");
                        Console.WriteLine(ql);
                        Console.WriteLine("nnhap ten nxb:");
                        nxb= Console.ReadLine();
                        Console.WriteLine(ql.DSAPNXBx(nxb));
                        Console.ReadKey();
                        break;
                    case menu.HienThiAPTHeoGia:
                        Console.WriteLine("6.Hiển thị các ấn phấm theo giá.");
                        Console.WriteLine("\ndanh sach ban dau la:");
                        Console.WriteLine(ql);
                        Console.WriteLine("danh sach theo gia:");
                        ql.XuatTheoGia();
                        Console.ReadKey();
                        break;
                    case menu.TinhTongGiaTien:
                        Console.WriteLine("7.Tính tổng giá tiền của danh sách ấn phẩm.");
                        Console.WriteLine("\ndanh sach ban dau la:");
                        Console.WriteLine(ql);
                        Console.WriteLine("tong gia tien la: {0}",ql.TongGia());
                        Console.ReadKey();
                        break;
                    case menu.SapGiamTheoTenGia:
                        Console.WriteLine("8.Sắp xếp danh sách ấn phẩm giảm theo tên, giảm theo giá(sử dụng delegate).");
                        Console.WriteLine("\ndanh sach ban dau la:");
                        Console.WriteLine(ql);
                        ql.SapXep((e1, e2) =>
                        {
                            IAnPham x=(IAnPham)e1;
                            IAnPham y=(IAnPham)e2;
                            return y.Ten.CompareTo(x.Ten);
                        });
                        Console.WriteLine("danh sach sau khi sap theo ten la: ");
                        Console.WriteLine(ql);
                        ql.SapXep((e1, e2) =>
                        {
                            IAnPham x = (IAnPham)e1;
                            IAnPham y = (IAnPham)e2;
                            return y.GiaTien.CompareTo(x.GiaTien);
                        });
                        Console.WriteLine("danh sach sau khi sap theo gia la: ");
                        Console.WriteLine(ql);
                        Console.ReadKey();
                        break;
                    case menu.SapTangTheoTenGia:
                        Console.WriteLine("9.Sắp xếp danh sách ấn phẩm tăng theo tên, tăng theo giá(sử dụng IComparer)");
                        Console.WriteLine("\ndanh sach ban dau la:");
                        Console.WriteLine(ql);
                        ql.SapXepTheoTen();
                        Console.WriteLine("danh sach sau khi sap theo ten la: ");
                        Console.WriteLine(ql);
                        ql.SapXepTheoGia();
                        Console.WriteLine("danh sach sau khi sap theo gia la: ");
                        Console.WriteLine(ql);
                        Console.ReadKey();
                        break;
                    case menu.TimAPCoGiaMin:
                        Console.WriteLine("10.Tìm các ấn phẩm có giá thấp nhất.");
                        Console.WriteLine("\ndanh sach ban dau la:");
                        Console.WriteLine(ql);
                        Console.WriteLine("danh sach cac an pham co gia min la:");
                        Console.WriteLine(ql.TimAnPhamCoGiaThapNhat());
                        Console.ReadKey();
                        break;
                    case menu.XoaAPGiaMin:
                        Console.WriteLine("11.Xóa tất cả ấn phẩm có giá thấp nhất.");
                        Console.WriteLine("\ndanh sach ban dau la:");
                        Console.WriteLine(ql);
                        ql.XoaAnPhamGiaMin();
                        Console.WriteLine("\ndanh sach sau khi xoa la:");
                        Console.WriteLine(ql);
                        Console.ReadKey();
                        break;
                    case menu.ChenAPTruoci:
                        Console.WriteLine("12.Chèn ấn phẩm vào danh sách ấn phẩm trước vị trí i");
                        int i;
                        Console.WriteLine("\ndanh sach ban dau la:");
                        Console.WriteLine(ql);
                        Console.WriteLine("nhap vi tri can them:");
                        i = int.Parse(Console.ReadLine());
                        ql.InSert(i);
                        Console.WriteLine("\ndanh sach sau khi xoa la:");
                        Console.WriteLine(ql);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\nlua con cua ban khong ton tai hay nhap lai!!!");
                        Console.ReadKey();
                        break;
                }
            }
           
        }
    }
}
