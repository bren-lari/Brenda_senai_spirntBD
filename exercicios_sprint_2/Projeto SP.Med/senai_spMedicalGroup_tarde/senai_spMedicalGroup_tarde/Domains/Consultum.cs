using System;
using System.Collections.Generic;

#nullable disable

namespace senai_spMedicalGroup_tarde.Domains
{
    public partial class Consultum
    {
        public Consultum()
        {
            Pacientes = new HashSet<Paciente>();
        }

        public int IdConsulta { get; set; }
        public int? IdUsuario { get; set; }
        public string DataConsulta { get; set; }
        public string Situação { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
