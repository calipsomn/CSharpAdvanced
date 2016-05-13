using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CountLargerNeighbours(Console.ReadLine().Split(' ').Select(num => int.Parse(num)).ToArray<int>()));
        }

        public static int CountLargerNeighbours(int[] numbers)
        {
            int count = 0;
            for (int ind = 1; ind < numbers.Length - 1; ind++)
            {
                if (numbers[ind] > numbers[ind - 1] && numbers[ind] > numbers[ind + 1])
                    count++;
            }
            return count;
        }
    }
}
