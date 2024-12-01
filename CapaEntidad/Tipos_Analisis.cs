using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Tipos_Analisis
    {
        public int tipo_analisis_id { get; set; }
        public string nombres { get; set; }
        public string descripcion { get; set; }
        public decimal precio_comun { get; set; }
        public decimal precio_derivado { get; set; }
        public decimal precio_sucursal { get; set; }
        public string fecha_creacion { get; set; }
    }
}
