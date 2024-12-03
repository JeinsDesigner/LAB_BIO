using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Roles
    {
        private CD_Roles objcd_roles = new CD_Roles();

        public List<Roles> Listar()
        {
            return objcd_roles.Listar();
        }
    }
}
