using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string direction = Console.ReadLine();
            int[,] matrix = new int[n, n];
            switch (direction.ToLower())
            {
                case "a":
                    int aNumber = 1;
                    for (int colInd = 0; colInd < n; colInd++)
                    {
                        for (int rowInd = 0; rowInd < n; rowInd++)
                        {
                            matrix[rowInd, colInd] = aNumber++;
                        }
                    }
                    break;
                case "b":
                    int bNumber = 1;
                    for (int colInd = 0; colInd < n; colInd++)
                    {
                        if (colInd % 2 == 0)
                            for (int rowInd = 0; rowInd < n; rowInd++)
                                matrix[rowInd, colInd] = bNumber++;
                        else
                            for (int rowInd = n - 1; rowInd >= 0; rowInd--)
                                matrix[rowInd, colInd] = bNumber++;
                    }
                    break;
                case "c":
                    int cNumber = 1;
                    for (int startPointRow = n - 1; startPointRow > 0; startPointRow--)
                    {
                        for (int rowInd = startPointRow, colInd = 0; rowInd < n && colInd < n; rowInd++, colInd++)
                        {
                            matrix[rowInd, colInd] = cNumber++;
                        }
                    }
                    for (int startPointCol = 0; startPointCol < n; startPointCol++)
                    {
                        for (int rowInd = 0, colInd = startPointCol; rowInd < n && colInd < n; rowInd++, colInd++)
                        {
                            matrix[rowInd, colInd] = cNumber++;
                        }
                    }
                        break;
                case "d":
                        int dNumber = 1;
                        int startRowInd = 0;
                        int startColInd = 0;
                        int endRowInd = n-1;
                        int endColInd = n-1;
                        while (dNumber <= n * n)
                        {
                            for (int row = startRowInd; row <= endRowInd; row++)
                                matrix[row, startColInd] = dNumber++;
                            startColInd++;

                            for (int col = startColInd; col <= endColInd; col++)
                                matrix[endRowInd, col] = dNumber++;
                            endRowInd--;

                            for (int row = endRowInd; row >= startRowInd; row--)
                                matrix[row, endColInd] = dNumber++;
                            endColInd--;

                            for (int col = endColInd; col >= startColInd; col--)
                                matrix[startRowInd, col] = dNumber++;
                            startRowInd++;
                        }
                        break;
            }

            for (int rowInd = 0; rowInd < n; rowInd++)
            {
                for (int colInd = 0; colInd < n; colInd++)
                {
                    Console.Write(matrix[rowInd, colInd]);
                    if (colInd < n - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
