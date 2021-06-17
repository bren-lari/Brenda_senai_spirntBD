using Microsoft.EntityFrameworkCore;
using senai_hroads_tarde.Interfaces;
using senai_hroads_webApi.Contexts;
using senai_hroads_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_tarde.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        HroadsContext cxt = new HroadsContext();
        public void Atualizar(int id, Habilidade habilidadeAtualizado)
        {
            Habilidade habilidadeBuscado = cxt.Habilidades.Find(id);

            // Verifica se o nome do estúdio foi informado
            if (habilidadeBuscado.Nome != null)
            {
                // Atribui os novos valores aos campos existentes
                habilidadeBuscado.Nome = habilidadeAtualizado.Nome;
            }

            // Atualiza o estúdio que foi buscado
            cxt.Habilidades.Update(habilidadeBuscado);

            // Salva as informações para serem gravadas no banco de dados
            cxt.SaveChanges();
        }

        public Habilidade BuscarPorId(int id)
        {
            return cxt.Habilidades.FirstOrDefault(c => c.IdHabilidade == id);
        }

        public void Cadastrar(Habilidade cadastrarHabilidade)
        {
            cxt.Habilidades.Add(cadastrarHabilidade);

            // Salva as informações para serem gravadas no banco de dados
            cxt.SaveChanges();
        }

        public void Deletar(int id)
        {
            Habilidade deletarHabilidade = cxt.Habilidades.Find(id);

            // Remove a classe que foi buscado
            cxt.Habilidades.Remove(deletarHabilidade);

            // Salva as alterações
            cxt.SaveChanges();
        }

        public List<Habilidade> Listar()
        {
            return cxt.Habilidades.ToList();
        }

        public List<Habilidade> ListarTodos()
        {
            return cxt.Habilidades.Include(h => h.IdTipoHabilidadeNavigation).ToList();
        }
    }
}
