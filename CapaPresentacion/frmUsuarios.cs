using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            List<Roles> listaRoles = new CN_Roles().Listar();

            foreach (Roles item in listaRoles) 
            {
                cboRol.Items.Add(new OpcionCombo() { valor = item.rol_id, texto = item.descripcion});
            }
            cboRol.DisplayMember = "texto";
            cboRol.ValueMember = "valor";
            cboRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { valor = columna.Name, texto = columna.HeaderText});
                }
            }
            cboBusqueda.DisplayMember = "texto";
            cboBusqueda.ValueMember = "valor";
            cboBusqueda.SelectedIndex = 0;

            //MOSTRAR TODOS LOS USUARIOS
            List<Usuarios> listaUsuarios = new CN_Usuarios().Listar();

            foreach (Usuarios item in listaUsuarios)
            {
                dgvData.Rows.Add(new object[] {
                    "",
                    item.usuario_id,
                    item.dni,
                    item.nombres,
                    item.apellidos,
                    item.telefono,
                    item.email,
                    item.clave,
                    item.oRol.rol_id,
                    item.oRol.descripcion
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuarios objUsuario = new Usuarios()
            {
                usuario_id = Convert.ToInt32(txtId.Text),
                nombres = txtNombres.Text,
                apellidos = txtApellidos.Text,
                telefono = txtTelefono.Text,
                dni = txtDNI.Text,
                email = txtEmail.Text,
                clave = txtClave.Text,
                oRol = new Roles()
                {
                    rol_id = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).valor)
                }
            };

            if (objUsuario.usuario_id == 0)
            {
                int idUsuarioGenerado = new CN_Usuarios().Registrar(objUsuario, out mensaje);

                if (idUsuarioGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] 
                    {
                        "",
                        idUsuarioGenerado,
                        txtDNI.Text,
                        txtNombres.Text,
                        txtApellidos.Text,
                        txtTelefono.Text,
                        txtEmail.Text,
                        txtClave.Text,
                        ((OpcionCombo)cboRol.SelectedItem).valor.ToString(),
                        ((OpcionCombo)cboRol.SelectedItem).texto.ToString()
                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Usuarios().Editar(objUsuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["usuario_id"].Value = txtId.Text;
                    row.Cells["dni"].Value = txtDNI.Text;
                    row.Cells["nombres"].Value = txtNombres.Text;
                    row.Cells["apellidos"].Value = txtApellidos.Text;
                    row.Cells["telefono"].Value = txtTelefono.Text;
                    row.Cells["email"].Value = txtEmail.Text;
                    row.Cells["clave"].Value = txtClave.Text;
                    row.Cells["rol_id"].Value = ((OpcionCombo)cboRol.SelectedItem).valor.ToString();
                    row.Cells["rol"].Value = ((OpcionCombo)cboRol.SelectedItem).texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDNI.Text = "";
            cboRol.SelectedIndex = 0;
            txtEmail.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";

            txtNombres.Select();
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvData.Rows[indice].Cells["usuario_id"].Value.ToString();
                    txtDNI.Text = dgvData.Rows[indice].Cells["dni"].Value.ToString();
                    txtNombres.Text = dgvData.Rows[indice].Cells["nombres"].Value.ToString();
                    txtApellidos.Text = dgvData.Rows[indice].Cells["apellidos"].Value.ToString();
                    txtTelefono.Text = dgvData.Rows[indice].Cells["telefono"].Value.ToString();
                    txtEmail.Text = dgvData.Rows[indice].Cells["email"].Value.ToString();
                    txtClave.Text = dgvData.Rows[indice].Cells["clave"].Value.ToString();
                    txtConfirmarClave.Text = dgvData.Rows[indice].Cells["clave"].Value.ToString();

                    foreach (OpcionCombo oc in cboRol.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["rol_id"].Value))
                        {
                            int indice_combo = cboRol.Items.IndexOf(oc);
                            cboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar este usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuarios objUsuario = new Usuarios()
                    {
                        usuario_id = Convert.ToInt32(txtId.Text),
                    };

                    bool respuesta = new CN_Usuarios().Eliminar(objUsuario, out mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
