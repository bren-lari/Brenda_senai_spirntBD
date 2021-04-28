﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_tarde.Domains
{
    public partial class Habilidade
    {
        public int IdHabilidade { get; set; }
        public int? IdTipoHabilidade { get; set; }
        public string Nome { get; set; }

        public virtual TipoHabilidade IdTipoHabilidadeNavigation { get; set; }
    }
}
