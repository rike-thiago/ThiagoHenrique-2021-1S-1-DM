using System;

namespace ExemploPOO1.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigoBarras;
        Random r = new Random();

        public void Registrar(){
            CodigoBarras = r.Next(3000000).ToString();
            Console.WriteLine($"Boleto gerado com desconto, resultando em R${this.Valor}");
            Console.WriteLine($"Boleto foi gerado com o código {CodigoBarras}");
        }
    }
}