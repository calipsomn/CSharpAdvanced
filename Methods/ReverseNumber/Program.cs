using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString(Console.ReadLine()));
        }

        public static string ReverseString(string word)
        {
            return new string(word.Reverse().ToArray());
        }
    }
}
