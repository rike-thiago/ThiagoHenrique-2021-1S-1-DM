using System;

namespace ExemploPOO1.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string Cvv;

        public string SalvarCartao(){
            Console.WriteLine("Digite a Bandeira do seu cartão");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite o Número do seu cartão");
            Numero = Console.ReadLine();
            
            Console.WriteLine("Digite o Titular do seu cartão");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o CVV do seu cartão");
            Cvv = Console.ReadLine();

            return $"Cartão de Número {Numero} salvo com sucesso!";
        }
    }
}