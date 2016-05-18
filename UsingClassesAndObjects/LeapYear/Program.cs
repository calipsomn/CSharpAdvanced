using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsLeapYear(int.Parse(Console.ReadLine())) ? "Leap" : "Common");
        }

        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }
}
