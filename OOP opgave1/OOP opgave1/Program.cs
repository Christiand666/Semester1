using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_opgave1
{
    class Program
    {
        public class Car
        {
            private int Bregnr;
            public int Bweight;


            public Car(int regnr, int weight)
            {
                Bregnr = regnr;
            }

            public void setregnr(int value)
            {
                if (value <= 7)
                {
                    Console.WriteLine("længere end 7");
                }
                else
                {
                    Bregnr = value;
                }

            }

            public int getregnr()
            {
                return Bregnr;
            }

            public Car(int weight)
            {
                weight= 56;
            }
            

        }

        public class Carprio
        {
            private int bregnr;
            public int regnr { get => bregnr; set => bregnr = value; }

            public int bweight { get; set; }
        }

      
    }

}