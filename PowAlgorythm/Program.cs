using System;
using System.Text;

namespace PowAlgorythm
{
    public class Program
    {
        // public int Degree;
        // public int Number;
        // public int Steps;

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
            // Console.WriteLine("Pow Result:");
            // Console.WriteLine(powrun.Run());
            // Console.WriteLine("Pow Steps:");
            // Console.WriteLine(powrun.Steps);
            // Export.ExportAsCsvPow(results,powrun);
            // Console.WriteLine("QuickPow Result:");
            // Console.WriteLine(quickpowrum.Run());
            // Console.WriteLine("QuickPow Steps:");
            // Console.WriteLine(quickpowrum.Steps);
            // Console.WriteLine("QuickPow1 Result:");
            // Console.WriteLine(quickpow1run.Run());
            // Console.WriteLine("QuickPow1 Steps:");
            // Console.WriteLine(quickpow1run.Steps);
            // Console.WriteLine("RecPow Result:");
            // Console.WriteLine(recpowrun.Run());
            // Console.WriteLine("RecPow Steps:");
            // Console.WriteLine(recpowrun.Steps);
        }
    }
}