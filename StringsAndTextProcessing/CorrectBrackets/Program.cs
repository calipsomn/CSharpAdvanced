using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool valid = true;
            int leftCount = 0;
            int rightCount = 0;
            foreach (var ch in input)
            {
                if (ch == '(')
                {
                    leftCount++;
                    continue;
                }
                if (ch == ')')
                    rightCount++;
                if (rightCount > leftCount)
                {
                    valid = false;
                    break;
                }
            }
            if (leftCount != rightCount)
                valid = false;
            Console.WriteLine(valid ? "Correct" : "Incorrect");
        }
    }
}
