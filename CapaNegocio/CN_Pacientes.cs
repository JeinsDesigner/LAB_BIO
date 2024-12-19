using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Pacientes
    {
        private CD_Pacientes objcd_pacientes = new CD_Pacientes();

        public List<Pacientes> Listar()
        {
            return objcd_pacientes.Listar();
        }

        public int Registrar(Pacientes obj, out string mensaje)
        {
            mensaje = string.Empty;
            
            return objcd_pacientes.Registrar(obj, out mensaje);
            
        }

        public Pacientes BuscarPorDNI(string dni)
        {
            return objcd_pacientes.BuscarPorDNI(dni);
        }
    }
}
