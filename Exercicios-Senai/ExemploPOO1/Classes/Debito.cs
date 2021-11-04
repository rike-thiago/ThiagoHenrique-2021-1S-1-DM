using System;

namespace ExemploPOO1.Classes
{
    public class Debito : Cartao
    {
         private float Saldo = 600f;

         public void Pagar(){
             float valor = this.Valor;

             if (valor > Saldo){
                 Console.WriteLine("O valor da compra excede o saldo do seu cartão!");
             }else{
                 Console.WriteLine($"O valor de {valor:C2} foi pago com sucesso!");
             }
         }
    }
}