using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DSLKDCSharp
{
    internal class Program
    {

        enum Menu
        {
            Thoat, ChucNang1,
            ChucNang2, ChucNang3,
            ChucNang4, ChucNang5,
            ChucNang6, ChucNang7,
            ChucNang8, ChucNang9


        }
        static void Main(string[] args)
        {
            
            var ql = new QuanLySinhVien();
            List<QuanLySinhVien.SinhVien> ds = new List<QuanLySinhVien.SinhVien>();
            
            int n = 0;

            while (true)
            {
                Clear();
                WriteLine("\n\n\t\t=============================================");
                WriteLine("\nNhap {0} de thoat khoi chuong trinh", (int)Menu.Thoat);
                WriteLine("nhap {0} de thuc hien doc thong tin tu file", (int)Menu.ChucNang1);
                WriteLine("nhap {0} de thuc hien xem danh sach sinh vien", (int)Menu.ChucNang2);
                WriteLine("nhap {0} de thuc hien xep loai sinh vien", (int)Menu.ChucNang3);
                WriteLine("nhap {0} de thuc hien tim sinh vien co diem cao nhat", (int)Menu.ChucNang4);
                WriteLine("nhap {0} de thuc hien xuat cac sinh vien co hoc luc cho truoc va thuoc lop cho truoc", (int)Menu.ChucNang5);
                WriteLine("nhap {0} de thuc hien them 1 sinh vien vao vi tri cho truoc", (int)Menu.ChucNang6);
                WriteLine("nhap {0} de thuc hien xoa sinh vien co hoc luc kem", (int)Menu.ChucNang7);
                WriteLine("nhap {0} de thuc hien sap xep sinh vien theo co nam sinh tang dan", (int)Menu.ChucNang8);
                WriteLine("nhap {0} de thuc hien tim kiem sinh co diem trung binh lon hon 8", (int)Menu.ChucNang9);
                WriteLine("\n\n\t\t=============================================");
                WriteLine("\nNhap lua chon cua ban: ");
                Menu Nhap = (Menu)int.Parse(ReadLine());


                switch (Nhap)
                {
                    case Menu.Thoat:
                        {
                            return;
                        }
                    case Menu.ChucNang1:
                        {

                            Clear();
                            ql.NhapDanhSachSinhVien(ds);

                        }
                        break;
                    case Menu.ChucNang2:
                        {
                            Clear();
                            ql.XuatDanhSach(ds);
                        }
                        break;
                    case Menu.ChucNang3:
                        {
                            Clear();
                            foreach (var item in ds)
                            {
                                ql.XepLoai1SV(item);
                            }
                            WriteLine("\nDanh Sach sau khi xep loai la : ");
                            ql.XuatDanhSach(ds);



                        }
                        break;

                    case Menu.ChucNang4:
                        {
                            Clear();
                            var max = ds[0].diem;
                            foreach(var item in ds)
                            {
                                if (item.diem > max)
                                {
                                    max = item.diem;
                                }
                            }
                            var st=ds.FindAll(
                                (e) =>
                                {
                                    return e.diem == max;
                                }
                                );
                            foreach(var item in st)
                            {
                                ql.XuatMotSV(item);
                                WriteLine();
                            }







                        }
                        break;
                    case Menu.ChucNang5:
                        {
                            Clear();
                            WriteLine("nhap hoc luc sinh vien: ");
                            string hocLuc=ReadLine();
                            var x=ds.FindAll(
                                (e) =>
                                {
                                    return string.Compare(e.xepLoai, hocLuc) == 0;
                                }
                           );
                            ql.XuatTieuDe();
                            foreach(var item in x)
                            {
                                ql.XuatMotSV(item);
                                WriteLine();
                            }
                            ql.XuatDongKe('=');
                        }
                        break;
                    case Menu.ChucNang6:
                        {
                            Clear();
                            WriteLine("nhap vi tri can them: ");
                            int vt=int.Parse(ReadLine());
                            QuanLySinhVien.SinhVien newSinhVien = ql.NhapSVTuBanPhim();
                            ds.Insert(vt, newSinhVien);
                            WriteLine("danh sach sau khi them: ");
                            ql.XuatDanhSach(ds);
                        }
                        break;
                    case Menu.ChucNang7:
                        {
                            Clear();
                           var x= ds.FindAll(
                                (e) =>
                                {
                                    return string.Compare(e.xepLoai, "kem")==0;
                                }
                                );
                            foreach(var item in x)
                            {
                                ds.Remove(item);
                            }
                            WriteLine("danh sach sau khi xoa la: ");
                            ql.XuatDanhSach(ds);
                        }
                        break;
                    case Menu.ChucNang8:
                        {
                            Clear();
                            ds.Sort(
                                (q1, q2) =>
                                {
                                    if (q1.namSinh > q2.namSinh) return 1;
                                    if (q1.namSinh == q2.namSinh) return 0;
                                    return -1;
                                }
                                );
                            WriteLine("danh sach sau khi sap xep: ");
                            ql.XuatDanhSach(ds);
                        }
                        break;
                    case Menu.ChucNang9:
                        {
                            Clear();
                            var x = ds.FindAll((e) =>
                            {
                                return e.diem >= 8;
                            });
                            foreach(var item in x)
                            {
                                ql.XuatMotSV(item);
                                WriteLine();
                            }
                        }
                        break;
                    default:
                        {
                            Clear();
                            WriteLine("\nlua chon khong ton tai!");

                        }
                        break;
                }
                ReadKey();
            }

        }
    }
}
