using System;
using pt_migracion.data.Entity;

namespace pt_migracion.data.Entity
{
    public class Equipo : BaseEntity
    {
        public Guid PersonaId { get; set; }

        public virtual Persona Persona { get; set; }

        public Guid SolicitudId { get; set; }

        public virtual Solicitud Solicitud { get; set; }

        public Guid EstadoId { get; set; }

        public virtual Estados Estados{ get; set; }

        public DateTime FechaDeCreacion { get; set; }
    }
}