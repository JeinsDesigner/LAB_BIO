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

namespace CapaPresentacion
{
    public partial class frmSubirResultados : Form
    {
        public frmSubirResultados()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text.Length == 8)
            {
                flpOrdenes.Controls.Clear();
                flpDetalles.Controls.Clear();
                flpResultados.Controls.Clear();

                List<Ordenes_Analisis> listaOrdenesAnalisis = new CN_Ordenes_Analisis().ListarPorDNI(Convert.ToInt32(txtDNI.Text));
                listaOrdenesAnalisis.Reverse();
                int contador = 0;

                foreach (Ordenes_Analisis orden in listaOrdenesAnalisis)
                {
                    string mensaje;
                    Usuarios usuario = new CN_Usuarios().BuscarPorId(orden.oUsuario.usuario_id, out mensaje);
                    contador = contador + 1;
                    DateTime fecha = DateTime.Parse(orden.fecha_orden);

                    Panel panel = new Panel
                    {
                        Width = flpOrdenes.Width - 30,
                        Height = 60,
                        Name = "panel" + contador,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(5)
                    };

                    Label lblId = new Label
                    {
                        Text = "Código",
                        AutoSize = true,
                        Location = new Point(15, 10)
                    };

                    TextBox txtId = new TextBox
                    {
                        Name = "txtId" + contador,
                        Location = new Point(15, 30),
                        Width = 20,
                        Text = orden.orden_id.ToString(),
                        ReadOnly = true,
                    };

                    Label lblUsuario = new Label
                    {
                        Text = "Atendido por",
                        AutoSize = true,
                        Location = new Point(60, 10)
                    };

                    TextBox txtUsuario = new TextBox
                    {
                        Name = "txtUsuario" + contador,
                        Width = 90,
                        Location = new Point(60, 30),
                        Text = usuario.nombres.Split(' ')[0] + " " + usuario.apellidos.Split(' ')[0],
                        ReadOnly = true,
                    };

                    Label lblFecha = new Label
                    {
                        Text = "Fecha",
                        AutoSize = true,
                        Location = new Point(170, 10)
                    };

                    TextBox txtFecha = new TextBox
                    {
                        Name = "txtFecha" + contador,
                        Width = 110,
                        Text = fecha.ToString("dd-MM-yyyy HH:mm:ss"),
                        Location = new Point(170, 30),
                        ReadOnly = true,
                    };

                    Button btnSeleccionarOrden = new Button
                    {
                        Text = "Seleccionar" + contador,
                        Location = new Point(280, 30),
                        Tag = orden.orden_id,
                    };

                    btnSeleccionarOrden.Click += btnSeleccionarOrden_Click;

                    panel.Controls.Add(lblId);
                    panel.Controls.Add(txtId);
                    panel.Controls.Add(lblUsuario);
                    panel.Controls.Add(txtUsuario);
                    panel.Controls.Add(lblFecha);
                    panel.Controls.Add(txtFecha);
                    panel.Controls.Add(btnSeleccionarOrden);

                    flpOrdenes.Controls.Add(panel);
                }
            }
        }

        public void btnSeleccionarOrden_Click(object sender, EventArgs e)
        {
            flpDetalles.Controls.Clear();
            flpResultados.Controls.Clear();

            Button btn = (Button)sender;
            int idSeleccionado = (int)btn.Tag;
            int contador = 0;

            List<Detalles_Ordenes> listaDetalleOrdenes = new CN_Detalles_Ordenes().ListarPorId(idSeleccionado);

            foreach (Detalles_Ordenes detalle in listaDetalleOrdenes)
            {
                string mensaje;
                Tipos_Analisis tipoAnalisis = new CN_Tipos_Analisis().BuscarPorId(detalle.oTipoAnalisis.tipo_analisis_id, out mensaje);
                contador += 1;

                Panel panel = new Panel
                {
                    Width = flpOrdenes.Width - 30,
                    Height = 60,
                    Name = "panel" + contador,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5)
                };

                Label lblId = new Label
                {
                    Text = "Código",
                    AutoSize = true,
                    Location = new Point(15, 10)
                };

                TextBox txtId = new TextBox
                {
                    Name = "txtId" + contador,
                    Location = new Point(15, 30),
                    Width = 20,
                    Text = detalle.detalle_id.ToString(),
                    ReadOnly = true,
                };

                Label lblTipoAnalisis = new Label
                {
                    Text = "Tipo Analisis",
                    AutoSize = true,
                    Location = new Point(60, 10)
                };

                TextBox txtTipoAnalisis = new TextBox
                {
                    Name = "txtTipoAnalisis" + contador,
                    Width = 90,
                    Location = new Point(60, 30),
                    Text = tipoAnalisis.nombres,
                    ReadOnly = true,
                };

                Button btnSeleccionarAnalisis = new Button
                {
                    Text = "Seleccionar" + contador,
                    Location = new Point(280, 30),
                    Tag = detalle.detalle_id,
                };

                btnSeleccionarAnalisis.Click += btnSeleccionarAnalisis_Click;

                panel.Controls.Add(lblId);
                panel.Controls.Add(txtId);
                panel.Controls.Add(lblTipoAnalisis);
                panel.Controls.Add(txtTipoAnalisis);
                panel.Controls.Add(btnSeleccionarAnalisis);

                flpDetalles.Controls.Add(panel);
            }
        }

        public void btnSeleccionarAnalisis_Click(object sender, EventArgs e)
        {
            flpResultados.Controls.Clear();
            Button btn = (Button)sender;
            int idSeleccionado = (int)btn.Tag;
            int contador = 0;

            List<Variables_Analisis> listaVariablesAnalisis = new CN_Variables_Analisis().ListarPorId(idSeleccionado);

            foreach (Variables_Analisis variable in listaVariablesAnalisis)
            {
                contador += 1;

                Panel panel = new Panel
                {
                    Width = flpOrdenes.Width - 30,
                    Height = 60,
                    Name = "panel" + contador,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5)
                };

                TextBox txtId = new TextBox
                {
                    Name = "txtId" + contador,
                    Location = new Point(15, 30),
                    Width = 20,
                    Text = variable.variable_id.ToString(),
                    ReadOnly = true,
                    Visible = false,
                };

                TextBox txtNombre = new TextBox
                {
                    Name = "txtTipoAnalisis" + contador,
                    Width = 90,
                    Location = new Point(15, 30),
                    Text = variable.nombre_variable,
                    ReadOnly = true,
                };

                TextBox txtValor = new TextBox
                {
                    Name = "txtTipoAnalisis" + contador,
                    Width = 90,
                    Location = new Point(110, 30),
                };

                TextBox txtUnidad = new TextBox
                {
                    Name = "txtTipoAnalisis" + contador,
                    Width = 90,
                    Location = new Point(200, 30),
                    Text = variable.unidad,
                    ReadOnly = true,
                };

                TextBox txtReferencia = new TextBox
                {
                    Name = "txtTipoAnalisis" + contador,
                    Width = 90,
                    Location = new Point(250, 30),
                    Text = variable.referencia,
                    ReadOnly = true,
                };

                panel.Controls.Add(txtId);
                panel.Controls.Add(txtNombre);
                panel.Controls.Add(txtValor);
                panel.Controls.Add(txtUnidad);
                panel.Controls.Add(txtReferencia);

                flpResultados.Controls.Add(panel);
            }
        }
    }
}
