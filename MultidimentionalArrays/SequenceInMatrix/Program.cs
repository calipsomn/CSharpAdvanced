using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRowNumbers = Console.ReadLine().Split(' ');
            int n = int.Parse(firstRowNumbers[0]);
            int m = int.Parse(firstRowNumbers[1]);
            string[,] matrix = new string[n, m];
            for (int rowInd = 0; rowInd < n; rowInd++)
            {
                var numbers = Console.ReadLine().Split(' ');
                for (int colInd = 0; colInd < numbers.Count(); colInd++)
                    matrix[rowInd, colInd] = numbers[colInd];
            }
            int maxSequence = 0;
            for (int rowInd = 0; rowInd < n; rowInd++)
            {
                for (int colInd = 0; colInd < n; colInd++)
                {
                    var currentString = matrix[rowInd, colInd];
                    int currentSequence = 0;
                    for (int currentCol = colInd; currentCol < n; currentCol++)
                    {
                        if (matrix[rowInd, currentCol] == currentString)
                            currentSequence++;
                        else
                            break;
                    }
                    if (currentSequence > maxSequence)
                        maxSequence = currentSequence;

                    currentSequence = 0;
                    for (int currentRow = rowInd; currentRow < n; currentRow++)
                    {
                        if (matrix[currentRow, colInd] == currentString)
                            currentSequence++;
                        else
                            break;
                    }
                    if (currentSequence > maxSequence)
                        maxSequence = currentSequence;

                    currentSequence = 0;
                    for (int currentRow = rowInd, currentCol = colInd; currentRow < n && currentCol < n; currentRow++, currentCol++)
                    {
                        if (matrix[currentRow, currentCol] == currentString)
                            currentSequence++;
                        else
                            break;
                    }
                    if (currentSequence > maxSequence)
                        maxSequence = currentSequence;

                    currentSequence = 0;
                    for (int currentRow = rowInd, currentCol = n - 1; currentRow < n && currentCol >= 0; currentRow++, currentCol--)
                    {
                        if (matrix[currentRow, currentCol] == currentString)
                            currentSequence++;
                        else
                            break;
                    }
                    if (currentSequence > maxSequence)
                        maxSequence = currentSequence;
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}
