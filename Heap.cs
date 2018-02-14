using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortingAlgorithms.HeapSort
{
    public class Heap
    {
        public static void Sort(int[] arr)
        {
            Sort(arr, arr.Length);
        }

        public static void Sort(int[] arr, int n)
        {
            if (n <= 1) return;
            int swap;
            for(int i = (n / 2) - 1; i >= 0; i--)
            {
                if (arr[i] < arr[2 * i + 1])
                {
                    swap = arr[2 * i + 1];
                    arr[2 * i + 1] = arr[i];
                    arr[i] = swap;
                }
                if (2 * i + 2 < n && arr[i] < arr[2 * i + 2])
                {
                    swap = arr[2 * i + 2];
                    arr[2 * i + 2] = arr[i];
                    arr[i] = swap;
                }
            }
            swap = arr[n-1];
            arr[n-1] = arr[0];
            arr[0] = swap;

            Sort(arr, n - 1);
        }
    }
}
