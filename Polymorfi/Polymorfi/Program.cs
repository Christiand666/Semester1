using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyprøverigen
{
    public abstract class person
    {
        public string navn;
        public abstract void Info();
       
    }


    class studerne : person
    {
        public string StudieId;
        public studerne(string StudieId, string navn)
        {
            this.StudieId = StudieId;
            this.navn = navn;
        }

           
        public override void Info()
        {
            Console.WriteLine(this.navn);
            Console.WriteLine(this.StudieId);
        }
    }

    class Underviser : person
    {
        public string inti;
        public Underviser(string inti, string navn)
        {
            this.inti = inti;
            this.navn = navn;

        }
        public override void Info()
        {
            Console.WriteLine(this.navn);
            Console.WriteLine(this.inti);
        }

    }
}
