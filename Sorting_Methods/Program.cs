using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Sorting_Methods
{
    class Program
    {
        public static int[] GenerateRandomArray(int range)
        {
            int[] result = new int[range];
            Random rnd = new Random();
            for (int i = 0; i < range; i++)
            {
                result[i] = rnd.Next(20);
            }

            return result;
        }

        public static void PrintArray(int[] a)
        {
            for(int k = 0; k < a.Length - 1; k++)
            {
                Console.Write(a[k] + ", ");
            }
            Console.WriteLine(a[a.Length - 1]);
        }


        static void Main(string[] args)
        {
            var array = GenerateRandomArray(19);
            int[] array2 = new int[19];
            int[] array3 = new int[19];
            int[] array4 = new int[19];
            int[] array5 = new int[19];
            Array.Copy(array, array2, array.Length);
            Array.Copy(array, array3, array.Length);
            Array.Copy(array, array4, array.Length);
            Array.Copy(array, array5, array.Length);

            PrintArray(array);

            SelectionSort.Act(array);
            PrintArray(array);

            InsertionSort.Act(array2);
            PrintArray(array2);

            MergeSort.Act(array3);
            PrintArray(array3);

            QuickSort.Act(array4);
            PrintArray(array4);

            BubbleSort.Act(array5);
            PrintArray(array5);

            BenchmarkRunner.Run<BenchmarkAccomulator>();


            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
