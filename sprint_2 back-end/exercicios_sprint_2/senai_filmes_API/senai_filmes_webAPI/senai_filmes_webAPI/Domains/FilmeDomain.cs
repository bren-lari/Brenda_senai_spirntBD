using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Domains
{
    /// <summary>
    ///  classe que representa a entidade e tablea filmes
    /// </summary>
    public class FilmeDomain
    {
        public int idFIlme { get; set; }

        public string titulo { get; set; }

        public int idGenero { get; set; }
    }

}
