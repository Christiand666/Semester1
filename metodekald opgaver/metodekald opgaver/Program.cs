using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodekald_opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("indtast åretstal");
            
            int åretstal0 = Convert.ToInt32(Console.ReadLine());

            bool erdetskudår = skudÅro(åretstal0);

            Console.WriteLine(erdetskudår);
            Console.ReadLine();

        }


        public static bool skudÅro(int ettal1)
        {
            
            bool erdetskudår=false;
            if (ettal1 % 4 == 0)
            {
                erdetskudår = true;
  


            }
            if (ettal1 != 0)
            {
                erdetskudår = false;
               
            }
            return erdetskudår;

        }
    }
}
