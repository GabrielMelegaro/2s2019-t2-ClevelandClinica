using System;
using System.Collections.Generic;

namespace Senai.Cleveland_Clinica.WebApi.Domains
{
    public partial class Medicos
    {
        public int IdMedico { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Crm { get; set; }
    }
}
