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
    public class ClassesController : ControllerBase
    {
        private IClasseRepository _classeRepository { get; set; }

        public ClassesController()
        {
            _classeRepository = new ClasseRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Retorna a resposta da requisição fazendo a chamada para o método
            return Ok(_classeRepository.Listar());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método
            _classeRepository.Deletar(id);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpPost]
        public IActionResult Post(Classe cadastrarClasse)
        {
            // Faz a chamada para o método
            _classeRepository.Cadastrar(cadastrarClasse);

            // Retorna um status code
            return StatusCode(201);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a resposta da requisição fazendo a chamada o método
            return Ok(_classeRepository.BuscarPorId(id));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Classe classeAtualizado)
        {
            // Faz a chamada para o método
            _classeRepository.Atualizar(id, classeAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }



    }
}
