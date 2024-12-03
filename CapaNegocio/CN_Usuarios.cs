using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objcd_usuarios = new CD_Usuarios();

        public List<Usuarios> Listar()
        {
            return objcd_usuarios.Listar();
        }

        public int Registrar(Usuarios obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.nombres == "")
            {
                mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.apellidos == "")
            {
                mensaje += "Son necesarios los apellidos del usuario\n";
            }

            if (obj.dni == "")
            {
                mensaje += "Es necesario DNI del usuario\n";
            }

            if (obj.clave == "")
            {
                mensaje += "Es necesaria la contraseña del usuario\n";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuarios.Registrar(obj, out mensaje);
            }
        }

        public bool Editar(Usuarios obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.nombres == "")
            {
                mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.apellidos == "")
            {
                mensaje += "Son necesarios los apellidos del usuario\n";
            }

            if (obj.dni == "")
            {
                mensaje += "Es necesario DNI del usuario\n";
            }

            if (obj.clave == "")
            {
                mensaje += "Es necesaria la contraseña del usuario\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuarios.Editar(obj, out mensaje);
            }
        }

        public bool Eliminar(Usuarios obj, out string mensaje)
        {
            return objcd_usuarios.Eliminar(obj, out mensaje);
        }
    }
}
