
namespace AgenciaSeguros
{
    partial class GestionPoliza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPoliza));
            this.botonAtras = new System.Windows.Forms.Label();
            this.botonAñadir = new System.Windows.Forms.Label();
            this.estadoCB = new System.Windows.Forms.ComboBox();
            this.labelPoliza = new System.Windows.Forms.Label();
            this.labelPoblación = new System.Windows.Forms.Label();
            this.importeTB = new System.Windows.Forms.TextBox();
            this.labelImporte = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.fechaDP = new System.Windows.Forms.DateTimePicker();
            this.tablaClientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarTB = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.numPolizaTB = new TextBoxNumerico.TextBoxNumerico();
            this.labelError = new System.Windows.Forms.Label();
            this.observacionesTB = new TextBoxNumerico.TextBoxNumerico();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAtras
            // 
            this.botonAtras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAtras.AutoSize = true;
            this.botonAtras.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.botonAtras.Location = new System.Drawing.Point(406, 607);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(63, 23);
            this.botonAtras.TabIndex = 27;
            this.botonAtras.Text = "Atrás";
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            this.botonAtras.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonAtras.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // botonAñadir
            // 
            this.botonAñadir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAñadir.AutoSize = true;
            this.botonAñadir.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.botonAñadir.Location = new System.Drawing.Point(294, 607);
            this.botonAñadir.Name = "botonAñadir";
            this.botonAñadir.Size = new System.Drawing.Size(78, 23);
            this.botonAñadir.TabIndex = 26;
            this.botonAñadir.Text = "Añadir";
            this.botonAñadir.Click += new System.EventHandler(this.boton_Click);
            this.botonAñadir.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonAñadir.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // estadoCB
            // 
            this.estadoCB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCB.FormattingEnabled = true;
            this.estadoCB.Location = new System.Drawing.Point(157, 151);
            this.estadoCB.Name = "estadoCB";
            this.estadoCB.Size = new System.Drawing.Size(195, 24);
            this.estadoCB.TabIndex = 2;
            this.estadoCB.TabStop = false;
            this.estadoCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // labelPoliza
            // 
            this.labelPoliza.AutoSize = true;
            this.labelPoliza.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoliza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelPoliza.Location = new System.Drawing.Point(12, 35);
            this.labelPoliza.Name = "labelPoliza";
            this.labelPoliza.Size = new System.Drawing.Size(139, 16);
            this.labelPoliza.TabIndex = 14;
            this.labelPoliza.Text = "Número de Póliza:";
            // 
            // labelPoblación
            // 
            this.labelPoblación.AutoSize = true;
            this.labelPoblación.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoblación.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelPoblación.Location = new System.Drawing.Point(377, 36);
            this.labelPoblación.Name = "labelPoblación";
            this.labelPoblación.Size = new System.Drawing.Size(119, 16);
            this.labelPoblación.TabIndex = 12;
            this.labelPoblación.Text = "Observaciones:";
            // 
            // importeTB
            // 
            this.importeTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeTB.Location = new System.Drawing.Point(157, 92);
            this.importeTB.Name = "importeTB";
            this.importeTB.Size = new System.Drawing.Size(195, 22);
            this.importeTB.TabIndex = 1;
            this.importeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.importeTB_KeyPress);
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelImporte.Location = new System.Drawing.Point(12, 95);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(74, 16);
            this.labelImporte.TabIndex = 0;
            this.labelImporte.Text = "Importe:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelEstado.Location = new System.Drawing.Point(12, 155);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(62, 16);
            this.labelEstado.TabIndex = 29;
            this.labelEstado.Text = "Estado:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelFecha.Location = new System.Drawing.Point(12, 215);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(56, 16);
            this.labelFecha.TabIndex = 30;
            this.labelFecha.Text = "Fecha:";
            // 
            // fechaDP
            // 
            this.fechaDP.CustomFormat = "";
            this.fechaDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDP.Location = new System.Drawing.Point(157, 212);
            this.fechaDP.Name = "fechaDP";
            this.fechaDP.Size = new System.Drawing.Size(195, 20);
            this.fechaDP.TabIndex = 3;
            this.fechaDP.Value = new System.DateTime(2022, 2, 25, 0, 0, 0, 0);
            // 
            // tablaClientes
            // 
            this.tablaClientes.AllowUserToAddRows = false;
            this.tablaClientes.AllowUserToDeleteRows = false;
            this.tablaClientes.AllowUserToOrderColumns = true;
            this.tablaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellidos,
            this.Telefono,
            this.Localidad,
            this.Cod_Postal,
            this.Provincia,
            this.Tipo});
            this.tablaClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tablaClientes.Location = new System.Drawing.Point(12, 288);
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.ReadOnly = true;
            this.tablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaClientes.Size = new System.Drawing.Size(756, 316);
            this.tablaClientes.TabIndex = 32;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Poblacion";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // Cod_Postal
            // 
            this.Cod_Postal.HeaderText = "Cod_Postal";
            this.Cod_Postal.Name = "Cod_Postal";
            this.Cod_Postal.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // buscarTB
            // 
            this.buscarTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarTB.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.buscarTB.Location = new System.Drawing.Point(502, 214);
            this.buscarTB.Name = "buscarTB";
            this.buscarTB.Size = new System.Drawing.Size(266, 20);
            this.buscarTB.TabIndex = 5;
            this.buscarTB.TextChanged += new System.EventHandler(this.buscarTB_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelBuscar.Location = new System.Drawing.Point(377, 216);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(84, 16);
            this.labelBuscar.TabIndex = 33;
            this.labelBuscar.Text = "Buscador: ";
            // 
            // numPolizaTB
            // 
            this.numPolizaTB.EscribirLetras = false;
            this.numPolizaTB.Location = new System.Drawing.Point(157, 31);
            this.numPolizaTB.MaxLetras = 30;
            this.numPolizaTB.Name = "numPolizaTB";
            this.numPolizaTB.Size = new System.Drawing.Size(195, 20);
            this.numPolizaTB.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(15, 256);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 14);
            this.labelError.TabIndex = 49;
            // 
            // observacionesTB
            // 
            this.observacionesTB.EscribirLetras = true;
            this.observacionesTB.Location = new System.Drawing.Point(502, 36);
            this.observacionesTB.MaxLetras = 50;
            this.observacionesTB.Multiline = true;
            this.observacionesTB.Name = "observacionesTB";
            this.observacionesTB.Size = new System.Drawing.Size(266, 78);
            this.observacionesTB.TabIndex = 4;
            // 
            // GestionPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 639);
            this.Controls.Add(this.observacionesTB);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.numPolizaTB);
            this.Controls.Add(this.buscarTB);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.tablaClientes);
            this.Controls.Add(this.fechaDP);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.importeTB);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.estadoCB);
            this.Controls.Add(this.botonAñadir);
            this.Controls.Add(this.labelPoliza);
            this.Controls.Add(this.labelPoblación);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GestionPoliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionPoliza";
            this.Load += new System.EventHandler(this.GestionPoliza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label botonAtras;
        public System.Windows.Forms.Label botonAñadir;
        public System.Windows.Forms.ComboBox estadoCB;
        private System.Windows.Forms.Label labelPoliza;
        private System.Windows.Forms.Label labelPoblación;
        public System.Windows.Forms.TextBox importeTB;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelFecha;
        public System.Windows.Forms.DataGridView tablaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        public System.Windows.Forms.DateTimePicker fechaDP;
        private System.Windows.Forms.TextBox buscarTB;
        private System.Windows.Forms.Label labelBuscar;
        public TextBoxNumerico.TextBoxNumerico numPolizaTB;
        private System.Windows.Forms.Label labelError;
        public TextBoxNumerico.TextBoxNumerico observacionesTB;
    }
}