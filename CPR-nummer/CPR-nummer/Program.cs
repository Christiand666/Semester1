using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    static void Main(string[] args) {
        {
            int løn = 120;
            int arbejdstimer = 37;
            double tillæg = 1.75;
            
            double overarbejningsløn;
            double timeløn;



            Console.Write("indtast timer");
            int antaltimerindtastet = Convert.ToInt32(Console.ReadLine());

            Console.Write("indtast skattetræk");
            int skattetræk = Convert.ToInt32(Console.ReadLine());

            Console.Write("indtast fradrag");
            int fradrag = Convert.ToInt32(Console.ReadLine());


            if (antaltimerindtastet > arbejdstimer)

            {
                overarbejningsløn = (antaltimerindtastet - arbejdstimer) * (løn * tillæg) + (arbejdstimer * løn);
                overarbejningsløn = overarbejningsløn - ((overarbejningsløn / 100) * skattetræk)+fradrag; //den bruger de samme værdier eller det vi har fået ovn over til vores samlede skattefradrag'
                Console.WriteLine(overarbejningsløn);
            }

            if (antaltimerindtastet <= arbejdstimer)
            {
                timeløn = (antaltimerindtastet * løn);
                timeløn = timeløn - (antaltimerindtastet / 100 * skattetræk) + fradrag;
                Console.WriteLine(timeløn);
            }

            Console.ReadLine();

        }
    }
}


    

