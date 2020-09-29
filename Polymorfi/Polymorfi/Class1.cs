using DocumentFormat.OpenXml.Office2013.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace polyprøverigen
{
    class Program
    {
        static void Main(string[] args)
        {

            List<person> noget = new List<person>();

            studerne x = new studerne("4jn45j", "Christian");
            Underviser y = new Underviser("pew", "poul");

            noget.Add(x);
            noget.Add(y);

            foreach (person item in noget)
            {
                item.Info();
                
            }
            Console.ReadLine();




        }
	
       
          
            
          


        }
    }

