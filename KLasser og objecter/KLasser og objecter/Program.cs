using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLasser_og_objecter
{
    class Program
    {
        static void Main(string[] args)
        {
            kender k = new kender(); //object
            
            Console.WriteLine(k.HentNavn());
            
            Console.ReadLine();
        }
    }
}
