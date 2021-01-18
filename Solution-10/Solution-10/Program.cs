using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solution - 10
            /*
             * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
             *
             *  Find the sum of all the primes below two million.
             */
            // Best Solution
            int number = 2000000;
            List<int> primeList = new List<int>();
            primeList.Add(2);
            long total = 2;
            for (int i = 3; i <= number; i+=2)
            {
                bool isPrimeNumber = true;
                foreach (int j in primeList)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    primeList.Add(i);
                    total += i;
                }
            }
            Console.WriteLine("Answer = {0}", total);
            Console.ReadKey();
        }
    }
}
