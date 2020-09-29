using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I main");
            bool ok = false;
            m1(10.25, ok);
            Console.WriteLine("tilbage i main");
            Console.ReadLine();
        }

        public static void m1(double x, bool ok)
        {
            Console.WriteLine("yes du {0} {1}", x, ok);
        }
    }
}
