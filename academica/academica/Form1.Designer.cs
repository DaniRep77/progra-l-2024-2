
namespace academica
{
    partial class Form1
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
            this.lblBuscarAlumnos = new System.Windows.Forms.Label();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.grdDatosAlumnos = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnNuevoAlumno = new System.Windows.Forms.Button();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.lblRegistrosAlumnos = new System.Windows.Forms.Label();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.grbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.lblDuiAlumno = new System.Windows.Forms.Label();
            this.txtDuiAlumno = new System.Windows.Forms.TextBox();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.lblDireccionAlumno = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).BeginInit();
            this.grbEdicionAlumno.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbDatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarAlumnos
            // 
            this.lblBuscarAlumnos.AutoSize = true;
            this.lblBuscarAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarAlumnos.Location = new System.Drawing.Point(553, 25);
            this.lblBuscarAlumnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarAlumnos.Name = "lblBuscarAlumnos";
            this.lblBuscarAlumnos.Size = new System.Drawing.Size(117, 29);
            this.lblBuscarAlumnos.TabIndex = 15;
            this.lblBuscarAlumnos.Text = "BUSCAR:";
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(674, 31);
            this.txtBuscarAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(461, 22);
            this.txtBuscarAlumnos.TabIndex = 16;
            // 
            // grdDatosAlumnos
            // 
            this.grdDatosAlumnos.AllowUserToAddRows = false;
            this.grdDatosAlumnos.AllowUserToDeleteRows = false;
            this.grdDatosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdDatosAlumnos.Location = new System.Drawing.Point(558, 63);
            this.grdDatosAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.grdDatosAlumnos.Name = "grdDatosAlumnos";
            this.grdDatosAlumnos.ReadOnly = true;
            this.grdDatosAlumnos.RowHeadersWidth = 51;
            this.grdDatosAlumnos.Size = new System.Drawing.Size(579, 310);
            this.grdDatosAlumnos.TabIndex = 14;
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "ID";
            this.idAlumno.MinimumWidth = 6;
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            this.idAlumno.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnNuevoAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(306, 381);
            this.grbEdicionAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionAlumno.Size = new System.Drawing.Size(392, 71);
            this.grbEdicionAlumno.TabIndex = 13;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Navegacion";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(252, 23);
            this.btnEliminarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(129, 47);
            this.btnEliminarAlumno.TabIndex = 6;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.Location = new System.Drawing.Point(116, 23);
            this.btnModificarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(139, 47);
            this.btnModificarAlumno.TabIndex = 5;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlumno.Location = new System.Drawing.Point(8, 23);
            this.btnNuevoAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(111, 47);
            this.btnNuevoAlumno.TabIndex = 4;
            this.btnNuevoAlumno.Text = "Nuevo";
            this.btnNuevoAlumno.UseVisualStyleBackColor = true;
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.lblRegistrosAlumnos);
            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(14, 381);
            this.grbNavegacionAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(284, 71);
            this.grbNavegacionAlumno.TabIndex = 12;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // lblRegistrosAlumnos
            // 
            this.lblRegistrosAlumnos.AutoSize = true;
            this.lblRegistrosAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosAlumnos.Location = new System.Drawing.Point(101, 30);
            this.lblRegistrosAlumnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosAlumnos.Name = "lblRegistrosAlumnos";
            this.lblRegistrosAlumnos.Size = new System.Drawing.Size(77, 29);
            this.lblRegistrosAlumnos.TabIndex = 10;
            this.lblRegistrosAlumnos.Text = "x de n";
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoAlumno.Location = new System.Drawing.Point(229, 17);
            this.btnUltimoAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(47, 47);
            this.btnUltimoAlumno.TabIndex = 3;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(185, 17);
            this.btnSiguienteAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(47, 47);
            this.btnSiguienteAlumno.TabIndex = 2;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(53, 22);
            this.btnAnteriorAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(47, 47);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(9, 22);
            this.btnPrimeroAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(47, 47);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            // 
            // grbDatosAlumno
            // 
            this.grbDatosAlumno.Controls.Add(this.lblDuiAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtDuiAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblCodigoAlumno);
            this.grbDatosAlumno.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumno.Enabled = false;
            this.grbDatosAlumno.Location = new System.Drawing.Point(13, 13);
            this.grbDatosAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosAlumno.Name = "grbDatosAlumno";
            this.grbDatosAlumno.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosAlumno.Size = new System.Drawing.Size(520, 318);
            this.grbDatosAlumno.TabIndex = 11;
            this.grbDatosAlumno.TabStop = false;
            this.grbDatosAlumno.Text = "Datos Alumnos";
            // 
            // lblDuiAlumno
            // 
            this.lblDuiAlumno.AutoSize = true;
            this.lblDuiAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiAlumno.Location = new System.Drawing.Point(41, 246);
            this.lblDuiAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuiAlumno.Name = "lblDuiAlumno";
            this.lblDuiAlumno.Size = new System.Drawing.Size(55, 29);
            this.lblDuiAlumno.TabIndex = 9;
            this.lblDuiAlumno.Text = "Dui:";
            // 
            // txtDuiAlumno
            // 
            this.txtDuiAlumno.Location = new System.Drawing.Point(175, 251);
            this.txtDuiAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuiAlumno.Name = "txtDuiAlumno";
            this.txtDuiAlumno.Size = new System.Drawing.Size(132, 22);
            this.txtDuiAlumno.TabIndex = 8;
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(41, 191);
            this.lblTelefonoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(116, 29);
            this.lblTelefonoAlumno.TabIndex = 7;
            this.lblTelefonoAlumno.Text = "Telefono:";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(175, 196);
            this.txtTelefonoAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(132, 22);
            this.txtTelefonoAlumno.TabIndex = 6;
            // 
            // lblDireccionAlumno
            // 
            this.lblDireccionAlumno.AutoSize = true;
            this.lblDireccionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionAlumno.Location = new System.Drawing.Point(41, 143);
            this.lblDireccionAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionAlumno.Name = "lblDireccionAlumno";
            this.lblDireccionAlumno.Size = new System.Drawing.Size(121, 29);
            this.lblDireccionAlumno.TabIndex = 5;
            this.lblDireccionAlumno.Text = "Direccion:";
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(175, 148);
            this.txtDireccionAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(333, 22);
            this.txtDireccionAlumno.TabIndex = 4;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(41, 94);
            this.lblNombreAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(107, 29);
            this.lblNombreAlumno.TabIndex = 3;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(175, 98);
            this.txtNombreAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(333, 22);
            this.txtNombreAlumno.TabIndex = 2;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(41, 46);
            this.lblCodigoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(98, 29);
            this.lblCodigoAlumno.TabIndex = 1;
            this.lblCodigoAlumno.Text = "Codigo:";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(175, 50);
            this.txtCodigoAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoAlumno.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 486);
            this.Controls.Add(this.lblBuscarAlumnos);
            this.Controls.Add(this.txtBuscarAlumnos);
            this.Controls.Add(this.grdDatosAlumnos);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).EndInit();
            this.grbEdicionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbDatosAlumno.ResumeLayout(false);
            this.grbDatosAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarAlumnos;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.DataGridView grdDatosAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnNuevoAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.Label lblRegistrosAlumnos;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.GroupBox grbDatosAlumno;
        private System.Windows.Forms.Label lblDuiAlumno;
        private System.Windows.Forms.TextBox txtDuiAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.Label lblDireccionAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
    }
}

