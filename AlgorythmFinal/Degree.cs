// using System;
//
// namespace AlgorithmsAnalysis
// {
//     class Degree : IResercheable
//
//     {
//     public static void Master()
//     {
//         Console.WriteLine("Enter a number");
//         long x = (long) Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Enter a degree");
//         int n = Convert.ToInt32(Console.ReadLine());
//         Degree2(x, n);
//     }
//
//     public static void Degree2(long x, int n)
//     {
//         long f = 1;
//         for (int i = 0; i < n; i++)
//         {
//             f = f * x;
//         }
//
//         Console.WriteLine($"Finish result:{f}");
//     }
//     }
// }