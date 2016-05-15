using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            var firstPolinomial = Console.ReadLine().Split(' ').Select(num => int.Parse(num)).ToArray<int>();
            var secondPolinomial = Console.ReadLine().Split(' ').Select(num => int.Parse(num)).ToArray<int>();
            var resultPolinomial = AddPolinomials(firstPolinomial, secondPolinomial);
            for (int ind = 0; ind < resultPolinomial.Length; ind++)
            {
                Console.Write("{0}{1}", resultPolinomial[ind], ind < resultPolinomial.Length - 1 ? " " : "");
            }
        }

        static int[] AddPolinomials(int[] firstPolinomial, int[] secondPolinomial)
        {
            int[] resultPolinomial = new int[firstPolinomial.Length];
            for (int ind = 0; ind < firstPolinomial.Length; ind++)
            {
                resultPolinomial[ind] = firstPolinomial[ind] + secondPolinomial[ind];
            }
            return resultPolinomial;
        }
    }
}
