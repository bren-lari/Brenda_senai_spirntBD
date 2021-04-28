using senai_hroads_tarde.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_tarde.Interfaces
{
    interface IHabilidadeRepository
    {
        List<Habilidade> Listar();

        Habilidade BuscarPorId(int id);


        void Cadastrar(Habilidade cadastrarHabilidade);


        void Atualizar(int id, Habilidade habilidadeAtualizado);


        void Deletar(int id);

        List<Habilidade> ListarTodos();
    }
}
