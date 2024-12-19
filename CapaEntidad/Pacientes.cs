using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pacientes
    {
        public int paciente_id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public int edad {  get; set; }
        public int dni { get; set; }
        public string email { get; set; }
        public string sexo { get; set; }
        public string procedencia { get; set; }
        public string fecha_creacion { get; set; }
    }
}
