using senai.inlock.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Interfaces
{
    interface IUsuarioRepository
    {

        List<UsuarioDomain> Listar();

        UsuarioDomain BuscarPorId(int id);

        void Atualizar(int id, UsuarioDomain atualizarUsuario);

        void Cadastrar(UsuarioDomain cadastrarUsuario);

        void Deletar(int id);
    }
}
