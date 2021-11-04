using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, multiplicador, tabuada;
            numero = 0;
            multiplicador = 1;
            Console.WriteLine("Bem vindo a Tabuada :D");

            while (numero < 10)
            {
                numero++;
                Console.WriteLine($"\nTabuada do {numero}");
                multiplicador = 1;
                while (multiplicador <= 10)
                {
                    tabuada = numero * multiplicador;
                    Console.WriteLine($"{numero} x {multiplicador} = {tabuada}");
                    multiplicador++;
                }
            }
        }
    }
}