using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRowNumbers = Console.ReadLine().Split(' ');
            int n = int.Parse(firstRowNumbers[0]);
            int m = int.Parse(firstRowNumbers[1]);
            int[,] matrix = new int[n, m];
            for (int rowInd = 0; rowInd < n; rowInd++)
            {
                var numbers = Console.ReadLine().Split(' ');
                for (int colInd = 0; colInd < numbers.Count(); colInd++)
                    matrix[rowInd, colInd] = int.Parse(numbers[colInd]);
            }
            int maxSum = int.MinValue;
            int subNumber = 3;
            for (int rowInd = 0; n >= subNumber ? rowInd <= n - subNumber : rowInd < n; rowInd++)
            {
                for (int colInd = 0; n>= subNumber? colInd <= n - subNumber: colInd < n; colInd++)
                {
                    int currentSum = 0;
                    for (int currentRowInd = rowInd; currentRowInd < rowInd + subNumber && currentRowInd < n; currentRowInd++)
                    {
                        for (int currentColInd = colInd; currentColInd < colInd + subNumber && currentColInd < n; currentColInd++)
                        {
                            currentSum += matrix[currentRowInd, currentColInd];

                        }
                    }
                    if (currentSum > maxSum)
                        maxSum = currentSum;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
