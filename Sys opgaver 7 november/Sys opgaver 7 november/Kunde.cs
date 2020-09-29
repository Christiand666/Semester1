using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys_opgaver_7_november
{
    abstract class Kunde :Person, Iprintable
    {
        Kunde Id { get; private set; }

        public void print() { }
        public Kunde()
        {
            

        }
    }

    public string Id()
    {
        return Id;
    }

    

}
