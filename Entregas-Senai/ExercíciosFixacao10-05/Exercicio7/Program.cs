using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = null;
            int quantidade = 15;
            numeros = new double[quantidade];

            for (var i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i + 1}° número:");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("");
            Console.WriteLine("Números digitados em ordem contrária:");

            foreach (var item in numeros)
            {
                Console.Write(numeros[quantidade - 1] + " ");
                quantidade = quantidade - 1;
            }
        }
    }
}