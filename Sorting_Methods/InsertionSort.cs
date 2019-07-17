using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Methods
{
    public class InsertionSort
    {
        public static void Act(int[] a)
        {
            int key, k, buf;
            for (int i = 0; i < a.Length; i++)
            {
                key = a[i];
                for(k = i - 1; k >= 0 && a[k] > key; k--)
                {
                    buf = a[k + 1];
                    a[k + 1] = a[k];
                    a[k] = buf;
                }
                a[k + 1] = key;
            }
        }
    }
}
