using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_test_classe_array
{
    class Bankonto
    {
        public int Nr { get; set; }
        public string Navn { get; set; }

        public double Saldo { get; private set; }

        public Bankonto(int nr, string navn, double saldo)
        {
            Nr = nr;
            Navn = navn;
            Saldo = saldo;
        }
        public void indsæt(double belob)
        {
            Saldo = Saldo + belob;
        }

        public double Hæve(double belob)
        {
            if (belob > Saldo)
                Console.WriteLine("overtræk");
            else
            Saldo = Saldo - belob;
            return belob;
        }

    }
}
