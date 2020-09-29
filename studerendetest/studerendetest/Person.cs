using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studerendetest
{
    [Serializable]
    public  abstract class Person
    {
        
        public string Navn { private set; get; }
        public Person(string Navn)
        {
            this.Navn = Navn; 
        }

        public abstract string Info();
    }
}
