using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] endim;
            endim= new string[12];
            endim[0] = "januar";
            endim[1] = "febuaer";
            endim[2] = "marts";
            endim[3] = "aprill";
            endim[4] = "maj";
            endim[5] = "juni";
            endim[6] = "juli";
            endim[7] = "august";
            endim[8] = "september";
            endim[9] = "oktober";
            endim[10] = "november";
            endim[11] = "december";

            int mdnr = 10;
            Console.WriteLine(endim[mdnr-1]);

            int[] nr = { 31, 28, 31, 30, 31, 30, 31, 31, 31, 31, 31, 30 };
            int dag = 31;
            if (dag > nr[mdnr - 1]) 
            Console.WriteLine("forkert antal dage");
            Console.ReadLine();
        }
        //foreach (string element in endim)
        //    Console.WriteLine(element);

    }
}
 //for (int i = 0; i <= endim.Length-1; i++)
 //           {
 //               Console.WriteLine(endim[i]);
 //           }