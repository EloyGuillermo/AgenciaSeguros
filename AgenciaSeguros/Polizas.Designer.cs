
namespace AgenciaSeguros
{
    partial class Polizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polizas));
            this.barraEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.barraMenu = new System.Windows.Forms.MenuStrip();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEloySeguros = new System.Windows.Forms.Label();
            this.imagenLogo = new System.Windows.Forms.PictureBox();
            this.tablaPolizas = new System.Windows.Forms.DataGridView();
            this.IdPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaPagos = new System.Windows.Forms.DataGridView();
            this.labelAñadir = new System.Windows.Forms.Label();
            this.labelModificar = new System.Windows.Forms.Label();
            this.labelEliminar = new System.Windows.Forms.Label();
            this.pagoTB = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.okButton2 = new System.Windows.Forms.Button();
            this.pago2TB = new System.Windows.Forms.TextBox();
            this.labelGestionPagos = new System.Windows.Forms.Label();
            this.verdePB = new System.Windows.Forms.PictureBox();
            this.labelCobrada = new System.Windows.Forms.Label();
            this.labelAcuenta = new System.Windows.Forms.Label();
            this.rojoPB = new System.Windows.Forms.PictureBox();
            this.labelLiquidada = new System.Windows.Forms.Label();
            this.azulPB = new System.Windows.Forms.PictureBox();
            this.labelAnulada = new System.Windows.Forms.Label();
            this.purplePB = new System.Windows.Forms.PictureBox();
            this.labelPreAnulada = new System.Windows.Forms.Label();
            this.orchidPB = new System.Windows.Forms.PictureBox();
            this.labelLeyenda = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelVisualizarCliente = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraEstado.SuspendLayout();
            this.barraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPolizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azulPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orchidPB)).BeginInit();
            this.SuspendLayout();
            // 
            // barraEstado
            // 
            this.barraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.barraEstado.Location = new System.Drawing.Point(0, 550);
            this.barraEstado.Name = "barraEstado";
            this.barraEstado.Size = new System.Drawing.Size(1056, 22);
            this.barraEstado.TabIndex = 4;
            this.barraEstado.Text = "Clientes";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel1.Text = "Agencia De Seguros";
            // 
            // barraMenu
            // 
            this.barraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.barraMenu.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.volverAlInicioToolStripMenuItem});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(1056, 24);
            this.barraMenu.TabIndex = 5;
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
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.informesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informesToolStripMenuItem.Image")));
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // volverAlInicioToolStripMenuItem
            // 
            this.volverAlInicioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.volverAlInicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("volverAlInicioToolStripMenuItem.Image")));
            this.volverAlInicioToolStripMenuItem.Name = "volverAlInicioToolStripMenuItem";
            this.volverAlInicioToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.volverAlInicioToolStripMenuItem.Text = "Volver Al Inicio";
            this.volverAlInicioToolStripMenuItem.Click += new System.EventHandler(this.volverAlInicioToolStripMenuItem_Click);
            // 
            // labelEloySeguros
            // 
            this.labelEloySeguros.AutoSize = true;
            this.labelEloySeguros.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEloySeguros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelEloySeguros.Location = new System.Drawing.Point(86, 50);
            this.labelEloySeguros.Name = "labelEloySeguros";
            this.labelEloySeguros.Size = new System.Drawing.Size(151, 25);
            this.labelEloySeguros.TabIndex = 13;
            this.labelEloySeguros.Text = "Eloy Seguros";
            // 
            // imagenLogo
            // 
            this.imagenLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenLogo.BackgroundImage")));
            this.imagenLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenLogo.Location = new System.Drawing.Point(-29, 12);
            this.imagenLogo.Name = "imagenLogo";
            this.imagenLogo.Size = new System.Drawing.Size(155, 131);
            this.imagenLogo.TabIndex = 12;
            this.imagenLogo.TabStop = false;
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
            this.Cliente,
            this.Fecha,
            this.Importe,
            this.Estado,
            this.Observaciones,
            this.Debe,
            this.Pagado});
            this.tablaPolizas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tablaPolizas.Location = new System.Drawing.Point(12, 118);
            this.tablaPolizas.Name = "tablaPolizas";
            this.tablaPolizas.ReadOnly = true;
            this.tablaPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPolizas.Size = new System.Drawing.Size(683, 414);
            this.tablaPolizas.TabIndex = 14;
            this.tablaPolizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPolizas_CellClick);
            this.tablaPolizas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPolizas_CellDoubleClick);
            // 
            // IdPoliza
            // 
            this.IdPoliza.HeaderText = "IdPoliza";
            this.IdPoliza.Name = "IdPoliza";
            this.IdPoliza.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
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
            this.tablaPagos.Location = new System.Drawing.Point(705, 118);
            this.tablaPagos.Name = "tablaPagos";
            this.tablaPagos.ReadOnly = true;
            this.tablaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPagos.Size = new System.Drawing.Size(339, 414);
            this.tablaPagos.TabIndex = 16;
            this.tablaPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPagos_CellClick);
            // 
            // labelAñadir
            // 
            this.labelAñadir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAñadir.AutoSize = true;
            this.labelAñadir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelAñadir.Location = new System.Drawing.Point(703, 32);
            this.labelAñadir.Name = "labelAñadir";
            this.labelAñadir.Size = new System.Drawing.Size(110, 18);
            this.labelAñadir.TabIndex = 20;
            this.labelAñadir.Text = "Añadir Pago";
            this.labelAñadir.Visible = false;
            this.labelAñadir.Click += new System.EventHandler(this.labelAñadir_Click);
            this.labelAñadir.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.labelAñadir.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // labelModificar
            // 
            this.labelModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModificar.AutoSize = true;
            this.labelModificar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelModificar.Location = new System.Drawing.Point(702, 61);
            this.labelModificar.Name = "labelModificar";
            this.labelModificar.Size = new System.Drawing.Size(133, 18);
            this.labelModificar.TabIndex = 21;
            this.labelModificar.Text = "Modificar Pago";
            this.labelModificar.Visible = false;
            this.labelModificar.Click += new System.EventHandler(this.labelModificar_Click);
            this.labelModificar.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.labelModificar.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // labelEliminar
            // 
            this.labelEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEliminar.AutoSize = true;
            this.labelEliminar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelEliminar.Location = new System.Drawing.Point(702, 90);
            this.labelEliminar.Name = "labelEliminar";
            this.labelEliminar.Size = new System.Drawing.Size(126, 18);
            this.labelEliminar.TabIndex = 22;
            this.labelEliminar.Text = "Eliminar Pago";
            this.labelEliminar.Visible = false;
            this.labelEliminar.Click += new System.EventHandler(this.labelEliminar_Click);
            this.labelEliminar.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.labelEliminar.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // pagoTB
            // 
            this.pagoTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagoTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoTB.Location = new System.Drawing.Point(835, 31);
            this.pagoTB.Name = "pagoTB";
            this.pagoTB.Size = new System.Drawing.Size(162, 22);
            this.pagoTB.TabIndex = 23;
            this.pagoTB.Visible = false;
            this.pagoTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.importeTB_KeyPress);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(1003, 30);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(46, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // okButton2
            // 
            this.okButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton2.Location = new System.Drawing.Point(1003, 59);
            this.okButton2.Name = "okButton2";
            this.okButton2.Size = new System.Drawing.Size(46, 23);
            this.okButton2.TabIndex = 26;
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
            this.pago2TB.Location = new System.Drawing.Point(835, 59);
            this.pago2TB.Name = "pago2TB";
            this.pago2TB.Size = new System.Drawing.Size(162, 22);
            this.pago2TB.TabIndex = 25;
            this.pago2TB.Visible = false;
            this.pago2TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.importeTB_KeyPress);
            // 
            // labelGestionPagos
            // 
            this.labelGestionPagos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGestionPagos.AutoSize = true;
            this.labelGestionPagos.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionPagos.ForeColor = System.Drawing.Color.Red;
            this.labelGestionPagos.Location = new System.Drawing.Point(9, 98);
            this.labelGestionPagos.Name = "labelGestionPagos";
            this.labelGestionPagos.Size = new System.Drawing.Size(301, 16);
            this.labelGestionPagos.TabIndex = 27;
            this.labelGestionPagos.Text = "*Selecciona una póliza para gestionar sus pagos";
            // 
            // verdePB
            // 
            this.verdePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verdePB.BackColor = System.Drawing.Color.LimeGreen;
            this.verdePB.Location = new System.Drawing.Point(475, 53);
            this.verdePB.Name = "verdePB";
            this.verdePB.Size = new System.Drawing.Size(14, 14);
            this.verdePB.TabIndex = 28;
            this.verdePB.TabStop = false;
            // 
            // labelCobrada
            // 
            this.labelCobrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCobrada.AutoSize = true;
            this.labelCobrada.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCobrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelCobrada.Location = new System.Drawing.Point(498, 53);
            this.labelCobrada.Name = "labelCobrada";
            this.labelCobrada.Size = new System.Drawing.Size(55, 14);
            this.labelCobrada.TabIndex = 29;
            this.labelCobrada.Text = "Cobrada";
            // 
            // labelAcuenta
            // 
            this.labelAcuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAcuenta.AutoSize = true;
            this.labelAcuenta.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelAcuenta.Location = new System.Drawing.Point(498, 73);
            this.labelAcuenta.Name = "labelAcuenta";
            this.labelAcuenta.Size = new System.Drawing.Size(59, 14);
            this.labelAcuenta.TabIndex = 31;
            this.labelAcuenta.Text = "A cuenta";
            // 
            // rojoPB
            // 
            this.rojoPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rojoPB.BackColor = System.Drawing.Color.IndianRed;
            this.rojoPB.Location = new System.Drawing.Point(475, 73);
            this.rojoPB.Name = "rojoPB";
            this.rojoPB.Size = new System.Drawing.Size(14, 14);
            this.rojoPB.TabIndex = 30;
            this.rojoPB.TabStop = false;
            // 
            // labelLiquidada
            // 
            this.labelLiquidada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLiquidada.AutoSize = true;
            this.labelLiquidada.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLiquidada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelLiquidada.Location = new System.Drawing.Point(498, 94);
            this.labelLiquidada.Name = "labelLiquidada";
            this.labelLiquidada.Size = new System.Drawing.Size(64, 14);
            this.labelLiquidada.TabIndex = 33;
            this.labelLiquidada.Text = "Liquidada";
            // 
            // azulPB
            // 
            this.azulPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.azulPB.BackColor = System.Drawing.Color.Aquamarine;
            this.azulPB.Location = new System.Drawing.Point(475, 94);
            this.azulPB.Name = "azulPB";
            this.azulPB.Size = new System.Drawing.Size(14, 14);
            this.azulPB.TabIndex = 32;
            this.azulPB.TabStop = false;
            // 
            // labelAnulada
            // 
            this.labelAnulada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnulada.AutoSize = true;
            this.labelAnulada.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnulada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelAnulada.Location = new System.Drawing.Point(602, 62);
            this.labelAnulada.Name = "labelAnulada";
            this.labelAnulada.Size = new System.Drawing.Size(57, 14);
            this.labelAnulada.TabIndex = 35;
            this.labelAnulada.Text = "Anulada";
            // 
            // purplePB
            // 
            this.purplePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.purplePB.BackColor = System.Drawing.Color.DarkGray;
            this.purplePB.Location = new System.Drawing.Point(579, 62);
            this.purplePB.Name = "purplePB";
            this.purplePB.Size = new System.Drawing.Size(14, 14);
            this.purplePB.TabIndex = 34;
            this.purplePB.TabStop = false;
            // 
            // labelPreAnulada
            // 
            this.labelPreAnulada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreAnulada.AutoSize = true;
            this.labelPreAnulada.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreAnulada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelPreAnulada.Location = new System.Drawing.Point(602, 82);
            this.labelPreAnulada.Name = "labelPreAnulada";
            this.labelPreAnulada.Size = new System.Drawing.Size(77, 14);
            this.labelPreAnulada.TabIndex = 37;
            this.labelPreAnulada.Text = "Pre anulada";
            // 
            // orchidPB
            // 
            this.orchidPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orchidPB.BackColor = System.Drawing.Color.Orchid;
            this.orchidPB.Location = new System.Drawing.Point(579, 82);
            this.orchidPB.Name = "orchidPB";
            this.orchidPB.Size = new System.Drawing.Size(14, 14);
            this.orchidPB.TabIndex = 36;
            this.orchidPB.TabStop = false;
            // 
            // labelLeyenda
            // 
            this.labelLeyenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLeyenda.AutoSize = true;
            this.labelLeyenda.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeyenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelLeyenda.Location = new System.Drawing.Point(472, 29);
            this.labelLeyenda.Name = "labelLeyenda";
            this.labelLeyenda.Size = new System.Drawing.Size(129, 16);
            this.labelLeyenda.TabIndex = 38;
            this.labelLeyenda.Text = "Leyenda Estados";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.Red;
            this.labelCliente.Location = new System.Drawing.Point(261, 57);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(73, 16);
            this.labelCliente.TabIndex = 39;
            this.labelCliente.Text = "Usuario: ";
            // 
            // labelVisualizarCliente
            // 
            this.labelVisualizarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVisualizarCliente.AutoSize = true;
            this.labelVisualizarCliente.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisualizarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(121)))), ((int)(((byte)(169)))));
            this.labelVisualizarCliente.Location = new System.Drawing.Point(9, 96);
            this.labelVisualizarCliente.Name = "labelVisualizarCliente";
            this.labelVisualizarCliente.Size = new System.Drawing.Size(157, 18);
            this.labelVisualizarCliente.TabIndex = 40;
            this.labelVisualizarCliente.Text = "Visualizar Cliente";
            this.labelVisualizarCliente.Visible = false;
            this.labelVisualizarCliente.Click += new System.EventHandler(this.labelVisualizarCliente_Click);
            this.labelVisualizarCliente.MouseEnter += new System.EventHandler(this.botonVisualizar_MouseEnter);
            this.labelVisualizarCliente.MouseLeave += new System.EventHandler(this.botonVisualizar_MouseLeave);
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
            // Polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 572);
            this.Controls.Add(this.labelVisualizarCliente);
            this.Controls.Add(this.labelCliente);
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
            this.Controls.Add(this.labelGestionPagos);
            this.Controls.Add(this.okButton2);
            this.Controls.Add(this.pago2TB);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.pagoTB);
            this.Controls.Add(this.labelEliminar);
            this.Controls.Add(this.labelModificar);
            this.Controls.Add(this.labelAñadir);
            this.Controls.Add(this.tablaPagos);
            this.Controls.Add(this.tablaPolizas);
            this.Controls.Add(this.labelEloySeguros);
            this.Controls.Add(this.barraMenu);
            this.Controls.Add(this.barraEstado);
            this.Controls.Add(this.imagenLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Polizas";
            this.Text = "Polizas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Polizas_Load);
            this.Click += new System.EventHandler(this.Polizas_Click);
            this.barraEstado.ResumeLayout(false);
            this.barraEstado.PerformLayout();
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPolizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azulPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orchidPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip barraMenu;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlInicioToolStripMenuItem;
        private System.Windows.Forms.Label labelEloySeguros;
        private System.Windows.Forms.PictureBox imagenLogo;
        public System.Windows.Forms.DataGridView tablaPolizas;
        public System.Windows.Forms.DataGridView tablaPagos;
        private System.Windows.Forms.Label labelAñadir;
        private System.Windows.Forms.Label labelModificar;
        private System.Windows.Forms.Label labelEliminar;
        public System.Windows.Forms.TextBox pagoTB;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button okButton2;
        public System.Windows.Forms.TextBox pago2TB;
        private System.Windows.Forms.Label labelGestionPagos;
        private System.Windows.Forms.PictureBox verdePB;
        private System.Windows.Forms.Label labelCobrada;
        private System.Windows.Forms.Label labelAcuenta;
        private System.Windows.Forms.PictureBox rojoPB;
        private System.Windows.Forms.Label labelLiquidada;
        private System.Windows.Forms.PictureBox azulPB;
        private System.Windows.Forms.Label labelAnulada;
        private System.Windows.Forms.PictureBox purplePB;
        private System.Windows.Forms.Label labelPreAnulada;
        private System.Windows.Forms.PictureBox orchidPB;
        private System.Windows.Forms.Label labelLeyenda;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.Label labelVisualizarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportePago;
    }
}