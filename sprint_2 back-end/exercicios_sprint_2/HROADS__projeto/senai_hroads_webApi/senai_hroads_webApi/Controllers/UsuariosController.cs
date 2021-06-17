﻿using Microsoft.AspNetCore.Authorization;
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
    public class UsuariosController : ControllerBase
    {
        private UsuarioRepository _usuarioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _habilidadeRepository para que haja a referência aos métodos do repositório
        /// </summary>
        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_usuarioRepository.Listar());
        }

        
        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {

            _usuarioRepository.Cadastrar(novoUsuario);


            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método
            _usuarioRepository.Deletar(id);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuario usuarioAtualizado)
        {
            // Faz a chamada para o método
            _usuarioRepository.Atualizar(id, usuarioAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a resposta da requisição fazendo a chamada o método
            return Ok(_usuarioRepository.BuscarPorId(id));
        }




    }
}
