using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(num => int.Parse(num)).ToArray<int>();
            numbers = SortArray(numbers, false);
            for (int ind = 0; ind < numbers.Length; ind++)
            {
                Console.Write("{0}{1}", numbers[ind], ind < numbers.Length - 1 ? " " : "");
            }
        }

        static int GetMaXFromPosition(int[] numbers, int startIndex)
        {
            int maxNumber = numbers[startIndex];
            int maxInd = startIndex;
            for (int ind = startIndex; ind < numbers.Count(); ind++)
            {
                if (numbers[ind] > maxNumber)
                {
                    maxNumber = numbers[ind];
                    maxInd = ind;
                }
            }
            return maxInd;
        }

        static int[] SortArray(int[] numbers, bool descending)
        {
            for (int ind = 0; ind < numbers.Length; ind++)
            {
                var currentNumber = numbers[ind];
                var maxInd = GetMaXFromPosition(numbers, ind);
                numbers[ind] = numbers[maxInd];
                numbers[maxInd] = currentNumber;
            }
            return descending ? numbers : numbers.Reverse().ToArray();
        }
    }
}
