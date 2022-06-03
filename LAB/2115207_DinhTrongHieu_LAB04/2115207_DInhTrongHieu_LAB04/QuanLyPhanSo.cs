using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2115207_DInhTrongHieu_LAB04
{
    public class QuanLyPhanSo
    {
        //public List<PhanSo> ds;
        public ArrayList ds;
        

        public QuanLyPhanSo()
        {
            //ds = new List<PhanSo>();
            ds = new ArrayList();
        }
        public int SoPhanTu
        {
            get { return ds.Count; }

        }
        public PhanSo Max
        {
            get
            {

                PhanSo psMAX = this[0];
                double max = (double)this[0];
                for (int i = 0; i < SoPhanTu; i++)
                {
                    if ((double)this[i] > max)
                    {
                        max = (double)this[i];
                        psMAX = this[i];
                    }
                }
                return psMAX;
            }
        }
        public PhanSo Min
        {
            get
            {
                PhanSo psMIN = this[0];
                double min = (double)this[0];
                for (int i = 0; i < SoPhanTu; i++)
                {
                    if ((double)this[i] < min)
                    {
                        min = (double)this[i];
                        psMIN = this[i];
                    }
                }
                return psMIN;
            }
        }
        public PhanSo this[int i]
        {

            get
            {

                if (i >= 0 && i < SoPhanTu)
                {
                    return (PhanSo)ds[i];
                }
                else
                {
                    throw new Exception("so chi nam ngoai pham vi cua mang");
                }
            }
            set
            {
                if (i >= 0 && i < SoPhanTu)
                {
                    ds[i] = value;
                }
                else
                {
                    throw new Exception("so chi nam ngoai pham vi cua mang");
                }

            }
        }
        public void NhapThuCong(int So)
        {
            
            for (int i = 0; i < So; i++)
            {
                PhanSo newPhanSo = new PhanSo();
                newPhanSo.Nhap();
                ds.Add(newPhanSo);
            }
        }

        public void NhapTuDong()
        {
            ds.Add(new PhanSo(1, 2));
            ds.Add(new PhanSo(3, 4));
            ds.Add(new PhanSo(4, 7));
            ds.Add(new PhanSo(7, 4));
            ds.Add(new PhanSo(5, 6));
            ds.Add(new PhanSo(6, 5));
            ds.Add(new PhanSo(6, 7));
            ds.Add(new PhanSo(2, 5));
            ds.Add(new PhanSo(5, 2));
            ds.Add(new PhanSo(2, 5));
        }
        public void DocFile()
        {
            try
            {
                StreamReader st = new StreamReader("dsphanso.txt");

                string temp = "";
                while ((temp = st.ReadLine()) != null)
                {
                    var temp1 = temp.Split(' ');
                    if (temp1.Length > 1)
                        ds.Add(new PhanSo(int.Parse(temp1[0]), int.Parse(temp1[1])));
                    else
                    {
                        ds.Add(new PhanSo(int.Parse(temp1[0]), 1));
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void RutGonDS()
        {
            for (int i = 0; i < SoPhanTu; i++)
            {
                
                this[i] = this[i].RutGon();

            }
        }
        public void Xuat(/*List<PhanSo>*/ArrayList _ds)
        {
            foreach (var ps in _ds)
                Console.WriteLine(ps);
        }
        public /*List<PhanSo>*/ void TimMauT(int mauSo)
        {
            //var kq = ds.FindAll((e) =>
            //{
            //    return e.MauSo == mauSo;
            //});
            //return kq;
            for(int i=0; i < SoPhanTu; i++)
            {
                if (this[i].MauSo == mauSo)
                {     
                    Console.WriteLine(this[i]);
                }
            }

        }
        public /*List<PhanSo>*/void TimPsX(PhanSo x)
        {
            //var kq = ds.FindAll((e) =>
            //  {
            //      return (double)e == (double)x;
            //  });
            //return kq;
            for (int i = 0; i < SoPhanTu; i++)
            {
                if ((double)this[i] == (double)x)
                {
                    Console.WriteLine(this[i]);
                }
            }
        }
        public double TongPs()
        {
            double kq = 0;
            for (int i = 0; i < SoPhanTu; i++)
            {
                kq += (double)this[i];
            }
            return kq;
        }
        public void SapXepTang()
        {

            //ds.Sort((e1, e2) =>
            //{
            //    if ((double)e1 > (double)e2)
            //        return 1;
            //    return -1;
            //});
            int j;
            PhanSo temp;
            for (int i = 1;i< SoPhanTu; i++)
            {
                temp = this[i];
                for (j = i - 1; j >= 0&&(double)temp<(double)this[j]; j--)
                {
                    this[j + 1] = this[j];
                }
                this[j+1]=temp;
            }
            
        }
        public void SapXepGiam()
        {
            //ds.Sort((e1, e2) =>
            //{
            //    if ((double)e1 < (double)e2)
            //        return 1;
            //    return -1;
            //});
            int j;
            PhanSo temp;
            for (int i = 1; i < SoPhanTu; i++)
            {
                temp = this[i];
                for (j = i - 1; j >= 0 && (double)temp > (double)this[j]; j--)
                {
                    this[j + 1] = this[j];
                }
                this[j + 1] = temp;
            }
        }
        public void XoaAllMin()
        {
            for(int i = 0; i < SoPhanTu; ++i)
            {
                if ((double)this[i] == (double)this.Min)
                {
                    ds.Remove(ds[i]);
                }
            }

        }
    }
}
