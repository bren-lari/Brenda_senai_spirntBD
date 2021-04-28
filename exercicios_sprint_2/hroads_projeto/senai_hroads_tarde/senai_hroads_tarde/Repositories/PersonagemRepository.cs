using senai_hroads_tarde.Contexts;
using senai_hroads_tarde.Domains;
using senai_hroads_tarde.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_tarde.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
    HroadsContext cxt = new HroadsContext();
        public void Atualizar(int id, Personagem personagemAtualizado)
        {
            Personagem personagemBuscado = cxt.Personagems.Find(id);

            // Verifica se o nome do estúdio foi informado
            if (personagemBuscado.Nome != null)
            {
                // Atribui os novos valores aos campos existentes
                personagemBuscado.Nome = personagemAtualizado.Nome;
            }

            // Atualiza o estúdio que foi buscado
            cxt.Personagems.Update(personagemBuscado);

            // Salva as informações para serem gravadas no banco de dados
            cxt.SaveChanges();
        }

        public Personagem BuscarPorId(int id)
        {
            return cxt.Personagems.FirstOrDefault(p => p.IdPersonagem == id);
        }

        public void Cadastrar(Personagem cadastrarPersonagem)
        {
            cxt.Personagems.Add(cadastrarPersonagem);

            // Salva as informações para serem gravadas no banco de dados
            cxt.SaveChanges();
        }

        public void Deletar(int id)
        {

            Personagem deletarPersonagem = cxt.Personagems.Find(id);

            // Remove a classe que foi buscado
            cxt.Personagems.Remove(deletarPersonagem);

            // Salva as alterações
            cxt.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            return cxt.Personagems.ToList();
        }
    }
}
