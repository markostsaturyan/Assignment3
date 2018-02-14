using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.QuickSort
{
    public class Quick
    {
        public static void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        public static void Sort(int[] arr, int start, int end)
        {
            if (end - start == 0) return;

            int pivot = arr[(end + start) / 2]; 
            int swap;
            int i = start;
            int j = end;


            while(i <= j)
            {
                while(arr[i] < pivot)
                {
                    i++;
                }
                while(arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    swap = arr[i];
                    arr[i] = arr[j];
                    arr[j] = swap;
                    i++;
                    j--;
                }
            }

             
            Sort(arr, start, i-1);     
            Sort(arr, i, end);         
        }
    }
}
