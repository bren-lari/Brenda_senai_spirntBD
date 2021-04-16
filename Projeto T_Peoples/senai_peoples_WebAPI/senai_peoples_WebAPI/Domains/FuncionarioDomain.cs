using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai_peoples_WebAPI.Domains
{
    public class FuncionarioDomain
    {
        public int idFuncionarios { get; set; }

        [Required(ErrorMessage = "Por favor, insira seu nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Por favor, insira seu sobrenome")]
        public string sobrenome { get; set; }
    }
}
