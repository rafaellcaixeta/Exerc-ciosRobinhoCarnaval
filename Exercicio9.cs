using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] juizes = new int[7];
            double maior = 0;
            double menor = 10;
            List<double> notas = new List<double>();
           
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite uma nota de 1 a 10:");
                double nota = double.Parse(Console.ReadLine());
                notas.Add(nota);

                if (nota > maior)
                {
                    maior = nota;
                }
                
                if (nota < menor)
                {
                    menor = nota;
                }
            }
            notas.Remove(maior);
            notas.Remove(menor);
            double soma = notas.Sum();
            Console.WriteLine($"A soma das notas e {soma}");
        }
    }
}