using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data;
using pt_migracion.data.Entity;
using pt_migracion.repository.Interface;

namespace pt_migracion.repository
{
    public class EquipoRepository: IEquipoRepository
    {
        private readonly ApplicationDbContext _aApplicationDbContext;

        public EquipoRepository(ApplicationDbContext theApplicationDbContext)
        {
            _aApplicationDbContext = theApplicationDbContext;
        }

        public Task AddEquipo(Equipo theNewEquipo)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Equipo>> GetAllEquipos()
        {
            throw new NotImplementedException();
        }

        public Task<Equipo> GetEquipoById(Guid theEquipoId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEquipo(Equipo theUpdatedEquipo)
        {
            throw new NotImplementedException();
        }
    }
}
