using System;
using System.Collections.Generic;

#nullable disable

namespace senai_spMedicalGroup_tarde.Domains
{
    public partial class Paciente
    {
        public int IdPaciente { get; set; }
        public int? IdConsulta { get; set; }
        public string Nome { get; set; }

        public virtual Consultum IdConsultaNavigation { get; set; }
    }
}
