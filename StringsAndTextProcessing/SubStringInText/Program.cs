using System;
using System.Collections.Generic;
using System.Text;

namespace SubStringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            int count = 0;
            for (int ind = 0; ind < text.Length - pattern.Length + 1; ind++ )
            {
                if (String.Compare(text.Substring(ind, pattern.Length), pattern, true) == 0)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
