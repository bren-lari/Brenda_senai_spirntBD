using Microsoft.AspNetCore.Mvc;
using senai_peoples_WebAPI.Domains;
using senai_peoples_WebAPI.Interfaces;
using senai_peoples_WebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_peoples_WebAPI.Controllers
{
    // define que a nossa aplicação vai ser lida em JSON
    [Produces("application/json")]

    // a rota da nossa requisição
    // http://localhost:5000/api/funcionarios
    [Route("api/[controller]")]


    // o nosso controller será um controllador de API
    [ApiController]



    public class FuncionarioController : ControllerBase
    {
        // objeto que irá receber os métodos definidos na nossa Interface
        private IFuncionarioRepository _funcionarioRepository {get; set;}


        public FuncionarioController()
        {
            _funcionarioRepository = new FuncionarioRepository();
        }

        // endpoint get
        [HttpGet]
        public IActionResult Get()
        {
            List<FuncionarioDomain> funcionarios = _funcionarioRepository.ListarTodos();

            return Ok(funcionarios);
        }

        [HttpPost]
        public IActionResult Post(FuncionarioDomain novoFuncionario)
        {
            _funcionarioRepository.Cadastrar(novoFuncionario);

            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _funcionarioRepository.Deletar(id);

            return StatusCode(2004);
        }

    }
}
