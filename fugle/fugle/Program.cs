using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fugle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fugleTabel = new string[6];
            fugleTabel[0] = "musvit";
            fugleTabel[1] = "Solsort";
            fugleTabel[2] = "sumpemejse";
            fugleTabel[3] = "gråspurv";
            fugleTabel[4] = "stær";
            fugleTabel[5] = "nattergal";
            Array.Sort(fugleTabel);
            for (int index = 0; index < fugleTabel.Length; index++)
            { Console.WriteLine(fugleTabel[index]);
                //if (fugleTabel[index] == "sumpmejse")
                //    index = fugleTabel.Length;
                }
            Console.ReadLine();
        }
    }
}
