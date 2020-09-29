using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte tal = 0;
            tal = 9;
            tal = 255;

            short tal2 = -9;
            tal2 = 32;

            int tal3 = -2;
            tal3 = 2;

            long tal4 = -9;
            tal4 = 9;


            sbyte talsbyte = -127;


            ushort talsbyte1 = 127;


            tal2 = short.MaxValue;
            tal2 = short.MinValue;

            double tal2Decimal = 1.07; //komma er et punktum

            


            string tekst = "lol";
            char tegn = 't';

            bool ok = true;
            ok = false;

            if(ok)
            Console.WriteLine(ok);
            Console.ReadKey();

            int x = 10;
            int y = x * 11;

        }
    }
}
