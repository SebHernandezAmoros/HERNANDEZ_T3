using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HERNANDEZ_T3.WEB.Models
{
    public class Mascota
    {
        public int MascotaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public double Tamano { get; set; }
        public string DatosParticulares { get; set; }
        public string NombreDueño { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
