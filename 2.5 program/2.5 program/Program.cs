using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast et åretstal i formartet DDMMYY:");
            int input = Convert.ToInt32(Console.ReadLine());


            if(((int)Math.Floor(Math.Log10(input))+1==8)){
                int year, month, day, temp;

                temp = input;

                year = temp % 10000;
                temp /= 10000;

                month = temp % 100;
                temp /= 100;

                day = temp;

                Console.WriteLine("Datoen {0} er d.{1} i {2} måned, år{3}.",input,day,month,year);
                Console.ReadKey();
            }
        }
    }
}
