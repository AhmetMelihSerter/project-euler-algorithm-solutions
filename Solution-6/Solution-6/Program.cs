using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem - 6
            /*
             * The sum of the squares of the first ten natural numbers is,
             * 1^2 + 2^2 + .... + 10^2 = 385
             * The square of the sum of the first ten natural numbers is,
             * (1 + 2 + ... + 10) = 55^2 = 385
             * Hence the difference between the sum of the squares of the first ten natural numbers
             * and the square of the sum is.
             * 3025 - 385 = 2640
             * Find the difference between the sum of the squares of the first one hundred natural numbers
             * and the square of the sum. 
             */
            int number = 100;
            int sumSequares = 0;
            int sequareSum = 0;
            for (int i = 1; i <= number; i++)
            {
                sumSequares += i * i;
                sequareSum += i;
            }
            sequareSum *= sequareSum;
            Console.WriteLine("The sum of the squares = {0}", sumSequares);
            Console.WriteLine("The square of the sum = {0}", sequareSum);
            Console.WriteLine("Answer = {0}", (sequareSum - sumSequares));
            Console.ReadKey();
        }
    }
}
