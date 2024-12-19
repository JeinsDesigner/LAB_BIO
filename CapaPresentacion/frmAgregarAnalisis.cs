using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using System.Windows.Media;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmAgregarAnalisis : Form
    {
        Usuarios oUsuarioActual;
        public frmAgregarAnalisis(Usuarios usuarioActual)
        {
            oUsuarioActual = usuarioActual;
            InitializeComponent();
        }

        List<Tipos_Analisis> listaTiposAnalisis = new CN_Tipos_Analisis().Listar();

        bool pacienteEncontrado = false;
        Pacientes paciente = null;

        private void btnAgregarExamen_Click(object sender, EventArgs e)
        {
            txtContador.Text = (Convert.ToInt32(txtContador.Text) + 1).ToString();

            Panel panel = new Panel
            {
                Width = flpDatos.Width - 30,
                Height = 60,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            Label lblId = new Label
            {
                Text = "Código de análisis",
                AutoSize = true,
                Location = new Point(15, 10)
            };

            TextBox txtId = new TextBox
            {
                Name = "txtId" + txtContador.Text,
                Location = new Point(15, 30),
                Width = 60,
                ReadOnly = true,
            };

            Label lblAnalisis = new Label
            {
                Text = "Tipo de Analisis",
                AutoSize = true,
                Location = new Point(210, 10)
            };

            ComboBox cboAnalisis = new ComboBox
            {
                Name = "cboTipoAnalisis" + txtContador.Text,
                Width = 150,
                Location = new Point(210, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cboAnalisis.Items.Add("Seleccione una opción");

            foreach (Tipos_Analisis item in listaTiposAnalisis)
            {
                cboAnalisis.Items.Add(new Tipos_Analisis() { tipo_analisis_id = item.tipo_analisis_id, nombres = item.nombres, precio_comun = item.precio_comun, precio_derivado = item.precio_derivado, precio_sucursal = item.precio_sucursal });
            }
            
            cboAnalisis.DisplayMember = "nombres";
            cboAnalisis.ValueMember = "tipo_analisis_id";
            cboAnalisis.SelectedIndex = 0;

            Label lblPrecio = new Label
            {
                Text = "Precio",
                AutoSize = true,
                Location = new Point(440, 10)
            };

            TextBox txtPrecio = new TextBox
            {
                Name = "txtPrecio" + txtContador.Text,
                Width = 150,
                Location = new Point(440, 30),
            };

            panel.Controls.Add(lblId);
            panel.Controls.Add(txtId);
            panel.Controls.Add(lblAnalisis);
            panel.Controls.Add(cboAnalisis);
            panel.Controls.Add(lblPrecio);
            panel.Controls.Add(txtPrecio);

            cboAnalisis.SelectedIndexChanged += (s, ee) => cboAnalisis_SelectedIndexChanged(s, e, txtId, txtPrecio);

            flpDatos.Controls.Add(panel);
        }

        private void cboAnalisis_SelectedIndexChanged(object sender, EventArgs e,TextBox txtId, TextBox txtPrecio)
        {
            ComboBox cboAnalisis = (ComboBox)sender;

            if (cboAnalisis.SelectedIndex == 0)
            {
                cboAnalisis.SelectedIndex = 1;
                return;
            }

            Tipos_Analisis tipoAnalisisSeleccionado = (Tipos_Analisis)cboAnalisis.SelectedItem;

            if (tipoAnalisisSeleccionado != null)
            {
                txtId.Text = "00" + tipoAnalisisSeleccionado.tipo_analisis_id.ToString();

                string seleccion = cboProcedencia.SelectedItem.ToString();
                switch (seleccion)
                {
                    case "Usuario Comun":
                        txtPrecio.Text = "$ " + tipoAnalisisSeleccionado.precio_comun.ToString("F2");
                        break;
                    case "Derivado":
                        txtPrecio.Text = "$ " + tipoAnalisisSeleccionado.precio_derivado.ToString("F2");
                        break;
                    case "Convenio":
                        txtPrecio.Text = "$ " + tipoAnalisisSeleccionado.precio_sucursal.ToString("F2");
                        break;
                }
            }
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (txtDNI.Text.Length == 8)
            {
                string dni = txtDNI.Text;

                paciente = new CN_Pacientes().BuscarPorDNI(dni);
            }

            if (paciente != null && paciente.paciente_id != 0)
            {
                pacienteEncontrado = true;
                txtNombres.Text = paciente.nombres;
                txtApellidos.Text = paciente.apellidos;
                txtEdad.Text = paciente.edad.ToString();
                txtEmail.Text = paciente.email;
                txtTelefono.Text = paciente.telefono;
                cboProcedencia.SelectedItem = paciente.procedencia;
                cboSexo.SelectedItem = paciente.sexo;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            int idPacienteGenerado;
            int idOrdenGenerada;

            Ordenes_Analisis objOrden = new Ordenes_Analisis()
            {
                oUsuario = new Usuarios()
                {
                    usuario_id = oUsuarioActual.usuario_id,
                }
            };

            idOrdenGenerada = new CN_Ordenes_Analisis().Registrar(objOrden, out mensaje);

            if (pacienteEncontrado == false)
            {
                Pacientes objPaciente = new Pacientes()
                {
                    nombres = txtNombres.Text,
                    apellidos = txtApellidos.Text,
                    dni = Convert.ToInt32(txtDNI.Text),
                    telefono = txtTelefono.Text,
                    edad = Convert.ToInt32(txtEdad.Text),
                    email = txtEmail.Text,
                    sexo = cboSexo.Text,
                    procedencia = cboProcedencia.Text,
                };

                idPacienteGenerado = new CN_Pacientes().Registrar(objPaciente, out mensaje);
            }
            else
            {
                idPacienteGenerado = paciente.paciente_id;
            }

            if (idPacienteGenerado != 0)
            {
                for (int i = 1; i < Convert.ToInt32(txtContador.Text) + 1; i++)
                {
                    TextBox txtId = flpDatos.Controls.Find("txtId" + i, true).FirstOrDefault() as TextBox;
                    TextBox txtPrecio = flpDatos.Controls.Find("txtPrecio" + i, true).FirstOrDefault() as TextBox;
                    txtPrecio.Text = txtPrecio.Text.Replace("$ ", "").Trim();

                    Detalles_Ordenes objDetalleOrdenes = new Detalles_Ordenes()
                    {
                        oOrdenAnalisis = new Ordenes_Analisis()
                        {
                            orden_id = idOrdenGenerada,
                        },
                        oPaciente = new Pacientes()
                        {
                            paciente_id = idPacienteGenerado,
                        },
                        oTipoAnalisis = new Tipos_Analisis()
                        {
                            tipo_analisis_id = Convert.ToInt32(txtId.Text),
                        },
                        precio = Convert.ToDecimal(txtPrecio.Text)
                    };

                    int idDetalleOrdenGenerado = new CN_Detalles_Ordenes().Registrar(objDetalleOrdenes, out mensaje);
                }
            }

            Limpiar();
        }

        private void frmAgregarAnalisis_Load(object sender, EventArgs e)
        {
            cboSexo.Items.Add("Masculino");
            cboSexo.Items.Add("Femenino");

            cboProcedencia.Items.Add("Usuario Comun");
            cboProcedencia.Items.Add("Derivado");
            cboProcedencia.Items.Add("Convenio");
        }

        private void Limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            cboSexo.SelectedItem = null;
            cboProcedencia.SelectedItem = null;

            for (int i = 1; i < Convert.ToInt32(txtContador.Text) + 1; i++)
            {
                flpDatos.Controls.Clear();
            }

            flpDatos.PerformLayout();
            flpDatos.Refresh();

            txtContador.Text = "0";
        }
    }
}
