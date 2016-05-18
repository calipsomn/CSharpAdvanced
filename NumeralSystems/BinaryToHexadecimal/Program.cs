using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetHexFromBinary(Console.ReadLine()));
        }

        public static string GetHexFromBinary(string binary)
        {
            int reminder = binary.Length % 4;
            string binaryNumber = reminder > 0 ? binary.Insert(0, new string('0', 4 - reminder)) : binary;
            StringBuilder hexNumber = new StringBuilder();
            for (int ind = 0; ind < binaryNumber.Length; ind += 4)
            {
                string binaryRep = new string(new char[] { binaryNumber[ind], binaryNumber[ind + 1], binaryNumber[ind + 2], binaryNumber[ind + 3] });
                char hex = '0';
                switch (binaryRep)
                {
                    case "0001": hex = '1'; break;
                    case "0010": hex = '2'; break;
                    case "0011": hex = '3'; break;
                    case "0100": hex = '4'; break;
                    case "0101": hex = '5'; break;
                    case "0110": hex = '6'; break;
                    case "0111": hex = '7'; break;
                    case "1000": hex = '8'; break;
                    case "1001": hex = '9'; break;
                    case "1010": hex = 'A'; break;
                    case "1011": hex = 'B'; break;
                    case "1100": hex = 'C'; break;
                    case "1101": hex = 'D'; break;
                    case "1110": hex = 'E'; break;
                    case "1111": hex = 'F'; break;
                }
                hexNumber.Append(hex);
            }
            return hexNumber.ToString();
        }
    }
}
