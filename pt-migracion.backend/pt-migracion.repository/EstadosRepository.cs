using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data;
using pt_migracion.data.Entity;
using pt_migracion.repository.Interface;

namespace pt_migracion.repository
{
    public class EstadosRepository: IEstadosRepository
    {
        private readonly ApplicationDbContext _aApplicationDbcontext;

        public EstadosRepository(ApplicationDbContext theApplicationDbContext)
        {
            _aApplicationDbcontext = theApplicationDbContext;
        }

        public Task AddEstadoAsync(Estados theNewEstado)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Estados>> GetAllEstadoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Estados> GetEstadoByIdAsync(Guid theEstadoId)
        {
            throw new NotImplementedException();
        }
    }
}
