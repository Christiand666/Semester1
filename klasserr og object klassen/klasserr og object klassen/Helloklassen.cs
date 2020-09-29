using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasserr_og_object_klassen
{
    class Helloklassen
    {
         private string tekst;
        public Helloklassen() //default metode
        {}
       public Helloklassen(string t)
        {
            tekst = t;
        }

        public void Hello()
        {
            Console.WriteLine(tekst);
        }
        public void ændretekst (string t)
        {
            tekst = t;
        }
    }
}

