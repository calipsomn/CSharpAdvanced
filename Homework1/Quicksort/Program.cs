using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            for (int ind = 0; ind < n; ind++)
            {
                numbers[ind] = int.Parse(Console.ReadLine());
            }
            QuickSortArr(numbers, 0, n - 1);
            for (int ind = 0; ind < n; ind++)
            {
                Console.WriteLine(numbers[ind]);
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int tmp;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;
                while (arr[j] > pivot)
                    j--;
                if (i <= j)
                {
                    tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                }
            };

            return i;
        }

        static void QuickSortArr(int[] arr, int left, int right)
        {
            int index = Partition(arr, left, right);
            if (left < index - 1)
                QuickSortArr(arr, left, index - 1);
            if (index < right)
                QuickSortArr(arr, index, right);
        }
    }
}
