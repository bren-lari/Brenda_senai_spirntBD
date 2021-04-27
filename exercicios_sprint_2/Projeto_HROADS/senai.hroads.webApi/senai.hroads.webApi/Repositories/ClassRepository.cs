using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Repositories
{
    public class ClassRepository : IClassRepository
    {

        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, Class classeAtualizada)
        {
            throw new NotImplementedException();
        }

        public Class BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Class cadastrarClasse)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Class> Listar()
        {
            return ctx.Class.
        }
    }
}
