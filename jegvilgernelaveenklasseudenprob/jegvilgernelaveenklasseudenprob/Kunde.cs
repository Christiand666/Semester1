using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jegvilgernelaveenklasseudenprob
{
    public class Kunde
    {
      
        private int Id;
        public string KundeNavn;

        private int telefonnummer;

        public string Mailadresse;

    }

    public Kunde(string kundenavn, int ttelefonnummer, string mailadresse)
    {
        telefonnummer = ttelefonnummer;
    }

    public int getId()
    {
        return Id;
     }
}

