
using senai_hroads_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_tarde.Interfaces
{
    interface IClasseRepository
    {
        List<Classe> Listar();

        Classe BuscarPorId(int id);

        
        void Cadastrar(Classe cadastrarEstudio);

        
        void Atualizar(int id, Classe classeAtualizado);

        
        void Deletar(int id);

       
    
    }

}
