
using System;
using System.Collections.Generic;
using System.Text;

namespace studerendetest
{
    [Serializable]
    public class klient : Person
    {

        public string Navn { private set; get; }
        public string klientId { private set; get; }

        public string randomting { private set; get; }

        public int AntalEksaminer { private set; get; } // ikke brugt
        public klient(string Navn, string klientId, string randomting) : base(Navn)
        {
            this.Navn = Navn;
            this.randomting = randomting;

            if (klientId.Length == 8)
                this.klientId = klientId;


            else
                throw Exception();
        }



        private Exception Exception()
        {
            throw new NotImplementedException();
        }

        public override string Info()
        {

            return $"klient navn: {Navn} \n StudieID: {klientId} \n random ting: {randomting} ";
        }


    }
}