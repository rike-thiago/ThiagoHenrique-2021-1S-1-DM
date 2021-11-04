using System;

namespace ExemploSobrescrita.Classes
{
    public abstract class Player
    {
        private float Velocidade;
        private float ForcaPulo;

        public virtual string Correr(){
            return "O Player conseguiu Correr!";
        }

        public virtual string Pular(){
            return "O Player conseguiu Pular!";
        }
    }
}