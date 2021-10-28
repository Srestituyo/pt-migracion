using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data;
using pt_migracion.data.Entity;
using pt_migracion.repository.Interface;

namespace pt_migracion.repository
{
    public class PersonaRepository: IPersonaRepository
    {
        private readonly ApplicationDbContext _aApplicationDbContext;

        public PersonaRepository(ApplicationDbContext theApplicationDbContext)
        {
            _aApplicationDbContext = theApplicationDbContext;
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
