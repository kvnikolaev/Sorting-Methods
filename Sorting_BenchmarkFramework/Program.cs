using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Sorting_BenchmarkFramework
{
    [Config(typeof(HabrExampleConfig))]
    public class Target
    {
        private class HabrExampleConfig : ManualConfig
        {
            public HabrExampleConfig()
            {
                Add(StatisticColumn.Max); // Добавляем необходимую колонку    
                Add(StatisticColumn.AllStatistics);
            }
        }


        [Benchmark(Description = "Init")]
        public void Bench()
        {
            Init(5000);
        }

        [Benchmark(Description = "InitDiagonal")]
        public void Bench1()
        {
            InitDiagonal(5000);
        }

        public static void Init(int range)
        {
            int[,] m = new int[range, range];

            for (int i = 0; i < range; i++)
            {
                for (int k = 0; k < range; k++)
                {
                    m[i, k] = 1;
                }
            }
        }
        public static void InitDiagonal(int range)
        {
            int[,] m = new int[range, range];

            for (int i = 0; i < range; i++)
            {
                m[i, i] = 2;
                for (int k = 0; k < range; k++)
                {
                    m[i, k] = m[k, i] = 1;
                }
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Target>();

            Console.ReadLine();
        }
    }
}
