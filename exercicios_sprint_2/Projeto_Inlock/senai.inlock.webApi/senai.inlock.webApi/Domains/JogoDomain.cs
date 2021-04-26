using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Domains
{
    public class JogoDomain
    {
        public int idJogos{ get; set; }

        [Required(ErrorMessage = "Insira o nome do jogo.")]
        public string nomeJogo { get; set; }
        public string descricaoJogo { get; set; }

        public DateTime dataDeLancamento { get; set; }

        [Required(ErrorMessage = "Insira o valor do jogo.")]
        public Decimal valor { get; set; }
    }
}
