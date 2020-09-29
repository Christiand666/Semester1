using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test_af_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast et tal eller bogstav");

            using (StreamWriter writer = new StreamWriter(@"C:\test1\yoursay.dat"))
            {

                string input = Console.ReadLine();

                while (input.Trim().Length != 0)
                {
                    writer.WriteLine(input);
                    input = Console.ReadLine();

                }
                Console.ReadLine();
            }

        }
    }
}
