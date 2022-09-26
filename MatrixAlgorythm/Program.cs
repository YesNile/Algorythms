using System.Diagnostics;
using System.Text;

namespace MatrixAlgorythm
{

    class Program:Matrix
    {
        public static void Main()
        {
            // Matrix algorithm = new Matrix();
            // Run(algorithm,5,10);
            int[,] numbers = { { 4345346, 7346345, 33543}, { 38678, 667868, 945674 }, { 4567456, 14657, 4654745 }, { 44567, 7456745, 3456745 }, { 3457, 6234, 934252 }, { 24355, 12345, 4262563 } };
            Matrix algorithm = new Matrix();
            ConductResearchMatrix(numbers, algorithm);
        }
        public static TimeSpan Run(Matrix algorithm, int column, int row)
        {
            TimeSpan[] pRes = new TimeSpan[5];
            Stopwatch timer = new Stopwatch();
            for (int i = 0; i < 5; i++)
            {
                algorithm.Matrix1 = GetMatrix(column, row);
                algorithm.Matrix2 = GetMatrix(row, column);
                timer.Start();
                algorithm.Run();
                timer.Stop();
                pRes[i] = timer.Elapsed;
                timer.Reset();
            }

            // ExportAsCsvMatrix();
            return GetAverageSpan(pRes);
        }
        
        public static void ConductResearchMatrix(int[,] dimensions, Matrix algorithm, bool sorted = false)
        {
            List<(int, int, TimeSpan)> results = new List<(int, int, TimeSpan)>();

            int rows = dimensions.GetUpperBound(0) + 1;
            int columns = dimensions.Length / rows;

            // for (int i = 0; i < rows; i++)
            // {                                   
            //     for (int j = 0; j < columns; j++)
            //     {
                    Console.WriteLine($"Проверка размера: {rows}*{columns}");
                    results.Add((rows, columns, Run(algorithm, columns, rows)));
                //}

            //}       
            Console.WriteLine("Выполнено!");
            ExportAsCsvMatrix(results, algorithm);
        }
    }
}