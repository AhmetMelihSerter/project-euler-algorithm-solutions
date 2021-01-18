using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem - 4
            /*
             * A palindromic number reads the same both ways.
             * The largest palindrome made from the product of two 2-digit numbers is, 
             * 9009 = 91 × 99.
             * Find the largest palindrome made from the product of two 3-digit numbers.
             */
            int largestPalin = 0;
            int number = 999;
            for (int i = 2; i <= number; i++)
            {
                for (int j = 2; j <= number; j++)
                {
                    string palinStr = (i * j).ToString();
                    if (palinStr.Length % 2 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        bool isPalin = true;
                        for (int k = 0; k < palinStr.Length / 2; k++)
                        {
                            if (palinStr[k] != palinStr[palinStr.Length - (k + 1)])
                            {
                                isPalin = false;
                                break;
                            }
                        }
                        int isLargestPalin = i * j;
                        if (isPalin && largestPalin < isLargestPalin)
                        {
                            largestPalin = isLargestPalin;
                        }
                    }
                }
            }
            Console.WriteLine("Answer = {0}", largestPalin);
            Console.ReadKey();
        }
    }
}
