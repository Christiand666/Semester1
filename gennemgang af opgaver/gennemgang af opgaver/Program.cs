using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gennemgang_af_opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bredde = 10;
            int længde = 20;
            int højde = 30;


            int resultat = 2 * (bredde * højde + højde * længde + bredde * længde);
            Console.WriteLine(resultat.ToString() + "cm2");
            Console.ReadLine();
            Console.ReadKey();


            
        }
    }
}
