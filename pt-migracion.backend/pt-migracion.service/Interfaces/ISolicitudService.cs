using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data.Entity;

namespace pt_migracion.service.Interfaces
{
    public interface ISolicitudService
    {
        Task<Solicitud> GetSolicitudByIdAsync(Guid theSolicitudId);

        Task<ICollection<Solicitud>> GetAllSolicitudAsync();

        Task AddSolicitudAsync(Solicitud theNewSolicitud);

        Task UpdateSolicitudAsync(Solicitud theUpdatedSolicitud);
    }
}
