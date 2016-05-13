using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');
            var maxNumber = int.Parse(numbers[0]);
            for (int ind = 1; ind < numbers.Count(); ind++)
            {
                maxNumber = GetMax(maxNumber, int.Parse(numbers[ind]));
            }
            Console.WriteLine(maxNumber);
        }

        public static int GetMax(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
    }
}
