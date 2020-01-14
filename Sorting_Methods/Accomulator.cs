using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Methods
{
    public class BenchmarkAccomulator
    {
        static int[] array, array1, array2, array3, array4;

        static BenchmarkAccomulator()
        {
            int howMuch = 1900;
            array1 = new int[howMuch];
            array2 = new int[howMuch];
            array3 = new int[howMuch];
            array4 = new int[howMuch];
            array = Program.GenerateRandomArray(howMuch);
            Array.Copy(array, array1, array.Length);
            Array.Copy(array, array2, array.Length);
            Array.Copy(array, array3, array.Length);
            Array.Copy(array, array4, array.Length);
        }

        [Benchmark(Description = "InsertionSort")]
        public void BenchInsertionSort()   
        {
            /*
             *  19 - median 272 ns    GenerateRandomArray (5,75us)
             *  190 - 2,6 us
             *  1900 - 24 us
             *  19000 - 243 us
             * */
            InsertionSort.Act(array);
        }

        [Benchmark(Description = "SelectionSort")]
        public void BenchSelectionSort()
        {
            /*
             
             1900 - 13909 us
             19000 - 1364279 us (1,37 s)
             */
            SelectionSort.Act(array1);
        }

        [Benchmark(Description = "MergeSort")]
        public void BenchMergeSort()
        {
            /*

            1900 - 703 us
            19000 - 8457 us
            */
            MergeSort.Act(array2);
        }

        [Benchmark(Description = "QuickSort")]
        public void BenchQuickSort()
        {
            /*
             
            1900 - 222
            19000 - 2657
             */
            QuickSort.Act(array3);
        }

        [Benchmark(Description = "BubbleSort")]
        public void BenchBubbleSort()
        {
            /*
             1900 - 14 us
             */
            BubbleSort.Act(array4);
        }

    }
}
