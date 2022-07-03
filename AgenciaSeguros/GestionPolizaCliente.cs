using System;
using MySqlConnector;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaSeguros
{
    public partial class GestionPolizaCliente : Form
    {
        public static int codCliente, codigo;
        MySqlConnection miConexion = new MySqlConnection();
        MySqlCommand miComando = new MySqlCommand();
        MySqlDataReader Lector;
        string strConexion = "server=127.0.0.1;uid=root;pwd=admin;database=agenciaseguros";

        public GestionPolizaCliente()
        {
            InitializeComponent();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarComboBox()
        {
            String[] listaEstados = { "Cobrada", "A cuenta", "Liquidada", "Pre anulada", "Anulada" };
            for (int i = 0; i < listaEstados.Length; i++)
            {
                estadoCB.Items.Add(listaEstados[i]);
            }
        }

        private void GestionPolizaCliente_Load(object sender, EventArgs e)
        {
            cargarComboBox();
        }
        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public bool existeIdPoliza(int numPoliza, Boolean forma)
        {
            Boolean existe = false;
            if (!forma)
            {
                miConexion = new MySqlConnection(strConexion);
                string Consulta = "SELECT NumPoliza FROM poliza WHERE NumPoliza = " + numPoliza + "";
                miComando = new MySqlCommand(Consulta, miConexion);
                miConexion.Open();
                Lector = miComando.ExecuteReader();
                while (Lector.Read())
                {
                    existe = true;
                }
                Lector.Close();
                miConexion.Close();
            }
            else
            {
                miConexion = new MySqlConnection(strConexion);
                string Consulta = "SELECT NumPoliza FROM poliza WHERE NumPoliza = " + numPoliza + " AND NumPoliza <> " + codigo + "";
                miComando = new MySqlCommand(Consulta, miConexion);
                miConexion.Open();
                Lector = miComando.ExecuteReader();
                while (Lector.Read())
                {
                    existe = true;

                }
                Lector.Close();
                miConexion.Close();
            }
            return existe;
        }

        private void boton_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(117, 194, 245);
        }

        private void boton_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(20, 29, 61);
        }

        private void importeTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void botonAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (numPolizaTB.Text.Equals("") || importeTB.Text.Equals("") || estadoCB.Text.Equals(""))
                {
                    labelError.Text = "El número de póliza, importe y estado son campos obligatorios";
                }
                else
                {
                    miConexion = new MySqlConnection(strConexion);
                    if (this.Text.Equals("Alta Póliza Cliente"))
                    {
                        if (!existeIdPoliza(int.Parse(numPolizaTB.Text), false))
                        {
                            miConexion.Open();
                            string Insertar = "INSERT INTO poliza (NumPoliza, CodCliente, Fecha, Importe, Estado, Observaciones) VALUES (" + int.Parse(numPolizaTB.Text) + ", " + codCliente + ", '" + fechaDP.Value.ToString("yyyy-MM-dd") + "', " + importeTB.Text + ", '" + estadoCB.SelectedItem + "', '" + observacionesTB.Text + "')";
                            miComando = new MySqlCommand(Insertar, miConexion);
                            miComando.ExecuteNonQuery();
                            miConexion.Close();
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Id de Poliza ya existe", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (!existeIdPoliza(int.Parse(numPolizaTB.Text), true))
                        {
                            miConexion.Open();
                            string Modificar = "UPDATE poliza SET NumPoliza = " + int.Parse(numPolizaTB.Text) + ", CodCliente = " + codCliente + ", Fecha = '" + fechaDP.Value.ToString("yyyy-MM-dd") + "', Importe = " + importeTB.Text.ToString().Replace(",", ".") + ", Estado = '" + estadoCB.Text + "', Observaciones = '" + observacionesTB.Text + "' WHERE NumPoliza = " + codigo + "";
                            miComando = new MySqlCommand(Modificar, miConexion);
                            miComando.ExecuteNonQuery();
                            miConexion.Close();
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Id de Poliza ya existe", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            } catch (Exception)
            {
                MessageBox.Show("Error inesperado", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

