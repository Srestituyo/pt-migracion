using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data.Entity;
using pt_migracion.repository.Interface;
using pt_migracion.service.Interfaces;

namespace pt_migracion.service
{
    public class EquipoService: IEquipoService
    {
        private readonly IEquipoRepository _aEquipoRepository;

        public EquipoService(IEquipoRepository theEquipoRepository)
        {
            _aEquipoRepository = theEquipoRepository;
        }

        public Task AddNewEquipoAsync(Equipo theNewEquipo)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Equipo>> GetAllEquipoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Equipo> GetEquipoByIdAsync(Guid theEquipoId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEquipoAsync(Equipo theUpdatedEquipo)
        {
            throw new NotImplementedException();
        }
    }
}
