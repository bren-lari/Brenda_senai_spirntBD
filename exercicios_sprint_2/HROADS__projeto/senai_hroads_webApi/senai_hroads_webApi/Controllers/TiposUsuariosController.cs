using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_hroads_webApi.Domains;
using senai_hroads_webApi.Interfaces;
using senai_hroads_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class TiposUsuariosController : ControllerBase
    {
        private ITipoUsuarioRepository _tipousuarioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _habilidadeRepository para que haja a referência aos métodos do repositório
        /// </summary>
        public TiposUsuariosController()
        {
            _tipousuarioRepository = new TipoUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_tipousuarioRepository.Listar());
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public IActionResult Post(TipoUsuario novoTipoUsuarios)
        {

            _tipousuarioRepository.Cadastrar(novoTipoUsuarios);


            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método
            _tipousuarioRepository.Deletar(id);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TipoUsuario tipoAtualizado)
        {
            // Faz a chamada para o método
            _tipousuarioRepository.Atualizar(id, tipoAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a resposta da requisição fazendo a chamada o método
            return Ok(_tipousuarioRepository.BuscarPorId(id));
        }


    }
}
