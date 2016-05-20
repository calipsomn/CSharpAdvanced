using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(Console.ReadLine()));
        }

        static long GetSum(string text)
        {
            long sum = 0;
            foreach (var num in text.Split(' '))
                sum += long.Parse(num);
            return sum;
        }
    }
}
