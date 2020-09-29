using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace something
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 9;
            int y = 12;
            Tal t = ombyt(x, y);
            Console.WriteLine("x={0} y={1}", t.x, t.y, );
            Console.ReadLine();
        }
        public static Tal ombyt( int x, int y)
        {
            int z = x;
            x = y;
            y = z;
            Tal t = new Tal();
            t.x = x;
            t.y = y;
            return t;

        }
    }
    }

