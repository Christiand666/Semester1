using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_i_klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tabel = { "ole", "pia", "hans" };
            string[] tabel2 = new string[3];
            Udskriv(tabel);
            tabel2 = Udskriv(tabel);
            for (int i = 0; i < tabel2.Length; i++)
                Console.WriteLine(tabel2[i]);
            foreach (string element in tabel2)
                Console.WriteLine(element);

            tabel2[0] = "ole hansen";
            tabel2[1] = "pia pii";
           tabel2[2] = "hans lart";

            Udskriv(tabel);
            Udskriv(tabel);
            Console.ReadLine();
        }
        public static string [] Udskriv(string [] tab)
        {
            string[] tab3 = new string[3]; //shallow copy tab3 og tab peger på ref eller peger på samme objekt
            for (int i = 0; i < tab3.Length; i++)
                tab3[i] = tab[i];
                //Console.WriteLine(tab3[i]);
            tab3[0] = "katrine";
            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i]);
            return tab3;
        }
    }
}
