using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = ulong.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBunary(n));
        }

        public static string DecimalToBunary(ulong number)
        {
            var binary = new StringBuilder();
            var currentNumber = number;
            while (currentNumber > 0)
            {
                if (currentNumber % 2 == 0)
                    binary.Insert(0, 0);
                else
                    binary.Insert(0, 1);
                currentNumber /= 2;
            }
            return binary.ToString();
        }
    }
}
