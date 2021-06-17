using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Domains
{
    public class EstudioDomain
    {
        public int idEstudio { get; set; }

        [Required(ErrorMessage = "Insira o nome do Estúdio.")]
        public string nomeEstudio { get; set;  }
    }
}
