namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuOrdenesAnalisis = new FontAwesome.Sharp.IconMenuItem();
            this.menuPacientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuResultados = new FontAwesome.Sharp.IconMenuItem();
            this.menuTiposDeAnalisis = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuOrdenesAnalisis,
            this.menuPacientes,
            this.menuResultados,
            this.menuTiposDeAnalisis,
            this.menuReportes,
            this.menuAcercaDe});
            this.menu.Location = new System.Drawing.Point(0, 59);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(927, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(122, 69);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuOrdenesAnalisis
            // 
            this.menuOrdenesAnalisis.AutoSize = false;
            this.menuOrdenesAnalisis.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.menuOrdenesAnalisis.IconColor = System.Drawing.Color.Black;
            this.menuOrdenesAnalisis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuOrdenesAnalisis.IconSize = 50;
            this.menuOrdenesAnalisis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuOrdenesAnalisis.Name = "menuOrdenesAnalisis";
            this.menuOrdenesAnalisis.Size = new System.Drawing.Size(122, 69);
            this.menuOrdenesAnalisis.Text = "Ordenes Análisis";
            this.menuOrdenesAnalisis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuOrdenesAnalisis.Click += new System.EventHandler(this.menuOrdenesAnalisis_Click);
            // 
            // menuPacientes
            // 
            this.menuPacientes.AutoSize = false;
            this.menuPacientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuPacientes.IconColor = System.Drawing.Color.Black;
            this.menuPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuPacientes.IconSize = 50;
            this.menuPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuPacientes.Name = "menuPacientes";
            this.menuPacientes.Size = new System.Drawing.Size(122, 69);
            this.menuPacientes.Text = "Pacientes";
            this.menuPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuPacientes.Click += new System.EventHandler(this.menuPacientes_Click);
            // 
            // menuResultados
            // 
            this.menuResultados.AutoSize = false;
            this.menuResultados.IconChar = FontAwesome.Sharp.IconChar.FlaskVial;
            this.menuResultados.IconColor = System.Drawing.Color.Black;
            this.menuResultados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuResultados.IconSize = 50;
            this.menuResultados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuResultados.Name = "menuResultados";
            this.menuResultados.Size = new System.Drawing.Size(122, 69);
            this.menuResultados.Text = "Resultados";
            this.menuResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuResultados.Click += new System.EventHandler(this.menuResultados_Click);
            // 
            // menuTiposDeAnalisis
            // 
            this.menuTiposDeAnalisis.AutoSize = false;
            this.menuTiposDeAnalisis.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.menuTiposDeAnalisis.IconColor = System.Drawing.Color.Black;
            this.menuTiposDeAnalisis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuTiposDeAnalisis.IconSize = 50;
            this.menuTiposDeAnalisis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuTiposDeAnalisis.Name = "menuTiposDeAnalisis";
            this.menuTiposDeAnalisis.Size = new System.Drawing.Size(122, 69);
            this.menuTiposDeAnalisis.Text = "Tipos de Análisis";
            this.menuTiposDeAnalisis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuTiposDeAnalisis.Click += new System.EventHandler(this.menuTiposDeAnalisis_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 50;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(122, 69);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.AutoSize = false;
            this.menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.menuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcercaDe.IconSize = 50;
            this.menuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(122, 69);
            this.menuAcercaDe.Text = "Acerca de";
            this.menuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAcercaDe.Click += new System.EventHandler(this.menuAcercaDe_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(927, 59);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "LAB BIO";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 132);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(927, 510);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(690, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(740, 18);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(61, 15);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "lblusuario";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 642);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuAcercaDe;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuTiposDeAnalisis;
        private FontAwesome.Sharp.IconMenuItem menuPacientes;
        private FontAwesome.Sharp.IconMenuItem menuResultados;
        private FontAwesome.Sharp.IconMenuItem menuOrdenesAnalisis;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
    }
}

