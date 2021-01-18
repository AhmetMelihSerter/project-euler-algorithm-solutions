using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem - 7
            /*
             * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
             * What is the 10 001st prime number?
             */
            int primeNumberCount = 0;
            int primeNumber = 1;
            while (primeNumberCount < 10001)
            {
                primeNumber++;
                bool isPrimeNumber = true;
                for (int i = 2; i < primeNumber; i++)
                {
                    if (primeNumber % i == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (primeNumber == 2 || isPrimeNumber)
                {
                    primeNumberCount++;
                }
            }
            Console.WriteLine("The {0}st prime number is = {1}", primeNumberCount, primeNumber);
            Console.ReadKey();
        }
    }
}
