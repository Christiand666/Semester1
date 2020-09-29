using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gennemgangitimerne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 8, 9, 10, 20 };

            m1(t);
            Console.WriteLine(t[1]);
            Console.ReadLine();

        }
        public static void m1(int[] t1)
        {
            t1[1] = 17;
        }
    }
}
