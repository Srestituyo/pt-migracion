using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task AddEstadoAsync(Estados theNewEstado)
        {
            _aApplicationDbcontext.Estados.Add(theNewEstado);
            await _aApplicationDbcontext.SaveChangesAsync();
        }

        public async Task<ICollection<Estados>> GetAllEstadoAsync()
        {
            var aEstadoList = await _aApplicationDbcontext.Estados.ToListAsync();
            return aEstadoList;
        }

        public async Task<Estados> GetEstadoByIdAsync(Guid theEstadoId)
        {
            var aEstado = await _aApplicationDbcontext.Estados.FindAsync(theEstadoId);
            return aEstado;
        }
    }
}
