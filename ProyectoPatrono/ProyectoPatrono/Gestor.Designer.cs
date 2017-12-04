namespace ProyectoPatrono
{
    partial class Gestor
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
            this.dgvDatosBanco = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.btnXML = new System.Windows.Forms.Button();
            this.tabGestor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbApellido1 = new System.Windows.Forms.Label();
            this.lbEmpleado = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lbResgitroEditado = new System.Windows.Forms.Label();
            this.lbTituloActual = new System.Windows.Forms.Label();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.dgvEdicion = new System.Windows.Forms.DataGridView();
            this.dgvActual = new System.Windows.Forms.DataGridView();
            this.lbtitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBanco)).BeginInit();
            this.tabGestor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActual)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosBanco
            // 
            this.dgvDatosBanco.AllowUserToAddRows = false;
            this.dgvDatosBanco.AllowUserToDeleteRows = false;
            this.dgvDatosBanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosBanco.Location = new System.Drawing.Point(3, 28);
            this.dgvDatosBanco.Name = "dgvDatosBanco";
            this.dgvDatosBanco.ReadOnly = true;
            this.dgvDatosBanco.Size = new System.Drawing.Size(963, 285);
            this.dgvDatosBanco.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Maroon;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargar.Location = new System.Drawing.Point(231, 346);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(159, 28);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar Archivo Excel";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "OpenFileDialog1";
            this.OFD.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_FileOk_1);
            // 
            // btnXML
            // 
            this.btnXML.BackColor = System.Drawing.Color.Maroon;
            this.btnXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXML.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXML.Location = new System.Drawing.Point(604, 346);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(159, 28);
            this.btnXML.TabIndex = 3;
            this.btnXML.Text = "Cargar Archivo XML";
            this.btnXML.UseVisualStyleBackColor = false;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // tabGestor
            // 
            this.tabGestor.Controls.Add(this.tabPage1);
            this.tabGestor.Controls.Add(this.tabPage2);
            this.tabGestor.Location = new System.Drawing.Point(12, 53);
            this.tabGestor.Name = "tabGestor";
            this.tabGestor.SelectedIndex = 0;
            this.tabGestor.Size = new System.Drawing.Size(980, 446);
            this.tabGestor.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDatosBanco);
            this.tabPage1.Controls.Add(this.btnXML);
            this.tabPage1.Controls.Add(this.btnCargar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Recibidos del Banco";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtIdEmpleado);
            this.tabPage2.Controls.Add(this.lbId);
            this.tabPage2.Controls.Add(this.txtApellido2);
            this.tabPage2.Controls.Add(this.txtApellido1);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.btnConsultar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbApellido1);
            this.tabPage2.Controls.Add(this.lbEmpleado);
            this.tabPage2.Controls.Add(this.btnExportar);
            this.tabPage2.Controls.Add(this.lbResgitroEditado);
            this.tabPage2.Controls.Add(this.lbTituloActual);
            this.tabPage2.Controls.Add(this.btnAgregarPago);
            this.tabPage2.Controls.Add(this.dgvEdicion);
            this.tabPage2.Controls.Add(this.dgvActual);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(221, 12);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(137, 20);
            this.txtIdEmpleado.TabIndex = 18;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(79, 15);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(71, 13);
            this.lbId.TabIndex = 17;
            this.lbId.Text = "ID Empleado:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(505, 47);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.ReadOnly = true;
            this.txtApellido2.Size = new System.Drawing.Size(200, 20);
            this.txtApellido2.TabIndex = 16;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(505, 12);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.ReadOnly = true;
            this.txtApellido1.Size = new System.Drawing.Size(200, 20);
            this.txtApellido1.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(221, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(137, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultar.Location = new System.Drawing.Point(750, 15);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(216, 29);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido2:";
            // 
            // lbApellido1
            // 
            this.lbApellido1.AutoSize = true;
            this.lbApellido1.Location = new System.Drawing.Point(434, 15);
            this.lbApellido1.Name = "lbApellido1";
            this.lbApellido1.Size = new System.Drawing.Size(56, 13);
            this.lbApellido1.TabIndex = 11;
            this.lbApellido1.Text = "Apellido1: ";
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.AutoSize = true;
            this.lbEmpleado.Location = new System.Drawing.Point(79, 50);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(100, 13);
            this.lbEmpleado.TabIndex = 10;
            this.lbEmpleado.Text = "Nombre Empleado: ";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Maroon;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportar.Location = new System.Drawing.Point(872, 387);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(94, 30);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbResgitroEditado
            // 
            this.lbResgitroEditado.AutoSize = true;
            this.lbResgitroEditado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResgitroEditado.Location = new System.Drawing.Point(695, 394);
            this.lbResgitroEditado.Name = "lbResgitroEditado";
            this.lbResgitroEditado.Size = new System.Drawing.Size(109, 16);
            this.lbResgitroEditado.TabIndex = 8;
            this.lbResgitroEditado.Text = "Registro Editado";
            // 
            // lbTituloActual
            // 
            this.lbTituloActual.AutoSize = true;
            this.lbTituloActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloActual.Location = new System.Drawing.Point(200, 396);
            this.lbTituloActual.Name = "lbTituloActual";
            this.lbTituloActual.Size = new System.Drawing.Size(99, 16);
            this.lbTituloActual.TabIndex = 7;
            this.lbTituloActual.Text = "Registro Actual";
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPago.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarPago.Location = new System.Drawing.Point(750, 63);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(216, 29);
            this.btnAgregarPago.TabIndex = 3;
            this.btnAgregarPago.Text = "Agregar Pago";
            this.btnAgregarPago.UseVisualStyleBackColor = false;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // dgvEdicion
            // 
            this.dgvEdicion.AllowUserToAddRows = false;
            this.dgvEdicion.AllowUserToDeleteRows = false;
            this.dgvEdicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEdicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdicion.Location = new System.Drawing.Point(487, 98);
            this.dgvEdicion.Name = "dgvEdicion";
            this.dgvEdicion.ReadOnly = true;
            this.dgvEdicion.Size = new System.Drawing.Size(479, 285);
            this.dgvEdicion.TabIndex = 2;
            // 
            // dgvActual
            // 
            this.dgvActual.AllowUserToAddRows = false;
            this.dgvActual.AllowUserToDeleteRows = false;
            this.dgvActual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActual.Location = new System.Drawing.Point(6, 98);
            this.dgvActual.Name = "dgvActual";
            this.dgvActual.ReadOnly = true;
            this.dgvActual.Size = new System.Drawing.Size(475, 285);
            this.dgvActual.TabIndex = 1;
            // 
            // lbtitulo
            // 
            this.lbtitulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbtitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbtitulo.Location = new System.Drawing.Point(12, 13);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Padding = new System.Windows.Forms.Padding(400, 5, 0, 0);
            this.lbtitulo.Size = new System.Drawing.Size(980, 37);
            this.lbtitulo.TabIndex = 6;
            this.lbtitulo.Text = "Gestor del Patrono";
            // 
            // Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1004, 504);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.tabGestor);
            this.Name = "Gestor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor";
            this.Load += new System.EventHandler(this.Gestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBanco)).EndInit();
            this.tabGestor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosBanco;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.TabControl tabGestor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvEdicion;
        private System.Windows.Forms.DataGridView dgvActual;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.Label lbTituloActual;
        private System.Windows.Forms.Label lbResgitroEditado;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbApellido1;
        private System.Windows.Forms.Label lbEmpleado;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtIdEmpleado;
    }
}

