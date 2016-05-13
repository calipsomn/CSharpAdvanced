using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengths = Console.ReadLine();
            var result = ArraySum(Console.ReadLine().Split(' ').Select(num => int.Parse(num)).ToArray<int>(),
                Console.ReadLine().Split(' ').Select(num => int.Parse(num)).ToArray<int>());
            for (int ind = 0; ind < result.Length; ind++)
            {
                Console.Write(result[ind]);
                if (ind < result.Length - 1)
                    Console.Write(" ");
            }
        }

        public static int[] ArraySum(int[] number1, int[] number2)
        {
            List<string> result = new List<string>();
            int reminder = 0;
            var biggerLength = number1.Length > number2.Length ? number1.Length : number2.Length;
            for (int ind = 0; ind < biggerLength; ind++)
            {
                int count = reminder;
                if (number1.Length > ind)
                    count += number1[ind];
                if (number2.Length > ind)
                    count += number2[ind];

                if(count>=10)
                {
                    reminder = 1;
                    result.Add(count.ToString()[1].ToString());
                }
                else
                {
                    reminder = 0;
                    result.Add(count.ToString());
                }
            }
            if (reminder > 0)
                result.Add(reminder.ToString());
            return result.Select(num => int.Parse(num)).ToArray<int>();
        }
    }
}
