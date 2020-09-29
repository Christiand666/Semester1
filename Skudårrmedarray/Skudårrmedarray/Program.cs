using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Skudårrmedarray
{
    class GFG
    {
        static int[] days = { 31, 28, 31, 30, 31, 30,
                           31, 31, 30, 31, 30, 31 };

        // Function to return the day number 
        // of the year for the given date 
        static int dayOfYear(string date)
        {
            // Extract the year, month and the 
            // day from the date string 
            int year = Int32.Parse(date.Substring(0, 4));

            int month = Int32.Parse(date.Substring(5, 2));

            int day = Int32.Parse(date.Substring(8));

            // If current year is a leap year and the date 
            // given is after the 28th of February then 
            // it must include the 29th February 
            if (month > 2 && year % 4 == 0 &&
               (year % 100 != 0 || year % 400 == 0))
            {
                ++day;
            }

            // Add the days in the previous months 
            while (--month > 0)
            {
                day = day + days[month - 1];

            }
            return day;
        }

        // Driver code 
        public static void Main()
        {
            String date = "2019-01-09";
            Console.WriteLine(dayOfYear(date));
            Console.ReadLine();
        }
    }
}






