using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_ark_6
{
    class Program
    {
       
            public void Main()
            {
            Console.Write("indtast nummer");
            int i = Convert.ToInt32(Console.ReadLine());

            int? n = GetDefault<int?>();


                // This will write null       
                switch (n)
                {
                    case null: Console.WriteLine("null"); break;
                    case 1: Console.WriteLine("value 1"); break;
                    default: Console.WriteLine("default"); break;
                }


                string s = GetDefault<string>();

                // This will write null       
                switch (s)
                {
                    case null: Console.WriteLine("null"); break;
                    case "foo": Console.WriteLine("foo"); break;
                    default: Console.WriteLine("default"); break;
                }
            }

        // GetDefault returns null for nullable and reference type T
        private T GetDefault<T>()
        {
            return default(T);
        }

    }
}  




         
