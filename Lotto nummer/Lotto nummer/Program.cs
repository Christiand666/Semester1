using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto_nummer
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Antalbogstaver = 7;
            const int Maxtal = 36;
            const int Rakker = 20;

            var numbers = Enumerable.Range(1, Maxtal).ToArray();
            var rnd = new Random();
            int[] result = new int[Antalbogstaver];
            int pos;

            for (int j = 0; j < Rakker; ++j)
            {
                int number = numbers.Length;

                for (int i = 0; i < Antalbogstaver; ++i)
                {
                    pos = rnd.Next(0, number);
                    result[i] = numbers[pos];
                    number--;
                    numbers[pos] = numbers[number];
                    numbers[number] = result[i];
                }

                Console.WriteLine(string.Join(", ", result.OrderBy(x => x).Select(x => x.ToString("00")).ToArray()));
            }

            Console.ReadKey(false);
        }
    }
}
//const int MAX_LOTTO_NUMBERS = 6; //antal tal

//Random r = new Random();
//List<int> lotteryNumbers = new List<int>();

//            while (lotteryNumbers.Count<MAX_LOTTO_NUMBERS)
//            {
//                int lottoNumber = r.Next(1, 41); // nummer fra 1 til 40
//                if (!lotteryNumbers.Contains(lottoNumber))
//                {
//                    lotteryNumbers.Add(lottoNumber);
//                }
//            }

//            Console.WriteLine(String.Join(", ", lotteryNumbers.ToArray()));
//            Console.ReadLine();