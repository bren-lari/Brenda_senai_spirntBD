using System;
using System.Collections.Generic;

#nullable disable

namespace senai_spMedicalGroup_tarde.Domains
{
    public partial class Clinica
    {
        public int IdClinica { get; set; }
        public string Endereco { get; set; }
        public string HorarioDeFuncionamento { get; set; }
        public string Cnpj { get; set; }
    }
}
