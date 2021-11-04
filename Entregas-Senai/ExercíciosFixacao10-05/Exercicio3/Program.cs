using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int quantidade;
            double preco, desconto, total, pagar;

            Console.Write("Digite qual nome do produto que você está comprando: ");
            nome = Console.ReadLine();

            Console.Write($"Digite quantos {nome} você está comprando: ");
            quantidade = int.Parse(Console.ReadLine());

            Console.Write($"Qual o valor unitário do(a) {nome}: ");
            preco = double.Parse(Console.ReadLine());

            if(quantidade <= 5){
                total = preco * quantidade;
                desconto = total * 0.02;
                pagar = total - desconto;

                Console.WriteLine($"Você recebeu um desconto de 2% equivalente a {desconto:C2}");
                Console.WriteLine($"O total que você tem a pagar passa de {total:C2} para {pagar:C2}");
            }else if(quantidade > 5 && quantidade <= 10){
                total = preco * quantidade;
                desconto = total * 0.03;
                pagar = total - desconto;

                Console.WriteLine($"Você recebeu um desconto de 3% equivalente a {desconto:C2}");
                Console.WriteLine($"O total que você tem a pagar passa de {total:C2} para {pagar:C2}");
            }else{
                total = preco * quantidade;
                desconto = total * 0.05;
                pagar = total - desconto;

                Console.WriteLine($"Você recebeu um desconto de 5% equivalente a {desconto:C2}");
                Console.WriteLine($"O total que você tem a pagar passa de {total:C2} para {pagar:C2}");
            }
        }
    }
}
