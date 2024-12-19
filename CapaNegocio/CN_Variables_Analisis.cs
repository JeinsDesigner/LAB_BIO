using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Variables_Analisis
    {
        private CD_Variables_Analisis objcd_variables_analisis = new CD_Variables_Analisis();

        public List<Variables_Analisis> Listar()
        {
            return objcd_variables_analisis.Listar();
        }

        public List<Variables_Analisis> ListarPorId(int id)
        {
            return objcd_variables_analisis.ListarPorId(id);
        }

        public int Registrar(Variables_Analisis obj, out string mensaje)
        {
            mensaje = string.Empty;

            return objcd_variables_analisis.Registrar(obj, out mensaje);
        }
    }
}
