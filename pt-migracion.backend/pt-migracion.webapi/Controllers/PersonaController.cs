using System;
using System.Collections.Generic;
using System.Net;
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
    public class PersonaController : ControllerBase
    {
        
        private readonly ILogger<PersonaController> _aLogger;
        private readonly IPersonaService _aPersonaService;

        public PersonaController(ILogger<PersonaController> theLogger, IPersonaService thePersonaService)
        {
            _aLogger = theLogger;
            _aPersonaService = thePersonaService;
        }

        [HttpGet("personaid/{thePersonaId}")]
        public async Task<PersonaModel> GetPersonaById(Guid thePersonaId)
        {
            var aPersonaResult = await _aPersonaService.GetPersonaByIdAsync(thePersonaId);

            var aPersona = new PersonaModel() {
                PersonaId = aPersonaResult.Id,
                Nombre = aPersonaResult.Nombre,
                Apellido = aPersonaResult.Apellido,
                Direccion = aPersonaResult.Direccion,
                FechaNacimiento = aPersonaResult.FechaNacimiento,
                Pasaporte = aPersonaResult.Pasaporte,
                Sexo = aPersonaResult.Sexo,
                FotoPath = aPersonaResult.FotoPath
            };

            HttpContext.Response.StatusCode = (int)HttpStatusCode.OK;
            return aPersona;
        }

        [HttpGet]
        public async Task<IEnumerable<PersonaModel>> GetAllPersona()
        {
            var aPersonList = new List<PersonaModel>();
            var aPersonaListResult = await _aPersonaService.GetAllPersonaAsync();

            foreach (var aPersonaItem in aPersonaListResult)
            {
                var aPersona = new PersonaModel()
                {
                    PersonaId = aPersonaItem.Id,
                    Nombre = aPersonaItem.Nombre,
                    Apellido = aPersonaItem.Apellido,
                    Direccion = aPersonaItem.Direccion,
                    FechaNacimiento = aPersonaItem.FechaNacimiento,
                    Pasaporte = aPersonaItem.Pasaporte,
                    Sexo = aPersonaItem.Sexo,
                    FotoPath = aPersonaItem.FotoPath
                };

                aPersonList.Add(aPersona);
            }

            HttpContext.Response.StatusCode = (int)HttpStatusCode.OK;
            return aPersonList;
        }

        [HttpPut("personaid/thePersonaId")]
        public async Task<IActionResult> UpdatePersona(Guid thePersonaId, PersonaModel theUpdatedPersona)
        {
            var aPersona = await _aPersonaService.GetPersonaByIdAsync(thePersonaId);

            if (aPersona == null)
            {
                return NotFound();
            }

            var aUpdatedPersona = new Persona()
            {
                Id = thePersonaId,
                Nombre = theUpdatedPersona.Nombre,
                Apellido = theUpdatedPersona.Apellido,
                Direccion = theUpdatedPersona.Direccion,
                FechaNacimiento = theUpdatedPersona.FechaNacimiento,
                Pasaporte = theUpdatedPersona.Pasaporte,
                Sexo = theUpdatedPersona.Sexo,
                FotoPath = theUpdatedPersona.FotoPath
            };
            await _aPersonaService.UpdatePersonaAsync(aUpdatedPersona);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddPersona(PersonaModel thePersona)
        {
            var aNewPersona = new Persona()
            {
                Nombre = thePersona.Nombre,
                Apellido = thePersona.Apellido,
                Direccion = thePersona.Direccion,
                FechaNacimiento = thePersona.FechaNacimiento,
                Pasaporte = thePersona.Pasaporte,
                Sexo = thePersona.Sexo,
                FotoPath = thePersona.FotoPath
            };
            await _aPersonaService.AddPersonaAsync(aNewPersona);
            return Ok();
        }


    }
}
