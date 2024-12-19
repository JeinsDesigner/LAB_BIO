using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Detalles_Ordenes
    {
        private CD_Detalles_Ordenes objcd_detalles_ordenes = new CD_Detalles_Ordenes();

        public List<Detalles_Ordenes> Listar()
        {
            return objcd_detalles_ordenes.Listar();
        }

        public int Registrar(Detalles_Ordenes obj, out string mensaje)
        {
            mensaje = string.Empty;
            
            return objcd_detalles_ordenes.Registrar(obj, out mensaje);
        }

        public List<Detalles_Ordenes> ListarPorId(int id)
        {
            return objcd_detalles_ordenes.ListarPorId(id);
        }
    }
}
