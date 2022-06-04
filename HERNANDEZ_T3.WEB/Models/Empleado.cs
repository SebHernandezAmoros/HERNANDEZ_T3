using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HERNANDEZ_T3.WEB.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Dni { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
