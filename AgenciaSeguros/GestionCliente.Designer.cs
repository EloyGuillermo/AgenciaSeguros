
namespace AgenciaSeguros
{
    partial class GestionCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCliente));
            this.contactoGB = new System.Windows.Forms.GroupBox();
            this.telefonoTB = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.domicilioGB = new System.Windows.Forms.GroupBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.poblacionCB = new System.Windows.Forms.ComboBox();
            this.provinciaCB = new System.Windows.Forms.ComboBox();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.labelPoblación = new System.Windows.Forms.Label();
            this.DatosPersonalesGB = new System.Windows.Forms.GroupBox();
            this.apellidosTB = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.particularRB = new System.Windows.Forms.RadioButton();
            this.empresaRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.botonAtras = new System.Windows.Forms.Label();
            this.botonAñadir = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.codPostalTB = new TextBoxNumerico.TextBoxNumerico();
            this.contactoGB.SuspendLayout();
            this.domicilioGB.SuspendLayout();
            this.DatosPersonalesGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactoGB
            // 
            this.contactoGB.Controls.Add(this.telefonoTB);
            this.contactoGB.Controls.Add(this.labelTelefono);
            this.contactoGB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactoGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.contactoGB.Location = new System.Drawing.Point(17, 128);
            this.contactoGB.Name = "contactoGB";
            this.contactoGB.Size = new System.Drawing.Size(297, 65);
            this.contactoGB.TabIndex = 2;
            this.contactoGB.TabStop = false;
            this.contactoGB.Text = "Contacto";
            // 
            // telefonoTB
            // 
            this.telefonoTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTB.Location = new System.Drawing.Point(118, 23);
            this.telefonoTB.MaxLength = 10;
            this.telefonoTB.Name = "telefonoTB";
            this.telefonoTB.Size = new System.Drawing.Size(173, 22);
            this.telefonoTB.TabIndex = 3;
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
            this.domicilioGB.Controls.Add(this.codPostalTB);
            this.domicilioGB.Controls.Add(this.labelCodigo);
            this.domicilioGB.Controls.Add(this.poblacionCB);
            this.domicilioGB.Controls.Add(this.provinciaCB);
            this.domicilioGB.Controls.Add(this.labelProvincia);
            this.domicilioGB.Controls.Add(this.labelPoblación);
            this.domicilioGB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilioGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.domicilioGB.Location = new System.Drawing.Point(348, 33);
            this.domicilioGB.Name = "domicilioGB";
            this.domicilioGB.Size = new System.Drawing.Size(276, 235);
            this.domicilioGB.TabIndex = 4;
            this.domicilioGB.TabStop = false;
            this.domicilioGB.Text = "Domicilio";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelCodigo.Location = new System.Drawing.Point(6, 165);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(89, 14);
            this.labelCodigo.TabIndex = 17;
            this.labelCodigo.Text = "Código postal: ";
            // 
            // poblacionCB
            // 
            this.poblacionCB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poblacionCB.FormattingEnabled = true;
            this.poblacionCB.Location = new System.Drawing.Point(94, 93);
            this.poblacionCB.Name = "poblacionCB";
            this.poblacionCB.Size = new System.Drawing.Size(176, 24);
            this.poblacionCB.TabIndex = 7;
            this.poblacionCB.TabStop = false;
            this.poblacionCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // provinciaCB
            // 
            this.provinciaCB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinciaCB.FormattingEnabled = true;
            this.provinciaCB.Location = new System.Drawing.Point(94, 26);
            this.provinciaCB.Name = "provinciaCB";
            this.provinciaCB.Size = new System.Drawing.Size(176, 24);
            this.provinciaCB.TabIndex = 6;
            this.provinciaCB.TabStop = false;
            this.provinciaCB.SelectedIndexChanged += new System.EventHandler(this.provinciaCB_SelectedIndexChanged);
            this.provinciaCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelProvincia.Location = new System.Drawing.Point(7, 34);
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
            this.labelPoblación.Location = new System.Drawing.Point(7, 98);
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
            this.DatosPersonalesGB.Location = new System.Drawing.Point(17, 33);
            this.DatosPersonalesGB.Name = "DatosPersonalesGB";
            this.DatosPersonalesGB.Size = new System.Drawing.Size(297, 86);
            this.DatosPersonalesGB.TabIndex = 1;
            this.DatosPersonalesGB.TabStop = false;
            this.DatosPersonalesGB.Text = "Datos Personales";
            // 
            // apellidosTB
            // 
            this.apellidosTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosTB.Location = new System.Drawing.Point(118, 52);
            this.apellidosTB.MaxLength = 15;
            this.apellidosTB.Name = "apellidosTB";
            this.apellidosTB.Size = new System.Drawing.Size(173, 22);
            this.apellidosTB.TabIndex = 2;
            this.apellidosTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
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
            this.nombreTB.MaxLength = 15;
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.Size = new System.Drawing.Size(173, 22);
            this.nombreTB.TabIndex = 1;
            this.nombreTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.particularRB);
            this.groupBox1.Controls.Add(this.empresaRB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.groupBox1.Location = new System.Drawing.Point(17, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // particularRB
            // 
            this.particularRB.AutoSize = true;
            this.particularRB.Location = new System.Drawing.Point(192, 22);
            this.particularRB.Name = "particularRB";
            this.particularRB.Size = new System.Drawing.Size(99, 20);
            this.particularRB.TabIndex = 5;
            this.particularRB.TabStop = true;
            this.particularRB.Text = "Particular";
            this.particularRB.UseVisualStyleBackColor = true;
            // 
            // empresaRB
            // 
            this.empresaRB.AutoSize = true;
            this.empresaRB.Location = new System.Drawing.Point(71, 22);
            this.empresaRB.Name = "empresaRB";
            this.empresaRB.Size = new System.Drawing.Size(90, 20);
            this.empresaRB.TabIndex = 4;
            this.empresaRB.TabStop = true;
            this.empresaRB.Text = "Empresa";
            this.empresaRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo:";
            // 
            // botonAtras
            // 
            this.botonAtras.AutoSize = true;
            this.botonAtras.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.botonAtras.Location = new System.Drawing.Point(337, 268);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(63, 23);
            this.botonAtras.TabIndex = 10;
            this.botonAtras.Text = "Atrás";
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            this.botonAtras.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonAtras.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // botonAñadir
            // 
            this.botonAñadir.AutoSize = true;
            this.botonAñadir.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.botonAñadir.Location = new System.Drawing.Point(225, 268);
            this.botonAñadir.Name = "botonAñadir";
            this.botonAñadir.Size = new System.Drawing.Size(78, 23);
            this.botonAñadir.TabIndex = 9;
            this.botonAñadir.Text = "Añadir";
            this.botonAñadir.Click += new System.EventHandler(this.boton_Click);
            this.botonAñadir.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonAñadir.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(23, 6);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 14);
            this.labelError.TabIndex = 8;
            // 
            // codPostalTB
            // 
            this.codPostalTB.EscribirLetras = false;
            this.codPostalTB.Location = new System.Drawing.Point(94, 160);
            this.codPostalTB.MaxLength = 5;
            this.codPostalTB.MaxLetras = 30;
            this.codPostalTB.Name = "codPostalTB";
            this.codPostalTB.Size = new System.Drawing.Size(176, 22);
            this.codPostalTB.TabIndex = 18;
            // 
            // GestionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 300);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonAñadir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contactoGB);
            this.Controls.Add(this.domicilioGB);
            this.Controls.Add(this.DatosPersonalesGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GestionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionCliente";
            this.contactoGB.ResumeLayout(false);
            this.contactoGB.PerformLayout();
            this.domicilioGB.ResumeLayout(false);
            this.domicilioGB.PerformLayout();
            this.DatosPersonalesGB.ResumeLayout(false);
            this.DatosPersonalesGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox contactoGB;
        public System.Windows.Forms.TextBox telefonoTB;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.GroupBox domicilioGB;
        private System.Windows.Forms.Label labelCodigo;
        public System.Windows.Forms.ComboBox poblacionCB;
        public System.Windows.Forms.ComboBox provinciaCB;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.Label labelPoblación;
        private System.Windows.Forms.GroupBox DatosPersonalesGB;
        public System.Windows.Forms.TextBox apellidosTB;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombre;
        public System.Windows.Forms.TextBox nombreTB;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label botonAtras;
        public System.Windows.Forms.Label botonAñadir;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton empresaRB;
        public System.Windows.Forms.RadioButton particularRB;
        public TextBoxNumerico.TextBoxNumerico codPostalTB;
    }
}