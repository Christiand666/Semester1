using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kunde_klasse
{

    class kunde
    {
        private int Id;
        private string Fornavn;
        private string Efternavn;
        private string Adresse;
        private int postNr;
        private string by;

        public void setId(int newId)
        {
            Id = newId;
        }
        public void setFornavn(string newfornavn)
        {
            Fornavn = newfornavn;
        }
        public void setEfternavn(string newefternavn)
        {
            Efternavn = newefternavn;
        }

        public void setadresse(string newadresse)
        {
            Adresse = newadresse;
        }

        public void setpostNr(int newpostNr)
        {
            postNr = newpostNr;
        }

        public void setby(string newby)
        {
            by = newby;
        }
        public string kundeoplysninger()
        {
            return (" Id er " + Id + " fornavn er " + Fornavn + " efternavn er " + Efternavn + " adresse er " + Adresse + " postNr " + postNr + " by er " + by);
        }

    }

       class varenummer
        {
        private int odrenummer;
       


            public void setodrenummer(int newodrenummer)
            {
                odrenummer = newodrenummer;
            }
                public string gætodrenummer()
                {
                    return ("odrenummer" + odrenummer);
                }
            
        }
    
}
