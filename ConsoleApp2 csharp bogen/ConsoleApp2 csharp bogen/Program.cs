using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_csharp_bogen
{
    class Program
    {
        static Main(string[] args)
        {//Variabel til at gemme navn
            string navn = "";
            //Hent navn fra konsol

            Console.WriteLine("Indtast navn");
            navn = Console.ReadLine();


            //Konverter navn til store bogstaver
            navn = NavnTilStoreBogstaver(navn);

            //udskriv navn
            Console.WriteLine("Velkommen " + navn);

            //vent til brugeren trykker enter
            Console.ReadLine();

            //Program afsluttes

            {
                static string NavnTilStoreBogstaver(string navn)
            }
            return navn.ToUpper();
        }

      
        }
    }
}
