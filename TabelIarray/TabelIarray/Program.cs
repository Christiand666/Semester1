using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelIarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 2; //2 rækker 0,1
            int col = 6; // 6 koloner 0,1,2,4,5
            int[,] toddim = new int[row,col];

            toddim[0, 0] = 80;
            toddim[1, 5] = 5;
            for (int irow = 0; irow < toddim.GetLength(0); irow++)
                for (int icol = 0; icol < toddim.GetLength(1); icol++)
                {
                    Console.WriteLine(toddim[irow, icol]);
                }
            Console.ReadLine();
        }
    }
}
