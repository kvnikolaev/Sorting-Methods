using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            PrintArray(array);

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
