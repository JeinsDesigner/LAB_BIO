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
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmTiposAnalisis : Form
    {
        public frmTiposAnalisis()
        {
            InitializeComponent();
        }

        private void btnAgregarExamen_Click(object sender, EventArgs e)
        {
            txtContador.Text = (Convert.ToInt32(txtContador.Text) + 1).ToString();

            Panel panel = new Panel
            {
                Name = "campo" + txtContador.Text,
                Width = flpDatos.Width - 30,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            Label lblNombre = new Label
            {
                Text = "Nombre de la variable",
                AutoSize = true,
                Location = new Point(15, 10)
            };

            TextBox txtNombre = new TextBox
            {
                Name = "txtNombreVariable" + txtContador.Text,
                Location = new Point(15, 30),
                Width = 120,
            };

            Label lblUnidad = new Label
            {
                Text = "Unidad de Variable",
                AutoSize = true,
                Location = new Point(180, 10)
            };

            TextBox txtUnidad = new TextBox
            {
                Name = "txtUnidadVariable" + txtContador.Text,
                Location = new Point(180, 30),
                Width = 120,
            };

            Label lblReferencia = new Label
            {
                Text = "Valor referencial",
                AutoSize = true,
                Location = new Point(345, 10)
            };

            TextBox txtReferencia = new TextBox
            {
                Name = "txtReferenciaVariable" + txtContador.Text,
                Location = new Point(345, 30),
                Width = 180,
                Multiline = true,
                Height = 60,
                ScrollBars = ScrollBars.Both,
            };

            panel.Controls.Add(lblNombre);
            panel.Controls.Add(txtNombre);
            panel.Controls.Add(lblUnidad);
            panel.Controls.Add(txtUnidad);
            panel.Controls.Add(lblReferencia);
            panel.Controls.Add(txtReferencia);

            flpDatos.Controls.Add(panel);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Tipos_Analisis objTipoAnalisis = new Tipos_Analisis()
            {
                nombres = txtNombre.Text,
                precio_comun = Convert.ToDecimal(txtPrecioComun.Text),
                precio_derivado = Convert.ToDecimal(txtPrecioDerivado.Text),
                precio_sucursal = Convert.ToDecimal(txtPrecioConvenio.Text),
                descripcion = txtDescripcion.Text,
                muestra = txtMuestra.Text,
            };

            int idTipoAnalisisGenerado = new CN_Tipos_Analisis().Registrar(objTipoAnalisis, out mensaje);

            if (idTipoAnalisisGenerado != 0)
            {
                for (int i = 1; i < Convert.ToInt32(txtContador.Text) + 1; i++)
                {
                    TextBox txtNombreVariable = flpDatos.Controls.Find("txtNombreVariable" + i, true).FirstOrDefault() as TextBox;
                    TextBox txtUnidadVariable = flpDatos.Controls.Find("txtUnidadVariable" + i, true).FirstOrDefault() as TextBox;
                    TextBox txtReferenciaVariable = flpDatos.Controls.Find("txtReferenciaVariable" + i, true).FirstOrDefault() as TextBox;

                    Variables_Analisis objVariableAnalisis = new Variables_Analisis()
                    {
                        oTipo_Analisis = new Tipos_Analisis()
                        {
                            tipo_analisis_id = idTipoAnalisisGenerado,
                        },
                        nombre_variable = txtNombreVariable.Text,
                        unidad = txtUnidadVariable.Text,
                        referencia = txtReferenciaVariable.Text,
                    };

                    int idVaribleAnalisisGenerado = new CN_Variables_Analisis().Registrar(objVariableAnalisis, out mensaje);
                }

                Limpiar();
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtPrecioComun.Text = "";
            txtPrecioDerivado.Text = "";
            txtPrecioConvenio.Text = "";
            txtDescripcion.Text = "";
            txtMuestra.Text = "";

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
