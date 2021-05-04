using senai_hroads_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();

        TipoUsuario BuscarPorId(int id);


        void Cadastrar(TipoUsuario cadastrarTipoUsario);


        void Atualizar(int id, TipoUsuario tipoUsuarioAtualizado);


        void Deletar(int id);
    }
}
