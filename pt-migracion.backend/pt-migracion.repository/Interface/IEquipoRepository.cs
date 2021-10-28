using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data.Entity;

namespace pt_migracion.repository.Interface
{
    public interface IEquipoRepository
    {
        Task<Equipo> GetEquipoById(Guid theEquipoId);

        Task<ICollection<Equipo>> GetAllEquipos();

        Task AddEquipo(Equipo theNewEquipo);

        Task UpdateEquipo(Equipo theUpdatedEquipo); 
    }
}
