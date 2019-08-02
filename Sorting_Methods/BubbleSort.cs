using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Methods
{
    public class BubbleSort
    {
        public static void Act(int[] a)
        {
            int counterShift = 0;
            do
            {
                counterShift = 0;
                int biggest = 0, buf;
                for (int i = 0; i+1 < a.Length; i++)
                {
                    if (a[i+1] < a[i])
                    {
                        buf = a[i+1];
                        a[i+1] = a[i];
                        a[i] = buf;
                        counterShift++;
                    }
                }

            } while (counterShift > 0);
        }
    }
}
