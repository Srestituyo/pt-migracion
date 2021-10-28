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

        public Task AddPersonaAsync(Persona theNewPersona)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Persona>> GetAllPersonaAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Persona> GetPersonaByIdAsync(Guid thePersonaId)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePersonaAsync(Persona theUpdatedPersona)
        {
            throw new NotImplementedException();
        }
    }
}
