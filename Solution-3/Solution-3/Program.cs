using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem - 3
            /*
             * The prime factors of 13195 are 5, 7, 13 and 29.
             * What is the largest prime factor of the number 600851475143 ?
             */
            // Best Solution
            long number = 600851475143;
            int k = 2;
            while (k < number)
            {
                if (number % k == 0)
                {
                    number /= k;
                }
                else
                {
                    k++;
                }
            }
            Console.WriteLine("Answer = {0}", k);

            // Worst Solution
            long maxPrimeFactor = 0;
            long number2 = 600851475143;
            for (long i = 2; i < number2; i++)
            {
                if (number2 % i == 0)
                {
                    bool isPrimeFactor = true;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrimeFactor = false;
                            break;
                        }
                    }
                    if (isPrimeFactor)
                    {
                        if (maxPrimeFactor < i)
                        {
                            maxPrimeFactor = i;
                        }
                    }
                }
            }
            Console.WriteLine("Answer = {0}", maxPrimeFactor);

            Console.ReadKey();
        }
    }
}
