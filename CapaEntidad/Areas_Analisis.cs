using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Areas_Analisis
    {
        public int area_id { get; set; }
        public Tipos_Analisis oTipoAnalisis { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string fecha_creacion { get; set; }
    }
}
