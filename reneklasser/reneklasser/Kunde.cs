using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reneklasser
{
    class person
    {

        //properties 
        public string personNavn;

        public int personNr;

        public double personPris;


        //method
        public void PrintOplysninger()
        {
            Console.WriteLine($"person med navnet {personNavn} har et personNr som er {personNr}");

        }


    }
    class Kunde
    {
        public string KundeNavn;

        public int KundeNr;

        public double KundeMaksbeløb;

        public void printoplysningerombeløb()
        {
            if (KundeMaksbeløb > 10000)
            {
                Console.WriteLine($"kære {KundeNavn}du har hævet over dit beløb");
            }
            if(KundeMaksbeløb <=10000) 
            {
                Console.WriteLine($"dit beløb på {KundeMaksbeløb} er i orden {KundeNavn}");
            }
        }

    }
}
