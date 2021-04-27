using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi_.Domains
{
    public partial class Habilidade
    {
        public int IdHabilidade { get; set; }
        public int? IdTiposHabilidades { get; set; }
        public string NomeHabilidade { get; set; }

        public virtual TiposHabilidade IdTiposHabilidadesNavigation { get; set; }
    }
}
