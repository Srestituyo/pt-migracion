using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pt_migracion.data.Entity;
using pt_migracion.service.Interfaces;

namespace pt_migracion.webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SolicitudController : ControllerBase
    {

        private readonly ILogger<SolicitudController> _aLogger;
        private readonly ISolicitudService _aSolicitudService;

        public SolicitudController(ILogger<SolicitudController> theLogger, ISolicitudService theSolicitudService)
        {
            _aLogger = theLogger;
            _aSolicitudService = theSolicitudService;
        }

        [HttpGet("solicitudid/{theSolicitudId}")]
        public async Task<Solicitud> GetSolicitudById(Guid theSolicitudId)
        {
            var aSolicitud = await _aSolicitudService.GetSolicitudByIdAsync(theSolicitudId);
            return aSolicitud;
        }

        [HttpGet]
        public async Task<IEnumerable<Solicitud>> GetAllSolicitud()
        {
            var aSolicitudList = await _aSolicitudService.GetAllSolicitudAsync();
            return aSolicitudList;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSolicitud(Solicitud theUpdatedSolicitud)
        {
            await _aSolicitudService.UpdateSolicitudAsync(theUpdatedSolicitud);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult>  AddSolicitud(Solicitud theSolicitud)
        {
            await _aSolicitudService.AddSolicitudAsync(theSolicitud);
            return Ok();
        }


    }
} 