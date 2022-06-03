using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_QuanLyMayTinh
{
    class Run
    {
        static void Main()
        {
            QuanLyMayTinh ql = new QuanLyMayTinh();
            ql.NhapCD();
            Console.WriteLine(ql);
            ql.SapGiamTheoGia();
            Console.WriteLine("Danh sach giam theo Gia:{0}",ql);

        }
    }
}
