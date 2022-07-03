using MySqlConnector;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AgenciaSeguros
{
    public partial class Login : Form
    {
        MySqlConnection miConexion = new MySqlConnection();
        MySqlCommand miComando = new MySqlCommand();
        MySqlDataReader Lector;
        string strConexion = "server=127.0.0.1;uid=root;pwd=admin;database=agenciaseguros";
        public static String usuario;

        public Login()
        {
            InitializeComponent();
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (botonLogin.Text.Equals("Login"))
                {
                    if (!usuarioTB.Text.Equals("") && !contraseñaTB.Text.Equals("") && (usuarioTB.ForeColor != Color.Gray && contraseñaTB.ForeColor != Color.Gray))
                    {
                        Boolean existe = false;
                        miConexion.ConnectionString = strConexion;
                        miConexion.Open();
                        string Consulta = "SELECT * FROM usuario WHERE usuario LIKE '" + usuarioTB.Text + "' AND contraseña LIKE '" + contraseñaTB.Text + "'";
                        miComando = new MySqlCommand(Consulta, miConexion);
                        Lector = miComando.ExecuteReader();

                        while (Lector.Read())
                        {
                            existe = true;
                        }
                        Lector.Close();
                        miConexion.Close();

                        if (existe)
                        {
                            usuario = usuarioTB.Text;
                            Principal p = new Principal();
                            this.Hide();
                            p.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            labelError.Text = "Usuario y contraseña incorrectos";
                            labelError2.Text = "";
                        }
                    }
                    else
                    {
                        labelError.Text = "        Faltan datos por rellenar";
                        labelError2.Text = "";
                    }
                }
                else
                {
                    if (!usuarioTB.Text.Equals("") && !contraseñaTB.Text.Equals("") && !repetirContraseñaTB.Text.Equals("") && (usuarioTB.ForeColor != Color.Gray && contraseñaTB.ForeColor != Color.Gray && repetirContraseñaTB.ForeColor != Color.Gray))
                    {
                        Boolean existe = false;
                        miConexion.ConnectionString = strConexion;
                        miConexion.Open();
                        string Consulta = "SELECT * FROM usuario WHERE usuario LIKE '" + usuarioTB.Text + "' OR contraseña LIKE '" + contraseñaTB.Text + "'";
                        miComando = new MySqlCommand(Consulta, miConexion);
                        Lector = miComando.ExecuteReader();

                        while (Lector.Read())
                        {
                            existe = true;
                        }
                        Lector.Close();
                        miConexion.Close();

                        if (!existe)
                        {
                            if (contraseñaTB.Text.Equals(repetirContraseñaTB.Text))
                            {
                                miConexion.Open();
                                string Insertar = "INSERT INTO usuario (usuario, contraseña) VALUES ('" + usuarioTB.Text + "', '" + contraseñaTB.Text + "')";
                                miComando = new MySqlCommand(Insertar, miConexion);
                                miComando.ExecuteNonQuery();
                                miConexion.Close();
                                labelAunSinCuenta.Text = "Sí tengo cuenta";
                                labelAunSinCuenta_Click(sender, e);
                                usuarioTB.Text = "";
                                contraseñaTB.Text = "";
                                MessageBox.Show("Usuario registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                labelError2.Text = "Las contraseñan no coindicen";
                                labelError.Text = "";
                            }
                        }
                        else
                        {
                            labelError2.Text = "    Ya existe ese usuario";
                            labelError.Text = "";
                        }
                    }
                    else
                    {
                        labelError2.Text = "        Faltan datos por rellenar";
                        labelError.Text = "";
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error inesperado, reinicia el servicio de MySQL", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(117, 194, 245);
        }

        private void boton_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.White;
        }

        private void imagenVerContraseña_Click(object sender, EventArgs e)
        {
            if (imagenVerContraseña.Name.Equals("imagenVerContraseña"))
            {
                imagenVerContraseña.BackgroundImage = Image.FromFile("invisible.png");
                contraseñaTB.PasswordChar = '\0';
                imagenVerContraseña.Name = "imagenContraseñaDescubierta";

            }
            else
            {
                imagenVerContraseña.BackgroundImage = Image.FromFile("ver.png");
                contraseñaTB.PasswordChar = '•';
                imagenVerContraseña.Name = "imagenVerContraseña";
            }
        }

        private void imagenVerContraseña2_Click(object sender, EventArgs e)
        {
            if (imagenVerContraseña2.Name.Equals("imagenVerContraseña2"))
            {
                imagenVerContraseña2.BackgroundImage = Image.FromFile("invisible.png");
                repetirContraseñaTB.PasswordChar = '\0';
                imagenVerContraseña2.Name = "imagenContraseñaDescubierta";

            }
            else
            {
                imagenVerContraseña2.BackgroundImage = Image.FromFile("ver.png");
                repetirContraseñaTB.PasswordChar = '•';
                imagenVerContraseña2.Name = "imagenVerContraseña";
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botonLogin_Click(sender, e);
            }
        }

        private void labelAunSinCuenta_Click(object sender, EventArgs e)
        {
            if (!labelAunSinCuenta.Text.Equals("Sí tengo cuenta"))
            {
                labelRepetir.Visible = true;
                repetirContraseñaTB.Visible = true;
                imagenVerContraseña2.Visible = true;
                imagenCandado2.Visible = true;
                labelAunSinCuenta.Location = new Point(412, 273);
                labelAunSinCuenta.Text = "Sí tengo cuenta";
                botonLogin.Text = "Registro";
            }
            else
            {
                labelRepetir.Visible = false;
                repetirContraseñaTB.Visible = false;
                imagenVerContraseña2.Visible = false;
                imagenCandado2.Visible = false;
                labelAunSinCuenta.Location = new Point(396, 273);
                labelAunSinCuenta.Text = "¿Aún no tienes cuenta?";
                botonLogin.Text = "Login";
            }
            labelError.Text = "";
            labelError2.Text = "";
        }

        private void labelAunSinCuenta_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.White;
        }

        private void labelAunSinCuenta_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(117, 194, 245);
        }
    }
}