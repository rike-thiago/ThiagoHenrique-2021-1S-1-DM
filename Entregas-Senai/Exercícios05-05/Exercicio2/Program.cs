using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, bem vindo ao meu sistema! :D");
            
            Console.WriteLine($"Digite um nome de usuário:");
            string nome = Console.ReadLine();
            
            Console.WriteLine($"Digite uma senha (diferente do nome de usuário):");
            string senha = Console.ReadLine();
            
            while (nome == senha)
            {
                Console.WriteLine($"Sua senha não pode ser igual ao seu nome de usuário\nPor favor digite uma senha diferente do seu nome de usuário.");
                senha = Console.ReadLine(); 
            }

            Console.WriteLine($"Cadastro Concluído");

        }
    }
}
