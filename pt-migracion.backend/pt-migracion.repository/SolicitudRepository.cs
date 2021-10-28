using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data;
using pt_migracion.data.Entity;
using pt_migracion.repository.Interface;

namespace pt_migracion.repository
{
    public class SolicitudRepository: ISolicitudRepository
    {
        private readonly ApplicationDbContext _aApplicationDbContext;

        public SolicitudRepository(ApplicationDbContext theApplicationDbContext)
        {
            _aApplicationDbContext = theApplicationDbContext;
        }

        public Task AddSolicitudAsync(Solicitud theNewSolicitud)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Solicitud>> GetAllSolicitudAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Solicitud> GetSolicitudByIdAsync(Guid theSolicitudId)
        {
            var aSolicitud = await _aApplicationDbContext.Solicitud.FindAsync(theSolicitudId);
            return aSolicitud;
        }

        public Task UpdateSolicitudAsync(Solicitud theUpdatedSolicitud)
        {
            throw new NotImplementedException();
        }
    }
}
