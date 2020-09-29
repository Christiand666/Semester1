using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    class Program
    {
        //overloading man kan ikke kalde sin metoder det samme jo mindre den anden parameter er anderledes, men overloading forgår i samme klasse
        static void Main(string[] args)
        {
        }

        public static void M1(string b)
        {

        }

        public static void M1(int t)
        {

        }
    }
}
