using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi_.Domains
{
    public partial class Personagen
    {
        public int IdPersonagem { get; set; }
        public int? IdClasse { get; set; }
        public string Nome { get; set; }
        public int? Pvmaximo { get; set; }
        public int? ManaMaxima { get; set; }
        public string DataAtt { get; set; }
        public string DataCr { get; set; }

        public virtual Class IdClasseNavigation { get; set; }
    }
}
