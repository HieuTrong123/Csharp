using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KieuLiet_Menu
{
    internal class Program
    {
        enum Menu
        {
            Thoat = 10, //0
            LayHo,
            LayTen,
            LayTenLot,
            TimChuoi,
            ChuyenInHoa,
            ChuyenThuong
        }

        static void Main()
        {

            //Menu m = Menu.LayHo;
            //Console.WriteLine("Nhap {0} de {1}", (int)m, m);

            //int somenu = (int)Menu.ChuyenThuong + 1 - (int)Menu.Thoat;
            //Console.WriteLine("So menu chuong trinh {0}", somenu);
           
            
            ChayCT();
            

            Console.ReadKey();
        }

        static void ChayCT()
        {
            string hoTen;
            Console.WriteLine("nhap ho ten ma ban muon xu ly : ");
            hoTen = Console.ReadLine();
            XuatMenu();
            //Chuyen so nguyen ve Menu
            int chon = ChonMenu();
            Menu mchon = (Menu)chon;
            Console.WriteLine("Ban da chon {0} de thuc hien {1}", chon, mchon);

            XuLyMenu(hoTen, mchon);

        }
        static void XuatMenu()
        {
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.Thoat, Menu.Thoat);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.LayHo, Menu.LayHo);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.LayTen, Menu.LayTen);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.LayTenLot, Menu.LayTenLot);

            Console.WriteLine("Nhap {0} de {1}", (int)Menu.TimChuoi, Menu.TimChuoi);

            Console.WriteLine("Nhap {0} de {1}", (int)Menu.ChuyenInHoa, Menu.ChuyenInHoa);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.ChuyenThuong, Menu.ChuyenThuong);


        }

        static int ChonMenu()
        {
            int chon = 0;
            do
            {
                Console.Write("\nNhap chon [{0}...{1}]:",
                    (int)Menu.Thoat, (int)Menu.ChuyenThuong);
                chon = int.Parse(Console.ReadLine());

                if ((int)Menu.Thoat <= chon && chon <= (int)Menu.ChuyenThuong)
                    break;

            } while (true);
            return chon;
        }

        static void XuLyMenu(string hoten, Menu m)
        {
            string s = "";
            Console.WriteLine("Ho ten la: \"{0}\"", hoten);
            switch (m)
            {
                case Menu.Thoat:
                    break;
                case Menu.LayHo:
                    s = LayHo(hoten);
                    Console.WriteLine("Ho cua ban la: {0}", s);
                    break;
                case Menu.LayTen:
                    s = LayTen(hoten);
                    Console.WriteLine("Ten cua ban la: {0}", s);
                    break;
                case Menu.LayTenLot:
                    hoten.Trim();
                    var x = hoten.IndexOf(' ');
                    var y = hoten.LastIndexOf(' ');
                    var c = hoten.Substring(x, y-x);
                    Console.WriteLine("ten Lot la: " + c);
                    break;
                case Menu.TimChuoi:

                    break;
                case Menu.ChuyenInHoa:
                   Console.WriteLine($"chuoi in HOA la : {hoten.ToUpper()}" );
                    break;
                case Menu.ChuyenThuong:
                    Console.WriteLine($"Chuoi in Thuong la :{hoten.ToLower()}");
                    
                    break;
                default:
                    break;
            }
        }
        static string LayHo(string hoten)
        {
            string[] ss = hoten.Split(' ');
            return ss[0];
        }

        static string LayHoSubstring(string hoten)
        {
            int vt = hoten.Trim().IndexOf(' ');
            string ho = hoten.Substring(0, vt);
            return ho;
        }
        static string LayTen(string hoten)
        {
            string[] ss = hoten.Split(' ');
            int n = ss.Length;
            return ss[n - 1];
        }


    }
}
