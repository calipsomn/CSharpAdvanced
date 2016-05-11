using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var charArr1 = Console.ReadLine().ToCharArray();
            var charArr2 = Console.ReadLine().ToCharArray();
            int length = charArr1.Length > charArr2.Length ? charArr1.Length : charArr2.Length;
            for (int ind = 0; ind < length; ind++)
            {
                if (charArr1.Length < length)
                {
                    Console.WriteLine("<");
                    return;
                }
                if (charArr2.Length < length)
                {
                    Console.WriteLine(">");
                    return;
                }
                if (charArr1[ind] > charArr2[ind])
                {
                    Console.WriteLine(">");
                    return;
                }
                if (charArr1[ind] < charArr2[ind])
                {
                    Console.WriteLine("<");
                    return;
                }
            }
            Console.WriteLine("=");
        }
    }
}
