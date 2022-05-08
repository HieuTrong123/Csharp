
namespace MangMotChieu
{
    public delegate int SoSanh(object x, object y);
    public class Mang
    {
        public object[] ds = new object[100];
        public int len = 0;
        public void Them(object o)
        {
            ds[len++] = o;
        }
        public void SapXep(SoSanh ss)
        {
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (ss(ds[i], ds[j]) == 1)
                    {

                        object tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write(" {0} ", ds[i]);
            }
        }
    }
}