using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10._4
{

    class program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("please enter date as dd-MM-yyyy");

            int day;
            int month;
            int year;

            string[] read = Console.ReadLine().Split('-');
            day = int.Parse(read[0]);
            month = int.Parse(read[1]);
            year = int.Parse(read[2]);

            Date i = new Date(day, month, year);


           
            Console.WriteLine("{0}/{1}/{2}", i.Day, i.Month, i.Year);
            Console.ReadLine();
        }


        class Date
        {
            private int _month; // 1-12
            private int _day; // 1-31 depending on month
            private int _year;

            public Date(int day, int month, int year)
            {
                Month = month;
                Year = year;
                Day = day;
            }

            public int Year
            {
                get { return _year; }
                set
                {

                    _year = value;
                   
                }
            }

            public int Month
            {
                get { return _month; }
                set
                {
                    if (value > 0 && value <= 12)
                        _month = value;
                    else
                        throw new ArgumentOutOfRangeException("Month", value, "Month must be 1-12");
                }
            }

            public int Day
            {
                get { return _day; }
                set
                {

                    int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                   
                    if (value > 0 && value <= days[_month])
                    {
                        _day = value;
                       
                    }

                    else if (_month == 2 && value == 29 &&
                       _year % 400 == 0 || (_year % 4 == 0 && _year % 100 != 0))
                       _day = value;
                    else
                  
                        throw new ArgumentOutOfRangeException("Day", value, "Day is out of range");

                }

            }

        }
    }
}


//10.5


//        static void Main(string[] args)
//{
//    string test = "Play it again Sam, play i";

//    //nu skal metoden kunne tæller hvor mange af et valgt bogstav d
//    int cnt = vilæserbogstaver(test);
//    Console.WriteLine(cnt);
//    Console.ReadLine();
//}

//public static int vilæserbogstaver(string test)
//{
//    int cnt = 0;
//    foreach (char c in test)
//    {
//        if (c == 'a') cnt++;

//    }
//    return cnt;
//}

//10.6

// {
//            string test = "Play it again Sam, play i";

//char bogstavAtTjekke = 'P';

////nu skal metoden kunne tæller hvor mange af et valgt bogstav der er i en string 
//int cnt = vilæserbogstaver(test, bogstavAtTjekke);
//Console.WriteLine(cnt);
//            Console.ReadLine();
//        }

//        public static int vilæserbogstaver(string test, char bogstaveAtjekke)
//{
//    int cnt = 0;
//    foreach (char c in test)
//    {
//        if (c == bogstaveAtjekke) cnt++;

//    }
//    return cnt;
//}