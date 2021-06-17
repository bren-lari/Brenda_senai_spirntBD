using senai_hroads_webApi.Domains;
using System.Collections.Generic;

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
