using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Methods
{
    public class QuickSort
    {
        public static void Act(int[] a)
        {
            int begin = 0, end = a.Length - 1;
            Sort(a, begin, end);
        }

        private static void Sort(int[] a, int begin, int end)
        {
            int p = a[(end + begin) / 2];
            int buf;
            int i = begin, j = end;
            while (i <= j)
            {
                while (a[i] < p && i <= end) ++i;
                while (a[j] > p && j >= begin) --j;
                if (i <= j)
                {
                    buf = a[i];
                    a[i] = a[j];
                    a[j] = buf;
                    ++i; --j;
                }
            }
            if (j > begin) Sort(a, begin, j);
            if (i < end) Sort(a, i, end);
        }

        //private static int Paritition(int[] a, int begin, int end)
        //{
        //    int q = begin, buf;
        //    for (int u = begin; u < end-1; u++)
        //    {
        //        if (a[u] <= a[end])
        //        {
        //            buf = a[u];
        //            a[u] = a[q];
        //            a[q] = buf;
        //            q++;
        //        }
        //    }
        //    buf = a[q];
        //    a[q] = a[end];
        //    a[end] = buf;

        //    return q;
        //}
    }
}
