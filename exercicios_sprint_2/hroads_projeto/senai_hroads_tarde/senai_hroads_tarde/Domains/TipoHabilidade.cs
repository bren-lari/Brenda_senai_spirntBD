using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_tarde.Domains
{
    public partial class TipoHabilidade
    {
        public TipoHabilidade()
        {
            Habilidades = new HashSet<Habilidade>();
        }

        public int IdTipoHabilidade { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Habilidade> Habilidades { get; set; }
    }
}
