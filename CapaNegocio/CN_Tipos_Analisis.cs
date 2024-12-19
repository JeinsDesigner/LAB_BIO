using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Tipos_Analisis
    {
        private CD_Tipos_Analisis objcd_tipos_analisis = new CD_Tipos_Analisis();

        public List<Tipos_Analisis> Listar()
        {
            return objcd_tipos_analisis.Listar();
        }

        public int Registrar(Tipos_Analisis obj, out string mensaje)
        {
            mensaje = String.Empty;

            return objcd_tipos_analisis.Registrar(obj, out mensaje);
        }

        public Tipos_Analisis BuscarPorId(int id, out string mensaje)
        {
            mensaje = String.Empty;

            return objcd_tipos_analisis.BuscarPorId(id, out mensaje);
        }
    }
}
