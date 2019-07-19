using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Methods
{
    public class MergeSort
    {
        static int SortCounter = 0;

        public static void Act(int[] a)
        {
            int begin = 0, end = a.Length - 1;
            Sort(a, begin, end);
            
        }

        private static void Sort(int[] a, int begin, int end)
        {
            SortCounter++;
            Console.WriteLine(SortCounter);

            if (begin >= end) return;

            int q = end / 2;
            Sort(a, begin, q);
            Sort(a, q + 1, end);

            Merge(a, begin, q, end);
         }

        private static void Merge(int[] a, int begin, int q, int end)
        {
            int[] first = new int[q - begin + 1];
            int[] second = new int[end - q];

            for (int i = begin, k = 0; i <= q; i++, k++)
            {
                first[k] = a[i];
            }
            for (int i = q+1, k = 0; i <= end; i++, k++)
            {
                second[k] = a[i];
            }

            for (int a_i = begin, first_k = 0, second_j = 0; a_i <= end; a_i++)
            {
                if (first_k >= first.Length)
                {
                    a[a_i] = second[second_j];
                    second_j++;
                    continue;
                }
                if (second_j >= second.Length)
                {
                    a[a_i] = first[first_k];
                    first_k++;
                    continue;
                }
                if (first[first_k] <= second[second_j])
                {
                    a[a_i] = first[first_k];
                    first_k++;
                }
                else
                {
                    a[a_i] = second[second_j];
                    second_j++;
                }
            }
        }
    }
}
