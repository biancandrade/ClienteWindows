
using System.Collections.Generic;

namespace Dominio.Repositorios
{
    public interface IContatoRepositorio

    {
        void Salvar(Contato contato);

        void Excluir(Contato contato);

        void Atualizar(Contato contato);

        void AtualizarProcedure(Contato contato);
  
        Contato ObterPor(int codigo);

        IEnumerable<Contato> ObterTodos();
    }
}
