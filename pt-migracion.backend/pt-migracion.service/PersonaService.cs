using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data.Entity;
using pt_migracion.repository.Interface;
using pt_migracion.service.Interfaces;

namespace pt_migracion.service
{
    public class PersonaService: IPersonaService
    {
        private readonly IPersonaRepository _aPersonaRepository;

        public PersonaService(IPersonaRepository thePersonaRepository)
        {
            _aPersonaRepository = thePersonaRepository;
        }

        public async Task AddPersonaAsync(Persona theNewPersona)
        {
            await _aPersonaRepository.AddPersonaAsync(theNewPersona);
        }

        public async Task<ICollection<Persona>> GetAllPersonaAsync()
        {
            return await _aPersonaRepository.GetAllPersonaAsync();
        }

        public async Task<Persona> GetPersonaByIdAsync(Guid thePersonaId)
        {
            return await _aPersonaRepository.GetPersonaByIdAsync(thePersonaId);
        }

        public async Task UpdatePersonaAsync(Persona theUpdatedPersona)
        { 
            await _aPersonaRepository.UpdatePersonaAsync(theUpdatedPersona);
        }
    }
}
