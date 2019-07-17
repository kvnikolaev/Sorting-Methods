using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Methods
{
    public class SelectionSort
    {
        public static void Act(int[] a)
        {
            int[] result = new int[a.Length];
            int smalles, buf;

            for (int i = 0; i < a.Length; i++)
            {
                smalles = i;
                for (int k = i+1; k < a.Length; k++)
                {
                    if (a[k] < a[smalles]) smalles = k;
                }
                buf = a[i];
                a[i] = a[smalles];
                a[smalles] = buf;
            }
        }
    }
}
