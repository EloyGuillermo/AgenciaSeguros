
namespace AgenciaSeguros
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.imagenLogo = new System.Windows.Forms.PictureBox();
            this.botonLogin = new System.Windows.Forms.Label();
            this.botonCerrar = new System.Windows.Forms.Label();
            this.imagenPersona = new System.Windows.Forms.PictureBox();
            this.imagenCandado = new System.Windows.Forms.PictureBox();
            this.usuarioTB = new bibliotecaControlesPropios.TextBoxHint();
            this.contraseñaTB = new bibliotecaControlesPropios.TextBoxHint();
            this.imagenVerContraseña = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelAunSinCuenta = new System.Windows.Forms.Label();
            this.repetirContraseñaTB = new bibliotecaControlesPropios.TextBoxHint();
            this.imagenCandado2 = new System.Windows.Forms.PictureBox();
            this.labelRepetir = new System.Windows.Forms.Label();
            this.imagenVerContraseña2 = new System.Windows.Forms.PictureBox();
            this.labelError2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCandado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenVerContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCandado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenVerContraseña2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelUsuario.Location = new System.Drawing.Point(320, 71);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(101, 23);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario: ";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelContraseña.Location = new System.Drawing.Point(320, 125);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(130, 23);
            this.labelContraseña.TabIndex = 1;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // imagenLogo
            // 
            this.imagenLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenLogo.BackgroundImage")));
            this.imagenLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenLogo.Location = new System.Drawing.Point(-3, -6);
            this.imagenLogo.Name = "imagenLogo";
            this.imagenLogo.Size = new System.Drawing.Size(317, 316);
            this.imagenLogo.TabIndex = 5;
            this.imagenLogo.TabStop = false;
            // 
            // botonLogin
            // 
            this.botonLogin.AutoSize = true;
            this.botonLogin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.botonLogin.Location = new System.Drawing.Point(376, 239);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(66, 23);
            this.botonLogin.TabIndex = 7;
            this.botonLogin.Text = "Login";
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            this.botonLogin.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonLogin.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // botonCerrar
            // 
            this.botonCerrar.AutoSize = true;
            this.botonCerrar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.botonCerrar.Location = new System.Drawing.Point(472, 239);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(76, 23);
            this.botonCerrar.TabIndex = 8;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            this.botonCerrar.MouseEnter += new System.EventHandler(this.boton_MouseEnter);
            this.botonCerrar.MouseLeave += new System.EventHandler(this.boton_MouseLeave);
            // 
            // imagenPersona
            // 
            this.imagenPersona.BackColor = System.Drawing.Color.DarkGray;
            this.imagenPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenPersona.BackgroundImage")));
            this.imagenPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenPersona.Location = new System.Drawing.Point(448, 75);
            this.imagenPersona.Name = "imagenPersona";
            this.imagenPersona.Size = new System.Drawing.Size(22, 21);
            this.imagenPersona.TabIndex = 9;
            this.imagenPersona.TabStop = false;
            // 
            // imagenCandado
            // 
            this.imagenCandado.BackColor = System.Drawing.Color.DarkGray;
            this.imagenCandado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenCandado.BackgroundImage")));
            this.imagenCandado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenCandado.Location = new System.Drawing.Point(448, 128);
            this.imagenCandado.Name = "imagenCandado";
            this.imagenCandado.Size = new System.Drawing.Size(22, 21);
            this.imagenCandado.TabIndex = 10;
            this.imagenCandado.TabStop = false;
            // 
            // usuarioTB
            // 
            this.usuarioTB.ColorHint = System.Drawing.Color.Gray;
            this.usuarioTB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTB.ForeColor = System.Drawing.Color.Gray;
            this.usuarioTB.Hint = "Usuario";
            this.usuarioTB.Location = new System.Drawing.Point(469, 75);
            this.usuarioTB.Name = "usuarioTB";
            this.usuarioTB.Size = new System.Drawing.Size(135, 21);
            this.usuarioTB.TabIndex = 15;
            this.usuarioTB.Text = "Usuario";
            this.usuarioTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // contraseñaTB
            // 
            this.contraseñaTB.ColorHint = System.Drawing.Color.Gray;
            this.contraseñaTB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaTB.ForeColor = System.Drawing.Color.Gray;
            this.contraseñaTB.Hint = "Contraseña";
            this.contraseñaTB.Location = new System.Drawing.Point(469, 128);
            this.contraseñaTB.Name = "contraseñaTB";
            this.contraseñaTB.PasswordChar = '•';
            this.contraseñaTB.Size = new System.Drawing.Size(135, 21);
            this.contraseñaTB.TabIndex = 16;
            this.contraseñaTB.Text = "Contraseña";
            this.contraseñaTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // imagenVerContraseña
            // 
            this.imagenVerContraseña.BackColor = System.Drawing.Color.White;
            this.imagenVerContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenVerContraseña.BackgroundImage")));
            this.imagenVerContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenVerContraseña.Location = new System.Drawing.Point(582, 129);
            this.imagenVerContraseña.Name = "imagenVerContraseña";
            this.imagenVerContraseña.Size = new System.Drawing.Size(22, 19);
            this.imagenVerContraseña.TabIndex = 17;
            this.imagenVerContraseña.TabStop = false;
            this.imagenVerContraseña.Click += new System.EventHandler(this.imagenVerContraseña_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(424, 160);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 14);
            this.labelError.TabIndex = 18;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "EloySeguros";
            this.notifyIcon.Visible = true;
            // 
            // labelAunSinCuenta
            // 
            this.labelAunSinCuenta.AutoSize = true;
            this.labelAunSinCuenta.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAunSinCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(194)))), ((int)(((byte)(245)))));
            this.labelAunSinCuenta.Location = new System.Drawing.Point(396, 273);
            this.labelAunSinCuenta.Name = "labelAunSinCuenta";
            this.labelAunSinCuenta.Size = new System.Drawing.Size(133, 15);
            this.labelAunSinCuenta.TabIndex = 19;
            this.labelAunSinCuenta.Text = "¿Aún no tienes cuenta?";
            this.labelAunSinCuenta.Click += new System.EventHandler(this.labelAunSinCuenta_Click);
            this.labelAunSinCuenta.MouseEnter += new System.EventHandler(this.labelAunSinCuenta_MouseEnter);
            this.labelAunSinCuenta.MouseLeave += new System.EventHandler(this.labelAunSinCuenta_MouseLeave);
            // 
            // repetirContraseñaTB
            // 
            this.repetirContraseñaTB.ColorHint = System.Drawing.Color.Gray;
            this.repetirContraseñaTB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repetirContraseñaTB.ForeColor = System.Drawing.Color.Gray;
            this.repetirContraseñaTB.Hint = "Contraseña";
            this.repetirContraseñaTB.Location = new System.Drawing.Point(469, 186);
            this.repetirContraseñaTB.Name = "repetirContraseñaTB";
            this.repetirContraseñaTB.PasswordChar = '•';
            this.repetirContraseñaTB.Size = new System.Drawing.Size(135, 21);
            this.repetirContraseñaTB.TabIndex = 22;
            this.repetirContraseñaTB.Text = "Contraseña";
            this.repetirContraseñaTB.Visible = false;
            // 
            // imagenCandado2
            // 
            this.imagenCandado2.BackColor = System.Drawing.Color.DarkGray;
            this.imagenCandado2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenCandado2.BackgroundImage")));
            this.imagenCandado2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenCandado2.Location = new System.Drawing.Point(448, 186);
            this.imagenCandado2.Name = "imagenCandado2";
            this.imagenCandado2.Size = new System.Drawing.Size(22, 21);
            this.imagenCandado2.TabIndex = 21;
            this.imagenCandado2.TabStop = false;
            this.imagenCandado2.Visible = false;
            // 
            // labelRepetir
            // 
            this.labelRepetir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepetir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRepetir.Location = new System.Drawing.Point(320, 170);
            this.labelRepetir.Name = "labelRepetir";
            this.labelRepetir.Size = new System.Drawing.Size(130, 55);
            this.labelRepetir.TabIndex = 20;
            this.labelRepetir.Text = "Repetir Contraseña:";
            this.labelRepetir.Visible = false;
            // 
            // imagenVerContraseña2
            // 
            this.imagenVerContraseña2.BackColor = System.Drawing.Color.White;
            this.imagenVerContraseña2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenVerContraseña2.BackgroundImage")));
            this.imagenVerContraseña2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenVerContraseña2.Location = new System.Drawing.Point(582, 187);
            this.imagenVerContraseña2.Name = "imagenVerContraseña2";
            this.imagenVerContraseña2.Size = new System.Drawing.Size(22, 19);
            this.imagenVerContraseña2.TabIndex = 23;
            this.imagenVerContraseña2.TabStop = false;
            this.imagenVerContraseña2.Visible = false;
            this.imagenVerContraseña2.Click += new System.EventHandler(this.imagenVerContraseña2_Click);
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError2.ForeColor = System.Drawing.Color.Red;
            this.labelError2.Location = new System.Drawing.Point(424, 218);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(0, 14);
            this.labelError2.TabIndex = 24;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 297);
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.imagenVerContraseña2);
            this.Controls.Add(this.imagenCandado2);
            this.Controls.Add(this.labelRepetir);
            this.Controls.Add(this.labelAunSinCuenta);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.imagenVerContraseña);
            this.Controls.Add(this.contraseñaTB);
            this.Controls.Add(this.usuarioTB);
            this.Controls.Add(this.imagenCandado);
            this.Controls.Add(this.imagenPersona);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.imagenLogo);
            this.Controls.Add(this.repetirContraseñaTB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCandado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenVerContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCandado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenVerContraseña2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.PictureBox imagenLogo;
        private System.Windows.Forms.Label botonLogin;
        private System.Windows.Forms.Label botonCerrar;
        private System.Windows.Forms.PictureBox imagenPersona;
        private System.Windows.Forms.PictureBox imagenCandado;
        private bibliotecaControlesPropios.TextBoxHint usuarioTB;
        private bibliotecaControlesPropios.TextBoxHint contraseñaTB;
        private System.Windows.Forms.PictureBox imagenVerContraseña;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label labelAunSinCuenta;
        private bibliotecaControlesPropios.TextBoxHint repetirContraseñaTB;
        private System.Windows.Forms.PictureBox imagenCandado2;
        private System.Windows.Forms.Label labelRepetir;
        private System.Windows.Forms.PictureBox imagenVerContraseña2;
        private System.Windows.Forms.Label labelError2;
    }
}

