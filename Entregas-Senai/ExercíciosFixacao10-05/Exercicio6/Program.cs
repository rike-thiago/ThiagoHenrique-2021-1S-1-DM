using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] nomes = null;
            int quantidade = 10;
            nomes = new string[quantidade];

            string comparar;

            for (var i = 0; i <= (10 - 1); i++)
            {
                Console.Write("Digite o " + (i + 1) + "° nome: ");
                nomes[i] = Console.ReadLine().ToLower();
            }

            Console.Write("Digite um nome para que eu procure: ");
            comparar = Console.ReadLine().ToLower();

            int c = 0;

            bool nomeAchado = false;

            foreach (var item in nomes)
            {
                if (nomes[c] == comparar)
                {
                    nomeAchado = true;
                }
                c++;
            }

            if (nomeAchado == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAchei! :D");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNão achei! >:(");
            }
        }
    }
}
