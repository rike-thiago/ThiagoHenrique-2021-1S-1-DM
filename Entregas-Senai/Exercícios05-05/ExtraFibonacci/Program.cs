using System;

namespace ExtraFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAnterior, proximoNumero, resultado;

            numeroAnterior = -1;
            proximoNumero = 1;
            resultado = 0;

            for (int i = 0; i < 15; i++)
            {
                resultado = numeroAnterior + proximoNumero;
                numeroAnterior = proximoNumero;
                proximoNumero = resultado;
                Console.Write(resultado + " ");
            }
        }
    }
}