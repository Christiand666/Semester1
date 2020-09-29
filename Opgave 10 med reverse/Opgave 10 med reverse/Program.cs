using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Opgave_10_med_reverse
{
    public static class Test
    {
        private static IEnumerable<string> Vibytterlige(this string s)
        {
            var enting = StringInfo.GetTextElementEnumerator(s);
            while (enting.MoveNext())
            {
                yield return (string)enting.Current;
            }
        }
        private static string Reversevibytterlige(this string s)
        {
            return string.Join("", s.Vibytterlige().Reverse().ToArray());
        }

        public static void Main()
        {
            var s = "har lavet den her selv uden hjælp lol";
            var r = s.Reversevibytterlige();
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}



