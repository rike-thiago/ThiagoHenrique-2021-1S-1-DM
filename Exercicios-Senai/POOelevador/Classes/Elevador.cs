using System;

namespace POOelevador.Classes
{
    public abstract class Elevador
    {
        private int andarAtual;
        private int totalAndares = 5;
        private int pessoasPresentes;
        private int capacidade = 10;

        public string Inicializar(){
            andarAtual = 0;
            pessoasPresentes = 0;
            return "Elevador inicializado";
        }

        public string AdicionarPess(){
            if(pessoasPresentes < capacidade){
                pessoasPresentes++;
                return $@"Uma pessoa entrou no elevador
Há {pessoasPresentes} pessoas presentes neste elevador";
            }else{
                return $@"O elevador está cheio
Há {pessoasPresentes} pessoas presentes neste elevador";
                ;
            }
        }
        public string RetirarPess(){
            if(pessoasPresentes != 0){
                pessoasPresentes--;
                return $@"Uma pessoa saiu do elevador
Há {pessoasPresentes} pessoas presentes neste elevador";
                ;
            }else{
                return $@"O elevador está vazio
Há {pessoasPresentes} pessoas presentes neste elevador";
                ;
            }
        }
        public string Subir(){
            if(andarAtual < totalAndares){
                andarAtual++;
                return $@"O elevador subiu um andar
O elevador está no {andarAtual}° Andar";
            }else{
                return $@"O elevador já está no último andar do prédio
O elevador está no {andarAtual}° Andar";
            }
        }
        public string Descer(){
            if(andarAtual != 0){
                andarAtual--;
                return $@"O elevador desceu um andar
O elevador está no {andarAtual}° Andar";
            }else{
                return $@"O elevador já está no térreo
O elevador está no {andarAtual}° Andar";
            }
        }

    }
}