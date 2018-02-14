using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.InsertionSort
{
    public class Insertion
    {
        public static void Sort(int [] arr)
        {
            int i;
            int j;
            int current;
            for (i = 1; i < arr.Length; i++)
            {
                current = arr[i];
                j = i;
                while(j > 0 && arr[j-1] > current)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = current;
            }
        }
    }
}
