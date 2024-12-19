using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Ordenes_Analisis
    {
        public int orden_id { get; set; }
        public Usuarios oUsuario { get; set; }
        public string fecha_orden { get; set; }
    }
}
