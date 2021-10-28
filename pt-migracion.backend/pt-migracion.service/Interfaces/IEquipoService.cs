using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data.Entity;

namespace pt_migracion.service.Interfaces
{
    public interface IEquipoService
    {
        Task<Equipo> GetEquipoByIdAsync(Guid theEquipoId);

        Task<ICollection<Equipo>> GetAllEquipoAsync();

        Task AddNewEquipoAsync(Equipo theNewEquipo);

        Task UpdateEquipoAsync(Equipo theUpdatedEquipo);
    }
}
