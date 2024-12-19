using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Ordenes_Analisis
    {
        private CD_Ordenes_Analisis objcd_ordenes_analisis = new CD_Ordenes_Analisis();

        public List<Ordenes_Analisis> Listar()
        {
            return objcd_ordenes_analisis.Listar();
        }

        public List<Ordenes_Analisis> ListarPorDNI(int dni)
        {
            return objcd_ordenes_analisis.ListarPorDNI(dni);
        }

        public int Registrar(Ordenes_Analisis obj, out string mensaje)
        {
            mensaje = string.Empty;

            return objcd_ordenes_analisis.Registrar(obj, out mensaje);
        }
    }
}
