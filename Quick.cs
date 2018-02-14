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
            // Ռեկուրսիայի բազան
            if (end - start == 0) return;

            int pivot = arr[(end + start) / 2]; // Ընտրում ենք առանցքային տարրը
            int swap;
            int i = start;
            int j = end;

            //  Կարգավորում ենք զանգվածը հետևյալ սկզբունքով՝
            //  առանցքային տարրից փոքր կամ հավասար տարրերը զանգվածի "ձախ" կողմում իսկ մեծ տարրերը "աջ"

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

            //  Կանչում ենք կարգավորման ֆունկցիան երկու ենթազանգվածների համար
             
            Sort(arr, start, i-1);     //  Առանցքային տարրից փոքր կամ հավասար տարրերի ենթազանգվածի
            Sort(arr, i, end);         //  Առանցքային տարրից մեծ տարրերի ենթազանգվածի
        }
    }
}