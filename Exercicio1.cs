using System;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int VendaMediaMensal;
            double precoAtual = 30;
            double novoPreco;

            Console.WriteLine("Qual foi a média de venda mensal?");
            VendaMediaMensal = int.Parse(Console.ReadLine());

            if (VendaMediaMensal< 500)
            {
                novoPreco = precoAtual * 1.10;

                Console.WriteLine("O novo valor é:" + novoPreco);
            }
            else
            {
                novoPreco = precoAtual * 0.80;

                Console.WriteLine("O novo valor é:" + novoPreco);
            }
        }
    }
}