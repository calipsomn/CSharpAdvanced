using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> alphabet = new List<char>();
            
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                alphabet.Add(ch);
            }
            string word = Console.ReadLine();
            foreach (char ch in word)
            {
                Console.WriteLine(alphabet.IndexOf(ch));
            }
        }
    }
}
