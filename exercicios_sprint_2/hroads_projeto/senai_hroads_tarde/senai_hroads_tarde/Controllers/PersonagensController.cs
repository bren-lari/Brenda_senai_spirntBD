using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_hroads_tarde.Domains;
using senai_hroads_tarde.Interfaces;
using senai_hroads_tarde.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_tarde.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class PersonagensController : ControllerBase
    {
        private IPersonagemRepository _personagemRepository { get; set; }

    /// <summary>
    /// Instancia o objeto _estudioRepository para que haja a referência aos métodos do repositório
    /// </summary>
    public PersonagensController()
    {
        _personagemRepository = new PersonagemRepository();
    }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personagemRepository.Listar());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método
            _personagemRepository.Deletar(id);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpPost]
        public IActionResult Post(Personagem cadastrarPersonagem)
        {
            // Faz a chamada para o método
            _personagemRepository.Cadastrar(cadastrarPersonagem);

            // Retorna um status code
            return StatusCode(201);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a resposta da requisição fazendo a chamada o método
            return Ok(_personagemRepository.BuscarPorId(id));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Personagem personagemAtualizado)
        {
            // Faz a chamada para o método
            _personagemRepository.Atualizar(id, personagemAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }
    }
}
