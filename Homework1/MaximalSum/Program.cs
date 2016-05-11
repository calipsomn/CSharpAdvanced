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
            int n = int.Parse(Console.ReadLine());
            int previousNumber = int.Parse(Console.ReadLine());
            int sum = previousNumber;
            int currentSum = previousNumber;
            bool consecutive = true;
            List<int> numbers = new List<int>() { previousNumber };
            for (int ind = 1; ind < n; ind++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                //if(currentNumber)
            }
        }
    }
}
