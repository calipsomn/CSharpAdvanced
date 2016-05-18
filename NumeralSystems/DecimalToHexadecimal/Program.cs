using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetHexFromDecimal(ulong.Parse(Console.ReadLine())));
        }

        public static string GetHexFromDecimal(ulong number)
        {
            ulong decimalNumber = number;
            StringBuilder hexNumber = new StringBuilder();
            while (decimalNumber > 0)
            {
                var reminder = decimalNumber % 16;
                string hexPresentation = reminder.ToString();
                switch (reminder)
                {
                    case (10): hexPresentation = "A"; break;
                    case (11): hexPresentation = "B"; break;
                    case (12): hexPresentation = "C"; break;
                    case (13): hexPresentation = "D"; break;
                    case (14): hexPresentation = "E"; break;
                    case (15): hexPresentation = "F"; break;
                }
                hexNumber.Insert(0, hexPresentation);
                decimalNumber /= 16;
            }
            return hexNumber.ToString();
        }
    }
}
