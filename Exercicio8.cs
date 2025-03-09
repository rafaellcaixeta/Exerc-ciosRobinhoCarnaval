using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] d = new int[20];
            Console.WriteLine("Digite 20 numeros:");
            
            for (int i = 0; i < 20; i++)
            {
                d[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite N:");
            int n = int.Parse(Console.ReadLine());
            
            List<int> compactado = new List<int>();

            foreach (int item in d)
            {
                if (item > n)
                {
                    compactado.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", compactado));
        }
    }
}