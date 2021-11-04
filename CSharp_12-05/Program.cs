using System;

namespace _12_05
{
    class Program
    {
        static void Main(string[] args)
        {

            bool senhaCorreta = false;

            do
            {
                Console.Write("Por favor digite a senha predefinida: ");
                int senha = int.Parse(Console.ReadLine());

                if (senha == 123456)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Senha Correta");
                    Console.ForegroundColor = ConsoleColor.White;
                    senhaCorreta = true;
                }
            } while (senhaCorreta == false);

            Console.WriteLine("Escolha uma das opções a seguir\n1 - Cadastrar Passagem\n2 - Listar Passagem\n0 - Sair");
            string menu = Console.ReadLine();


            switch (menu)
            {


                case "Cadastrar Passagem (máx. 5)":
                case "1":

                    bool respostaNovaPassagem = true;
                    int contador = 5;

                    do
                    {
                        Console.Write("Digite o nome do passageiro: ");
                        string nomePassageiro = Console.ReadLine();
                        Console.Write("Informe a origem do voo: ");
                        string origemVoo = Console.ReadLine();
                        Console.Write("Informe o destino do voo: ");
                        string destinoVoo = Console.ReadLine();
                        Console.Write("Informe a data desejada para o voo (DD-MM-AA): ");
                        string dataVoo = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Passagem Cadastrada");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Gostaria de cadastrar uma nova passagem? (S/N)");
                        string resposta = Console.ReadLine().ToUpper();

                        if (resposta == "S")
                        {
                            respostaNovaPassagem = true;
                        }
                        else
                        {
                            respostaNovaPassagem = false;
                            Console.WriteLine("FIM DO PROGRAMA");
                        }

                    } while (respostaNovaPassagem == true && contador == 5);

                    break;






                case "Listar Passagem":
                case "2":
                    Console.WriteLine("Lista");
                    break;


                case "Sair":
                case "0":
                    Console.WriteLine("FIM DO PROGRAMA");
                    break;


            }

        }
    }
}

