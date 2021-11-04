using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           double quantidade;
            string combustivel;

            Console.WriteLine($@"
Qual combustível você deseja:
Gasolina(g), Álcool(a)
");
            combustivel = Console.ReadLine().ToLower();

            Console.Write("Quantos litros você quer desse combustivel: ");
            quantidade = double.Parse(Console.ReadLine());

            switch (CombustivelValidado(combustivel))
            {
                case "a":
                precoAlcool(quantidade);
                    break;
                case "g":
                precoGasolina(quantidade);
                    break;
            }
        }
        static string CombustivelValidado(string combustivel){
            bool combustivelVerificado;
            combustivelVerificado = false;

            while(combustivelVerificado == false){
                if(combustivel == "a"){
                    combustivelVerificado = true;
                }
                else if(combustivel == "g"){
                    combustivelVerificado = true;
                }
                else{
                    Console.Write($@"
Combustível inválido!!

Qual combustível você deseja: 
Gasolina(g), Álcool(a)");
                    combustivel = Console.ReadLine().ToLower();
                }
            }
                return(combustivel);
        }
        static void precoAlcool(double quantidade){
            double precoAlcool, valor, descontoInicial, desconto, valorDescontado;

            if(quantidade <= 20){
            precoAlcool = 4.90; 
            descontoInicial = precoAlcool * 0.03;
            valorDescontado = precoAlcool - descontoInicial;

            desconto = descontoInicial * quantidade;
            valor = valorDescontado * quantidade;

            Console.WriteLine($"O desconto que você receberá é de {desconto.ToString("N2")}");
            Console.WriteLine($"O valor a pagar é de {valor.ToString("N2")}");
            } else {
            precoAlcool = 4.90; 
            descontoInicial = precoAlcool * 0.05;
            valorDescontado = precoAlcool - descontoInicial;

            desconto = descontoInicial * quantidade;
            valor = valorDescontado * quantidade;

            Console.WriteLine($"O desconto que você receberá é de {desconto.ToString("N2")}");
            Console.WriteLine($"O valor a pagar é de {valor.ToString("N2")}");
            }
        }
        static void precoGasolina(double quantidade){
            double precoGasolina, valor, descontoInicial, desconto, valorDescontado;

            if(quantidade <= 20){
            precoGasolina = 4.90; 
            descontoInicial = precoGasolina * 0.04;
            valorDescontado = precoGasolina - descontoInicial;

            desconto = descontoInicial * quantidade;
            valor = valorDescontado * quantidade;

            Console.WriteLine($"O desconto que você receberá é de {desconto.ToString("N2")}");
            Console.WriteLine($"O valor a pagar é de {valor.ToString("N2")}");
            } else {
            precoGasolina = 4.90; 
            descontoInicial = precoGasolina * 0.06;
            valorDescontado = precoGasolina - descontoInicial;

            desconto = descontoInicial * quantidade;
            valor = valorDescontado * quantidade;

            Console.WriteLine($"O desconto que você receberá é de {desconto.ToString("N2")}");
            Console.WriteLine($"O valor a pagar é de {valor.ToString("N2")}");
            }
        }
    }
}
