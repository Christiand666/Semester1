using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_eks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("indtast nummer");
            int i = Convert.ToInt32(Console.ReadLine());
           
            
            switch (i)
            {
                case var s when new[] { 0,1, 2, 3,4,5,6,7,8,9 }.Contains(s):
                    Console.WriteLine("blandede skrifter");
                    Console.ReadLine();
                    break;

                case var s when new[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, }.Contains(s):
                    Console.WriteLine("Filosofi psykologi");
                    Console.ReadLine();
                    break;
                case var s when new[] { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29}.Contains(s):
                    Console.WriteLine("Religion");
                    break;

                case var s when new[] { 30, 31, 32, 33, 34, 35, 36, 37, 38, 39 }.Contains(s):
                    Console.WriteLine("Samfundsvidenskab, Pædagogik ");
                    break;

                case var s when new[] { 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 }.Contains(s):
                    Console.WriteLine(" Geografi og rejser");
                    break;

                case var s when new[] { 50, 51, 52, 53, 54, 55, 56, 57, 58, 59 }.Contains(s):
                    Console.WriteLine("  Naturvidenskab og matematik");
                    break;

                case var s when new[] { 60, 61, 62, 63, 64, 65, 66, 67, 68, 69 }.Contains(s):
                    Console.WriteLine("  Praktiske fag ");
                    break;


                case var s when new[] { 70, 71, 72, 73, 74, 75, 76, 77, 78, 79 }.Contains(s):
                    Console.WriteLine("   Kunst, teater, film, musik, spil, idræt  ");
                    break;

                case var s when new[] { 80, 81, 82, 83, 84, 85, 86, 87, 88, 89 }.Contains(s):
                    Console.WriteLine("   Litteratur, sprog   ");
                    break;

                case var s when new[] { 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 }.Contains(s):
                    Console.WriteLine("   Historie ");
                    break;
                default:
                    Console.WriteLine("Hold dig til nummeret klovn");
                    break;
                        

            }
            Console.ReadKey();
           

        }
    }
}
