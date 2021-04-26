using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Domains
{
    public class UsuarioDomain
    {
        public int idUsuario { get; set; }

        [Required(ErrorMessage = "Por favor, insira o seu e-mail.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Por favor, insira uma senha.")]
        public string senha { get; set; }
    }
}
