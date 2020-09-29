using System;
using System.Collections.Generic;
using System.Text;

namespace studerendetest
{
    [Serializable]
    public class Studerende : Person
    {
       
        public string Navn { private set; get; }
        public string StudieID { private set; get; }

        public int AntalEksaminer { private set; get; } // ikke brugt
        public Studerende(string Navn, string StudieID) : base(Navn)
        {
            this.Navn = Navn;

            if (StudieID.Length == 8)
                this.StudieID = StudieID;
            else
                throw Exception();
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