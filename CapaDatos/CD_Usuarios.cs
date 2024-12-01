using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select usuario_id, nombres, apellidos, telefono, rol_id, dni, email, clave from USUARIOS";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader()) 
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuarios()
                            {
                                usuario_id = Convert.ToInt32(dr["usuario_id"]),
                                nombres = dr["nombres"].ToString(),
                                apellidos = dr["apellidos"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                dni = dr["dni"].ToString(),
                                email = dr["email"].ToString(),
                                clave = dr["clave"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex) 
                { 
                    lista = new List<Usuarios>();
                }
            }

            return lista;

        }
    }
}
