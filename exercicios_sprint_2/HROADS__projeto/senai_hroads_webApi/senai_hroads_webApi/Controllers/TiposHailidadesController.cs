using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_hroads_tarde.Interfaces;
using senai_hroads_tarde.Repositories;
using senai_hroads_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_tarde.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class TiposHabilidadesController : ControllerBase
    {
        private TipoHabilidadeRepository  _tipoHabilidadeRepository { get; set; }

       
        public TiposHabilidadesController()
        {
            _tipoHabilidadeRepository = new TipoHabilidadeRepository();
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tipoHabilidadeRepository.Listar());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método
            _tipoHabilidadeRepository.Deletar(id);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpPost]
        public IActionResult Post(TipoHabilidade cadastrarTipoHabilidade)
        {
            // Faz a chamada para o método
            _tipoHabilidadeRepository.Cadastrar(cadastrarTipoHabilidade);

            // Retorna um status code
            return StatusCode(201);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a resposta da requisição fazendo a chamada o método
            return Ok(_tipoHabilidadeRepository.BuscarPorId(id));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TipoHabilidade tipoHabilidadeAtualizado)
        {
            // Faz a chamada para o método
            _tipoHabilidadeRepository.Atualizar(id, tipoHabilidadeAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpGet("{Habilidade}")]
        public IActionResult GetHabilidades()
        {
            // Retorna a resposta da requisição fazendo a chamada para o método
            return Ok(_tipoHabilidadeRepository.ListarHabilidades());
        }





    }
}
