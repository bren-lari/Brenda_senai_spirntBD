using senai_hroads_webApi.Contexts;
using senai_hroads_webApi.Domains;
using senai_hroads_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        HroadsContext cxt = new HroadsContext();

        public void Atualizar(int id, TipoUsuario tipoUsuarioAtualizado)
        {
            TipoUsuario tipoBuscado = cxt.TipoUsuarios.Find(id);


            if (tipoUsuarioAtualizado.Permissao != null)
            {

                tipoBuscado.Permissao = tipoUsuarioAtualizado.Permissao;
            }


            cxt.TipoUsuarios.Update(tipoBuscado);


            cxt.SaveChanges();
        }

        public TipoUsuario BuscarPorId(int id)
        {
            return cxt.TipoUsuarios.FirstOrDefault(tp => tp.IdTipoUsuario == id);
        }

        public void Cadastrar(TipoUsuario cadastrarTipoUsario)
        {
            cxt.TipoUsuarios.Add(cadastrarTipoUsario);


            cxt.SaveChanges();
        }

        public void Deletar(int id)
        {
            TipoUsuario tipoBuscado = cxt.TipoUsuarios.Find(id);


            cxt.TipoUsuarios.Remove(tipoBuscado);


            cxt.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return cxt.TipoUsuarios.ToList();
        }
    }
}
