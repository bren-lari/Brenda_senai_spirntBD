﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Domains
{
    /// <summary>
    /// classe que representa a entidade e tablea genêros
    /// </summary>
    public class GeneroDomain
    {
        public int idGenero { get; set; }

        public string nome { get; set; }
    }
}
