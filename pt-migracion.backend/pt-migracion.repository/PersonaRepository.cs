using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task AddPersonaAsync(Persona theNewPersona)
        {
            try
            {
                _aApplicationDbContext.Add(theNewPersona);
                await _aApplicationDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
        }

        public async Task<ICollection<Persona>> GetAllPersonaAsync()
        {
            try
            {
                var aPersonaList = await _aApplicationDbContext.Persona.ToListAsync();
                return aPersonaList;
            }
            catch (Exception ex)
            {
                throw new SystemException();
            }
        }

        public async Task<Persona> GetPersonaByIdAsync(Guid thePersonaId)
        {
            try
            {
                var aPersona = await _aApplicationDbContext.Persona.FindAsync(thePersonaId);

                return aPersona;
            }
            catch (Exception ex)
            {
                throw new SystemException();
            }
        }

        public async Task UpdatePersonaAsync(Persona theUpdatedPersona)
        {
            try
            {
                _aApplicationDbContext.Update(theUpdatedPersona);
                await _aApplicationDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new SystemException();
            }
        }
    }
}
