using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSystemToAnyOther
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFromDecimal(GetDecimal(number, s), d));
        }

        static ulong GetDecimal(string number, int baseSystem)
        {
            ulong result = 0;
            ulong multiplier = 1;
            foreach (char ch in number.ToUpper().Reverse())
            {
                ulong decNum = 0;
                switch (ch)
                {
                    case 'A': decNum = 10; break;
                    case 'B': decNum = 11; break;
                    case 'C': decNum = 12; break;
                    case 'D': decNum = 13; break;
                    case 'E': decNum = 14; break;
                    case 'F': decNum = 15; break;
                    default: decNum = ulong.Parse(ch.ToString()); break;
                }
                result += decNum * multiplier;
                multiplier *= (ulong)baseSystem;
            }
            return result;
        }

        static string GetFromDecimal(ulong decNumber, int baseSystem)
        {
            var result = new StringBuilder();
            while (decNumber > 0)
            {
                var reminder = decNumber % (ulong)baseSystem;
                string numBaseRepresent = reminder.ToString();
                switch (reminder)
                {
                    case (10): numBaseRepresent = "A"; break;
                    case (11): numBaseRepresent = "B"; break;
                    case (12): numBaseRepresent = "C"; break;
                    case (13): numBaseRepresent = "D"; break;
                    case (14): numBaseRepresent = "E"; break;
                    case (15): numBaseRepresent = "F"; break;
                }
                result.Insert(0, numBaseRepresent);
                decNumber /= (ulong)baseSystem;
            }
            return result.ToString();
        }
    }
}
