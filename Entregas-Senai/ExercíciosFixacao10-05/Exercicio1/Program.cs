using System;

namespace Exercicio1
{
    class Program
    {

        static void Main(string[] args){
        int anoNascimento;

        Console.Write("Digite seu ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

        VerificarIdade(Idade(anoNascimento));

    }

    static void VerificarIdade(int idade)
    {
        if (idade >= 18)
        {
            Console.WriteLine("Você é obrigado a votar");
        }
        else if (idade == 16 || idade == 17)
        {
            Console.WriteLine("Você tem a opção de votar");
        }
        else
        {
            Console.WriteLine("Você não tem idade para votar");
        }
    }

    static int Idade(int anoNascimento)
    {
        int idade, anoAtual;
        anoAtual = DateTime.Now.Year;
        idade = anoAtual - anoNascimento;
        return (idade);
    }
}
}
