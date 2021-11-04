using System;

namespace Thiago_Henrique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome ?");
            string nomePessoa = Console.ReadLine();
            Console.WriteLine("Nossa " + nomePessoa + ", que belo nome :D");

            Console.Write("Digite a sua Primeira Nota: ");
            double primeiroNumero = int.Parse(Console.ReadLine());
            
            Console.Write("Agora Digite a Segunda Nota: ");
            double segundoNumero = int.Parse(Console.ReadLine());

            Console.Write("Por fim Digite a Terceira Nota: ");
            double terceiroNumero = int.Parse(Console.ReadLine());

            double soma = primeiroNumero + segundoNumero + terceiroNumero;

            double média = (soma) / 3;

            Console.WriteLine("\nA sua média é: " + média.ToString("N1"));

            if (média > 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Parabéns " + nomePessoa + ", você foi Aprovado :D");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Fim do Programa");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sinto Muito " + nomePessoa + ", mas você foi Reprovado :(");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
