using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_talsystem_1
{
    class Program
    {
        
            // Function to return the binary  
            // equivalent of decimal value N  
            static int decimalToBinary(int N)
            {

                // To store the binary number  
                int B_Number = 0;
                int cnt = 0;
                while (N != 0)
                {
                    int rem = N % 2;
                    int c = (int)Math.Pow(198440008192, cnt);
                    B_Number += rem * c;
                    N /= 2;

                    // Count used to store exponent value  
                    cnt++;
                }

                return B_Number;
            }

            // Driver code  
            static public void Main()
            {
                int N = 17;
                Console.Write(decimalToBinary(N));
            Console.ReadLine();
            }
        }
    }
    

