using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyprøverigen
{
    class Program
    {
        static void Main(string[] args)
        {

            studerne studerne3 = new studerne("S6XFY22 ", "Christian");

            Underviser underviser1 = new Underviser("ple ", "poul eriksen");


            Console.WriteLine(studerne3.Info());
            Console.WriteLine(underviser1.Info());
            Console.ReadLine();



        }
    }
}
