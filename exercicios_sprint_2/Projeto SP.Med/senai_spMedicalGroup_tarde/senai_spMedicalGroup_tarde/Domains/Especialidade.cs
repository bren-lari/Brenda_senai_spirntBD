using System;
using System.Collections.Generic;

#nullable disable

namespace senai_spMedicalGroup_tarde.Domains
{
    public partial class Especialidade
    {
        public int IdEspecialidade { get; set; }
        public int? IdUsuario { get; set; }
        public string NomeEspecialidade { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
