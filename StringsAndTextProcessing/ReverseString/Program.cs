using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            char[] output = new char[input.Length];
            int currentInd = 0;
            for(int ind = input.Length-1; ind>=0;ind--)
            {
                output[currentInd] = input[ind];
                currentInd++;
            }
            Console.WriteLine(new string(output));
        }
    }
}
