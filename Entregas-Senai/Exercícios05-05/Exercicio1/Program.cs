using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notaValida;
            
            Console.WriteLine("Olá, por favor insira uma nota entre Zero e Dez");
            int resposta = int.Parse(Console.ReadLine());
            notaValida = false;

            while (notaValida == false)
            {
                if (resposta >= 0 && resposta <= 10)
                {
                    notaValida = true;
                    Console.WriteLine("Obrigado, nota válida");
                }else{
                    Console.WriteLine("Nota inválida, por favor tente novamente");
                    resposta = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
