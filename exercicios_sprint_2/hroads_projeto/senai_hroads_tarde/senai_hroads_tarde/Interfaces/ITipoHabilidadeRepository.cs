using senai_hroads_tarde.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_tarde.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        List<TipoHabilidade> Listar();

        TipoHabilidade BuscarPorId(int id);


        void Cadastrar(TipoHabilidade cadastrarEstudio);


        void Atualizar(int id, TipoHabilidade classeAtualizado);


        void Deletar(int id);
    }
}
