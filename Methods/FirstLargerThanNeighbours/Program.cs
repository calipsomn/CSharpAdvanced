using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FirstLargerNeighbours(Console.ReadLine().Split(' ').Select(num => int.Parse(num)).ToArray<int>()));
        }

        public static int FirstLargerNeighbours(int[] numbers)
        {
            int largerInd = -1;
            for (int ind = 1; ind < numbers.Length - 1; ind++)
            {
                if (numbers[ind] > numbers[ind - 1] && numbers[ind] > numbers[ind + 1])
                {
                    largerInd = ind;
                    break;
                }
            }
            return largerInd;
        }
    }
}
