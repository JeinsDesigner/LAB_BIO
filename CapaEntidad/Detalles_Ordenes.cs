using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalles_Ordenes
    {
        public int detalle_id { get; set; }
        public Ordenes_Analisis oOrdenAnalisis { get; set; }
        public Pacientes oPaciente { get; set; }
        public Tipos_Analisis oTipoAnalisis { get; set; }
        public decimal precio { get; set; }
    }
}
