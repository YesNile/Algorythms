using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AlgorithmsAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] dimensions = new[]
            // {
            //     50,100,150,200,500,700,1000,2000,5000,8000,10000,12000
            // };
            Random rand = new Random();
            int[] dimensions = new int[2000];
            for (int i = 0; i < dimensions.Length; i++)
                dimensions[i] = i + 1; // rand.Next(0,1000) + 1;
            List<IResercheable> algorythmList = new List<IResercheable>()
            {
                new BubbleSort(),
                new CoctailSort(),
                new TimSort(),
                new Linal(),
                new Summ(),
                new Multiplication(),
                new CycleSort(),
                new QuickSort()
            };

            foreach (var algol in algorythmList)
            {
                    Tools.ConductResearch(dimensions, algol);
            }
        }
    }

    class Tools
    {
        //Метод, создающий массив заданного размера со случайными значениями
        public static int[] GenerateArray(int size)
        {
             int[] array = new int[size];
             Random random = new Random();
             for (int i = 0; i < array.Length; i++)
                 array[i] = random.Next(500000);
             return array;
        }

        //Метод, создающий массив заданного размера с отсортированными значениями
        public static int[] GenerateSortedArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 1; i < array.Length; i++)
                array[i] = array[i - 1] + random.Next(1000) + 1;
            return array;
        }

        //Метод, возвращающий время, которое он потратил на алгоритм
        public static long MeasureTime(int[] array, IResercheable algorithm)
        {
            Random random = new Random();
            Stopwatch watch = new Stopwatch();
            algorithm.Run(array, array.Length);
            watch.Start();
            algorithm.Run(array, array.Length);
            watch.Stop();
            //return watch.ElapsedMilliseconds;
            return watch.ElapsedTicks / 100;
        }

        //Метод для тестирования
        public static void ConductResearch(int[] dimensions, IResercheable algorithm, bool sorted = false)
        {
            List<(int, long)> results = new List<(int, long)>();
            results.Add((-1, sorted ? 1 : 0));

            foreach (int dimension in dimensions)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Проверка размера {algorithm.Name}: {dimension}");
                    results.Add((dimension,
                        MeasureTime(sorted ? GenerateSortedArray(dimension) : GenerateArray(dimension), algorithm)));
                }
            }
            // foreach(var num in results)
            // {
            //     Console.WriteLine(num);
            // }

            Console.WriteLine("Выполнено!");
            List<(int, long)> res = new List<(int, long)>();
            for (int i = 1; i <= 2000; i++)
            {
                var average =  results.Where(x => x.Item1 == i).Average(x=>x.Item2);
                res.Add((i,(long)average));
            }
            ExportAsCsv(res, algorithm);
        }

        //Метод, который записывает наши данные в файл
        private static void ExportAsCsv(List<(int, long)> researches, IResercheable algorithm)
        {
            string path =
                $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{algorithm.Name}_{DateTime.Now.ToString("yyyy-M-dd")}.csv";

            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tested algorithm:;{algorithm.GetType().Name}({algorithm.Name})");
            // int serviceIndex = researches.FindIndex(x => x.Item1 == -1);
            // string sorted = researches[serviceIndex].Item2 == 1 ? "YES" : "NO";
            // sb.AppendLine($"Sorted?;{sorted}");
            // sb.AppendLine();
            // researches.RemoveAt(serviceIndex);
            sb.AppendLine($"Dimension (elements);Spent time (µs)");
            foreach (var pos in researches)
                sb.AppendLine($"{pos.Item1};{pos.Item2}");
            File.WriteAllText(path, sb.ToString());
            Console.WriteLine($"File saved at: {path}");
        }
    }


    interface IResercheable
    {
        //Метод, описывающий алгоритм
        //array - набор данных, который будет тестироваться
        //value - значение, которое ищем в массиве
        void Run(int[] array, int value = 0);

        //Имя, которое отображается в экспортном файле
        string Name { get; }
    }
}