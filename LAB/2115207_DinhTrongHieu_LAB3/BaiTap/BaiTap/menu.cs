using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class menu
    {
        enum Menu
        {
            ThoatChuongTrinh = 1, TaoPhuongThucTaoLapQUanLySinhVien, ThemSinhVienVaoDanhSach, NhapDanhSachSinhVienTuBanPhim,
            NhapDanhSachCoDinhCo10SinhVien, XuatDanhSachSinhVien, TimDiemTrungBinhCong, TimDanhSachSinhVienTheoTen,
            TimDanhSachSinhVienCoDiemTrungBinhMAX, TimDanhSachSinhVienCoTenX, ThongKeSoLuongSinhVienKhongDat, SapXepTangDanTheoTen,
            SapXepDanhSachGiamTheoChieuDaiCuaHoTen, SapXepGiamTheoDiemTrungBinhNeuDiemTBTrungSapGiamTheoHoSinhVien, ChenSinHVienSVSauSinhVienCoMaSoX,
            XoaSInhVienTheoMaSo, XoaSinhVienDauTienCoTenX, XoaTatCaSinhVienCoTenX
        }
        static void XuatMenu()
        {
            Console.WriteLine("\n\n\t\t===============MENU===============");
            Console.WriteLine("1. Thoát chương trình.");
            Console.WriteLine("2. Tạo phương thức tạo lập QuanLySinhVien không có tham số.");
            Console.WriteLine("3. Thêm sinh viên vào danh sách (mã sinh viên là duy nhất).");
            Console.WriteLine("4. Nhập danh sách sinh viên từ bàn phím.");
            Console.WriteLine("5. Nhập danh sách cố định gồm 10 sinh viên.");
            Console.WriteLine("6. Xuất danh sách sinh viên: sử dụng Padleft, Padright để căn lề.");
            Console.WriteLine("7. Tính điểm trung bình cộng.");
            Console.WriteLine("8. Tìm danh sách sinh viên theo tên.");
            Console.WriteLine("9. Tìm danh sách sinh viên có điểm trung bình max.");
            Console.WriteLine("10.Tìm danh sách sinh viên có tên x.");
            Console.WriteLine("11.Thống kê số lượng sinh viên có không đạt (điểm trung bình < 5.5).");
            Console.WriteLine("12.Sắp xếp danh sách sinh viên tăng theo tên.");
            Console.WriteLine("13.Sắp xếp danh sách sinh viên giảm dần theo chiều dài của họ tên");
            Console.WriteLine("14.Sắp xếp danh sách giảm theo điểm trung bình, nếu điểm trung bình trùng nhau thì sắpgiảm theo họ sinh viên.");
            Console.WriteLine("15.Chèn sinh viên sv sau khi viên có mã số x.");
            Console.WriteLine("16.Xóa sinh viên theo mã số.");
            Console.WriteLine("17.Xóa sinh viên đầu tiên trong danh sách có tên x.");
            Console.WriteLine("18.Xóa tất cả sinh viên có tên x.");
            Console.WriteLine("\n\n\t\t===============MENU===============");
        }
        static public void XuLyMenu()
        {
            Menu chon;
            QuanLySinhVien ql = new QuanLySinhVien();

            while (true)
            {
                Console.Clear();
                XuatMenu();
                Console.WriteLine("nhap lua chon cua ban: ");
                chon = (Menu)int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case Menu.ThoatChuongTrinh:
                        return;
                    case Menu.TaoPhuongThucTaoLapQUanLySinhVien:
                        Console.WriteLine("2. Tạo phương thức tạo lập QuanLySinhVien không có tham số.");
                        ql = new QuanLySinhVien("khoi tao quan ly sinh vien thanh cong");
                        Console.ReadKey();
                        break;
                    case Menu.ThemSinhVienVaoDanhSach:
                        Console.WriteLine("3. Thêm sinh viên vào danh sách (mã sinh viên là duy nhất).");
                        ql.ThemMotSinHVien();
                        Console.ReadKey();
                        break;

                    case Menu.NhapDanhSachSinhVienTuBanPhim:
                        Console.WriteLine("4. Nhập danh sách sinh viên từ bàn phím.");
                        ql.NhapDanhSach();
                        Console.ReadKey();
                        break;
                    case Menu.NhapDanhSachCoDinhCo10SinhVien:
                        Console.WriteLine("5. Nhập danh sách cố định gồm 10 sinh viên.");
                        ql.NhapDanhSachCoDinh();
                        Console.ReadKey();
                        break;
                    case Menu.XuatDanhSachSinhVien:
                        Console.WriteLine("6. Xuất danh sách sinh viên: sử dụng Padleft, Padright để căn lề.");
                        ql.XuatDanhSach();
                        Console.ReadKey();
                        break;
                    case Menu.TimDiemTrungBinhCong:
                        Console.WriteLine("7. Tính điểm trung bình cộng.");
                        Console.WriteLine("danh sach la: ");
                        ql.XuatDanhSach();
                        Console.WriteLine("trung binh cong la: " + ql.TinhDiemTrungBinhCong());
                        Console.ReadKey();
                        break;
                    case Menu.TimDanhSachSinhVienTheoTen:
                        Console.WriteLine("8. Tìm danh sách sinh viên theo tên.");
                        Console.WriteLine("danh sach :");
                        ql.XuatDanhSach();
                        string hoTen;
                        Console.WriteLine("nhap ho ten : ");
                        hoTen = Console.ReadLine();
                        ql.DanhSachTheoTen(hoTen);


                        Console.ReadKey();
                        break;
                    case Menu.TimDanhSachSinhVienCoDiemTrungBinhMAX:
                        Console.WriteLine("9. Tìm danh sách sinh viên có điểm trung bình max.");
                        Console.WriteLine("danh sach ban dau:");
                        ql.XuatDanhSach();
                        ql.DanhSachDiemTBMAX();
                        Console.ReadKey();
                        break;
                    case Menu.TimDanhSachSinhVienCoTenX:
                        Console.WriteLine("10.Tìm danh sách sinh viên có tên x.");
                        Console.WriteLine("danh sach ban dau:");
                        ql.XuatDanhSach();
                        string tenX;
                        Console.WriteLine("nhap ten X can xet: ");
                        tenX = Console.ReadLine();
                        ql.DanhSachSVTenX(tenX);
                        Console.ReadKey();
                        break;
                    case Menu.ThongKeSoLuongSinhVienKhongDat:
                        Console.WriteLine("11.Thống kê số lượng sinh viên có không đạt (điểm trung bình < 5.5).");
                        Console.WriteLine("danh sach ban dau:");
                        ql.XuatDanhSach();
                        ql.DanhSachSVKhongDat();
                        Console.ReadKey();
                        break;
                    case Menu.SapXepTangDanTheoTen:
                        Console.WriteLine("12.Sắp xếp danh sách sinh viên tăng theo tên.");
                        Console.WriteLine("danh sach ban dau:");
                        ql.XuatDanhSach();
                        ql.SapXepTheoTen();
                        Console.WriteLine("danh sach sau khi sap xep la: ");
                        ql.XuatDanhSach();
                        Console.ReadKey();
                        break;
                    case Menu.SapXepDanhSachGiamTheoChieuDaiCuaHoTen:
                        Console.WriteLine("13.Sắp xếp danh sách sinh viên giảm dần theo chiều dài của họ tên");
                        Console.WriteLine("danh sach ban dau:");
                        ql.XuatDanhSach();
                        ql.SapXepChieuDaiHoTen();
                        Console.WriteLine("danh sach sau khi sap xep la: ");
                        ql.XuatDanhSach();
                        Console.ReadKey();
                        break;
                    case Menu.SapXepGiamTheoDiemTrungBinhNeuDiemTBTrungSapGiamTheoHoSinhVien:
                        Console.WriteLine("14.Sắp xếp danh sách giảm theo điểm trung bình, nếu điểm trung bình trùng nhau thì sắp giảm theo họ sinh viên.");
                        Console.WriteLine("danh sach ban dau:");
                        ql.XuatDanhSach();
                        ql.SapTheoDTBvaHoSinhVien();
                        Console.WriteLine("danh sach sau khi sap xep la: ");
                        ql.XuatDanhSach();
                        Console.ReadKey();
                        break;

                    case Menu.ChenSinHVienSVSauSinhVienCoMaSoX:
                        Console.WriteLine("15.Chèn sinh viên sv sau khi viên có mã số x.");
                        Console.WriteLine("danh sach ban dau:");
                        ql.XuatDanhSach();
                        ql.ChenSVTaiVT();
                        Console.WriteLine("danh sach sau khi chen la: ");
                        ql.XuatDanhSach();
                        Console.ReadKey();
                        break;
                    case Menu.XoaSInhVienTheoMaSo:
                        Console.WriteLine("16.Xóa sinh viên theo mã số.");
                        Console.WriteLine("danh sach ban dau:");
                        ql.XuatDanhSach();
                        string maSo;
                        Console.WriteLine("nhap ma so sinh vien can xoa: ");
                        maSo = Console.ReadLine();
                        ql.XoaSinhVienCoMaSo(maSo);
                        Console.WriteLine("danh sach sau khi xoa la: ");
                        ql.XuatDanhSach();
                        Console.ReadKey();
                        break;
                    case Menu.XoaSinhVienDauTienCoTenX:
                        Console.WriteLine("17.Xóa sinh viên đầu tiên trong danh sách có tên x.");
                        Console.WriteLine("danh sach ban dau:");
                        ql.XuatDanhSach();
                        string ten;
                        Console.WriteLine("nhap ten can xoa : ");
                        ten = Console.ReadLine();
                        ql.XoaSinhVienDauTienCoTenX(ten);
                        Console.WriteLine("danh sach sau khi xoa la: ");
                        ql.XuatDanhSach();
                        Console.ReadKey();
                        break;
                    case Menu.XoaTatCaSinhVienCoTenX:
                        Console.WriteLine("18.Xóa tất cả sinh viên có tên x.");
                        Console.WriteLine("danh sach ban dau:");
                        ql.XuatDanhSach();
                        string tenSV;
                        Console.WriteLine("nhap ten can xoa : ");
                        tenSV = Console.ReadLine();
                        ql.XoaSinhVienALLCoTenX(tenSV);
                        Console.WriteLine("danh sach sau khi xoa la: ");

                        ql.XuatDanhSach();
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
