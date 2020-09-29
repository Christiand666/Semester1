using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    namespace ConsoleApp2TryCatch2
    {
        class Program
        {
            static void Main(string[] args)

            {
                Console.WriteLine("indtast et nummer uden decimaltal eller et nul");
                Console.WriteLine("Input a number ");

                string input = Console.ReadLine();
                int number1 = 0;
                double number2 = 0;
               

                if (input == "0" || input.Contains(','))
                {
                    Console.WriteLine("wrong");
                    return;
                }
                foreach(char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        Console.WriteLine("du skrev et bogstav");
                        Console.ReadLine();
                        return;

                    }
                }
                try
                {
                    number1 = Convert.ToInt32(input); 
                    number2 = 64.0 / number1; 
                                            
                }
                catch
                {
                    Console.WriteLine("tallet kan ikke være størrer end 2 mil");
                    return;
                   
                }
                Console.WriteLine(number2.ToString(), "completed without errors");
                Console.ReadLine();
            }

        }
    }
}
