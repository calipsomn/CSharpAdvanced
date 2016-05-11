using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int ind = 0; ind < n; ind++)
            {
                numbers[ind] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(Console.ReadLine());
            int foundInd = -1;
            int firstInd = 0;
            int lastInd = n-1;
            while(foundInd<0)
            {
                if (lastInd - firstInd < 1)
                    break;

                int middleInd = (lastInd - firstInd) / 2;
                if (middleInd < firstInd)
                    break;

                int currentNumber = numbers[middleInd];
                if (currentNumber == x)
                {
                    foundInd = middleInd;
                    break;
                }
                if (currentNumber > x)
                {
                    firstInd = middleInd;
                }
                else
                {
                    lastInd = middleInd;
                }
            }
            Console.WriteLine(foundInd);
        }
    }
}
