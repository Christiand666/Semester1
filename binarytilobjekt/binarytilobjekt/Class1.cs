using System;
using System.Collections.Generic;
using System.Text;

namespace PrøveEksamen2
{
    
    class Studerende2 : Person
    {

        public string Navn { private set; get; }
        public string StudieID { private set; get; }

        public int AntalEksaminer { private set; get; } // ikke brugt
        public Studerende2(string Navn, string StudieID) : base(Navn)
        {
            this.Navn = Navn;

            if (StudieID.Length == this.StudieID = StudieID);
            else
                throw Exception();
        }

        public Studerende2(string s)
        {

        }

        private Exception Exception()
        {
            throw new NotImplementedException();
        }

        public override string Info()
        {

            return $"Studerende navn: {Navn} \n StudieID: {StudieID}";
        }


    }
}