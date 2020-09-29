using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fugleopgave12
{

    class Program
    {
        struct fugle
        {
            public string Name;
        }
        //musvit, solsort, sumpmejse, gråspurv , stær, nattergal
        //6


        static void Main(string[] args)
            {
                int antalaffugle;
                fugle[] names;
                string input;

                Console.WriteLine("Hvor mange fugle er der?");
                input = Console.ReadLine();
                antalaffugle = int.Parse(input);

                names = new fugle[antalaffugle];


                for (int i = 0; i < names.Length; i++)
                {
                    fugle s;
                    Console.WriteLine("skriv det antal fugle navne {0} ", (i + 1));
                    s.Name = Console.ReadLine();
                    names[i] = s;
                }
                Array.Sort(names, (x, y) => String.Compare(x.Name, y.Name));
                for (int i = 0; i < names.Length; i++)
                {

                    Console.WriteLine(names[i].Name);
                }
                Console.ReadLine();
            }
        }
    }


