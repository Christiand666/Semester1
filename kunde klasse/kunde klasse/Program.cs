using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kunde_klasse
{
    class program
    {
        static void Main(string[] args)
        {
            kunde k1 = new kunde();
            varenummer v1 = new varenummer();
           
            
            k1.setId(1);
            k1.setFornavn("jens");
            k1.setEfternavn("kristensen");
            k1.setadresse("møllevej1");
            k1.setpostNr(6760);
            k1.setby("Ribe");
            v1.setodrenummer(67895);

            kunde k2 = new kunde();
            varenummer v2 = new varenummer();
            k2.setId(2);
            k2.setFornavn("frederik");
            k2.setEfternavn("stormand");
            k2.setadresse("møllevej2");
            k2.setpostNr(6969);
            k2.setby("Ribee");
            v2 = v1;


            Console.WriteLine(k1.kundeoplysninger());
            Console.WriteLine(k2.kundeoplysninger());
            Console.WriteLine(v1.gætodrenummer());
            Console.WriteLine(v2.gætodrenummer());

            Console.ReadLine();
        }
    }
}
