using System;

namespace POOelevador.Classes
{
    public class ElevadorServico : Elevador
    {
        private int caixasAtual;
       private int capacidadeCaixas = 5;

        public string AdicionarCaixa(){
            if(caixasAtual < capacidadeCaixas){
                caixasAtual++;
                return $@"Uma caixa adicionada
Há {caixasAtual} caixas no elevador";
            }else{
                return $@"O elevador está cheio
Há {caixasAtual} caixas no elevador";
                
            }
        }
        public string RetirarCaixa(){
            if(caixasAtual != 0){
                caixasAtual--;
                return $@"Uma caixa retirada
Há {caixasAtual} caixas no elevador";
                
            }else{
                return $@"Não tem nenhuma caixa no elevador
Há {caixasAtual} caixas no elevador";
                
            }
        }
    }
}