using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pt_migracion.data.Entity;
using pt_migracion.service.Interfaces;
using pt_migracion.webapi.Model;

namespace pt_migracion.webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadoController : ControllerBase
    {

        private readonly ILogger<EstadoController> _aLogger;
        private readonly IEstadoService _aEstadoService;

        public EstadoController(ILogger<EstadoController> theLogger, IEstadoService theEstadoService)
        {
            _aLogger = theLogger;
            _aEstadoService = theEstadoService;
        }

        [HttpGet("estadoid/{theEstadoId}")]
        public async Task<Estados> GetEstadoById(Guid theEstadoId)
        {
            var aEstado = await _aEstadoService.GetEstadoByIdAsync(theEstadoId);
            return aEstado;

        }

        [HttpGet]
        public async Task<IEnumerable<Estados>> GetAllEstado()
        {
            var aEstadoList = await _aEstadoService.GetAllEstadoAsync();
            return aEstadoList;
        }

        [HttpPost]
        public async Task<IActionResult> AddEstado(CreateEstadoModel theEstado)
        {
            var aNewEstado = new Estados()
            {
                Estado = theEstado.Estado
            };
            await _aEstadoService.AddEstadoAsync(aNewEstado);

            return Ok();
        }


    }
}
