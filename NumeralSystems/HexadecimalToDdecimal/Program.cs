using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDdecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDecimalFromHex(Console.ReadLine()));
        }

        public static ulong GetDecimalFromHex(string hex)
        {
            string hexNumber = hex;
            ulong result = 0;
            ulong multiplier = 1;
            foreach (char ch in hex.ToLower().Reverse())
            {
                ulong decNum = 0;
                switch (ch)
                {
                    case 'a': decNum = 10; break;
                    case 'b': decNum = 11; break;
                    case 'c': decNum = 12; break;
                    case 'd': decNum = 13; break;
                    case 'e': decNum = 14; break;
                    case 'f': decNum = 15; break;
                    default: decNum = ulong.Parse(ch.ToString()); break;
                }
                result += decNum * multiplier;
                multiplier *= 16;
            }
            return result;
        }
    }
}
