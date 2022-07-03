
namespace AgenciaSeguros
{
    partial class PolizaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolizaCliente));
            this.tablaPagos = new System.Windows.Forms.DataGridView();
            this.tablaPolizas = new System.Windows.Forms.DataGridView();
            this.IdPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelEloySeguros = new System.Windows.Forms.Label();
            this.barraMenu = new System.Windows.Forms.MenuStrip();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipoTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contactoGB = new System.Windows.Forms.GroupBox();
            this.telefonoTB = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.domicilioGB = new System.Windows.Forms.GroupBox();
            this.poblacionCB = new System.Windows.Forms.TextBox();
            this.provinciaCB = new System.Windows.Forms.TextBox();
            this.codPostalTB = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.labelPoblación = new System.Windows.Forms.Label();
            this.DatosPersonalesGB = new System.Windows.Forms.GroupBox();
            this.apellidosTB = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.botonAtras = new System.Windows.Forms.Label();
            this.labelPolizas = new System.Windows.Forms.Label();
            this.labelLeyenda = new System.Windows.Forms.Label();
            this.labelPreAnulada = new System.Windows.Forms.Label();
            this.orchidPB = new System.Windows.Forms.PictureBox();
            this.labelAnulada = new System.Windows.Forms.Label();
            this.purplePB = new System.Windows.Forms.PictureBox();
            this.labelLiquidada = new System.Windows.Forms.Label();
            this.azulPB = new System.Windows.Forms.PictureBox();
            this.labelAcuenta = new System.Windows.Forms.Label();
            this.rojoPB = new System.Windows.Forms.PictureBox();
            this.labelCobrada = new System.Windows.Forms.Label();
            this.verdePB = new System.Windows.Forms.PictureBox();
            this.labelPagos = new System.Windows.Forms.Label();
            this.barraEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.okButton2 = new System.Windows.Forms.Button();
            this.pago2TB = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.pagoTB = new System.Windows.Forms.TextBox();
            this.labelEliminar = new System.Windows.Forms.Label();
            this.labelModificar = new System.Windows.Forms.Label();
            this.labelAñadir = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPolizas)).BeginInit();
            this.barraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contactoGB.SuspendLayout();
            this.domicilioGB.SuspendLayout();
            this.DatosPersonalesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orchidPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azulPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdePB)).BeginInit();
            this.barraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaPagos
            // 
            this.tablaPagos.AllowUserToAddRows = false;
            this.tablaPagos.AllowUserToDeleteRows = false;
            this.tablaPagos.AllowUserToOrderColumns = true;
            this.tablaPagos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NumPoliza,
            this.FechaPago,
            this.ImportePago});
            this.tablaPagos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tablaPagos.Location = new System.Drawing.Point(1002, 261);
            this.tablaPagos.Name = "tablaPagos";
            this.tablaPagos.ReadOnly = true;
            this.tablaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPagos.Size = new System.Drawing.Size(299, 272);
            this.tablaPagos.TabIndex = 21;
            this.tablaPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPagos_CellClick);
            // 
            // tablaPolizas
            // 
            this.tablaPolizas.AllowUserToAddRows = false;
            this.tablaPolizas.AllowUserToDeleteRows = false;
            this.tablaPolizas.AllowUserToOrderColumns = true;
            this.tablaPolizas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaPolizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPolizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPoliza,
            this.CodCliente,
            this.Fecha,
            this.Importe,
            this.Estado,
            this.Observaciones,
            this.Debe,
            this.Pagado});
            this.tablaPolizas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tablaPolizas.Location = new System.Drawing.Point(12, 261);
            this.tablaPolizas.Name = "tablaPolizas";
            this.tablaPolizas.ReadOnly = true;
            this.tablaPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPolizas.Size = new System.Drawing.Size(984, 272);
            this.tablaPolizas.TabIndex = 20;
            this.tablaPolizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPolizas_CellClick);
            // 
            // IdPoliza
            // 
            this.IdPoliza.HeaderText = "IdPoliza";
            this.IdPoliza.Name = "IdPoliza";
            this.IdPoliza.ReadOnly = true;
            // 
            // CodCliente
            // 
            this.CodCliente.HeaderText = "CodCliente";
            this.CodCliente.Name = "CodCliente";
            this.CodCliente.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            this.Debe.ReadOnly = true;
            // 
            // Pagado
            // 
            this.Pagado.HeaderText = "Pagado";
            this.Pagado.Name = "Pagado";
            this.Pagado.ReadOnly = true;
            // 
            // labelEloySeguros
            // 
            this.labelEloySeguros.AutoSize = true;
            this.labelEloySeguros.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEloySeguros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelEloySeguros.Location = new System.Drawing.Point(86, 49);
            this.labelEloySeguros.Name = "labelEloySeguros";
            this.labelEloySeguros.Size = new System.Drawing.Size(151, 25);
            this.labelEloySeguros.TabIndex = 19;
            this.labelEloySeguros.Text = "Eloy Seguros";
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.barraMenu.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.volverAlInicioToolStripMenuItem});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(1313, 24);
            this.barraMenu.TabIndex = 17;
            this.barraMenu.Text = "menuStrip1";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.añadirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("añadirToolStripMenuItem.Image")));
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // volverAlInicioToolStripMenuItem
            // 
            this.volverAlInicioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.volverAlInicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("volverAlInicioToolStripMenuItem.Image")));
            this.volverAlInicioToolStripMenuItem.Name = "volverAlInicioToolStripMenuItem";
            this.volverAlInicioToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.volverAlInicioToolStripMenuItem.Text = "Volver a Clientes";
            this.volverAlInicioToolStripMenuItem.Click += new System.EventHandler(this.volverAlInicioToolStripMenuItem_Click);
            // 
            // imagenLogo
            // 
            this.imagenLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenLogo.BackgroundImage")));
            this.imagenLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenLogo.Location = new System.Drawing.Point(-29, 11);
            this.imagenLogo.Name = "imagenLogo";
            this.imagenLogo.Size = new System.Drawing.Size(155, 131);
            this.imagenLogo.TabIndex = 18;
            this.imagenLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipoTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.groupBox1.Location = new System.Drawing.Point(246, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 44);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // tipoTB
            // 
            this.tipoTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoTB.Location = new System.Drawing.Point(118, 16);
            this.tipoTB.Name = "tipoTB";
            this.tipoTB.ReadOnly = true;
            this.tipoTB.Size = new System.Drawing.Size(208, 22);
            this.tipoTB.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo:";
            // 
            // contactoGB
            // 
            this.contactoGB.Controls.Add(this.telefonoTB);
            this.contactoGB.Controls.Add(this.labelTelefono);
            this.contactoGB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactoGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.contactoGB.Location = new System.Drawing.Point(246, 130);
            this.contactoGB.Name = "contactoGB";
            this.contactoGB.Size = new System.Drawing.Size(332, 65);
            this.contactoGB.TabIndex = 25;
            this.contactoGB.TabStop = false;
            this.contactoGB.Text = "Contacto";
            // 
            // telefonoTB
            // 
            this.telefonoTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTB.Location = new System.Drawing.Point(118, 23);
            this.telefonoTB.Name = "telefonoTB";
            this.telefonoTB.ReadOnly = true;
            this.telefonoTB.Size = new System.Drawing.Size(208, 22);
            this.telefonoTB.TabIndex = 2;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelTelefono.Location = new System.Drawing.Point(6, 26);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(62, 14);
            this.labelTelefono.TabIndex = 1;
            this.labelTelefono.Text = "Teléfono: ";
            // 
            // domicilioGB
            // 
            this.domicilioGB.Controls.Add(this.poblacionCB);
            this.domicilioGB.Controls.Add(this.provinciaCB);
            this.domicilioGB.Controls.Add(this.codPostalTB);
            this.domicilioGB.Controls.Add(this.labelCodigo);
            this.domicilioGB.Controls.Add(this.labelProvincia);
            this.domicilioGB.Controls.Add(this.labelPoblación);
            this.domicilioGB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilioGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.domicilioGB.Location = new System.Drawing.Point(584, 33);
            this.domicilioGB.Name = "domicilioGB";
            this.domicilioGB.Size = new System.Drawing.Size(367, 162);
            this.domicilioGB.TabIndex = 24;
            this.domicilioGB.TabStop = false;
            this.domicilioGB.Text = "Domicilio";
            // 
            // poblacionCB
            // 
            this.poblacionCB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poblacionCB.Location = new System.Drawing.Point(91, 65);
            this.poblacionCB.Name = "poblacionCB";
            this.poblacionCB.ReadOnly = true;
            this.poblacionCB.Size = new System.Drawing.Size(264, 22);
            this.poblacionCB.TabIndex = 20;
            // 
            // provinciaCB
            // 
            this.provinciaCB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinciaCB.Location = new System.Drawing.Point(91, 17);
            this.provinciaCB.Name = "provinciaCB";
            this.provinciaCB.ReadOnly = true;
            this.provinciaCB.Size = new System.Drawing.Size(264, 22);
            this.provinciaCB.TabIndex = 19;
            // 
            // codPostalTB
            // 
            this.codPostalTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codPostalTB.Location = new System.Drawing.Point(91, 120);
            this.codPostalTB.Name = "codPostalTB";
            this.codPostalTB.ReadOnly = true;
            this.codPostalTB.Size = new System.Drawing.Size(264, 22);
            this.codPostalTB.TabIndex = 18;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelCodigo.Location = new System.Drawing.Point(6, 126);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(89, 14);
            this.labelCodigo.TabIndex = 17;
            this.labelCodigo.Text = "Código postal: ";
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelProvincia.Location = new System.Drawing.Point(7, 22);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(70, 14);
            this.labelProvincia.TabIndex = 14;
            this.labelProvincia.Text = "Provincia: ";
            // 
            // labelPoblación
            // 
            this.labelPoblación.AutoSize = true;
            this.labelPoblación.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoblación.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelPoblación.Location = new System.Drawing.Point(7, 70);
            this.labelPoblación.Name = "labelPoblación";
            this.labelPoblación.Size = new System.Drawing.Size(69, 14);
            this.labelPoblación.TabIndex = 12;
            this.labelPoblación.Text = "Población: ";
            // 
            // DatosPersonalesGB
            // 
            this.DatosPersonalesGB.Controls.Add(this.apellidosTB);
            this.DatosPersonalesGB.Controls.Add(this.labelApellidos);
            this.DatosPersonalesGB.Controls.Add(this.labelNombre);
            this.DatosPersonalesGB.Controls.Add(this.nombreTB);
            this.DatosPersonalesGB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosPersonalesGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.DatosPersonalesGB.Location = new System.Drawing.Point(246, 33);
            this.DatosPersonalesGB.Name = "DatosPersonalesGB";
            this.DatosPersonalesGB.Size = new System.Drawing.Size(332, 86);
            this.DatosPersonalesGB.TabIndex = 23;
            this.DatosPersonalesGB.TabStop = false;
            this.DatosPersonalesGB.Text = "Datos Personales";
            // 
            // apellidosTB
            // 
            this.apellidosTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosTB.Location = new System.Drawing.Point(118, 52);
            this.apellidosTB.Name = "apellidosTB";
            this.apellidosTB.ReadOnly = true;
            this.apellidosTB.Size = new System.Drawing.Size(208, 22);
            this.apellidosTB.TabIndex = 7;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelApellidos.Location = new System.Drawing.Point(6, 57);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(66, 14);
            this.labelApellidos.TabIndex = 3;
            this.labelApellidos.Text = "Apellidos: ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelNombre.Location = new System.Drawing.Point(6, 25);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(60, 14);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre: ";
            // 
            // nombreTB
            // 
            this.nombreTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTB.Location = new System.Drawing.Point(118, 22);
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.ReadOnly = true;
            this.nombreTB.Size = new System.Drawing.Size(208, 22);
            this.nombreTB.TabIndex = 1;
            // 
            // botonAtras
            // 
            this.botonAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAtras.AutoSize = true;
            this.botonAtras.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.botonAtras.Location = new System.Drawing.Point(1238, 536);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(63, 23);
            this.botonAtras.TabIndex = 28;
            this.botonAtras.Text = "Atrás";
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            this.botonAtras.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonAtras.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // labelPolizas
            // 
            this.labelPolizas.AutoSize = true;
            this.labelPolizas.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPolizas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelPolizas.Location = new System.Drawing.Point(7, 233);
            this.labelPolizas.Name = "labelPolizas";
            this.labelPolizas.Size = new System.Drawing.Size(97, 25);
            this.labelPolizas.TabIndex = 29;
            this.labelPolizas.Text = "Pólizas:";
            // 
            // labelLeyenda
            // 
            this.labelLeyenda.AutoSize = true;
            this.labelLeyenda.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeyenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelLeyenda.Location = new System.Drawing.Point(25, 119);
            this.labelLeyenda.Name = "labelLeyenda";
            this.labelLeyenda.Size = new System.Drawing.Size(129, 16);
            this.labelLeyenda.TabIndex = 49;
            this.labelLeyenda.Text = "Leyenda Estados";
            // 
            // labelPreAnulada
            // 
            this.labelPreAnulada.AutoSize = true;
            this.labelPreAnulada.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreAnulada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelPreAnulada.Location = new System.Drawing.Point(155, 172);
            this.labelPreAnulada.Name = "labelPreAnulada";
            this.labelPreAnulada.Size = new System.Drawing.Size(77, 14);
            this.labelPreAnulada.TabIndex = 48;
            this.labelPreAnulada.Text = "Pre anulada";
            // 
            // orchidPB
            // 
            this.orchidPB.BackColor = System.Drawing.Color.Orchid;
            this.orchidPB.Location = new System.Drawing.Point(132, 172);
            this.orchidPB.Name = "orchidPB";
            this.orchidPB.Size = new System.Drawing.Size(14, 14);
            this.orchidPB.TabIndex = 47;
            this.orchidPB.TabStop = false;
            // 
            // labelAnulada
            // 
            this.labelAnulada.AutoSize = true;
            this.labelAnulada.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnulada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelAnulada.Location = new System.Drawing.Point(155, 152);
            this.labelAnulada.Name = "labelAnulada";
            this.labelAnulada.Size = new System.Drawing.Size(57, 14);
            this.labelAnulada.TabIndex = 46;
            this.labelAnulada.Text = "Anulada";
            // 
            // purplePB
            // 
            this.purplePB.BackColor = System.Drawing.Color.DarkGray;
            this.purplePB.Location = new System.Drawing.Point(132, 152);
            this.purplePB.Name = "purplePB";
            this.purplePB.Size = new System.Drawing.Size(14, 14);
            this.purplePB.TabIndex = 45;
            this.purplePB.TabStop = false;
            // 
            // labelLiquidada
            // 
            this.labelLiquidada.AutoSize = true;
            this.labelLiquidada.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLiquidada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelLiquidada.Location = new System.Drawing.Point(51, 184);
            this.labelLiquidada.Name = "labelLiquidada";
            this.labelLiquidada.Size = new System.Drawing.Size(64, 14);
            this.labelLiquidada.TabIndex = 44;
            this.labelLiquidada.Text = "Liquidada";
            // 
            // azulPB
            // 
            this.azulPB.BackColor = System.Drawing.Color.Aquamarine;
            this.azulPB.Location = new System.Drawing.Point(28, 184);
            this.azulPB.Name = "azulPB";
            this.azulPB.Size = new System.Drawing.Size(14, 14);
            this.azulPB.TabIndex = 43;
            this.azulPB.TabStop = false;
            // 
            // labelAcuenta
            // 
            this.labelAcuenta.AutoSize = true;
            this.labelAcuenta.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelAcuenta.Location = new System.Drawing.Point(51, 163);
            this.labelAcuenta.Name = "labelAcuenta";
            this.labelAcuenta.Size = new System.Drawing.Size(59, 14);
            this.labelAcuenta.TabIndex = 42;
            this.labelAcuenta.Text = "A cuenta";
            // 
            // rojoPB
            // 
            this.rojoPB.BackColor = System.Drawing.Color.IndianRed;
            this.rojoPB.Location = new System.Drawing.Point(28, 163);
            this.rojoPB.Name = "rojoPB";
            this.rojoPB.Size = new System.Drawing.Size(14, 14);
            this.rojoPB.TabIndex = 41;
            this.rojoPB.TabStop = false;
            // 
            // labelCobrada
            // 
            this.labelCobrada.AutoSize = true;
            this.labelCobrada.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCobrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelCobrada.Location = new System.Drawing.Point(51, 143);
            this.labelCobrada.Name = "labelCobrada";
            this.labelCobrada.Size = new System.Drawing.Size(55, 14);
            this.labelCobrada.TabIndex = 40;
            this.labelCobrada.Text = "Cobrada";
            // 
            // verdePB
            // 
            this.verdePB.BackColor = System.Drawing.Color.LimeGreen;
            this.verdePB.Location = new System.Drawing.Point(28, 143);
            this.verdePB.Name = "verdePB";
            this.verdePB.Size = new System.Drawing.Size(14, 14);
            this.verdePB.TabIndex = 39;
            this.verdePB.TabStop = false;
            // 
            // labelPagos
            // 
            this.labelPagos.AutoSize = true;
            this.labelPagos.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelPagos.Location = new System.Drawing.Point(997, 233);
            this.labelPagos.Name = "labelPagos";
            this.labelPagos.Size = new System.Drawing.Size(84, 25);
            this.labelPagos.TabIndex = 30;
            this.labelPagos.Text = "Pagos:";
            // 
            // barraEstado
            // 
            this.barraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.barraEstado.Location = new System.Drawing.Point(0, 567);
            this.barraEstado.Name = "barraEstado";
            this.barraEstado.Size = new System.Drawing.Size(1313, 22);
            this.barraEstado.TabIndex = 50;
            this.barraEstado.Text = "Clientes";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel1.Text = "Agencia De Seguros";
            // 
            // okButton2
            // 
            this.okButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton2.Location = new System.Drawing.Point(1257, 76);
            this.okButton2.Name = "okButton2";
            this.okButton2.Size = new System.Drawing.Size(46, 23);
            this.okButton2.TabIndex = 57;
            this.okButton2.Text = "OK";
            this.okButton2.UseVisualStyleBackColor = true;
            this.okButton2.Visible = false;
            this.okButton2.Click += new System.EventHandler(this.okButton2_Click);
            // 
            // pago2TB
            // 
            this.pago2TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pago2TB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pago2TB.Location = new System.Drawing.Point(1089, 76);
            this.pago2TB.Name = "pago2TB";
            this.pago2TB.Size = new System.Drawing.Size(162, 22);
            this.pago2TB.TabIndex = 56;
            this.pago2TB.Visible = false;
            this.pago2TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.importeTB_KeyPress);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(1257, 47);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(46, 23);
            this.okButton.TabIndex = 55;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // pagoTB
            // 
            this.pagoTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagoTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoTB.Location = new System.Drawing.Point(1089, 48);
            this.pagoTB.Name = "pagoTB";
            this.pagoTB.Size = new System.Drawing.Size(162, 22);
            this.pagoTB.TabIndex = 54;
            this.pagoTB.Visible = false;
            this.pagoTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.importeTB_KeyPress);
            // 
            // labelEliminar
            // 
            this.labelEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEliminar.AutoSize = true;
            this.labelEliminar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelEliminar.Location = new System.Drawing.Point(956, 107);
            this.labelEliminar.Name = "labelEliminar";
            this.labelEliminar.Size = new System.Drawing.Size(126, 18);
            this.labelEliminar.TabIndex = 53;
            this.labelEliminar.Text = "Eliminar Pago";
            this.labelEliminar.Visible = false;
            this.labelEliminar.Click += new System.EventHandler(this.labelEliminar_Click);
            this.labelEliminar.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.labelEliminar.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // labelModificar
            // 
            this.labelModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModificar.AutoSize = true;
            this.labelModificar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelModificar.Location = new System.Drawing.Point(956, 78);
            this.labelModificar.Name = "labelModificar";
            this.labelModificar.Size = new System.Drawing.Size(133, 18);
            this.labelModificar.TabIndex = 52;
            this.labelModificar.Text = "Modificar Pago";
            this.labelModificar.Visible = false;
            this.labelModificar.Click += new System.EventHandler(this.labelModificar_Click);
            this.labelModificar.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.labelModificar.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // labelAñadir
            // 
            this.labelAñadir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAñadir.AutoSize = true;
            this.labelAñadir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelAñadir.Location = new System.Drawing.Point(957, 49);
            this.labelAñadir.Name = "labelAñadir";
            this.labelAñadir.Size = new System.Drawing.Size(110, 18);
            this.labelAñadir.TabIndex = 51;
            this.labelAñadir.Text = "Añadir Pago";
            this.labelAñadir.Visible = false;
            this.labelAñadir.Click += new System.EventHandler(this.labelAñadir_Click);
            this.labelAñadir.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.labelAñadir.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // NumPoliza
            // 
            this.NumPoliza.HeaderText = "NumPoliza";
            this.NumPoliza.Name = "NumPoliza";
            this.NumPoliza.ReadOnly = true;
            // 
            // FechaPago
            // 
            this.FechaPago.HeaderText = "FechaPago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            // 
            // ImportePago
            // 
            this.ImportePago.HeaderText = "ImportePago";
            this.ImportePago.Name = "ImportePago";
            this.ImportePago.ReadOnly = true;
            // 
            // PolizaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1313, 589);
            this.Controls.Add(this.okButton2);
            this.Controls.Add(this.pago2TB);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.pagoTB);
            this.Controls.Add(this.labelEliminar);
            this.Controls.Add(this.labelModificar);
            this.Controls.Add(this.labelAñadir);
            this.Controls.Add(this.barraEstado);
            this.Controls.Add(this.labelLeyenda);
            this.Controls.Add(this.labelPreAnulada);
            this.Controls.Add(this.orchidPB);
            this.Controls.Add(this.labelAnulada);
            this.Controls.Add(this.purplePB);
            this.Controls.Add(this.labelLiquidada);
            this.Controls.Add(this.azulPB);
            this.Controls.Add(this.labelAcuenta);
            this.Controls.Add(this.rojoPB);
            this.Controls.Add(this.labelCobrada);
            this.Controls.Add(this.verdePB);
            this.Controls.Add(this.labelPagos);
            this.Controls.Add(this.labelPolizas);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contactoGB);
            this.Controls.Add(this.domicilioGB);
            this.Controls.Add(this.DatosPersonalesGB);
            this.Controls.Add(this.tablaPagos);
            this.Controls.Add(this.tablaPolizas);
            this.Controls.Add(this.labelEloySeguros);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.imagenLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PolizaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PolizaCliente";
            this.Load += new System.EventHandler(this.PolizaCliente_Load);
            this.Click += new System.EventHandler(this.PolizaCliente_Click);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPolizas)).EndInit();
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contactoGB.ResumeLayout(false);
            this.contactoGB.PerformLayout();
            this.domicilioGB.ResumeLayout(false);
            this.domicilioGB.PerformLayout();
            this.DatosPersonalesGB.ResumeLayout(false);
            this.DatosPersonalesGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orchidPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azulPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdePB)).EndInit();
            this.barraEstado.ResumeLayout(false);
            this.barraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView tablaPagos;
        public System.Windows.Forms.DataGridView tablaPolizas;
        private System.Windows.Forms.Label labelEloySeguros;
        private System.Windows.Forms.MenuStrip barraMenu;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlInicioToolStripMenuItem;
        private System.Windows.Forms.PictureBox imagenLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox contactoGB;
        public System.Windows.Forms.TextBox telefonoTB;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.GroupBox domicilioGB;
        public System.Windows.Forms.TextBox codPostalTB;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.Label labelPoblación;
        private System.Windows.Forms.GroupBox DatosPersonalesGB;
        public System.Windows.Forms.TextBox apellidosTB;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombre;
        public System.Windows.Forms.TextBox nombreTB;
        public System.Windows.Forms.Label botonAtras;
        private System.Windows.Forms.Label labelPolizas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
        private System.Windows.Forms.Label labelLeyenda;
        private System.Windows.Forms.Label labelPreAnulada;
        private System.Windows.Forms.PictureBox orchidPB;
        private System.Windows.Forms.Label labelAnulada;
        private System.Windows.Forms.PictureBox purplePB;
        private System.Windows.Forms.Label labelLiquidada;
        private System.Windows.Forms.PictureBox azulPB;
        private System.Windows.Forms.Label labelAcuenta;
        private System.Windows.Forms.PictureBox rojoPB;
        private System.Windows.Forms.Label labelCobrada;
        private System.Windows.Forms.PictureBox verdePB;
        private System.Windows.Forms.Label labelPagos;
        public System.Windows.Forms.TextBox tipoTB;
        public System.Windows.Forms.TextBox poblacionCB;
        public System.Windows.Forms.TextBox provinciaCB;
        private System.Windows.Forms.StatusStrip barraEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button okButton2;
        public System.Windows.Forms.TextBox pago2TB;
        private System.Windows.Forms.Button okButton;
        public System.Windows.Forms.TextBox pagoTB;
        private System.Windows.Forms.Label labelEliminar;
        private System.Windows.Forms.Label labelModificar;
        private System.Windows.Forms.Label labelAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportePago;
    }
}