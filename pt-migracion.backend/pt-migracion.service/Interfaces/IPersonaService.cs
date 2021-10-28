using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data.Entity;

namespace pt_migracion.service.Interfaces
{
    public interface IPersonaService
    {
        Task<Persona> GetPersonaByIdAsync(Guid thePersonaId);

        Task<ICollection<Persona>> GetAllPersonaAsync();

        Task AddPersonaAsync(Persona theNewPersona);

        Task UpdatePersonaAsync(Persona theUpdatedPersona);
    }
} 
