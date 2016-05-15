using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[] { 1 };
            for (int num = 2; num <= n; num++)
                number = MultiplyNumber(number, num);
            for (int ind = 0; ind < number.Length; ind++)
            {
                Console.Write(number[ind]);
            }
        }

        public static int[] MultiplyNumber(int[] number, int multiplier)
        {
            List<int> resultNumber = new List<int>();
            int reminder = 0;
            for (int ind = number.Length - 1; ind >= 0; ind--)
            {
                var multiplied = number[ind] * multiplier + reminder;
                reminder = multiplied.ToString().Length == 1 ? 0 : multiplied / 10;
                resultNumber.Insert(0, int.Parse(multiplied.ToString()[multiplied.ToString().Length - 1].ToString()));
            }
            if(reminder>0)
                for (int ind = reminder.ToString().Length - 1; ind >= 0; ind--)
                {
                    resultNumber.Insert(0, int.Parse(reminder.ToString()[ind].ToString()));
                }
            return resultNumber.ToArray();
        }
    }
}
