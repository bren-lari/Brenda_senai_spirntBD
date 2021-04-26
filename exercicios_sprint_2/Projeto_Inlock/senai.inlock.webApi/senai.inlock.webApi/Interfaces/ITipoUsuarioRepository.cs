using senai.inlock.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<tipoUsuarioDomain> Listar();

        tipoUsuarioDomain BuscarPorId(int id);

        void Atualizar(int id, tipoUsuarioDomain atulizarTipoUsuario);

        void Cadastrar(tipoUsuarioDomain cadastrarTipoUsuario);

        void Deletar(int id);

    }
}
