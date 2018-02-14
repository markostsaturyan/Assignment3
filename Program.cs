using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.BubbleSort;
using SortingAlgorithms.HeapSort;
using SortingAlgorithms.InsertionSort;
using SortingAlgorithms.MergeSort;
using SortingAlgorithms.QuickSort;
using System.Diagnostics;

namespace SortingProgram
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the size of array.");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Stopwatch time1 = new Stopwatch();
            Random rand=new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }
            Console.WriteLine("This is a your random array.");

            PrintArray(arr);

            Console.WriteLine("1.Insertion Sort.");
            Console.WriteLine("2.Bubble Sort.");
            Console.WriteLine("3.Heap Sort.");
            Console.WriteLine("4.Quick Sort.");
            Console.WriteLine("5.Merge Sort.");
            Console.WriteLine("6.All");

            string sortIndexis = Console.ReadLine();
            Dictionary<int, double> dict = new Dictionary<int, double>();
            DateTime currentTime = DateTime.Now;
            double time = 0;
            for (int i = 0; i < sortIndexis.Length; i++)
            {
                if (sortIndexis[i] == ',') continue;
                if (sortIndexis.Length == 1 && sortIndexis[0] == '6')
                {
                    int[] arr1 = CopyArray(arr);
                    time1.Start();
                    Insertion.Sort(arr1);
                    time1.Stop();
                    dict.Add(1, time1.Elapsed.TotalMilliseconds);
                    time1.Reset();

                    arr1 = CopyArray(arr);
                    time1.Start();
                    Bubble.Sort(arr1);
                    time1.Stop();
                    dict.Add(2, time1.Elapsed.TotalMilliseconds);
                    time1.Reset();

                    arr1 = CopyArray(arr);
                    time1.Start();
                    Heap.Sort(arr);
                    time1.Stop();
                    dict.Add(3, time1.Elapsed.TotalMilliseconds);
                    time1.Reset();

                    arr1 = CopyArray(arr);
                    time1.Start();
                    Quick.Sort(arr);
                    time1.Stop();
                    dict.Add(4, time1.Elapsed.TotalMilliseconds);
                    time1.Reset();

                    arr1 = CopyArray(arr);
                    time1.Start();
                    Merge.Sort(arr1);
                    time1.Stop();
                    dict.Add(5, time1.Elapsed.TotalMilliseconds);
                    time1.Reset();
                    break;
                }
                else {
                    if (i + 1 < sortIndexis.Length && sortIndexis[i + 1] == '-')
                    {
                        char a = sortIndexis[i];

                        while(a<=sortIndexis[i+2])
                        {
                            switch (a)
                            {
                                case '1':
                                    {
                                        int[] arr1 = CopyArray(arr);
                                        time1.Start();
                                        Insertion.Sort(arr1);
                                        time1.Stop();
                                        dict.Add(1, time1.Elapsed.TotalMilliseconds);
                                        time1.Reset();
                                        break;
                                    }
                                case '2':
                                    {
                                        int[] arr1 = CopyArray(arr);
                                        time1.Start();
                                        Bubble.Sort(arr1);
                                        time1.Stop();
                                        dict.Add(2, time1.Elapsed.TotalMilliseconds);
                                        time1.Reset();
                                        break;
                                    }
                                case '3':
                                    {
                                        int[] arr1 = CopyArray(arr);
                                        time1.Start();
                                        Heap.Sort(arr1);
                                        time1.Stop();
                                        dict.Add(3, time1.Elapsed.TotalMilliseconds);
                                        time1.Reset();
                                        break;
                                    }
                                case '4':
                                    {
                                        int[] arr1 = CopyArray(arr);
                                        time1.Start();
                                        Quick.Sort(arr1);
                                        time1.Stop();
                                        dict.Add(4, time1.Elapsed.TotalMilliseconds);
                                        time1.Reset();
                                        break;
                                    }
                                case '5':
                                    {
                                        int[] arr1 = CopyArray(arr);
                                        time1.Start();
                                        Merge.Sort(arr1);
                                        time1.Stop();
                                        dict.Add(5, time1.Elapsed.TotalMilliseconds);
                                        time1.Reset();
                                        break;
                                    }
                            }
                            a++;
                        }
                            i += 2;
                    }
                    else
                    {
                        if (sortIndexis[i] == '1' || sortIndexis[i] == '2' || sortIndexis[i] == '3' || sortIndexis[i] == '4' || sortIndexis[i] == '5')
                        {
                            
                            switch (sortIndexis[i])
                            {
                                case '1':
                                    {
                                        int[] arr1 = CopyArray(arr);
                                        time1.Start();
                                        Insertion.Sort(arr1);
                                        time1.Stop();
                                        dict.Add(1, time1.Elapsed.TotalMilliseconds);
                                        time1.Reset();
                                        break;

                                    }
                                case '2':
                                    {
                                        int[] arr1 = CopyArray(arr);
                                        time1.Start();
                                        Bubble.Sort(arr1);
                                        time1.Stop();
                                        dict.Add(2, time1.Elapsed.TotalMilliseconds);
                                        time1.Reset();
                                        break;
                                    }
                                case '3':
                                    {
                                        int[] arr1 = CopyArray(arr);
                                        time1.Start();
                                        Heap.Sort(arr1);
                                        time1.Stop();
                                        dict.Add(3, time1.Elapsed.TotalMilliseconds);

                                        time1.Reset(); break;
                                    }
                                case '4':
                                    {
                                        int[] arr1 = CopyArray(arr);
                                        time1.Start();
                                        Quick.Sort(arr1);
                                        time1.Stop();
                                        dict.Add(4, time1.Elapsed.TotalMilliseconds);
                                        time1.Reset();
                                        break;
                                    }
                                case '5':
                                    {
                                        int[] arr1 = CopyArray(arr);
                                        time1.Start();
                                        Merge.Sort(arr1);
                                        time1.Stop();
                                        dict.Add(5, time1.Elapsed.TotalMilliseconds);
                                        time1.Reset();
                                        break;
                                    }
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input");
                            break;
                            Console.Read();
                            return;
                        }
                    }

                }
            }

            time = dict.First().Value;
            int index=dict.First().Key;
            string fast = "the fastest";
            if (dict.Count == 1)
            {
                fast = null;
            }
            else
            {

                for (int i = 1; i <= 5; i++)
                {
                    if (dict.ContainsKey(i) == false) continue;
                    if (dict[i] < time)
                    {
                        time = dict[i];
                        index = i;
                    }
                    Console.WriteLine(i);
                    Console.WriteLine(dict[i]);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            switch (index)
            {
                case 1:
                    {
                        Console.WriteLine("Insertion Sort " +fast);
                        Console.Write("Time =");
                        Console.WriteLine(time);
                        Insertion.Sort(arr);
                        Console.WriteLine("Memory:0");
                        PrintArray(arr);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Bubble Sort " +fast);
                        Console.Write("Time =");
                        Console.WriteLine(time);
                        Bubble.Sort(arr);
                        Console.WriteLine("Memory:0");
                        PrintArray(arr);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Heap Sort " + fast);
                        Console.Write("Time =");
                        Console.WriteLine(time);
                        Heap.Sort(arr);
                        Console.WriteLine("Memory:0");
                        PrintArray(arr);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Quick Sort " + fast);
                        Console.Write("Time =");
                        Console.WriteLine(time);
                        Quick.Sort(arr);
                        Console.WriteLine("Memory:0");
                        PrintArray(arr);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Merge Sort " + fast);
                        Console.Write("Time =");
                        Console.WriteLine(time);
                        Console.Write("Memory:");
                        Console.Write(Merge.memory);
                        Merge.Sort(arr);
                        PrintArray(arr);
                        break;
                    }
            }


            Console.Read();
            
        }


        public static int[] CopyArray(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];
            }
            return arr1;
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.Write("\n");
        }

    }
}
