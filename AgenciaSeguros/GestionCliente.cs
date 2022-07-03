using MySqlConnector;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgenciaSeguros
{
    public partial class GestionCliente : Form
    {
        public static int codigo;
        MySqlConnection miConexion = new MySqlConnection();
        MySqlCommand miComando = new MySqlCommand();
        MySqlDataReader Lector;
        string strConexion = "server=127.0.0.1;uid=root;pwd=admin;database=agenciaseguros";

        public GestionCliente()
        {
            InitializeComponent();
            cargarComboBox();
        }

        public void cargarComboBox()
        {
            miConexion.ConnectionString = strConexion;
            miConexion.Open();

            string Consulta = "SELECT provincia FROM provincia";
            miComando = new MySqlCommand(Consulta, miConexion);
            Lector = miComando.ExecuteReader();

            while (Lector.Read())
            {
                provinciaCB.Items.Add(Lector.GetString(0));
            }
            Lector.Close();
            miConexion.Close();
        }

        private void botonAtrás_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void provinciaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            poblacionCB.Items.Clear();
            miConexion.ConnectionString = strConexion;
            miConexion.Open();

            string Consulta = "SELECT municipio FROM municipio WHERE provincia = (SELECT id FROM provincia WHERE provincia LIKE '" + provinciaCB.SelectedItem + "')";
            miComando = new MySqlCommand(Consulta, miConexion);
            Lector = miComando.ExecuteReader();

            while (Lector.Read())
            {
                poblacionCB.Items.Add(Lector.GetString(0));
            }
            Lector.Close();
            miConexion.Close();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            if (nombreTB.Text.Equals("") || apellidosTB.Text.Equals("") || telefonoTB.Text.Equals(""))
            {
                labelError.Text = "*Introduce al menos nombre, apellidos y teléfono";
            }
            else
            {
                String tipo = "";
                if (empresaRB.Checked)
                {
                    tipo = "Empresa";
                }
                else if (particularRB.Checked)
                {
                    tipo = "Particular";
                }
                miConexion.ConnectionString = strConexion;
                if (this.Text.Equals("Alta Cliente"))
                {
                    miConexion.Open();
                    string Insertar = "INSERT INTO cliente (Nombre, Apellidos, Telefono, Poblacion, Cod_Postal, Provincia , Tipo) VALUES ('" + nombreTB.Text + "', '" + apellidosTB.Text + "', '" + telefonoTB.Text + "', '" + poblacionCB.SelectedItem + "', '" + codPostalTB.Text + "', '" + provinciaCB.SelectedItem + "', '" + tipo + "')";
                    miComando = new MySqlCommand(Insertar, miConexion);
                    miComando.ExecuteNonQuery();
                    miConexion.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    miConexion.Open();
                    string Modificar = "UPDATE cliente SET Nombre = '" + nombreTB.Text + "', Apellidos = '" + apellidosTB.Text + "', Telefono = '" + telefonoTB.Text + "', Poblacion = '" + poblacionCB.SelectedItem + "', Cod_Postal = '" + codPostalTB.Text + "', Provincia = '" + provinciaCB.SelectedItem + "', Tipo = '" + tipo + "' WHERE Codigo = " + codigo + "";
                    miComando = new MySqlCommand(Modificar, miConexion);
                    miComando.ExecuteNonQuery();
                    miConexion.Close();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void boton_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(117, 194, 245);
        }

        private void boton_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(20, 29, 61);
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
