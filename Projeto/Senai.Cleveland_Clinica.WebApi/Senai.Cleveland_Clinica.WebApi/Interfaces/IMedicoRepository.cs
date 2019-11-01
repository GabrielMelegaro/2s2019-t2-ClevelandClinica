using Senai.Cleveland_Clinica.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Cleveland_Clinica.WebApi.Interfaces
{
    public interface IMedicoRepository
    {
        List<Medicos> Listar();
    }
}
