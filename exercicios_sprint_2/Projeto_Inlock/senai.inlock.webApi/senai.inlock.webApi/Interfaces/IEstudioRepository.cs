using senai.inlock.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Interfaces
{
    interface IEstudioRepository
    {
        List<EstudioDomain> Listar();

        EstudioDomain BuscarPorId(int id);

        void Atualizar(int id, EstudioDomain atualizarEstudio);

        void Cadastrar(EstudioDomain cadastrarEstudio);

        void Deletar(int id);



    }
}
