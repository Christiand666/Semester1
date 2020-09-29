using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gemme_til_binære_filer
{
    class Program
    {
        static void Main(string[] args)
        {
            Studerne student1 = new Studerne("Christian", "datamatiker", "4534jgkf");
            Studerne student2 = new Studerne("Karl", "datamatiker", "4534jgkg");
            Studerne student3 = new Studerne("Lasse", "datamatiker", "4534jgkt");

            string path = @"C:\Users\Christian\Documents\Skole\binærfiler.dat";
            if (!File.Exists(path))
            {
                Console.WriteLine("Owerwrited");
            }
            string stuudent1 = student1.navn + student1.klasser + student3.studieId;
            string stuudent2 = student2.navn + student2.klasser + student2.studieId;
            string stuudent3 = student3.navn + student3.klasser + student3.studieId;

            File.WriteAllText(path, stuudent1 + "/n" + stuudent2 + "/n" + stuudent3 + "/n");
            string læstekst = File.ReadAllText(path);
            Console.WriteLine(læstekst);
        }
    }
}
