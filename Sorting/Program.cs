
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Program
    {

        public static long Init(int range)
        {
            int[,] m = new int[range, range];

            var timer = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < range; i++)
            {
                for (int k = 0; k < range; k++)
                {
                    m[i, k] = 1;
                }
            }
            timer.Stop();


            Console.WriteLine(timer.ElapsedMilliseconds);
            return timer.ElapsedMilliseconds;
        }

        public static long InitDiagonal(int range)
        {
            int[,] m = new int[range, range];

            var timer = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < range; i++)
            {
                m[i, i] = 2;
                for (int k = 0; k < range; k++)
                {
                    m[i, k] = m[k, i] = 1;
                }
            }
            timer.Stop();

            Console.WriteLine(timer.ElapsedMilliseconds);
            return timer.ElapsedMilliseconds;
        }

        static void Main(string[] args)
        {
            
            int range = 50;

            // loop
            // Timer start
            List<long> time = new List<long>();
            for (int i = 0; i < range; i++)
            {
                time.Add( Init(5000));
            }
            // Timer stop
            Console.WriteLine(time.Average());
            /* range:
             * 500 - 284,162 
             * 50  - 282,54 
             * 10  - 320,5 (280)
             * 100 - 279,85
             pc50 - 83
             */
            Console.WriteLine("___________");

            List<long> time2 = new List<long>();
            for (int i = 0; i < range; i++)
            {
                time2.Add(InitDiagonal(5000));
            }
            // Timer stop
            Console.WriteLine(time2.Average());
            /* range:
             
             * 50  - 996 (1034)
             * 10 -  1008
             pc50 - !!в framework branch!!310
             */

            Console.ReadLine();
            // gigaLol

        }
    }
}
