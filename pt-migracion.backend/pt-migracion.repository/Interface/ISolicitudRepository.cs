using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using pt_migracion.data.Entity;

namespace pt_migracion.repository.Interface
{
    public interface ISolicitudRepository
    {
        Task<Solicitud> GetSolicitudByIdAsync(Guid theSolicitudId);

        Task<ICollection<Solicitud>> GetAllSolicitudAsync();

        Task AddSolicitudAsync(Solicitud theNewSolicitud);

        Task UpdateSolicitudAsync(Solicitud theUpdatedSolicitud);
    }
}
