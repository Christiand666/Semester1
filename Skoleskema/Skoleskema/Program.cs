using System;
using System.Collections.Generic;
using System.IO;
using System.CodeDom.Compiler;


namespace ogaver_
{

    class Program
    {



        static void Main(string[] args)
        {

            // tid         mandag, tirsdag, onsdag, torsdag, fredag

            //9-12         sys,     prog,   dat,    sys,    prog,
            //12-1330      sys,     fri,    dat,    sys,    fri,
            //1330-1500    fri,     lkaf,   fri,    lkaf,   fri,
            string[,,] skoleSkema = new string[2, 4, 6];





            skoleSkema[0, 0, 0] = "tid";
            skoleSkema[0, 0, 1] = "mandag";
            skoleSkema[0, 0, 2] = "tirsdag";
            skoleSkema[0, 0, 3] = "onsdag";
            skoleSkema[0, 0, 4] = "torsdag";
            skoleSkema[0, 0, 5] = "fredag";

            skoleSkema[0, 1, 0] = "9-12";
            skoleSkema[0, 1, 1] = "systemudvikling";
            skoleSkema[0, 1, 2] = "programmering";
            skoleSkema[0, 1, 3] = "database";
            skoleSkema[0, 1, 4] = "systemudvikling";
            skoleSkema[0, 1, 5] = "programmering";

            skoleSkema[0, 2, 0] = "12-1330";
            skoleSkema[0, 2, 1] = "systemudvikling";
            skoleSkema[0, 2, 2] = "fri";
            skoleSkema[0, 2, 3] = "database";
            skoleSkema[0, 2, 4] = "systemudvikling";
            skoleSkema[0, 2, 5] = "fri";

            skoleSkema[0, 3, 0] = "1330-1500";
            skoleSkema[0, 3, 1] = "fri";
            skoleSkema[0, 3, 2] = "lektiecafe";
            skoleSkema[0, 3, 3] = "fri";
            skoleSkema[0, 3, 4] = "lektiecafe";
            skoleSkema[0, 3, 5] = "fri";


            skoleSkema[1, 0, 0] = "tid";
            skoleSkema[1, 0, 1] = "mandag";
            skoleSkema[1, 0, 2] = "tirsdag";
            skoleSkema[1, 0, 3] = "onsdag";
            skoleSkema[1, 0, 4] = "torsdag";
            skoleSkema[1, 0, 5] = "fredag";

            skoleSkema[1, 1, 0] = "9-12";
            skoleSkema[1, 1, 1] = "systemudvikling";
            skoleSkema[1, 1, 2] = "programmering";
            skoleSkema[1, 1, 3] = "database";
            skoleSkema[1, 1, 4] = "systemudvikling";
            skoleSkema[1, 1, 5] = "programmering";

            skoleSkema[1, 2, 0] = "12-1330";
            skoleSkema[1, 2, 1] = "systemudvikling";
            skoleSkema[1, 2, 2] = "fri";
            skoleSkema[1, 2, 3] = "database";
            skoleSkema[1, 2, 4] = "systemudvikling";
            skoleSkema[1, 2, 5] = "fri";

            skoleSkema[1, 3, 0] = "1330-1500";
            skoleSkema[1, 3, 1] = "fri";
            skoleSkema[1, 3, 2] = "lektiecafe";
            skoleSkema[1, 3, 3] = "fri";
            skoleSkema[1, 3, 4] = "lektiecafe";
            skoleSkema[1, 3, 5] = "fri";



            for (int g = 0; g < skoleSkema.GetLength(0); g++)
            {
                for (int i = 0; i < skoleSkema.GetLength(1); i++)
                {
                    //for hver yderste 
                    for (int j = 0; j < skoleSkema.GetLength(2); j++)
                    {
                        string s = skoleSkema[g, i, j];
                        s += "                             ";
                        s = s.Substring(0, 20);
                        Console.Write(s);
                    }
                    if (i == 0)
                        Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}