using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_test_classe_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankonto nr1 = new Bankonto(1998767, "lønkonto", 5000.00);
            Bankonto nr2 = new Bankonto(1998767, "opsparingskonto", 1000000.00);
            Bankonto nr3 = new Bankonto(1998767, "forbrugslånkonto", 20000.00);

            Bankonto[] bank = new Bankonto[3];
            bank[0] = nr1;
            bank[1] = nr2;
            bank[2] = nr3;
            for (int i = 0; i < bank.Length; i++)
            {
                Console.WriteLine($"Navn={bank[i].Navn} Nr={bank[i].Nr} Saldo={bank[i].Saldo}");
            }
            bank[0].indsæt(1000.00);
            bank[1].Hæve(500.00);



            Console.ReadLine();
        }
    }
}
