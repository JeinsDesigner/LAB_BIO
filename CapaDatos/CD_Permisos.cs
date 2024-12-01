using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Permisos
    {
        public List<Permisos> Listar(int idUsuario)
        {
            List<Permisos> lista = new List<Permisos>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.rol_id, p.nombre_menu from PERMISOS p");
                    query.AppendLine("inner join ROLES r on r.rol_id = p.rol_id");
                    query.AppendLine("inner join USUARIOS u on u.rol_id = r.rol_id");
                    query.AppendLine("where u.usuario_id = @idUsuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permisos()
                            {
                                oRol = new Roles() { rol_id = Convert.ToInt32(dr["rol_id"]) } ,
                                nombre_menu = dr["nombre_menu"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permisos>();
                }
            }

            return lista;

        }
    }
}
