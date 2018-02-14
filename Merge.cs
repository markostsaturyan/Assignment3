using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.MergeSort
{
    public class Merge
    {
        public static int memory = 0;
        public static void Sort(int[] arr)
        {
            if (arr.Length == 1) return;

            memory = memory + arr.Length * 4;

            int[] arr1 = new int[arr.Length / 2];
            int[] arr2 = new int[arr.Length - arr1.Length];

            int i;
            for(i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }
            for(i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr[i + arr1.Length];
            }
            
            Sort(arr1);
            Sort(arr2);
            i = 0;
            int k = 0;
            int j = 0;
            while(i<arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    arr[k] = arr1[i];
                    i = i + 1;
                }
                else
                {
                    arr[k] = arr2[j];
                    j = j + 1;
                }
                k++;

            }
            while (i < arr1.Length)
            {
                arr[k] = arr1[i];
                k++;
                i++;
            }
            while (j < arr2.Length)
            {
                arr[k] = arr2[j];
                k++;
                j++;
            }
        }
    }
}
