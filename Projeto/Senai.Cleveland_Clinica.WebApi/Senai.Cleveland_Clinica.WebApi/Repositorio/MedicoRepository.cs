using Senai.Cleveland_Clinica.WebApi.Domains;
using Senai.Cleveland_Clinica.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Cleveland_Clinica.WebApi.Repositorio
{
    public class MedicoRepository : IMedicoRepository
    {
        public List<Medicos> Listar()
        {
            using (ClevelandclinicaContext ctx = new ClevelandclinicaContext())
            {
                return ctx.Medicos.ToList();
            }
        }
    }
}
