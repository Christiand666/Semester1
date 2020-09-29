using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reneklasser
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //Kunde er en klasse og kunde3 er et objekt af kundeklassen 
            person person3 = new person();
            string navn3 = "ole lukøje";
            person3.personNavn = (navn3 + "                       ").Substring(0, 20);
            person3.personNavn=navn3.Trim();
            if (navn3.Length > 20)
            {
                Console.WriteLine(navn3);
            }
            else
            {
                Console.Write("Fejl");
            }

            person3.personNr = 222;
            person3.personPris = 23.5;
            Console.WriteLine();

            person person4 = new person();
            string Navn4 = "Lars høj";
            person4.personNavn = (Navn4 + "                         ").Substring(0,20);
            Navn4 = Navn4.Trim();
            if (Navn4.Length > 20) 
            {
                Console.WriteLine(Navn4);
            }
            else
            {
                Console.Write("Fejl");
            }
            person4.personNr = 233;
            person4.personPris = 23.5;

            person3.PrintOplysninger();

            Console.WriteLine(person4.personNavn);
            Console.WriteLine();

       

            Kunde Kunde3 = new Kunde();
            string kundenavn3 = "ole lukøje";
            Kunde3.KundeNavn = (kundenavn3 + "               ").Substring(0, 10);
            Kunde3.KundeNavn = navn3.Trim();
            Kunde3.KundeNr = 234;
            Kunde3.KundeMaksbeløb = 1000;
            Kunde3.printoplysningerombeløb();
            Console.WriteLine();

            Kunde Kunde4 = new Kunde();
            string KundeNavn4 = "Lars høj";
            Kunde4.KundeNavn = (KundeNavn4 + "               ").Substring(0, 10);
            Navn4 = Navn4.Trim();
            Kunde4.KundeNr = 233;
            Kunde4.KundeMaksbeløb = 10001;

            Kunde4.printoplysningerombeløb();
            Console.WriteLine();


            Console.ReadLine();

            
        }
    }
}
