using System;
using System.Text;

namespace PowAlgorythm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<PowTest> results = new List<PowTest>()
            {
                new Pow
                {
                },
                new QuickPow
                {

                },
                new QuickPow1
                {

                },
                new RecPow
                {
                }
            };
            foreach (var pow in results)
            {
                Console.WriteLine($"Pow Result:{pow.Run()}");
                Export.ExportAsCsvPow(pow);
            }
        }
    }
}