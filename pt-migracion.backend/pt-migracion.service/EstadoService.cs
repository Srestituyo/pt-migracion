using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data.Entity;
using pt_migracion.repository.Interface;
using pt_migracion.service.Interfaces;

namespace pt_migracion.service
{
    public class EstadoService: IEstadoService
    {
        private readonly IEstadosRepository _aEstadoRepository;

        public EstadoService(IEstadosRepository theEstadoRepository)
        {
            _aEstadoRepository = theEstadoRepository;
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
