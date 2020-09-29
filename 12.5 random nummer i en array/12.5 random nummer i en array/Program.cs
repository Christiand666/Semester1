using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._5_random_nummer_i_en_array
{
    class Program
    {
        static void Main(string[] args)
        {
            tilfældig t = new tilfældig();
            int[] tabel1 = t.tabelmedtilfældig();
            foreach(int tal in tabel1)
            {
                Console.WriteLine(tal);
            }
            
            Console.ReadLine();
        }

        public class tilfældig
        {
            private Random rnd = new Random();
            public int[] tabelmedtilfældig()
            {
                int[] tabel3 = new int[3];
                tabel3[0] = rnd.Next(1, 4);
                tabel3[1] = rnd.Next(1, 4);
                tabel3[2] = rnd.Next(1, 4);
                return tabel3;

            }
        }

    }
}
