using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasserr_og_object_klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Helloklassen v1 = new Helloklassen("hello metode");
            
            v1.Hello();
            v1.ændretekst("something");
            v1.Hello();

            Helloklassen v2 = new Helloklassen();
            v2.ændretekst("virker det");
            v2.Hello();

            Console.ReadKey();
        }
       
    }
}
