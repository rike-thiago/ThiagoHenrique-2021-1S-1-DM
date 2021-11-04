using System;

namespace Exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Comparador de valores iniciados ツ");
            int[] numeros = null;
            int quantidade = 10;
            numeros = new int[quantidade];

            for (var i = 0; i <= (10 - 1); i++)
            {
                Console.Write("Digite o numéro " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int um = 1;

            double numeroMaior = 0;
            double numeroMenor = 0;

            numeroMaior = numeros[0];
            numeroMenor = numeros[0];

            while (um < 9)
            {
                int primeiro;
                primeiro = numeros[um];

                if (numeroMaior < primeiro)
                {
                    numeroMaior = primeiro;
                }
                if (numeroMenor > primeiro)
                {
                    numeroMenor = primeiro;
                }

                um++;
            }

            Console.WriteLine($"O maior número digitado foi: {numeroMaior}");
            Console.WriteLine($"O menor número digitado foi: {numeroMenor}");

        }
    }
}
