using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int ind = 0; ind < n; ind++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            numbers.Sort();
            int sum = 0;
            for (int ind = n - k; ind < n; ind++)
            {
                sum += numbers[ind];
            }
            Console.WriteLine(sum);
        }
    }
}
