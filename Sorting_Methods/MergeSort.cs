using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Methods
{
    public class MergeSort
    {
        public static void Act(int[] a)
        {
            int begin = 0, end = a.Length - 1;
            a = Sort(a);

        }

        private static int[] Sort(int[] buff)
        {
            if (buff.Length > 1)
            {
                int[] left = new int[buff.Length / 2];
                int[] right = new int[buff.Length - left.Length];

                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = buff[i];
                }
                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = buff[left.Length + i];
                }
                if (left.Length > 1)
                    left = Sort(left);
                if (right.Length > 1)
                    right = Sort(right);

                buff = Merge(left, right);
            }
            return buff;

        }
        static int number = 0;
        private static int[] Merge(int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            int[] buff = new int[left.Length + right.Length];
            while (i < left.Length && j < right.Length)
            {
                buff[k++] = left[i] < right[j] ? left[i++] : right[j++];
            }
            if (i < left.Length)
            {
                for (int x = i; x < left.Length; x++)
                    buff[k++] = left[x];
            }
            if (j < right.Length)
            {
                for (int y = j; y < right.Length; y++)
                    buff[k++] = right[y];
            }
            return buff;
        }
    }
}
