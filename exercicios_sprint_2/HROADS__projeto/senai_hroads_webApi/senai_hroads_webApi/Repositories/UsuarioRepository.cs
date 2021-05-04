using Microsoft.EntityFrameworkCore;
using senai_hroads_webApi.Contexts;
using senai_hroads_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Repositories
{
    public class UsuarioRepository
    {
        HroadsContext cxt = new HroadsContext();

        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = cxt.Usuarios.Find(id);


            if (usuarioAtualizado.Email != null)
            {

                usuarioBuscado.Email = usuarioAtualizado.Email;
            }


            cxt.Usuarios.Update(usuarioBuscado);


            cxt.SaveChanges();
        }

        public Usuario Logar(string email, string senha)
        {
            return cxt.Usuarios.Include(h => h.IdTipoUsuarioNavigation).FirstOrDefault(e => e.Email == email && e.Senha == senha);


        }

        public Usuario BuscarPorId(int id)
        {
            return cxt.Usuarios.Include(h => h.IdTipoUsuarioNavigation).FirstOrDefault(e => e.IdUsuario == id);
        }

        public void Cadastrar(Usuario cadastrarUsario)
        {
            cxt.Usuarios.Add(cadastrarUsario);


            cxt.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuarioBuscado = cxt.Usuarios.Find(id);


            cxt.Usuarios.Remove(usuarioBuscado);


            cxt.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return cxt.Usuarios.Include(p => p.IdTipoUsuarioNavigation).ToList();
        }
    }
}
