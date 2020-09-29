using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            int y = 12;
            ombyt(ref x,  ref y);
            Console.WriteLine("x={0} y={1}" , x,y);
            Console.ReadLine();
        }
        public static void ombyt(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }
    }
}
