using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brute_force
{
    class Program
    {
        static void Main(string[] args)
        {
            long thanumber = 1050504368559379;
            for (long i = 2; i < thanumber; i++)
                if (thanumber%i == 0)
                {
                    Console.WriteLine(i);
                }
            Console.WriteLine("programmet er færdig, hvilket det aldrig gør");
            Console.ReadLine();
        }
    }
}
