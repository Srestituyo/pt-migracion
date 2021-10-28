using System;
using pt_migracion.data;

namespace pt_migracion.data.Entity
{
    public class Estados : BaseEntity
    {
        public string Estado { get; set; }

        public virtual Equipo Equipo { get; set; }
    }
}
