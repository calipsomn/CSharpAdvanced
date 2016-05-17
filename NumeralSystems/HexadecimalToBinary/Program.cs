using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetBinaryFromHex(Console.ReadLine()));
        }

        public static string GetBinaryFromHex(string hexNumber)
        {
            StringBuilder binary = new StringBuilder();
            foreach (char ch in hexNumber.ToLower())
            {
                switch (ch)
                {
                    case '0': binary.Append("0000"); break;
                    case '1': binary.Append("0001"); break;
                    case '2': binary.Append("0010"); break;
                    case '3': binary.Append("0011"); break;
                    case '4': binary.Append("0100"); break;
                    case '5': binary.Append("0101"); break;
                    case '6': binary.Append("0110"); break;
                    case '7': binary.Append("0111"); break;
                    case '8': binary.Append("1000"); break;
                    case '9': binary.Append("1001"); break;
                    case 'a': binary.Append("1010"); break;
                    case 'b': binary.Append("1011"); break;
                    case 'c': binary.Append("1100"); break;
                    case 'd': binary.Append("1101"); break;
                    case 'e': binary.Append("1110"); break;
                    case 'f': binary.Append("1111"); break;
                }
            }
            return binary.ToString().TrimStart('0');
        }
    }
}
