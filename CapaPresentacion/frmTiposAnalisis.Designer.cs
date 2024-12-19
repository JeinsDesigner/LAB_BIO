namespace CapaPresentacion
{
    partial class frmTiposAnalisis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnAgregarExamen = new FontAwesome.Sharp.IconButton();
            this.flpDatos = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioConvenio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioDerivado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioComun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(700, 337);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(277, 36);
            this.iconButton1.TabIndex = 41;
            this.iconButton1.Text = "Guardar Registro";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnAgregarExamen
            // 
            this.btnAgregarExamen.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarExamen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarExamen.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarExamen.IconColor = System.Drawing.Color.White;
            this.btnAgregarExamen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarExamen.IconSize = 25;
            this.btnAgregarExamen.Location = new System.Drawing.Point(31, 280);
            this.btnAgregarExamen.Name = "btnAgregarExamen";
            this.btnAgregarExamen.Size = new System.Drawing.Size(637, 36);
            this.btnAgregarExamen.TabIndex = 40;
            this.btnAgregarExamen.Text = "Agregar Variables";
            this.btnAgregarExamen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarExamen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarExamen.UseVisualStyleBackColor = false;
            this.btnAgregarExamen.Click += new System.EventHandler(this.btnAgregarExamen_Click);
            // 
            // flpDatos
            // 
            this.flpDatos.AutoScroll = true;
            this.flpDatos.Location = new System.Drawing.Point(31, 337);
            this.flpDatos.Name = "flpDatos";
            this.flpDatos.Size = new System.Drawing.Size(637, 185);
            this.flpDatos.TabIndex = 39;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(17, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nombre del Análisis";
            // 
            // txtPrecioConvenio
            // 
            this.txtPrecioConvenio.Location = new System.Drawing.Point(777, 68);
            this.txtPrecioConvenio.Name = "txtPrecioConvenio";
            this.txtPrecioConvenio.Size = new System.Drawing.Size(200, 20);
            this.txtPrecioConvenio.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(774, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Precio Convenio";
            // 
            // txtPrecioDerivado
            // 
            this.txtPrecioDerivado.Location = new System.Drawing.Point(522, 68);
            this.txtPrecioDerivado.Name = "txtPrecioDerivado";
            this.txtPrecioDerivado.Size = new System.Drawing.Size(200, 20);
            this.txtPrecioDerivado.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(519, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Precio Derivado";
            // 
            // txtPrecioComun
            // 
            this.txtPrecioComun.Location = new System.Drawing.Point(266, 68);
            this.txtPrecioComun.Name = "txtPrecioComun";
            this.txtPrecioComun.Size = new System.Drawing.Size(200, 20);
            this.txtPrecioComun.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(263, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Precio Común";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tipo de Análisis";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1050, 214);
            this.label1.TabIndex = 25;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(17, 119);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 82);
            this.txtDescripcion.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Descripción";
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(700, 280);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(24, 20);
            this.txtContador.TabIndex = 44;
            this.txtContador.Text = "0";
            this.txtContador.Visible = false;
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(266, 119);
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(200, 20);
            this.txtMuestra.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(263, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Tipo de Muestra";
            // 
            // frmTiposAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1050, 596);
            this.Controls.Add(this.txtMuestra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnAgregarExamen);
            this.Controls.Add(this.flpDatos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecioConvenio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioDerivado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioComun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTiposAnalisis";
            this.Text = "frmTiposAnalisis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnAgregarExamen;
        private System.Windows.Forms.FlowLayoutPanel flpDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioConvenio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioDerivado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioComun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.Label label8;
    }
}