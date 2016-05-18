using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetBinaryFromShort(int.Parse(Console.ReadLine())));
        }

        public static string GetBinaryFromShort(int shortNumber)
        {
            var result = new StringBuilder();
            var currentNumber = shortNumber;
            while (currentNumber > 0)
            {
                if (currentNumber % 2 == 0)
                    result.Insert(0, 0);
                else
                    result.Insert(0, 1);
                currentNumber /= 2;
            }
            result.Insert(0, new string('0', 16 - result.Length));
            if (shortNumber < 0)
                result != result;
            return result.ToString();
        }
    }
}
