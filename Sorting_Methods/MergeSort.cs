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
            Sort(a);

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
            int[] buff = new int[left.Length + right.Length];
            //счетчики длины трех массивов
            int i = 0;  //соединенный массив
            int l = 0;  //левый массив
            int r = 0;  //правый массив
                        //сортировка сравнением элементов
            for (; i < buff.Length; i++)
            {
                //если правая часть уже использована, дальнейшее движение происходит только в левой
                //проверка на выход правого массива за пределы
                if (r >= right.Length)
                {
                    buff[i] = left[l];
                    l++;
                }
                //проверка на выход за пределы левого массива
                //и сравнение текущих значений обоих массивов
                else if (l < left.Length && left[l] < right[r])
                {
                    buff[i] = left[l];
                    l++;
                }
                //если текущее значение правой части больше
                else
                {
                    buff[i] = right[r];
                    r++;
                    //подсчет количества инверсий
                    if (l < left.Length)
                        number += left.Length - l;
                }
            }
            //возврат отсортированного массива
            return buff;

        }
    }
}
