using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data.Entity;
using pt_migracion.repository.Interface;
using pt_migracion.service.Interfaces;

namespace pt_migracion.service
{
    public class SolicitudService: ISolicitudService
    {
        private readonly ISolicitudRepository _aSolicitudRepository;

        public SolicitudService(ISolicitudRepository theSolicitudRepository)
        {
            _aSolicitudRepository = theSolicitudRepository;
        }

        public Task AddSolicitudAsync(Solicitud theNewSolicitud)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Solicitud>> GetAllSolicitudAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Solicitud> GetSolicitudByIdAsync(Guid theSolicitudId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSolicitudAsync(Solicitud theUpdatedSolicitud)
        {
            throw new NotImplementedException();
        }
    }
}
