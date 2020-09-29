using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace øvemedmetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string b2 = "såmange";
            int såmangebogstaver = HvorMangeBogstaver(b2);
            Console.WriteLine(såmangebogstaver);
            Console.ReadLine();
        }
       

       public static void Hjælp(int tal1, int tal2)
        {

        }
        public static int HvorMangeBogstaver(string s)
        {
            
            int b2 =s.Length;
            return b2;
           
        }
    }
}
