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
        public string Info()
        {
            return navn;
        }
    }


    class studerne : person
    {
        public string StudieId;
        public studerne(string StudieId, string navn)
        {
            this.StudieId=StudieId;
            this.navn=navn;

        }
        public string Info()
        {
            return StudieId + base.Info();
        }
       
    }

    class Underviser : person
    {
        public string inti;
        public Underviser(string inti, string navn)
        {
            this.inti = inti;
           

        }
        public string Info()
        {
            return inti + base.Info(); ;

        }
       
    }
}
