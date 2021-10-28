using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data.Entity;

namespace pt_migracion.repository.Interface
{
    public interface IEstadosRepository
    {
        Task AddEstadoAsync(Estados theNewEstado);

        Task<Estados> GetEstadoByIdAsync(Guid theEstadoId);

        Task<ICollection<Estados>> GetAllEstadoAsync();
    }
}
