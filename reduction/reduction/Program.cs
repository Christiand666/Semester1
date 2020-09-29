using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reduction
{//ideration 
    class Program
    {
        static void Main(string[] args)
        {
            m1("stor stygge ulv");
           Console.ReadLine();
        }

        public static void m1(string n)
        { //recroktion metode
            Console.WriteLine(n);
            if (n.Length == 0) //stop klods, den hopper ned til m1(n.sub) og starter forfra for hvert kald
                Console.WriteLine("stop");
            else m1(n.Substring(1)); //intgrere mod stopklods
            Console.WriteLine(n);
           
            
            //ideration er for loops som går op i 10 eller en foreach 






           for(int i=10; i <=100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //fall trough hopper igennem en swtich case eller hvis noget er lige med hinanden i switch casen 
            int l;
            switch (l)
            {
                case 5:
                case 6:
                    gør noget værdi
            }


            //compilering omsætter din værdi eller tekst til maskin kode bindekode og fortolkning er bare det omvendte ligesom man læser på englesk og så oversætter det automatisk til dansk c# compiler man til maskin kode fra sit syntax.
            //den compiler eller fortolker så snart man trykker compile.
            //alle ting har en bindings tid som f.eks. static 

            public int plnstring(string s)
            {
                int count = 0;
                foreach (char c in s)
                {
                    if (c == "p" || c == "p")
                        count++;
                }
                return count;
            }
        }
    }
}
