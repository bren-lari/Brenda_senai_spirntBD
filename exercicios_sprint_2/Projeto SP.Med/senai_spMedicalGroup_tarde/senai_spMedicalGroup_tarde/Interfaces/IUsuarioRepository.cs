using senai_spMedicalGroup_tarde.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_tarde.Interfaces
{

    /// <summary>
    /// Interface responsável pelo repositório do Usuario
    /// </summary>
    interface IUsuarioRepository
    {
        List<Usuario> ListarUsuario();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario cadastraruUsuario);

        void Atualizar(int id, Usuario atualizarUsuario);

        Usuario Logar(string email, string senha);

        void Deletar(int id);

    }
}
