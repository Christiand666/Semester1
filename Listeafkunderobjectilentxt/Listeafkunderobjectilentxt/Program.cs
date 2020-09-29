using System;
using System.IO;
using System.Collections.Generic;
namespace EksamenØvelsefeb18TxtConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kunde> kunder = new List<Kunde>();
            string filePath = @"C:\Users\Christian\Documents\Skole, word\filename.txt";

            string standardPath = @"C:\Users\Christian\Documents\Skole, word\filename.txt";


            StreamReader sr;

            try
            {
                sr = new StreamReader(filePath);

            }
            catch (Exception e)
            {
                //forkert sti 
                Console.WriteLine("Instantiering af StreamReader objekt ikke godkendt, stien er sat til default sti, og default txt fil er valgt");
                Console.WriteLine();

                sr = new StreamReader(standardPath);
            }

            string line = sr.ReadLine();

            while (line != null)
            {
                string[] kundeInfo = line.Split(' ');
                string navn = kundeInfo[0] + " " + kundeInfo[1];
                int tlf = Convert.ToInt32(kundeInfo[2]);
                int minutter = Convert.ToInt32(kundeInfo[3]);
                Kunde kunde = new Kunde(tlf, minutter, navn);
                kunder.Add(kunde);

                line = sr.ReadLine();

            }


            string navnLabel = "Kundenavn                          ";
            navnLabel = navnLabel.Substring(0, 20);

            string tlfLabel = "Tlf                            ";
            tlfLabel = tlfLabel.Substring(0, 20);

            string minutterLabel = "supportminutter                ";
            minutterLabel = minutterLabel.Substring(0, 20);


            Console.WriteLine(navnLabel + tlfLabel + minutterLabel);
            Console.WriteLine();


            foreach (Kunde k in kunder)
            {
                string navn = k.navn + "                             ";
                navn = navn.Substring(0, 20);
                string tlf = k.telefonnummer + "                        ";
                tlf = tlf.Substring(0, 20);
                string minutter = Convert.ToString(k.antalminutter);

                Console.WriteLine(navn + tlf + minutter);
            }

            Console.ReadLine();


        }
    }
}

