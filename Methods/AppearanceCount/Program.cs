using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            foreach (var number in Console.ReadLine().Split(' '))
                numbers.Add(int.Parse(number));

            int searchedNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetAppearanceCount(numbers.ToArray(), searchedNumber));
        }

        public static int GetAppearanceCount(int[] numbers, int number)
        {
            return numbers.Where(n => n == number).Count();
        }
    }
}
