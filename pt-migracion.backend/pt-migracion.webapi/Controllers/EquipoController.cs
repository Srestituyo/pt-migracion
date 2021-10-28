using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pt_migracion.data.Entity;
using pt_migracion.service.Interfaces;

namespace pt_migracion.webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipoController : ControllerBase
    {

        private readonly ILogger<EquipoController> _aLogger;
        private readonly IEquipoService _aEquipoService;

        public EquipoController(ILogger<EquipoController> theLogger, IEquipoService theEquipoService)
        {
            _aLogger = theLogger;
            _aEquipoService = theEquipoService;
        }

        [HttpGet("/{theEquipoId}")]
        public async Task<Equipo> GetEquipoById(Guid theEquipoId)
        {
            var aEquipo = await _aEquipoService.GetEquipoByIdAsync(theEquipoId);
            return aEquipo;
        }

        [HttpGet]
        public async Task<IEnumerable<Equipo>> GetAllEquipo()
        {
            var aEquipoList = await _aEquipoService.GetAllEquipoAsync();
            return aEquipoList;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEquipoAsync(Equipo theUpdatedEquipo)
        {
            await _aEquipoService.UpdateEquipoAsync(theUpdatedEquipo);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddEquipoAsync(Equipo theEquipo)
        {
            await _aEquipoService.AddNewEquipoAsync(theEquipo);
            return Ok();
        }


    }
}
