using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];
            int[] y = new int[10];
            int pontuacao = 0;

            Console.WriteLine("Digite 5 números do sorteio da loto:");

            for (int i = 0; i < 5; i++)
            {
                x[i] = int.Parse(Console.ReadLine());   
            }

            Console.WriteLine("Digite 10 números da sua aposta:");

            for (int i = 0; i < 10; i++)
            {
                y[i] = int.Parse(Console.ReadLine());
            }
            foreach (int num in y)
            {
                if (Array.Exists(x, element => element == num))
                {
                    pontuacao++;
                }
            }
            Console.WriteLine($"Você fez {pontuacao} pontos.");
        }
    }
}