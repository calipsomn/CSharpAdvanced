using System;
using System.Collections.Generic;
using System.Text;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            StringBuilder sb = new StringBuilder("1 < ");
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    int currentNumber = int.Parse(Console.ReadLine());
                    if (currentNumber <= number)
                    {
                        Console.WriteLine("Exception");
                        return;
                    }
                    if (i < 9)
                        sb.Append(currentNumber + " < ");
                    else
                        sb.Append(currentNumber + " < 100");
                    number = currentNumber;
                }
                Console.WriteLine(sb.ToString());
            }
            catch
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
