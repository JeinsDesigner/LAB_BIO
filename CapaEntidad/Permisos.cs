using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permisos
    {
        public int permiso_id { get; set; }
        public Roles oRol { get; set; }
        public string nombre_menu { get; set; }
        public string fecha_creacion { get; set; }
    }
}
