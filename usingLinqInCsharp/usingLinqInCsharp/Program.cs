using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingLinqInCsharp
{

    internal class Program
    {
        class SanPham
        {
            public string tenSP { get; set; }
            public string[] mauSac { get; set; }
            public int soLuong { get; set; }
            public int giaSP { get; set; }
            public void Xuat()
            {
                Console.WriteLine($"so luong : {soLuong} , ten : {tenSP} , gia: {giaSP}");
                Console.WriteLine("mau sac : ");
                foreach (var item in mauSac)
                {
                    Console.WriteLine(item);
                }
            }



        }
        class ThuongHieu
        {
            public string TenThuongHieu { get; set; }
            public int ID { get; set; }
        }
        static void Main(string[] args)
        {
            List<ThuongHieu> th = new List<ThuongHieu>() {
                new ThuongHieu() { ID =200,TenThuongHieu ="NOKIA 1" },
                new ThuongHieu() { ID =500,TenThuongHieu ="GALAXY 1" },
                new ThuongHieu() { ID =400,TenThuongHieu ="NOKIA 2" },
                new ThuongHieu() { ID =700,TenThuongHieu ="GALAXY 2" }


            };
            List<SanPham> sp = new List<SanPham>() {
                new SanPham() { tenSP = "samsung galaxy a30s", mauSac = new string[]{ "do", "xanh", "vang" },soLuong= 5, giaSP=400 },
                new SanPham() { tenSP = "oppo", mauSac = new string[]{ "tim-den","do", "xanh", "vang" },soLuong= 20, giaSP=200 },
                new SanPham() { tenSP = "iphone 10", mauSac = new string[]{ "do", "xanh", "vang" },soLuong= 1, giaSP=700 },
                new SanPham() { tenSP = "iphone 11", mauSac = new string[]{ "nau", "trang", "vang" },soLuong= 10, giaSP=600 },
                new SanPham() { tenSP = "iphone 12", mauSac = new string[]{ "xam", "den" },soLuong= 5, giaSP=700 },
                new SanPham() { tenSP = "iphone 12", mauSac = new string[]{ "xam", "den" },soLuong= 5, giaSP=700 },
                new SanPham() { tenSP = "iphone 12", mauSac = new string[]{ "xam", "den" },soLuong= 5, giaSP=700 },
                new SanPham() { tenSP = "iphone 13", mauSac = new string[]{ "luc", "xanh", "vang" },soLuong= 3, giaSP=400 },
                new SanPham() { tenSP = "samsung galaxy a20s", mauSac = new string[]{ "luc", "xanh", "cam" },soLuong= 3, giaSP=200 }
            };
            //var kq=from p in sp where p.giaSP <= 500 select new{
            //ten = p.tenSP,gia=p.giaSP

            //};
            //foreach(var p in kq)
            //{
            //    Console.WriteLine(p);
            //}
            //var temp=sp.SelectMany(s => s.mauSac);
            //var temp= sp.Where(x => x.giaSP<=500);
            //var temp=sp.Max(e=>e.giaSP);
            //var kq = th.GroupJoin(sp, t => t.ID, p => p.giaSP, (t, p) =>
            //{
            //    return new
            //    {
            //        thuonghieu = t.TenThuongHieu,
            //        sanPham = p

            //    };
            //});
            //foreach (var k in kq)
            //{
            //    Console.WriteLine(k.thuonghieu);
            //    foreach(var t in k.sanPham)
            //    {
            //        t.Xuat();
            //    }
            //    Console.WriteLine("========================================");
            //}
            //var kq=sp.OrderBy(p=>p.giaSP);
            //var kq1= kq.Reverse();
            //foreach(var k in kq1)
            //{
            //    k.Xuat();
            //}
            //int[] a = new int[] { 1, 1, 1, 2, 3, 2, 2, 2, 2, 2, 2, 2 };
            //var kq = a.Distinct();
            //foreach(var k in kq)
            //{
            //    Console.WriteLine(k);
            //}
            var gr1 = from p in sp
                      group p by p.giaSP into gr
                      orderby gr.Key
                      select gr;
            gr1.ToList().ForEach(k =>
            {
                Console.WriteLine(k.Key);
                foreach (var gr in k)
                {
                    gr.Xuat();
                }
            });
            //var kq = from p in sp
            //         join ths in th on p.giaSP equals ths.ID into t
            //         from b in t.DefaultIfEmpty()

            //select new
            //{
            //    ten = p.tenSP,
            //    gia = p.giaSP,
            //    thuonghieu = (b!=null)?b.TenThuongHieu:"khong co thuong hieu"
            //};
            //kq.ToList().ForEach(k => Console.WriteLine(k));



            Console.ReadKey();
        }
    }
}
