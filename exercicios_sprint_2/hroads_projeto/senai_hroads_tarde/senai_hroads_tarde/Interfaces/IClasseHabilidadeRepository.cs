using senai_hroads_tarde.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_tarde.Interfaces
{
    interface IClasseHabilidadeRepository
    {
        List<ClasseHabilidade> Listar();

        ClasseHabilidade BuscarPorId(int id);


        void Cadastrar(ClasseHabilidade cadastrarEstudio);


        void Atualizar(int id, ClasseHabilidade classeAtualizado);


        void Deletar(int id);

    }
}
