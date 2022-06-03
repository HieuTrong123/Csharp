using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
    static class kdl
    {
        public static int tong(this int a,int b)
        {
            return a + b;
        }
    }
    public class temp
    {
        public static int a;
        
        public void print_a()
        {
            Console.WriteLine(a);
        }
        public static int XuLy(int x,int y)
        {
            return x + y;
        }
        
	

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            temp.a = 0;
            temp x=new temp();
            temp y = new temp();
            x.print_a();
            y.print_a();
            temp.a = 3;
            x.print_a();
            y.print_a();
            kdl.tong(1, 2);
            1.tong(2);
            Console.ReadLine();
            
        }
    }
}
