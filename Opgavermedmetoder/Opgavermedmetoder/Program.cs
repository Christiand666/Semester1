using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavermedmetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 23;
            int n2 = 42;

            int BiggestNumb = Hjælp(n1, n2);

            Console.WriteLine(BiggestNumb);
            Console.ReadLine(); 

        }

        public static int  Hjælp(int tal1, int tal2)
        {
            int biggestNumb;
            if(tal1 > tal2)
            {
                biggestNumb = tal1;
            }
            else
            {
                biggestNumb = tal2;
            }

            return biggestNumb;
          
        }
    }
}
