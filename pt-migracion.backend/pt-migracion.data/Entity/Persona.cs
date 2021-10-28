using System;
using System.Collections.Generic;

namespace pt_migracion.data.Entity
{
    public class Persona: BaseEntity
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Pasaporte { get; set; }

        public string Direccion { get; set; }

        public string Sexo { get; set; }

        public string FotoPath { get; set; } 

        public virtual ICollection<Equipo> Equipos { get; set; } 
    }
}