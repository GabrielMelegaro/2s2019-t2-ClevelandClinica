using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Cleveland_Clinica.WebApi.Interfaces;
using Senai.Cleveland_Clinica.WebApi.Repositorio;

namespace Senai.Cleveland_Clinica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicosController : ControllerBase
    {
        private IMedicoRepository MedicosRepository { get; set; }

        public MedicosController()
        {
            MedicosRepository  = new MedicoRepository();
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(MedicosRepository.Listar());
        }
    }
}