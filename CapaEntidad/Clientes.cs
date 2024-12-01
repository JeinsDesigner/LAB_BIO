using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Clientes
    {
        public int cliente_id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public string tipo_cliente { get; set; }
        public string fecha_creacion { get; set; }
    }
}
