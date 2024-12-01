using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Permisos
    {
        private CD_Permisos objcd_permisos = new CD_Permisos();

        public List<Permisos> Listar(int idUsuario)
        {
            return objcd_permisos.Listar(idUsuario);
        }
    }
}
