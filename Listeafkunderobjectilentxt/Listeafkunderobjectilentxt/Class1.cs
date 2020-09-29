using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamenØvelsefeb18TxtConsole
{

    public abstract class person
    {
        public string navn;
    }
    public class cardinfo
    {
        public string kortnavn;
        public int kortnummer;
        public int udløbsdato;
        public int CVRnummer;

    }

    class Kunde : person
    {
        public int telefonnummer;
        public int antalminutter;
        public Kunde(int telefonnummer, int antalminutter, string navn)
        {
            this.telefonnummer = telefonnummer;
            this.antalminutter = antalminutter;
            this.navn = navn;
        }
    }
    public class owner : person
    {
    }
    class support : person
    {
        public string intialer;
    }
}
