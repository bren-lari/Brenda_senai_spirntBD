using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_filmes_webAPI.Domains;
using senai_filmes_webAPI.Interfaces;
using senai_filmes_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/// <summary>
/// controller responsável pelos endpoints/pontos onde uma requisição é feita referentes aos gêneros
/// </summary>
namespace senai_filmes_webAPI.Controllers
{
    // esta sendo definido que a resposta de toda nossa requisição será em JSON
    [Produces("application/json")]


    // define que a rota de uma requisição que será no formato dominio/api/nomeController
    // ex: http://localhost:5000/api/generos
    [Route("api/[controller]")]

    // defini que o controller é um controlador de API
    [ApiController]


    public class GenerosController : ControllerBase
    {
        // criamos esse objeto que irá receber todos os métodos definidos na interface IGeneroRepository
        private IGeneroRepository _generoRepository { get; set; }


        // está instanciando o objeto _generoRepository para que haja a referência aos métodos do repositório
        // ou seja, como os métodos vão funcionar
        public GenerosController()
        {
            _generoRepository = new GeneroRepository();
        }


        /// <summary>
        /// lista todos os generos
        /// </summary>
        /// <returns>lista de generos e o status code</returns>
        [HttpGet]
        public IActionResult Get()
        {
            // cria uma lista para receber os dados
            List<GeneroDomain> listaGeneros = _generoRepository.ListarTodos();

            // retorna o status code 200/ok e a lista de generos no formato de texto em JSON
            return Ok(listaGeneros);
        }

        /// <summary>
        /// endpoint que cadastra um novo genêro
        /// </summary>
        /// <returns>um status code 201 - created(criar)</returns>
        [HttpPost]

        // nosso método para cadastrar
        public IActionResult Post(GeneroDomain cadastrarGenero)
        {
            // faz a chamada para o método cadastrar
            _generoRepository.Cadastrar(cadastrarGenero);


            // vai retornar o status code 201 (created)
             return StatusCode(201);
        }

        /// <summary>
        /// endpoint que deleta e definindo a nossa rota dentro desse endopoint para poder deletar pela url atráves de um id
        /// </summary>
        [HttpDelete("{id}")]


        // método para deletar passando o parâmetro id 
        public IActionResult Delete(int id)
        {
            // faz a chamada para o método deletar definido lá no repository
            _generoRepository.Deletar(id);


            // retorna o statuscode (2004) - No COntent
            return StatusCode(2004);
        }

    }

}

