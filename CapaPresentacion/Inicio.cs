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
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuarios usuariosActual;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;

        public Inicio(Usuarios oUsuario = null)
        {
            if (oUsuario == null)
            {
                usuariosActual = new Usuarios() { nombres = "Usuario", apellidos = "Prueba", usuario_id =1 };
            }
            else
            {
                usuariosActual = oUsuario;
            }

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permisos> listaPermisos = new CN_Permisos().Listar(usuariosActual.usuario_id);

            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = listaPermisos.Any(m => m.nombre_menu == iconmenu.Name);
                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }

            lblusuario.Text = usuariosActual.nombres + " " + usuariosActual.apellidos;

        }

        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void menuOrdenesAnalisis_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmAnalisis());
        }

        private void menuPacientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmPacientes());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmReportes());
        }

        private void menuResultados_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmResultados());
        }

        private void menuTiposDeAnalisis_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmTiposAnalisis());
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmAcercaDe());
        }
    }
}
