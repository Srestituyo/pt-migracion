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

        public async Task AddEstadoAsync(Estados theNewEstado)
        {
            theNewEstado.TimeStamp = DateTime.UtcNow;

            await _aEstadoRepository.AddEstadoAsync(theNewEstado);
        }

        public async Task<ICollection<Estados>> GetAllEstadoAsync()
        {
            return await _aEstadoRepository.GetAllEstadoAsync();
        }

        public async Task<Estados> GetEstadoByIdAsync(Guid theEstadoId)
        {
            return await _aEstadoRepository.GetEstadoByIdAsync(theEstadoId);
        }
    }
}
