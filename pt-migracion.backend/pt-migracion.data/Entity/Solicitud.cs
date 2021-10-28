using System;
using System.Collections.Generic;

namespace pt_migracion.data.Entity
{
    public class Solicitud: BaseEntity
    {
        public string NombreEstado { get; set; }

        public DateTime FechaDeCreacion { get; set; }

        public virtual Equipo Equipo { get; set; }
    }
}