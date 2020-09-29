using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_med_dyr
{
    class Program
    {
        static void Main(string[] args)
        {
            int beløb = 1000;
            int Grise = 10;
            double høns = 3;
            double Duer = 0.5;
            int løsninger = 0;

            int maxGris = beløb / 10;
            double maxhøns = beløb / 3;
            double maxDuer = beløb / 0.5;

            List<string> løsningerAntalDyr = new List<string> {};
            for (int g= 1; g <= maxGris; g++) 
            {
                for (int h = 1; h <= maxhøns; h++)
                {
                    for (int d = 1; d <= maxDuer; d++)
                    {
                        if (g + h + d == beløb && (g * Grise) + (h * høns) + (d * Duer) == beløb)
                        {
                            løsninger++;
                            string løsning = " en løsning med " + g + " grise " + h + " høns " + d + " duer ";
                            løsningerAntalDyr.Add(løsning);

                        }
                    }
                }                 
            }
            Console.Write("der er {0} løsninger", løsninger);

            foreach (string løsning in løsningerAntalDyr)
            {
                    Console.WriteLine(løsning);

            }
                Console.ReadLine();
        }
            
                
    }
}

