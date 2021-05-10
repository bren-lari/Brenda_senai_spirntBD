using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_spMedicalGroup_tarde.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Consulta = new HashSet<Consultum>();
            Especialidades = new HashSet<Especialidade>();
            TipoUsuarios = new HashSet<TipoUsuario>();
        }

        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Insira um nome por favor!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Necessário informar o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Necessário informar a senha")]
        public string Senha { get; set; }

        public virtual ICollection<Consultum> Consulta { get; set; }
        public virtual ICollection<Especialidade> Especialidades { get; set; }
        public virtual ICollection<TipoUsuario> TipoUsuarios { get; set; }
        public object IdTipoUsuarioNavigation { get; internal set; }
    }
}
