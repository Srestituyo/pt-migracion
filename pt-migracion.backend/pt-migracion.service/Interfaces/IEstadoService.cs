using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data.Entity;

namespace pt_migracion.service.Interfaces
{
    public interface IEstadoService
    { 
        Task AddEstadoAsync(Estados theNewEstado);

        Task<Estados> GetEstadoByIdAsync(Guid theEstadoId);

        Task<ICollection<Estados>> GetAllEstadoAsync(); 
    }
}
