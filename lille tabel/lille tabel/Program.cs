using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lille_tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i <= 10; i++)
            {
                for (int j = i; j <= (i * 10); j = j + i)
                {
                    string tals = Convert.ToString(j);
                    int længde = tals.Length;
                    string udrykning = "";
                    switch (længde)
                    {
                        case 1:
                            udrykning = "  ";
                            break;

                        case 2:
                            udrykning = " ";
                            break;


                    }
                    Console.Write(j + udrykning);
                }

                Console.WriteLine();
               
            }
            Console.ReadLine();


        }
    }
}
