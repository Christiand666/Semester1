using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tester_lige_noget
{
    class Program
    {

        static void Main(string[] args)
        {

            Kunde kunde = new Kunde("Rasmus", 23322332, 60);
            Kunde kunde1 = new Kunde("Chris", 23232323, 120);

            string path = @"C:\Users\chris\Desktop\Skole\kundeliste.txt";

            if (!File.Exists(path))
            {
                

            }

            string createText = "KundeNavn   -   Telefon   -   Tid tilbage   " + Environment.NewLine;
            string createline = kunde.name + "     -     " + kunde.Tlf + "   -   " + kunde.AboneementMiuntter;
            string createline2 = kunde1.name + "     -     " + kunde1.Tlf + "   -   " + kunde1.AboneementMiuntter;
            File.WriteAllText(path, createText + "\n" + createline + "\n" + createline2);

            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);


        }
    }
}

class Kunde
{

    public string name;
    public int Tlf;
    public int AboneementMiuntter;

    public Kunde(string name, int Tlf, int AboneementMiuntter)
    {
        this.name = name;
        this.Tlf = Tlf;
        this.AboneementMiuntter = AboneementMiuntter;
    }



}


