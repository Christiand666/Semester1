using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3_del2
{
    class Program
    {
        static void Main(string[] args)
        {
            float celsius;
            Console.Write("Enter Fahrenheit temperature : ");
            float fahrenheit = float.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is: " + celsius);
            Console.ReadLine();
        }
    }
}
