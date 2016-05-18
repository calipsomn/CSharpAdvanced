using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinaryToDecimal(Console.ReadLine()));
        }

        public static ulong BinaryToDecimal(string binaryNumber)
        {
            ulong result = 0;
            ulong multiplier = 1;
            foreach (var ch in binaryNumber.Reverse())
            {
                if (ch != '0')
                    result += multiplier;
                multiplier *= 2;
            }
            return result;
        }
    }
}
