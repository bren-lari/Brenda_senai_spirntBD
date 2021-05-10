using System;
using System.Collections.Generic;

#nullable disable

namespace senai_spMedicalGroup_tarde.Domains
{
    public partial class Administrador
    {
        public int IdAdministrador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
