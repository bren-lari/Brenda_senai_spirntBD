using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_spMedicalGroup_tarde.Interfaces;
using senai_spMedicalGroup_tarde.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup_tarde.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _habilidadeRepository para que haja a referência aos métodos do repositório
        /// </summary>
        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }


    }
}
