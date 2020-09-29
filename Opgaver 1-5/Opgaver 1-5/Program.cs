using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv et tal ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("skriv hvad du vil ");
            string op = Console.ReadLine();
            Console.Write("Skriv et tal ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+") 
            {
                Console.WriteLine(num1 + num2);
                
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }

            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Forkert");
            }

            Console.ReadLine();
        }
    }
}
