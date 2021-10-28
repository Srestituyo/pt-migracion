using System;
using System.Collections.Generic;
using pt_migracion.data;

namespace pt_migracion.data.Entity
{
    public class Estados : BaseEntity
    {
        public string Estado { get; set; }

        public virtual ICollection<Equipo> Equipo { get; set; }
    }
}
