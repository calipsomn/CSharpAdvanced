using System;
using System.Collections.Generic;
using System.Text;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = double.Parse(Console.ReadLine());
                if (number > 0.0)
                    Console.WriteLine(Math.Sqrt(number).ToString("0.000"));
                else
                    Console.WriteLine("Invalid number");
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine("Good bye");
        }
    }
}
