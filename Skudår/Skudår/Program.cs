using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skudår
{
    class Program
    {
        static void Main(string[] args)
        {
            int skudår = 4;
            int DerErSkudÅr;
            Console.Write("indtast åretstal");
            int åretstal = Convert.ToInt32(Console.ReadLine());

            if (åretstal%4 == 0)
            {
                åretstal = 0;
                
                Console.WriteLine(åretstal);


            }
            if (åretstal != 0)
            {
                Console.WriteLine("nope");
            }
            Console.ReadLine();

        }
    }
}
