using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem - 9
            /*
             * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
             * a^2 + b^2 = c^2
             * For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
             * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
             * Find the product abc.
             */
            int a = 1, b = 2, c = 3;
            int total = 1000;
            while ((a * a) + (b * b) != (c * c) || a + b + c != total)
            {
                if (c == total)
                {
                    b++;
                    c = b + 1;
                }
                else if (b == total)
                {
                    a++;
                    b = a + 1;
                    c = b + 1;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine("{0}^2 + {1}^2 = {2}^2", a, b, c);
            Console.WriteLine("a * b * c = {0}", (a * b * c));
            Console.ReadKey();
        }
    }
}
