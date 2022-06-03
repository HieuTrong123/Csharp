using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DInhTrongHieu_LAB04
{
    public class PhanSo
    {
        public int tuSo { get; set; }
        private int mauSo;
        public int MauSo
        {
            get { return mauSo; }
            set
            {
                if (value == 0)
                {
                    value = 1;
                }
                mauSo = value;
            }
        }
        public PhanSo()
        {

        }
        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;

        }
        public override string ToString()
        {
            return $"{this.tuSo}/{this.MauSo}";
        }
        static int UCLN(int tuSo, int mauSo)
        {
            while (tuSo != mauSo)
            {
                if (tuSo > mauSo)
                {
                    tuSo -= mauSo;
                }
                else
                {
                    mauSo -= tuSo;
                }
            }
            return tuSo;
        }
        public PhanSo RutGon()
        {
            return new PhanSo(this.tuSo / UCLN(this.tuSo, this.MauSo), this.mauSo / UCLN(this.tuSo, this.MauSo));
        }
        static int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }
        static int mauChung(PhanSo a, PhanSo b)
        {
            return (a.mauSo * b.mauSo) / UCLN(a.mauSo, b.mauSo);
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {

            if (a.mauSo != b.mauSo)
            {
                return new PhanSo(a.tuSo * BCNN(a.mauSo, b.mauSo) + b.tuSo * BCNN(a.mauSo, b.mauSo), b.mauSo * BCNN(a.mauSo, b.mauSo));
            }
            return new PhanSo(a.tuSo + b.tuSo, b.mauSo);
        }
        public static PhanSo operator +(PhanSo a, int n)
        {
            return new PhanSo(a.tuSo + n * a.mauSo, a.mauSo);
        }
        public static PhanSo operator +(int n, PhanSo a)
        {
            return new PhanSo(a.tuSo + n * a.mauSo, a.mauSo);
        }
        

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {

            if (a.mauSo != b.mauSo)
            {
                return new PhanSo(a.tuSo * BCNN(a.mauSo, b.mauSo) - b.tuSo * BCNN(a.mauSo, b.mauSo), b.mauSo * BCNN(a.mauSo, b.mauSo));
            }
            return new PhanSo(a.tuSo - b.tuSo, b.mauSo);
        }
        public static PhanSo operator -(PhanSo a, int n)
        {
            return new PhanSo(a.tuSo - n * a.mauSo, a.mauSo);
        }
        public static PhanSo operator -(int n, PhanSo a)
        {
            return new PhanSo(a.tuSo - n * a.mauSo, a.mauSo);
        }
        public static PhanSo operator *(PhanSo a, PhanSo b) => new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);
        public static PhanSo operator *(PhanSo a, int n) => new PhanSo(a.tuSo * n, a.mauSo);
        public static PhanSo operator *(int n, PhanSo a) => new PhanSo(a.tuSo * n, a.mauSo);
        public static PhanSo operator /(PhanSo a, PhanSo b) => new PhanSo(a.tuSo * b.mauSo, a.mauSo * b.tuSo);
        public static PhanSo operator /(PhanSo a, int n) => new PhanSo(a.tuSo, a.mauSo * n);
        public static PhanSo operator /(int n, PhanSo a) => new PhanSo(a.tuSo, a.mauSo * n);
        public static PhanSo operator ++(PhanSo a) => a + 1;
        public static PhanSo operator --(PhanSo a) => a - 1;
        public static explicit operator double(PhanSo a) => (double)a.tuSo / a.MauSo;
        public static implicit operator PhanSo(int a) => new PhanSo(a, 1);

        public void Nhap()
        {
            Console.WriteLine("nhap tu so: ");
            this.tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap mau so: ");
            this.MauSo = int.Parse(Console.ReadLine());
        }
        
    }
}
