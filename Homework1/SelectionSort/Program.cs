using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
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
            for (int sortInd = 0; sortInd < n; sortInd++)
            {
                int minInd = sortInd;
                int currentNumber = numbers[sortInd];
                int minNumber = currentNumber;
                for (int toSortInd = sortInd + 1; toSortInd < n; toSortInd++)
                {
                    if (minNumber > numbers[toSortInd])
                    {
                        minNumber = numbers[toSortInd];
                        minInd = toSortInd;
                    }
                }
                numbers[minInd] = numbers[sortInd];
                numbers[sortInd] = minNumber;
            }
            for (int ind = 0; ind < n; ind++)
            {
                Console.WriteLine(numbers[ind]);
            }
        }
    }
}
