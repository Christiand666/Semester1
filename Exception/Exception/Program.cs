using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTryCatch3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IOHandling(); // may fail = may throw an exception
            }
            catch (GLGxception GLG)
            {
                Console.WriteLine("Fejl fanget som GLGxception1. Prøv igen. Oprindelig fejlbesked: " + GLG.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Fejl fanget som Exception2. Prøv igen. Oprindelig fejlbesked: " + e.ToString()); // é.ToString() er valgfri.
            }
            Console.ReadLine();
            try
            {
                InputValidation(); // may fail = may throw an exception
            }
            catch (Exception e)
            {
                Console.WriteLine("Fejl fanget som Exception2. Prøv igen. Oprindelig fejlbesked: " + e.ToString());
            }
        }

        static void IOHandling()
        {
            bool unluck = true;
            if (unluck)
                throw new GLGxception();
            else
                Console.WriteLine("Alt ok i IOHandling, skrevet ud fra IOHandling metoden.");
        }

        static void InputValidation()
        {
            bool unluck = true;
            if (unluck)
                throw new Exception("Inputvalidation fejl.");
            else
                Console.WriteLine("Alt ok i InputValidation, skrevet ud fra IOHandling metoden.");
        }
    }

    class GLGxception : Exception
    {
        public override string ToString()
        {
            return "En GLG fejl opstod";
        }
    }
}



