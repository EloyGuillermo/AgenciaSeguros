
namespace AgenciaSeguros
{
    partial class GestionPolizaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPolizaCliente));
            this.fechaDP = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.importeTB = new System.Windows.Forms.TextBox();
            this.labelImporte = new System.Windows.Forms.Label();
            this.estadoCB = new System.Windows.Forms.ComboBox();
            this.labelPoliza = new System.Windows.Forms.Label();
            this.labelPoblación = new System.Windows.Forms.Label();
            this.botonAtras = new System.Windows.Forms.Label();
            this.botonAñadir = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.numPolizaTB = new TextBoxNumerico.TextBoxNumerico();
            this.observacionesTB = new TextBoxNumerico.TextBoxNumerico();
            this.SuspendLayout();
            // 
            // fechaDP
            // 
            this.fechaDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDP.Location = new System.Drawing.Point(171, 179);
            this.fechaDP.Name = "fechaDP";
            this.fechaDP.Size = new System.Drawing.Size(195, 20);
            this.fechaDP.TabIndex = 3;
            this.fechaDP.Value = new System.DateTime(2022, 2, 25, 0, 0, 0, 0);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelFecha.Location = new System.Drawing.Point(26, 183);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(56, 16);
            this.labelFecha.TabIndex = 40;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelEstado.Location = new System.Drawing.Point(26, 136);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(62, 16);
            this.labelEstado.TabIndex = 39;
            this.labelEstado.Text = "Estado:";
            // 
            // importeTB
            // 
            this.importeTB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeTB.Location = new System.Drawing.Point(171, 87);
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
            this.labelImporte.Location = new System.Drawing.Point(26, 90);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(74, 16);
            this.labelImporte.TabIndex = 32;
            this.labelImporte.Text = "Importe:";
            // 
            // estadoCB
            // 
            this.estadoCB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCB.FormattingEnabled = true;
            this.estadoCB.Location = new System.Drawing.Point(171, 132);
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
            this.labelPoliza.Location = new System.Drawing.Point(26, 45);
            this.labelPoliza.Name = "labelPoliza";
            this.labelPoliza.Size = new System.Drawing.Size(139, 16);
            this.labelPoliza.TabIndex = 36;
            this.labelPoliza.Text = "Número de Póliza:";
            // 
            // labelPoblación
            // 
            this.labelPoblación.AutoSize = true;
            this.labelPoblación.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoblación.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelPoblación.Location = new System.Drawing.Point(388, 45);
            this.labelPoblación.Name = "labelPoblación";
            this.labelPoblación.Size = new System.Drawing.Size(119, 16);
            this.labelPoblación.TabIndex = 35;
            this.labelPoblación.Text = "Observaciones:";
            // 
            // botonAtras
            // 
            this.botonAtras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAtras.AutoSize = true;
            this.botonAtras.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.botonAtras.Location = new System.Drawing.Point(419, 230);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(63, 23);
            this.botonAtras.TabIndex = 43;
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
            this.botonAñadir.Location = new System.Drawing.Point(307, 230);
            this.botonAñadir.Name = "botonAñadir";
            this.botonAñadir.Size = new System.Drawing.Size(78, 23);
            this.botonAñadir.TabIndex = 42;
            this.botonAñadir.Text = "Añadir";
            this.botonAñadir.Click += new System.EventHandler(this.botonAñadir_Click);
            this.botonAñadir.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonAñadir.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(33, 12);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 14);
            this.labelError.TabIndex = 44;
            // 
            // numPolizaTB
            // 
            this.numPolizaTB.EscribirLetras = false;
            this.numPolizaTB.Location = new System.Drawing.Point(171, 44);
            this.numPolizaTB.MaxLetras = 30;
            this.numPolizaTB.Name = "numPolizaTB";
            this.numPolizaTB.Size = new System.Drawing.Size(195, 20);
            this.numPolizaTB.TabIndex = 0;
            // 
            // observacionesTB
            // 
            this.observacionesTB.EscribirLetras = true;
            this.observacionesTB.Location = new System.Drawing.Point(513, 44);
            this.observacionesTB.MaxLetras = 50;
            this.observacionesTB.Multiline = true;
            this.observacionesTB.Name = "observacionesTB";
            this.observacionesTB.Size = new System.Drawing.Size(266, 78);
            this.observacionesTB.TabIndex = 4;
            // 
            // GestionPolizaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 262);
            this.Controls.Add(this.observacionesTB);
            this.Controls.Add(this.numPolizaTB);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonAñadir);
            this.Controls.Add(this.fechaDP);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.importeTB);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.estadoCB);
            this.Controls.Add(this.labelPoliza);
            this.Controls.Add(this.labelPoblación);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GestionPolizaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionPolizaCliente";
            this.Load += new System.EventHandler(this.GestionPolizaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker fechaDP;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelEstado;
        public System.Windows.Forms.TextBox importeTB;
        private System.Windows.Forms.Label labelImporte;
        public System.Windows.Forms.ComboBox estadoCB;
        private System.Windows.Forms.Label labelPoliza;
        private System.Windows.Forms.Label labelPoblación;
        public System.Windows.Forms.Label botonAtras;
        public System.Windows.Forms.Label botonAñadir;
        private System.Windows.Forms.Label labelError;
        public TextBoxNumerico.TextBoxNumerico numPolizaTB;
        public TextBoxNumerico.TextBoxNumerico observacionesTB;
    }
}