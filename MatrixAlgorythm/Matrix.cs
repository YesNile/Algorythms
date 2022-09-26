using System;
using System.Text;

namespace MatrixAlgorythm
{
    public class Matrix

    {
        public int[,] Matrix1;
        public int[,] Matrix2;
        
        
        public int[,] Run()
        {
            var matrix1Rows = Matrix1.GetLength(0);
            var matrix1Cols = Matrix1.GetLength(1);
            var matrix2Rows = Matrix2.GetLength(0);
            var matrix2Cols = Matrix2.GetLength(1);

            if (matrix1Cols != matrix2Rows)
                throw new InvalidOperationException();

            int[,] product = new int[matrix1Rows, matrix2Cols];
            for (int matrix1Row = 0; matrix1Row < matrix1Rows; matrix1Row++)
            {
                for (int matrix2Col = 0; matrix2Col < matrix2Cols; matrix2Col++)
                {
                    for (int matrix1Col = 0; matrix1Col < matrix1Cols; matrix1Col++)
                    {
                        product[matrix1Row, matrix2Col] +=
                            Matrix1[matrix1Row, matrix1Col] *
                            Matrix2[matrix1Col, matrix2Col];
                    }
                }
            }

            return product;
        }
        public static int[,] GetMatrix(int column, int row)
        {
            int[,] matrix = new int[column,row];
            Random random = new Random();
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    matrix[i,j] = random.Next(100);
                }
            }

            return matrix;
        }
        public static TimeSpan GetAverageSpan(TimeSpan[] spans)
        {
            TimeSpan[] timeSpans = spans.OrderBy(n => n).ToArray();
            return timeSpans[3];
        }
        public static void ExportAsCsvMatrix(List<(int, int, TimeSpan)> researches, Matrix algorithm)
        {
            string path =
                $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"Matrix"}_{DateTime.Now.ToString("yyyy-M-dd")}.csv";

            Console.WriteLine($"File saved at: {path}");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tested algorithm:;{algorithm.GetType().Name}({"Matrix"})");

            sb.AppendLine();

            sb.AppendLine($"Dimension (elements);Dimension (elements);Spent time (µs)");
            foreach (var pos in researches)
                sb.AppendLine($"{pos.Item1};{pos.Item2};{pos.Item3.Ticks*1000}");
            File.WriteAllText(path, sb.ToString());
        }
    }
}