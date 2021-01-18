using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem - 5
            /*
             * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
             * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?
             */ 
            int smallestNumber = 20;
            while(true)
            {
                bool check = true;
                for (int i = 2; i <= 20; i++)
                {
                    if (smallestNumber % i != 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine("Answer = {0}", smallestNumber);
                    break;
                }
                smallestNumber +=20;
            }
            Console.ReadKey();
        }
    }
}
