
namespace AgenciaSeguros
{
    partial class GestionInforme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionInforme));
            this.labelEloySeguros = new System.Windows.Forms.Label();
            this.imagenLogo = new System.Windows.Forms.PictureBox();
            this.clienteCB2 = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cargoClientes2 = new AgenciaSeguros.cargoClientes2();
            this.clienteCB1 = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargoClientes = new AgenciaSeguros.cargoClientes();
            this.clientesGB = new System.Windows.Forms.GroupBox();
            this.fechasGB = new System.Windows.Forms.GroupBox();
            this.fechaDP2 = new System.Windows.Forms.DateTimePicker();
            this.fechaDP = new System.Windows.Forms.DateTimePicker();
            this.clienteTableAdapter = new AgenciaSeguros.cargoClientesTableAdapters.clienteTableAdapter();
            this.clienteTableAdapter1 = new AgenciaSeguros.cargoClientes2TableAdapters.clienteTableAdapter();
            this.botonGenerar = new System.Windows.Forms.Label();
            this.determinadoEstadoRB = new System.Windows.Forms.RadioButton();
            this.todasRB = new System.Windows.Forms.RadioButton();
            this.estadoCB = new System.Windows.Forms.ComboBox();
            this.seleccionaGB = new System.Windows.Forms.GroupBox();
            this.personalizadoRB = new System.Windows.Forms.RadioButton();
            this.labelError = new System.Windows.Forms.Label();
            this.botonAtras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoClientes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoClientes)).BeginInit();
            this.clientesGB.SuspendLayout();
            this.fechasGB.SuspendLayout();
            this.seleccionaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEloySeguros
            // 
            this.labelEloySeguros.AutoSize = true;
            this.labelEloySeguros.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEloySeguros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelEloySeguros.Location = new System.Drawing.Point(91, 14);
            this.labelEloySeguros.Name = "labelEloySeguros";
            this.labelEloySeguros.Size = new System.Drawing.Size(151, 25);
            this.labelEloySeguros.TabIndex = 13;
            this.labelEloySeguros.Text = "Eloy Seguros";
            // 
            // imagenLogo
            // 
            this.imagenLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenLogo.BackgroundImage")));
            this.imagenLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenLogo.Location = new System.Drawing.Point(-38, -22);
            this.imagenLogo.Name = "imagenLogo";
            this.imagenLogo.Size = new System.Drawing.Size(155, 131);
            this.imagenLogo.TabIndex = 12;
            this.imagenLogo.TabStop = false;
            // 
            // clienteCB2
            // 
            this.clienteCB2.DataSource = this.clienteBindingSource1;
            this.clienteCB2.DisplayMember = "Nombre";
            this.clienteCB2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteCB2.FormattingEnabled = true;
            this.clienteCB2.Location = new System.Drawing.Point(256, 21);
            this.clienteCB2.Name = "clienteCB2";
            this.clienteCB2.Size = new System.Drawing.Size(176, 24);
            this.clienteCB2.TabIndex = 2;
            this.clienteCB2.TabStop = false;
            this.clienteCB2.ValueMember = "Codigo";
            this.clienteCB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "cliente";
            this.clienteBindingSource1.DataSource = this.cargoClientes2;
            // 
            // cargoClientes2
            // 
            this.cargoClientes2.DataSetName = "cargoClientes2";
            this.cargoClientes2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteCB1
            // 
            this.clienteCB1.DataSource = this.clienteBindingSource;
            this.clienteCB1.DisplayMember = "Nombre";
            this.clienteCB1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteCB1.FormattingEnabled = true;
            this.clienteCB1.Location = new System.Drawing.Point(6, 21);
            this.clienteCB1.Name = "clienteCB1";
            this.clienteCB1.Size = new System.Drawing.Size(176, 24);
            this.clienteCB1.TabIndex = 1;
            this.clienteCB1.TabStop = false;
            this.clienteCB1.ValueMember = "Codigo";
            this.clienteCB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.cargoClientes;
            // 
            // cargoClientes
            // 
            this.cargoClientes.DataSetName = "cargoClientes";
            this.cargoClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesGB
            // 
            this.clientesGB.Controls.Add(this.clienteCB1);
            this.clientesGB.Controls.Add(this.clienteCB2);
            this.clientesGB.Enabled = false;
            this.clientesGB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.clientesGB.Location = new System.Drawing.Point(119, 210);
            this.clientesGB.Name = "clientesGB";
            this.clientesGB.Size = new System.Drawing.Size(438, 65);
            this.clientesGB.TabIndex = 0;
            this.clientesGB.TabStop = false;
            this.clientesGB.Text = "Selecciona dos clientes:";
            // 
            // fechasGB
            // 
            this.fechasGB.Controls.Add(this.fechaDP2);
            this.fechasGB.Controls.Add(this.fechaDP);
            this.fechasGB.Enabled = false;
            this.fechasGB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechasGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.fechasGB.Location = new System.Drawing.Point(119, 287);
            this.fechasGB.Name = "fechasGB";
            this.fechasGB.Size = new System.Drawing.Size(438, 65);
            this.fechasGB.TabIndex = 3;
            this.fechasGB.TabStop = false;
            this.fechasGB.Text = "Selecciona dos fechas:";
            // 
            // fechaDP2
            // 
            this.fechaDP2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDP2.Location = new System.Drawing.Point(256, 21);
            this.fechaDP2.Name = "fechaDP2";
            this.fechaDP2.Size = new System.Drawing.Size(176, 22);
            this.fechaDP2.TabIndex = 5;
            this.fechaDP2.Value = new System.DateTime(2022, 2, 25, 0, 0, 0, 0);
            // 
            // fechaDP
            // 
            this.fechaDP.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDP.Location = new System.Drawing.Point(6, 21);
            this.fechaDP.Name = "fechaDP";
            this.fechaDP.Size = new System.Drawing.Size(176, 22);
            this.fechaDP.TabIndex = 4;
            this.fechaDP.Value = new System.DateTime(2022, 2, 25, 0, 0, 0, 0);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // botonGenerar
            // 
            this.botonGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonGenerar.AutoSize = true;
            this.botonGenerar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.botonGenerar.Location = new System.Drawing.Point(188, 389);
            this.botonGenerar.Name = "botonGenerar";
            this.botonGenerar.Size = new System.Drawing.Size(176, 23);
            this.botonGenerar.TabIndex = 10;
            this.botonGenerar.Text = "Generar Informe";
            this.botonGenerar.Click += new System.EventHandler(this.botonGenerar_Click);
            this.botonGenerar.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonGenerar.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // determinadoEstadoRB
            // 
            this.determinadoEstadoRB.AutoSize = true;
            this.determinadoEstadoRB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.determinadoEstadoRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.determinadoEstadoRB.Location = new System.Drawing.Point(148, 23);
            this.determinadoEstadoRB.Name = "determinadoEstadoRB";
            this.determinadoEstadoRB.Size = new System.Drawing.Size(122, 20);
            this.determinadoEstadoRB.TabIndex = 8;
            this.determinadoEstadoRB.Text = "Según Estado";
            this.determinadoEstadoRB.UseVisualStyleBackColor = true;
            this.determinadoEstadoRB.CheckedChanged += new System.EventHandler(this.determinadoEstadoRB_CheckedChanged);
            // 
            // todasRB
            // 
            this.todasRB.AutoSize = true;
            this.todasRB.Checked = true;
            this.todasRB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todasRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.todasRB.Location = new System.Drawing.Point(39, 23);
            this.todasRB.Name = "todasRB";
            this.todasRB.Size = new System.Drawing.Size(70, 20);
            this.todasRB.TabIndex = 7;
            this.todasRB.TabStop = true;
            this.todasRB.Text = "Todas";
            this.todasRB.UseVisualStyleBackColor = true;
            this.todasRB.CheckedChanged += new System.EventHandler(this.todasRB_CheckedChanged);
            // 
            // estadoCB
            // 
            this.estadoCB.Enabled = false;
            this.estadoCB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCB.FormattingEnabled = true;
            this.estadoCB.Items.AddRange(new object[] {
            "Cobrada",
            "A cuenta",
            "Liquidada",
            "Pre anulada",
            "Anulada"});
            this.estadoCB.Location = new System.Drawing.Point(120, 60);
            this.estadoCB.Name = "estadoCB";
            this.estadoCB.Size = new System.Drawing.Size(176, 24);
            this.estadoCB.TabIndex = 9;
            this.estadoCB.TabStop = false;
            this.estadoCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // seleccionaGB
            // 
            this.seleccionaGB.Controls.Add(this.personalizadoRB);
            this.seleccionaGB.Controls.Add(this.labelError);
            this.seleccionaGB.Controls.Add(this.estadoCB);
            this.seleccionaGB.Controls.Add(this.todasRB);
            this.seleccionaGB.Controls.Add(this.determinadoEstadoRB);
            this.seleccionaGB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionaGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.seleccionaGB.Location = new System.Drawing.Point(119, 83);
            this.seleccionaGB.Name = "seleccionaGB";
            this.seleccionaGB.Size = new System.Drawing.Size(438, 115);
            this.seleccionaGB.TabIndex = 6;
            this.seleccionaGB.TabStop = false;
            this.seleccionaGB.Text = "Selecciona:";
            // 
            // personalizadoRB
            // 
            this.personalizadoRB.AutoSize = true;
            this.personalizadoRB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalizadoRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.personalizadoRB.Location = new System.Drawing.Point(305, 23);
            this.personalizadoRB.Name = "personalizadoRB";
            this.personalizadoRB.Size = new System.Drawing.Size(127, 20);
            this.personalizadoRB.TabIndex = 46;
            this.personalizadoRB.Text = "Personalizado";
            this.personalizadoRB.UseVisualStyleBackColor = true;
            this.personalizadoRB.CheckedChanged += new System.EventHandler(this.personalizadoRB_CheckedChanged);
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(120, 90);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(176, 19);
            this.labelError.TabIndex = 45;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonAtras
            // 
            this.botonAtras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAtras.AutoSize = true;
            this.botonAtras.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.botonAtras.Location = new System.Drawing.Point(385, 389);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(63, 23);
            this.botonAtras.TabIndex = 28;
            this.botonAtras.Text = "Atrás";
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            this.botonAtras.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonAtras.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // GestionInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 434);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.seleccionaGB);
            this.Controls.Add(this.botonGenerar);
            this.Controls.Add(this.fechasGB);
            this.Controls.Add(this.clientesGB);
            this.Controls.Add(this.labelEloySeguros);
            this.Controls.Add(this.imagenLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GestionInforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GestionInforme";
            this.Load += new System.EventHandler(this.GestionInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoClientes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoClientes)).EndInit();
            this.clientesGB.ResumeLayout(false);
            this.fechasGB.ResumeLayout(false);
            this.seleccionaGB.ResumeLayout(false);
            this.seleccionaGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEloySeguros;
        private System.Windows.Forms.PictureBox imagenLogo;
        public System.Windows.Forms.ComboBox clienteCB2;
        public System.Windows.Forms.ComboBox clienteCB1;
        private System.Windows.Forms.GroupBox clientesGB;
        private System.Windows.Forms.GroupBox fechasGB;
        public System.Windows.Forms.DateTimePicker fechaDP2;
        public System.Windows.Forms.DateTimePicker fechaDP;
        private cargoClientes cargoClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private cargoClientesTableAdapters.clienteTableAdapter clienteTableAdapter;
        private cargoClientes2 cargoClientes2;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private cargoClientes2TableAdapters.clienteTableAdapter clienteTableAdapter1;
        public System.Windows.Forms.Label botonGenerar;
        public System.Windows.Forms.RadioButton determinadoEstadoRB;
        public System.Windows.Forms.RadioButton todasRB;
        public System.Windows.Forms.ComboBox estadoCB;
        private System.Windows.Forms.GroupBox seleccionaGB;
        public System.Windows.Forms.Label botonAtras;
        private System.Windows.Forms.Label labelError;
        public System.Windows.Forms.RadioButton personalizadoRB;
    }
}