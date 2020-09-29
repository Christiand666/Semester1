using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1opgave
{


    public class Car

    {
        private int Bregnr;
        public int Bweight;


        public Car(int regnr, int weight)
        {
            Bregnr = regnr;
            Bweight = weight;
        }

        
        public void setregnr (int regnr) //void skriver man som en handling som ikke behøver at give noget tilbage en funktion 
        { if (regnr <= 7)
            {
                Bregnr = regnr;
            }
        }

        public int getregnr()
        {
            return Bregnr;
        }

       
    }
    
}