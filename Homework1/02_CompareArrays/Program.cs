using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            for (int ind = 0; ind < n; ind++)
                array1[ind] = int.Parse(Console.ReadLine());
            for (int ind = 0; ind < n; ind++)
                array2[ind] = int.Parse(Console.ReadLine());
            bool equal = true;
            for (int ind = 0; ind < n; ind++)
                if (array1[ind] != array2[ind])
                {
                    equal = false;
                    break;
                }
            Console.WriteLine(equal ? "Equal" : "Not equal");
        }
    }
}
