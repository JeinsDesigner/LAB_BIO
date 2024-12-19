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
    public class CD_Variables_Analisis
    {
        public List<Variables_Analisis> Listar()
        {
            List<Variables_Analisis> lista = new List<Variables_Analisis>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select variable_id, tipo_analisis_id, nombre_variable, unidad, referencia from VARIABLES_ANALISIS");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Variables_Analisis()
                            {
                                variable_id = Convert.ToInt32(dr["variable_id"]),
                                oTipo_Analisis = new Tipos_Analisis() { tipo_analisis_id = Convert.ToInt32(dr["tipo_analisis_id"]) },
                                nombre_variable = dr["nombre_variable"].ToString(),
                                unidad = dr["unidad"].ToString(),
                                referencia = dr["referencia"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Variables_Analisis>();
                }
            }

            return lista;
        }

        public List<Variables_Analisis> ListarPorId(int id)
        {
            List<Variables_Analisis> lista = new List<Variables_Analisis>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select variable_id, tipo_analisis_id, nombre_variable, unidad, referencia from VARIABLES_ANALISIS");
                    query.AppendLine("WHERE tipo_analisis_id = @id");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Variables_Analisis()
                            {
                                variable_id = Convert.ToInt32(dr["variable_id"]),
                                oTipo_Analisis = new Tipos_Analisis() { tipo_analisis_id = Convert.ToInt32(dr["tipo_analisis_id"]) },
                                nombre_variable = dr["nombre_variable"].ToString(),
                                unidad = dr["unidad"].ToString(),
                                referencia = dr["referencia"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Variables_Analisis>();
                }
            }

            return lista;
        }
        public int Registrar(Variables_Analisis obj, out string mensaje)
        {
            int idVariableGenerada = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARVARIABLE", oconexion);
                    cmd.Parameters.AddWithValue("tipo_analisis_id", obj.oTipo_Analisis.tipo_analisis_id);
                    cmd.Parameters.AddWithValue("nombre_variable", obj.nombre_variable);
                    cmd.Parameters.AddWithValue("unidad", obj.unidad);
                    cmd.Parameters.AddWithValue("referencia", obj.referencia);
                    cmd.Parameters.Add("idVariableResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idVariableGenerada = Convert.ToInt32(cmd.Parameters["idVariableResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idVariableGenerada = 0;
                mensaje = ex.Message;
            }

            return idVariableGenerada;
        }
    }
}
