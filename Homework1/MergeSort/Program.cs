using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> mainNumbers = new List<int>();
            for (int ind = 0; ind < n; ind++)
            {
                mainNumbers.Add(int.Parse(Console.ReadLine()));
            }
            mainNumbers = Merge(mainNumbers);
            foreach (var number in mainNumbers)
                Console.WriteLine(number);
        }

        static List<int> Merge(List<int> numbers)
        {
            if (numbers.Count < 2)
                return numbers;

            List<int> firstArray = new List<int>();
            List<int> secondArray = new List<int>();
            for (int ind = 0; ind < numbers.Count; ind++)
            {
                if (ind % 2 == 0)
                    secondArray.Add(numbers[ind]);
                else
                    firstArray.Add(numbers[ind]);
            }
            firstArray = Merge(firstArray);
            secondArray = Merge(secondArray);
            return MergeSortArray(firstArray, secondArray);
        }

        static List<int> MergeSortArray(List<int> firstArray, List<int> secondArray)
        {
            var result = new List<int>();
            while (firstArray.Count > 0 && secondArray.Count > 0)
            {
                if (firstArray[0] <= secondArray[0])
                {
                    result.Add(firstArray[0]);
                    firstArray.RemoveAt(0);
                }
                else
                {
                    result.Add(secondArray[0]);
                    secondArray.RemoveAt(0);
                }
            }
            while(firstArray.Count>0)
            {
                result.Add(firstArray[0]);
                firstArray.RemoveAt(0);
            }
            while (secondArray.Count > 0)
            {
                result.Add(secondArray[0]);
                secondArray.RemoveAt(0);
            }
            return result;
        }
    }
}
