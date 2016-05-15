using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(num => long.Parse(num)).ToArray<long>();
            Console.WriteLine(MinNumber(numbers));
            Console.WriteLine(MaxNumber(numbers));
            Console.WriteLine(AverageNumber(numbers).ToString("0.00"));
            Console.WriteLine(SumOfNumbers(numbers));
            Console.WriteLine(ProductOfNumbers(numbers));
        }

        public static long MaxNumber(params long[] numbers)
        {
            long max = numbers[0];
            for (long ind = 1; ind < numbers.Length; ind++)
                if (numbers[ind] > max)
                    max = numbers[ind];
            return max;
        }

        public static long MinNumber(params long[] numbers)
        {
            long min = numbers[0];
            for (long ind = 1; ind < numbers.Length; ind++)
                if (numbers[ind] < min)
                    min = numbers[ind];
            return min;
        }

        public static double AverageNumber(params long[] numbers)
        {
            long sum = 0;
            foreach(var number in numbers)
                sum += number;
            return (double)sum / (double)numbers.Length;
        }

        public static long SumOfNumbers(params long[] numbers)
        {
            long sum = 0;
            foreach (var number in numbers)
                sum += number;
            return sum;
        }

        public static long ProductOfNumbers(params long[] numbers)
        {
            long product = 1;
            foreach (var number in numbers)
                product *= number;
            return product;
        }
    }
}
