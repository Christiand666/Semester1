using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fahrenheit = Celsius
            Console.Write("enter the amount of celsius: ");
            double celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fahrenheit = {0}",celsius * 1.80 + 32);
            Console.ReadLine();
        }
    }
}
