using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spMedicalGroup.webApi.ViewModels
{

    /// <summary>
    /// modelo utilizado para criarmos um login
    /// </summary>
    public class LoginViewModel
    {

        /// <summary>
        /// modelo de login
        /// </summary>
        /// 

        [Required(ErrorMessage = "Informe o e-mail do usuário!")]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário!")]
        public string senha { get; set; }
    }
}
