using System.Collections.Generic;
using EPlayers.Models;

namespace EPlayers.Interfaces
{
    public interface IJogador
    {
         void Criar(Jogador j);

         List<Jogador> LerTodos();

         void Alterar(Jogador j);

         void Deletar(int id);
    }
}