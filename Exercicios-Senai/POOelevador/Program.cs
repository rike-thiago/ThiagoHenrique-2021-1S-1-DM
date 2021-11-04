using System;
using POOelevador.Classes;

namespace POOelevador
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            bool repeticao = true;

            ElevadorSocial o = new ElevadorSocial();
            ElevadorServico e = new ElevadorServico();
            Console.WriteLine(o.Inicializar());

            Console.WriteLine($@"
Qual elevador deseja utilizar?
1 - Social
2 - Serviço");
            escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {

                do
                {
                    Console.WriteLine($@"
Elevador Social
1 - Adicionar uma Pessoa
2 - Retirar uma Pessoa
3 - Subir um Andar
4 - Descer um Andar
0 - Sair");
                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine(o.AdicionarPess());
                            break;
                        case 2:
                            Console.WriteLine(o.RetirarPess());
                            break;
                        case 3:
                            Console.WriteLine(o.Subir());
                            break;
                        case 4:
                            Console.WriteLine(o.Descer());
                            break;
                        case 0:
                            Console.WriteLine("Obrigado por usar os Serviços da Thiaguin S.A.");
                            repeticao = false;
                            break;
                    }


                } while (repeticao == true);

            }
            else if(escolha == 2)
            {
                do
                {
                    Console.WriteLine($@"
Elevador Serviço
1 - Adicionar uma pessoa
2 - Retirar uma pessoa
3 - Subir um andar
4 - Descer um andar
5 - Adicionar uma caixa
6 - Retirar uma caixa
0 - Sair");
                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine(e.AdicionarPess());
                            break;
                        case 2:
                            Console.WriteLine(e.RetirarPess());
                            break;
                        case 3:
                            Console.WriteLine(e.Subir());
                            break;
                        case 4:
                            Console.WriteLine(e.Descer());
                            break;
                        case 5:
                            Console.WriteLine(e.AdicionarCaixa());
                            break;
                        case 6:
                            Console.WriteLine(e.RetirarCaixa());
                            break;
                        case 0:
                            Console.WriteLine("Obrigado por usar os Serviços da Thiaguin S.A.");
                            repeticao = false;
                            break;
                    }


                } while (repeticao == true);

            }

        }
    }
}
