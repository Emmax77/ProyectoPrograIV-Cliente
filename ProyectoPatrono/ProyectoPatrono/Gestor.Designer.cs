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
            this.lbDatosRecibidos = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.btnXML = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosBanco
            // 
            this.dgvDatosBanco.AllowUserToAddRows = false;
            this.dgvDatosBanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosBanco.Location = new System.Drawing.Point(12, 56);
            this.dgvDatosBanco.Name = "dgvDatosBanco";
            this.dgvDatosBanco.Size = new System.Drawing.Size(598, 285);
            this.dgvDatosBanco.TabIndex = 0;
            // 
            // lbDatosRecibidos
            // 
            this.lbDatosRecibidos.AutoSize = true;
            this.lbDatosRecibidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosRecibidos.Location = new System.Drawing.Point(203, 19);
            this.lbDatosRecibidos.Name = "lbDatosRecibidos";
            this.lbDatosRecibidos.Size = new System.Drawing.Size(226, 20);
            this.lbDatosRecibidos.TabIndex = 1;
            this.lbDatosRecibidos.Text = "Datos Recibidos del Banco";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(12, 380);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(159, 28);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar Archivo Excel";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "OpenFileDialog1";
            this.OFD.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_FileOk_1);
            // 
            // btnXML
            // 
            this.btnXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML.Location = new System.Drawing.Point(237, 380);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(159, 28);
            this.btnXML.TabIndex = 3;
            this.btnXML.Text = "Cargar Archivo XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(451, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cargar Archivo TXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lbDatosRecibidos);
            this.Controls.Add(this.dgvDatosBanco);
            this.Name = "Gestor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor";
            this.Load += new System.EventHandler(this.Gestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosBanco;
        private System.Windows.Forms.Label lbDatosRecibidos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button button1;
    }
}

