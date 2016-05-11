using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int previousNumber = 0;
            int currentCount = 0;
            int maxSequence = 0;
            for (int ind = 0; ind < n; ind++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (ind == 0)
                {
                    previousNumber = currentNumber;
                    maxSequence = 1;
                    currentCount = 1;
                    continue;
                }

                if (currentNumber > previousNumber)
                {
                    currentCount++;
                    if (currentCount > maxSequence)
                    {
                        maxSequence = currentCount;
                    }
                }
                else
                {
                    currentCount = 1;
                }
                previousNumber = currentNumber;
            }
            Console.WriteLine(maxSequence);
        }
    }
}
