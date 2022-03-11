using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiNom.Model;
using WebApiNom.Repos;

namespace WebApiNom.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NombresController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RNombres rpCli = new RNombres();
            return Ok(rpCli.ObtenerNombres());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RNombres rpCli = new RNombres();

            var cliRet = rpCli.ObtenerNombres(id);

            if (cliRet == null)
            {
                var nf = NotFound("El cliente " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cliRet);
        }

        [HttpPost("agregar")]
        public IActionResult AgregarNombre(NombreDt nuevoNombre)
        {
            RNombres rpCli = new RNombres();
            rpCli.Agregar(nuevoNombre);
            return CreatedAtAction(nameof(AgregarNombre), nuevoNombre);
        }
    }
}