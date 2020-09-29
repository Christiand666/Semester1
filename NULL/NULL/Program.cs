using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NULL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indlæs tekst");
            string str = Console.ReadLine();
            str = null;
            switch (str)
            {
                case "ok":
                    Console.WriteLine("ok" );
                    Console.ReadLine();
                    break;

                case null:
                    Console.WriteLine("null");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("stor 0");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
