using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_12_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
         string[] tabel = { "mandag", "tirsdag", "onsdag", "torsdag", "fredag", "lørdag", "søndag" };
            string dag2 = viudskriverenbesmtdag(tabel);
            Console.WriteLine("det er en "  +  dag2);
            

            string[] tabel1 = { "januar", "febuar", "marts", "april","maj","juni","juli","august","semtemper", "okbtober", "november","december" };
            string måned2 = viudskrivudskriverenbestmttilbage(tabel1);
            
            Console.WriteLine("i den her måned " + måned2);

            Console.WriteLine();


            //nem måde at lave array på med nemme tal
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };//besværligt

            int[] arr3 = new int[100];
            for (int i = 1; i <= 100; i++)
                arr3[i - 1] = i; //nem måde

            int tal = viudskriveretbestmugenummer(arr3);
            Console.WriteLine(tal);

           
          
            Console.ReadLine();
        }
        public static string viudskrivudskriverenbestmttilbage(string[] tabel1)
        {
            
           for (int i = 0; i < tabel1.Length; i++)
            
            Console.WriteLine(tabel1[i]);

            

            return tabel1[2-1];
        }
        public static string viudskriverenbesmtdag(string[] tabel)
        {
            for (int i = 0; i < tabel.Length; i++)
                Console.WriteLine(tabel[i]);
            return tabel[1-1];
        }
        public static int viudskriveretbestmugenummer(int[] tabel2)
        {
            
            return tabel2[50];
        }
    }
}
