using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_TRR_XuatTapHop
{
    internal class Program
    {
        static int[] a = new int[100];
        static int n, final;
        static int[] E=new int[100];

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vào gia tri cho n");


            n = int.Parse(Console.ReadLine());
            KhoiTao();
            KhoiTaoE();
            XuatTatcaTapCon();
             
            Console.ReadKey();


        }
        static void KhoiTaoE()
        {
            for(int i = 1; i <= n; i++)
            {
                E[i] = i;
            }
        }
        static void KhoiTaoCon()
        {

        }
        static void XuatTatcaTapCon()
        {
            final = 1;
            
            while (final == 1)
            {
                
                string strtg = "{";
                if (a[1] == 1)
                {
                    strtg = strtg + E[1].ToString() + ",";
                }
                for (int i = 2; i < n; i++)
                {
                    if (a[i]==1)
                    {
                        strtg = strtg + E[i].ToString();
                        if (i < n)
                        {
                            strtg = strtg + ",";
                        }
                    }
     
                }
                if (a[n] == 1)
                {
                    strtg = strtg +  E[n].ToString();
                }
                strtg = strtg + "}";
                Console.WriteLine(strtg);
                
                Tao();

            }
        }

        static void KhoiTao()
        {
            for(int i = 1; i <= n; i++)
            {
                a[i] = 0;
            }
        }
        static void Tao()
        {
            int i = n;
            while (i >= 0 && a[i] == 1)
            {
                a[i] = 0;
                --i;

            }
            if (i == 0)
            {
                final = 0;
                
            }
            else
            {
                a[i] = 1;
            }
        }

    }
}
