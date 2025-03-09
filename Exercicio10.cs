using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Digite os valores {i},{j}:");
                    x[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int somaA = 0, somaB = 0, somaC = 0, somaD = 0;
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i < 2 && j < 2) somaA += x[i, j];
                    if (i >= 2 && j >= 2) somaB += x[i, j];
                    if (i > j) somaC += x[i, j];
                    if (i < j) somaD += x[i, j];
                }
            }
            Console.WriteLine($"Soma da região (a): {somaA}");
            Console.WriteLine($"Soma da região (b): {somaB}");
            Console.WriteLine($"Soma da região (c): {somaC}");
            Console.WriteLine($"Soma da região (d): {somaD}");
        }
    }
}