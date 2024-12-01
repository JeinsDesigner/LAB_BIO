using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Resultados_Analisis
    {
        public int resultados_id { get; set; }
        public Detalles_Ordenes oDetalleOrden { get; set; }
        public Variables_Analisis oVariableAnalisis { get; set; }
        public string valor { get; set; }
        public string fecha_registro { get; set; }
    }
}
