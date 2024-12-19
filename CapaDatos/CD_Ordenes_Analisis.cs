using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Ordenes_Analisis
    {
        public List<Ordenes_Analisis> Listar()
        {
            List<Ordenes_Analisis> lista = new List<Ordenes_Analisis>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select orden_id, usuario_id, fecha_orden from DETALLES_ORDENES");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Ordenes_Analisis()
                            {
                                orden_id = Convert.ToInt32(dr["orden_id"]),
                                oUsuario = new Usuarios()
                                {
                                    usuario_id = Convert.ToInt32(dr["usuario_id"]),
                                },
                                fecha_orden = dr["fecha_orden"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Ordenes_Analisis>();
                }
            }

            return lista;

        }

        public List<Ordenes_Analisis> ListarPorDNI(int dni)
        {
            List<Ordenes_Analisis> lista = new List<Ordenes_Analisis>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select DISTINCT o.orden_id, o.usuario_id, o.fecha_orden from ORDENES_ANALISIS o");
                    query.AppendLine("INNER JOIN DETALLES_ORDENES d ON o.orden_id = d.orden_id");
                    query.AppendLine("INNER JOIN PACIENTES p ON d.paciente_id = p.paciente_id");
                    query.AppendLine("WHERE p.dni = @dni");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Ordenes_Analisis()
                            {
                                orden_id = Convert.ToInt32(dr["orden_id"]),
                                oUsuario = new Usuarios()
                                {
                                    usuario_id = Convert.ToInt32(dr["usuario_id"]),
                                },
                                fecha_orden = dr["fecha_orden"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Ordenes_Analisis>();
                }
            }

            return lista;
        }

        public int Registrar(Ordenes_Analisis obj, out string mensaje)
        {
            int idOrdenAnalisisGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARORDENANALISIS", oconexion);
                    cmd.Parameters.AddWithValue("usuario_id", obj.oUsuario.usuario_id);
                    cmd.Parameters.Add("idOrdenAnalisisResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idOrdenAnalisisGenerado = Convert.ToInt32(cmd.Parameters["idOrdenAnalisisResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idOrdenAnalisisGenerado = 0;
                mensaje = ex.Message;
            }

            return idOrdenAnalisisGenerado;
        }
    }
}
