using Microsoft.EntityFrameworkCore;
using senai_spMedicalGroup_tarde.Context;
using senai_spMedicalGroup_tarde.Domains;
using senai_spMedicalGroup_tarde.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_tarde.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        /// 

        MedicalGroupContext c = new MedicalGroupContext();

        public void Atualizar(int id, Usuario atualizarUsuario)
        {
            Usuario usuarioBuscado = c.Usuarios.Find(id);

            if (atualizarUsuario.Email != null)
            {
                usuarioBuscado.Email = atualizarUsuario.Email;
            }

            c.Usuarios.Update(usuarioBuscado);

            c.SaveChanges();
        }
        
       
        public Usuario BuscarPorId(int id)
        {
            return c.Usuarios.Include(h => h.IdTipoUsuarioNavigation).FirstOrDefault(e => e.IdUsuario == id);
        }

        public void Cadastrar(Usuario cadastraruUsuario)
        {
            c.Usuarios.Add(cadastraruUsuario);
            c.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuarioBuscado = c.Usuarios.Find(id);

            c.Usuarios.Remove(usuarioBuscado);

            c.SaveChanges();
        }

        public List<Usuario> ListarUsuario()
        {
            return c.Usuarios.ToList();
        }

        public Usuario Logar(string email, string senha)
        {
            return c.Usuarios.Include(h => h.IdTipoUsuarioNavigation).FirstOrDefault(e => e.Email == email && e.Senha == senha);
        }
    }
}
