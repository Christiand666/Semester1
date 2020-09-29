using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øveshit
{
    class Program
    {//lav program som returnerer summen af to tal som den tager som input parameter
        //GivMigSummen(2,3)
        //returns 5; 
        static void Main(string[] args)
        {
            {
                
            }

        }
    }
}









//public static int nogetnyt(int tal, int tal1)
//{


//}





//Console.WriteLine("skriv det første tal ");
//            int input = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("skriv dit andet tal ");
//            int input1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("indtast ");
//            int input2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("dit resultat er " + input* input1 * input2);
//            Console.ReadLine();


//Console.WriteLine("skriv det første tal ");
//            double input = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("skriv dit andet tal ");
//            double input1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("indtast ");
//            double input2 = Convert.ToDouble(Console.ReadLine());



//Console.WriteLine("dit gennemsnit er " + (input + input1 + input2) / 3);
//            Console.ReadLine();

//Console.WriteLine("første tal til dit x ");
//            int input = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("skriv dit andet tal til y");
//            int input1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("indtast et tal til z ");
//            int input2 = Convert.ToInt32(Console.ReadLine());



//Console.WriteLine("dit gennemsnit er " + (input + input1* input2)+ " din anden sum er "+ (input* input1 + input1* input2));
//            Console.ReadLine();



//Console.WriteLine("indtast et tal");
//            int ettal = Convert.ToInt32(Console.ReadLine());

//bool erdet5 = Vikastertilbage(ettal);

//Console.WriteLine(erdet5);
//            Console.ReadLine();


//        }
//        public static bool Vikastertilbage(int ettal)
//{
//    bool erdet5 = true;

//    if (ettal > 5)
//    {
//        erdet5 = false;
//    }
//    return erdet5;


//static void Main(string[] args)
//{
//    Console.WriteLine("indtast et tal");
//    int ettal = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("indtast et andet tal");
//    int etal1 = Convert.ToInt32(Console.ReadLine());
//    int erdet5 = Vikastertilbage(ettal, etal1);

//    Console.WriteLine(erdet5);
//    Console.ReadLine();


//}
//public static int Vikastertilbage(int ettal, int ettal1)
//{

//    int erdet5;
//    erdet5 = (ettal + ettal1);

//    return erdet5;


//}

//}


//static void Main(string[] args)
//{
//    Console.WriteLine(Vikastertilbage("vifjernermoskeet3elleretW", 1));
//    Console.WriteLine(Vikastertilbage("vifjernermoskeet3elleretW", 9));
//    Console.WriteLine(Vikastertilbage("1vifjernermoskeet3elleretW", 0));

//    Console.ReadLine();
//}
//public static string Vikastertilbage(string str, int n)
//{
//    return str.Remove(n, 1);



//}
//static void Main(string[] args)
//{


//    Console.WriteLine(first_last("nogetrandom"));
//    Console.WriteLine(first_last("Storebogstaver"));
//    Console.WriteLine(first_last("yx"));
//}
//public static string first_last(string ustr)
//{
//    return ustr.Length > 1
//   ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
//}


//    {
//            Console.WriteLine("indtast et negativt tal");
//            int x = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("indtast et posetivt tal");
//            int y = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(x< 0 && y> 0 || x< 0 && y< 0);
//            Console.ReadLine();


//        }

//     {
//            Console.WriteLine("indtast et tal");
//            int tal = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("indtast et tal");
//            int tal1 = Convert.ToInt32(Console.ReadLine());

//int erdettriple = nogetnyt(tal, tal1);

//Console.WriteLine(erdettriple);

//            Console.ReadLine();


//        }
//        public static int nogetnyt(int tal, int tal1)
//{
//    int erdettriple = 0;
//    int erdettriple1 = 0;

//    if (tal == tal1)
//    {
//        erdettriple = (tal + tal1) * 3;

//    }
//    if (tal > tal1 || tal < tal1)
//    {
//        erdettriple1 = (tal + tal1);
//        erdettriple = erdettriple1;
//    }

//    return erdettriple;

//}

//    {
//            Console.WriteLine(result(13, 40));
//            Console.WriteLine(result(50, 21));
//            Console.WriteLine(result(0, 23));
//            Console.ReadLine();
//        }

//        public static int result(int a, int b)
//{
//    if (a > b)
//    {
//        return (a - b) * 2;
//    }
//    return b - a;
//}

//string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
//string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
//string word = "";
//int ctr = 0;
//            foreach (String s in words)
//            {
//                if (s.Length > ctr)
//                {
//                    word = s;
//                    ctr = s.Length;
//                }
//            }

//            Console.WriteLine(word);
//            Console.ReadLine();

//{
//            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
//            for (int n = 1; n<(99 + 1); n++)
//            {
//                if (n % 2 != 0)
//                {
//                    Console.WriteLine(n.ToString());

//                }

//            }
//            Console.ReadLine();


//        }

//    {

//            Console.Write("Input  a number(integer): ");
//            int n = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//            while (n != 0)
//            {
//                sum += n % 10;
//                n /= 10;
//            }
//            Console.WriteLine("Sum of the digits of the said integer: " + sum);
//        }

//int[] first_array = { 1, 3, -5, 4 };
//int[] second_array = { 1, 4, -5, -2 };

//Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));
//            Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

//            Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

//            for (int i = 0; i<first_array.Length; i++) // den tæller i for loopet hvor mange gange den skal bruge i indexet fra index 0 og så til til i det første array
//            {

//                Console.Write(first_array[i] * second_array[i] + " ");
//            }
//            Console.WriteLine("\n");
//        }
//static void Main(string[] args)
//{
//    string[] array = { "første", "anden", "tredje" };
//    string[] array1 = { "lol", "lol", "lol" };

//    Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array));
//    Console.WriteLine("Array2: [{0}]", string.Join(", ", array1));

//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.WriteLine(array[i] + ", " + array1[i]);
//    }

//    Console.ReadLine();
//}

//    {
//            int[] first_array = { 1, 3, -5, 4 };
//int[] second_array = { 1, 4, -5, -2 };

//Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));
//            Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

//            Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

//            for (int i = 0; i<first_array.Length; i++)
//            {

//                Console.Write(first_array[i] * second_array[i] + " ");
//            }
//            Console.WriteLine("\n");
//        }