using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] sieve = new bool[n + 1];
            sieve[0] = false;
            sieve[1] = false;
            for (int ind = 2; ind <= n; ind++)
            {
                sieve[ind] = true;
            }
            int initialNumber = 2;
            while (initialNumber <= Math.Sqrt(n))
            {
                if (!sieve[initialNumber ])
                {
                    initialNumber++;
                    continue;
                }

                for (int iteration = 2 * initialNumber; iteration <= n; iteration += initialNumber)
                {
                    sieve[iteration] = false;
                }
                initialNumber++;
            }
            Console.WriteLine(sieve.ToList<bool>().LastIndexOf(true));
        }
    }
}
