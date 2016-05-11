using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int ind = 0; ind < n; ind++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (numbers.ContainsKey(currentNumber))
                    numbers[currentNumber]++;
                else
                    numbers.Add(currentNumber, 1);
            }

            var maxFrequency = numbers.OrderByDescending(p => p.Value).First();
            Console.WriteLine("{0} ({1} times)", maxFrequency.Key, maxFrequency.Value);
        }
    }
}
