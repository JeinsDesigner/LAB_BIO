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
    public class CD_Pacientes
    {
        public List<Pacientes> Listar()
        {
            List<Pacientes> lista = new List<Pacientes>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select paciente_id, nombres, apellidos, telefono, dni, email, sexo, edad, procedencia from PACIENTES");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Pacientes()
                            {
                                paciente_id = Convert.ToInt32(dr["paciente_id"]),
                                nombres = dr["nombres"].ToString(),
                                apellidos = dr["apellidos"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                dni = Convert.ToInt32(dr["dni"]),
                                email = dr["email"].ToString(),
                                sexo = dr["sexo"].ToString(),
                                edad = Convert.ToInt32(dr["edad"]),
                                procedencia = dr["procedencia"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Pacientes>();
                }
            }

            return lista;

        }

        public int Registrar(Pacientes obj, out string mensaje)
        {
            int idPacienteGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPACIENTE", oconexion);
                    cmd.Parameters.AddWithValue("nombres", obj.nombres);
                    cmd.Parameters.AddWithValue("apellidos", obj.apellidos);
                    cmd.Parameters.AddWithValue("dni", obj.dni);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("email", obj.email);
                    cmd.Parameters.AddWithValue("sexo", obj.sexo);
                    cmd.Parameters.AddWithValue("edad", obj.edad);
                    cmd.Parameters.AddWithValue("procedencia", obj.procedencia);
                    cmd.Parameters.Add("idPacienteResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idPacienteGenerado = Convert.ToInt32(cmd.Parameters["idPacienteResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idPacienteGenerado = 0;
                mensaje = ex.Message;
            }

            return idPacienteGenerado;
        }

        public Pacientes BuscarPorDNI(string dni)
        {
            Pacientes paciente = null;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select paciente_id, nombres, apellidos, telefono, dni, email, sexo, edad, procedencia from PACIENTES");
                    query.AppendLine("WHERE dni = @dni");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                paciente = new Pacientes()
                                {
                                    paciente_id = Convert.ToInt32(dr["paciente_id"]),
                                    nombres = dr["nombres"].ToString(),
                                    apellidos = dr["apellidos"].ToString(),
                                    telefono = dr["telefono"].ToString(),
                                    dni = Convert.ToInt32(dr["dni"]),
                                    email = dr["email"].ToString(),
                                    sexo = dr["sexo"].ToString(),
                                    edad = Convert.ToInt32(dr["edad"]),
                                    procedencia = dr["procedencia"].ToString()
                                };
                            }
                        }
                        else
                        {
                            paciente = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    paciente = null;
                }
            }

            return paciente;
        }
    }
}
