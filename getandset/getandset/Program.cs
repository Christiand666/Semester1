using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getandset
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("end game", "filminstruktør", "pg-13");
            Movie shrek = new Movie("shrek 2", "filminstruktør", "PG");
            avengers.Rating = "PG";
            Console.WriteLine(avengers.Rating);
            Console.ReadLine();

        }
    }
}
