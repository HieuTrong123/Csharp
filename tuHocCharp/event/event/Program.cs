using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace @event
{

    public delegate void BatCongTac(bool state);
    public class CongTac
    {
        public event BatCongTac OnBatCongTac;
        public bool state;
      
        public void KhiBatCongTac()
        {
            OnBatCongTac(state);
            state = state ? false : true;
        }
    }
    internal class Program
    {
        static CongTac c = new CongTac();
        static BongDen d = new BongDen();
        static TV t = new TV();
        static void Main(string[] args)
        {
            c.OnBatCongTac += new BatCongTac(d.TrangThaiDen);
            c.OnBatCongTac += new BatCongTac(d.TrangThaiDen);
            c.KhiBatCongTac();
            c.KhiBatCongTac();
            Console.ReadKey();
        }

    }
    public class BongDen
    {
        public void TrangThaiDen(bool state)
        {
            if (state)
                Console.WriteLine("Den Sang");
            else
                Console.WriteLine("Den tat");
        }
    }
    public class TV
    {
        public void TrangThaiTV(bool state)
        {
            if (state)
                Console.WriteLine("Mo TV");
            else
                Console.WriteLine("Tat tivi");
        }
    }
}
