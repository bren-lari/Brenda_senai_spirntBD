﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai_hroads_webApi.Domains;
using senai_hroads_webApi.Interfaces;
using senai_hroads_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private UsuarioRepository _usuarioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _habilidadeRepository para que haja a referência aos métodos do repositório
        /// </summary>
        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]

        public IActionResult Login(Usuario login)
        {
            Usuario usuarioBuscado = _usuarioRepository.Logar(login.Email, login.Senha);

            if (usuarioBuscado == null)
            {
                return NotFound("Email ou senha invalidos!");
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email) ,
                new Claim(type: JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuarioNavigation.Permissao)
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("hroads-chave-secreta-autenticacao"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                    issuer: "Hroads.webApi",
                    audience: "Hroads.webApi",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(10),
                    signingCredentials: creds
                );
            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)

            });
        }
    }
}
