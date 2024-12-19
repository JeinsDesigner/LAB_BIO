using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Net;

namespace CapaDatos
{
    public class CD_Detalles_Ordenes
    {
        public List<Detalles_Ordenes> Listar()
        {
            List<Detalles_Ordenes> lista = new List<Detalles_Ordenes>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select detalle_id, orden_id, paciente_id, tipo_analisis_id, precio from DETALLES_ORDENES");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Detalles_Ordenes()
                            {
                                detalle_id = Convert.ToInt32(dr["detalle_id"]),
                                oOrdenAnalisis = new Ordenes_Analisis()
                                {
                                    orden_id = Convert.ToInt32(dr["orden_id"]),
                                },
                                oPaciente = new Pacientes()
                                {
                                    paciente_id = Convert.ToInt32(dr["paciente_id"]),
                                },
                                oTipoAnalisis = new Tipos_Analisis()
                                {
                                    tipo_analisis_id = Convert.ToInt32(dr["tipo_analisis_id"]),
                                },
                                precio = Convert.ToInt32(dr["precio"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Detalles_Ordenes>();
                }
            }

            return lista;

        }

        public List<Detalles_Ordenes> ListarPorId(int id)
        {
            List<Detalles_Ordenes> lista = new List<Detalles_Ordenes>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select detalle_id, orden_id, paciente_id, tipo_analisis_id, precio from DETALLES_ORDENES");
                    query.AppendLine("WHERE orden_id = @id");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Detalles_Ordenes()
                            {
                                detalle_id = Convert.ToInt32(dr["detalle_id"]),
                                oOrdenAnalisis = new Ordenes_Analisis()
                                {
                                    orden_id = Convert.ToInt32(dr["orden_id"]),
                                },
                                oPaciente = new Pacientes()
                                {
                                    paciente_id = Convert.ToInt32(dr["paciente_id"]),
                                },
                                oTipoAnalisis = new Tipos_Analisis()
                                {
                                    tipo_analisis_id = Convert.ToInt32(dr["tipo_analisis_id"]),
                                },
                                precio = Convert.ToInt32(dr["precio"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Detalles_Ordenes>();
                }
            }

            return lista;
        }

        public int Registrar(Detalles_Ordenes obj, out string mensaje)
        {
            int idDetalleOrdenGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARDETALLEORDEN", oconexion);
                    cmd.Parameters.AddWithValue("orden_id", obj.oOrdenAnalisis.orden_id);
                    cmd.Parameters.AddWithValue("paciente_id", obj.oPaciente.paciente_id);
                    cmd.Parameters.AddWithValue("tipo_analisis_id", obj.oTipoAnalisis.tipo_analisis_id);
                    cmd.Parameters.AddWithValue("precio", obj.precio);
                    cmd.Parameters.Add("idDetalleOrdenResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idDetalleOrdenGenerado = Convert.ToInt32(cmd.Parameters["idDetalleOrdenResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idDetalleOrdenGenerado = 0;
                mensaje = ex.Message;
            }

            return idDetalleOrdenGenerado;
        }
    }
}
