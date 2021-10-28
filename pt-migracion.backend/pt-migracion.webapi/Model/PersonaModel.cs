using System;
namespace pt_migracion.webapi.Model
{
    public class PersonaModel
    {
        public Guid PersonaId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Pasaporte { get; set; }

        public string Direccion { get; set; }

        public string Sexo { get; set; }

        public string FotoPath { get; set; }
    }
}
