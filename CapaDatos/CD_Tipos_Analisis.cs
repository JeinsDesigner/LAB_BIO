using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Collections;

namespace CapaDatos
{
    public class CD_Tipos_Analisis
    {
        public List<Tipos_Analisis> Listar()
        {
            List<Tipos_Analisis> lista = new List<Tipos_Analisis>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select tipo_analisis_id, nombres, muestra, descripcion, precio_comun, precio_derivado, precio_sucursal from TIPOS_ANALISIS");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Tipos_Analisis()
                            {
                                tipo_analisis_id = Convert.ToInt32(dr["tipo_analisis_id"]),
                                nombres = dr["nombres"].ToString(),
                                muestra = dr["muestra"].ToString(),
                                descripcion = dr["descripcion"].ToString(),
                                precio_comun = Convert.ToInt32(dr["precio_comun"]),
                                precio_derivado = Convert.ToInt32(dr["precio_derivado"]),
                                precio_sucursal = Convert.ToInt32(dr["precio_sucursal"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Tipos_Analisis>();
                }
            }

            return lista;
        }

        public Tipos_Analisis BuscarPorId(int id, out string mensaje)
        {
            mensaje = string.Empty;
            Tipos_Analisis objTipoAnalisis = null;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select tipo_analisis_id, nombres, precio_comun, precio_derivado, precio_sucursal, muestra, descripcion from TIPOS_ANALISIS");
                    query.AppendLine("WHERE tipo_analisis_id = @id");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                objTipoAnalisis = new Tipos_Analisis()
                                {
                                    tipo_analisis_id = Convert.ToInt32(dr["tipo_analisis_id"]),
                                    nombres = dr["nombres"].ToString(),
                                    precio_comun = Convert.ToDecimal(dr["precio_comun"]),
                                    precio_derivado = Convert.ToDecimal(dr["precio_derivado"]),
                                    precio_sucursal = Convert.ToDecimal(dr["precio_sucursal"]),
                                    muestra = dr["muestra"].ToString(),
                                    descripcion = dr["descripcion"].ToString(),
                                };
                            }
                        }
                        else
                        {
                            objTipoAnalisis = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    objTipoAnalisis = null;
                }
            }

            return objTipoAnalisis;
        }
        public int Registrar(Tipos_Analisis obj, out string mensaje)
        {
            int idTipoAnalisisGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARTIPOANALISIS", oconexion);
                    cmd.Parameters.AddWithValue("nombres", obj.nombres);
                    cmd.Parameters.AddWithValue("precio_comun", obj.precio_comun);
                    cmd.Parameters.AddWithValue("precio_derivado", obj.precio_derivado);
                    cmd.Parameters.AddWithValue("precio_sucursal", obj.precio_sucursal);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("muestra", obj.muestra);
                    cmd.Parameters.Add("idTipoAnalisisResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idTipoAnalisisGenerado = Convert.ToInt32(cmd.Parameters["idTipoAnalisisResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idTipoAnalisisGenerado = 0;
                mensaje = ex.Message;
            }

            return idTipoAnalisisGenerado;
        }
    }
}
