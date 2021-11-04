using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, salario;
            string nome, estadoCivil, empregado;
            bool nomeValidado, idadeValidada, estadoCivilValidado, empregadoValidado, salarioValidado;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            nomeValidado = false;
            while (nomeValidado == false)
            {
                if (nome != " " && nome != "")
                {
                    nomeValidado = true;
                }
                else
                {
                    Console.Write("Nome inválido digite novamente: ");
                    nome = Console.ReadLine();
                }
            }

            Console.Write("Digite sua idade: ");
            idade = double.Parse(Console.ReadLine());
            idadeValidada = false;
            while (idadeValidada == false)
            {
                if (idade >= 0 && idade <= 150)
                {
                    idadeValidada = true;
                }
                else
                {
                    Console.Write("Idade inválida digite uma idade válida: ");
                    idade = double.Parse(Console.ReadLine());
                }
            }

            Console.Write("Digite seu estado civil solteiro(s), casado(c), viuvo(v), divorciado(d): ");
            estadoCivil = Console.ReadLine();
            estadoCivilValidado = false;
            while (estadoCivilValidado == false)
            {
                if (estadoCivil == "s" || estadoCivil == "S")
                {
                    estadoCivilValidado = true;
                }
                else if (estadoCivil == "c" || estadoCivil == "C")
                {
                    estadoCivilValidado = true;
                }
                else if (estadoCivil == "v" || estadoCivil == "V")
                {
                    estadoCivilValidado = true;
                }
                else if (estadoCivil == "d" || estadoCivil == "D")
                {
                    estadoCivilValidado = true;
                }
                else
                {
                    Console.Write("Estado civil inválido digite novamente: ");
                    estadoCivil = Console.ReadLine();
                }
            }
            Console.Write("Digite se você está empregado atualmente s/n: ");
            empregado = Console.ReadLine();
            empregadoValidado = false;
            while (empregadoValidado == false)
            {
                if (empregado == "s" || empregado == "S")
                {
                    empregadoValidado = true;
                    Console.Write("Digite seu salário atual: ");
                    salario = double.Parse(Console.ReadLine());
                    salarioValidado = false;
                    while (salarioValidado == false)
                    {
                        if (salario > 0)
                        {
                            salarioValidado = true;
                        }
                        else
                        {
                            Console.Write("Salário inválido digite seu salário atual: ");
                            salario = double.Parse(Console.ReadLine());
                        }
                    }
                }
                else
                {
                    empregadoValidado = true;
                }
            }
            
            Console.WriteLine("Dados cadastrados com sucesso.");
        }
    }
}
