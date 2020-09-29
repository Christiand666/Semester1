using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_og_random_ved_terning_kast
{

    public class tilfældigtal
    {
        static void Main(string[] args)
        { 
            tilfældig t = new tilfældig();
            for (int i = 0; i < 10; i++)
                Console.Write(t.dice() + "  ");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
                Console.Write(t.tal() + "  ");
            Console.WriteLine();





            int length = 100;

          int count1=0;
            for (int i = 0; i < length; i++)

            {
                int kast = t.dice();
                if (kast == 1)
                {

                    count1++;


                }

                Console.WriteLine("der er så mange 1ere  " + count1);


                int count2 = 0;




                if (kast == 2)
                {

                    count2++;


                }

                Console.WriteLine("der er så mange 2ere  " + count2);


                int count3 = 0;



                if (kast == 3)
                {

                    count3++;


                }

                Console.WriteLine("der er så mange 3ere  " + count3);


                int count4 = 0;



                if (kast == 4)
                {

                    count4++;


                }

                Console.WriteLine("der er så mange 4ere  " + count4);


                int count5 = 0;



                if (kast == 5)
                {

                    count5++;


                }

                Console.WriteLine("der er så mange 5ere  " + count5);



                int count6 = 0;



                if (kast == 6)
                {

                    count6++;


                }

                Console.WriteLine("der er så mange 6ere  " + count6);
                    }
            Console.ReadLine();
        }
            
        }

    }

    

        public  class tilfældig
        {
            
            private Random rnd = new Random();
            
            public int dice()
            {
               
                return rnd.Next(1, 7);

            }
            public int tal()
            {
                
                return rnd.Next(1, 7);
            }
        
        }
    public class terninger
    {
        
    }

   

