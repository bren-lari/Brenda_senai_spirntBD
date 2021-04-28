using senai_hroads_tarde.Contexts;
using senai_hroads_tarde.Domains;
using senai_hroads_tarde.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_tarde.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
        HroadsContext cxt = new HroadsContext();
        public void Atualizar(int id, Classe classeAtualizado)
        {
            Classe classeBuscado = cxt.Classes.Find(id);

            // Verifica se o nome do estúdio foi informado
            if (classeAtualizado.Nome != null)
            {
                // Atribui os novos valores aos campos existentes
                classeBuscado.Nome = classeAtualizado.Nome;
            }

            // Atualiza o estúdio que foi buscado
            cxt.Classes.Update(classeBuscado);

            // Salva as informações para serem gravadas no banco de dados
            cxt.SaveChanges();
        }

        public Classe BuscarPorId(int id)
        {
            return cxt.Classes.FirstOrDefault(c => c.IdClasse == id);
        }

        public void Cadastrar(Classe cadastrarEstudio)
        {
            cxt.Classes.Add(cadastrarEstudio);

            // Salva as informações para serem gravadas no banco de dados
            cxt.SaveChanges();
        }

        public void Deletar(int id)
        {
            Classe deletarClasse = cxt.Classes.Find(id);

            // Remove a classe que foi buscado
            cxt.Classes.Remove(deletarClasse);

            // Salva as alterações
            cxt.SaveChanges();
        }

        public List<Classe> Listar()
        {
            return cxt.Classes.ToList();
        }
    }
}
