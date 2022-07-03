
namespace AgenciaSeguros
{
    partial class SeguroEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeguroEliminar));
            this.labelSeguroSalir = new System.Windows.Forms.Label();
            this.botonNo = new System.Windows.Forms.Label();
            this.botonSi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSeguroSalir
            // 
            this.labelSeguroSalir.AutoSize = true;
            this.labelSeguroSalir.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeguroSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.labelSeguroSalir.Location = new System.Drawing.Point(43, 26);
            this.labelSeguroSalir.Name = "labelSeguroSalir";
            this.labelSeguroSalir.Size = new System.Drawing.Size(391, 25);
            this.labelSeguroSalir.TabIndex = 22;
            this.labelSeguroSalir.Text = "¿Está seguro que desea eliminarlo?";
            // 
            // botonNo
            // 
            this.botonNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonNo.AutoSize = true;
            this.botonNo.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.botonNo.Location = new System.Drawing.Point(275, 69);
            this.botonNo.Name = "botonNo";
            this.botonNo.Size = new System.Drawing.Size(38, 23);
            this.botonNo.TabIndex = 45;
            this.botonNo.Text = "No";
            this.botonNo.Click += new System.EventHandler(this.botonNo_Click);
            this.botonNo.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonNo.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // botonSi
            // 
            this.botonSi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonSi.AutoSize = true;
            this.botonSi.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.botonSi.Location = new System.Drawing.Point(163, 69);
            this.botonSi.Name = "botonSi";
            this.botonSi.Size = new System.Drawing.Size(29, 23);
            this.botonSi.TabIndex = 44;
            this.botonSi.Text = "Sí";
            this.botonSi.Click += new System.EventHandler(this.botonSi_Click);
            this.botonSi.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonSi.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // SeguroEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 111);
            this.Controls.Add(this.botonNo);
            this.Controls.Add(this.botonSi);
            this.Controls.Add(this.labelSeguroSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeguroEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSeguroSalir;
        public System.Windows.Forms.Label botonNo;
        public System.Windows.Forms.Label botonSi;
    }
}