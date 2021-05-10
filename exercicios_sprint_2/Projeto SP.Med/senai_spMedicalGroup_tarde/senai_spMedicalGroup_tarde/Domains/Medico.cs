using System;
using System.Collections.Generic;

#nullable disable

namespace senai_spMedicalGroup_tarde.Domains
{
    public partial class Medico
    {
        public int IdMedico { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string EspecialidadeDeterminada { get; set; }
    }
}
