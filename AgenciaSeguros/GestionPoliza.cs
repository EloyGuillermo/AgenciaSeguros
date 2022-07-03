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
    public partial class GestionPoliza : Form
    {
        public static int codigo, codigoCliente;
        MySqlConnection miConexion = new MySqlConnection();
        MySqlCommand miComando = new MySqlCommand();
        MySqlDataReader Lector;
        string strConexion = "server=127.0.0.1;uid=root;pwd=admin;database=agenciaseguros";

        public GestionPoliza()
        {
            InitializeComponent();
        }

        private void GestionPoliza_Load(object sender, EventArgs e)
        {
            actualizarTabla();
            cargarComboBox();
            if (this.Text.Equals("Alta Póliza"))
            {
                if (tablaClientes.CurrentCell != null)
                    tablaClientes.CurrentCell.Selected = false;
            }
        }

        public void cargarComboBox()
        {
            String[] listaEstados = { "Cobrada", "A cuenta", "Liquidada", "Pre anulada", "Anulada" };
            for (int i = 0; i < listaEstados.Length; i++)
            {
                estadoCB.Items.Add(listaEstados[i]);
            }
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buscarTB_TextChanged(object sender, EventArgs e)
        {
            if (buscarTB.Text.ToString().Equals(""))
            {
                tablaClientes.Rows.Clear();
                actualizarTabla();
            }
            else
            {
                if (buscarTB.Text.Length >= 3)
                {
                    tablaClientes.Rows.Clear();
                    miConexion = new MySqlConnection(strConexion);
                    string Consulta = "SELECT * FROM cliente WHERE Nombre LIKE '" + buscarTB.Text.ToString() + "%' OR Apellidos LIKE '" + buscarTB.Text.ToString() + "%' OR Telefono LIKE '" + buscarTB.Text.ToString() + "%'";
                    miComando = new MySqlCommand(Consulta, miConexion);
                    miConexion.Open();
                    Lector = miComando.ExecuteReader();
                    while (Lector.Read())
                    {
                        tablaClientes.Rows.Add(Lector.GetString(1), Lector.GetString(2), Lector.GetString(3), Lector.GetString(4), Lector.GetString(5), Lector.GetString(6), Lector.GetString(7));
                    }
                    Lector.Close();
                    Lector = null;
                }
            }
        }

        public void actualizarTabla()
        {
            tablaClientes.Rows.Clear();
            int i = 0;
            miConexion = new MySqlConnection(strConexion);
            string Consulta = "SELECT * FROM cliente";
            miComando = new MySqlCommand(Consulta, miConexion);
            miConexion.Open();
            Lector = miComando.ExecuteReader();
            while (Lector.Read())
            {

                MySqlConnection miConexion2 = new MySqlConnection();
                MySqlCommand miComando2 = new MySqlCommand();
                MySqlDataReader Lector2;

                string municipio = "";
                miConexion2 = new MySqlConnection(strConexion);
                miConexion2.Open();
                Consulta = "SELECT municipio FROM municipio WHERE municipio LIKE '" + Lector.GetString(4) + "'";
                miComando2 = new MySqlCommand(Consulta, miConexion2);
                Lector2 = miComando2.ExecuteReader();

                while (Lector2.Read())
                {
                    municipio = Lector2.GetString(0);
                }
                Lector2.Close();
                miConexion2.Close();

                string provincia = "";
                miConexion2 = new MySqlConnection(strConexion);
                miConexion2.Open();
                Consulta = "SELECT provincia FROM provincia WHERE provincia LIKE '" + Lector.GetString(6) + "'";
                miComando2 = new MySqlCommand(Consulta, miConexion2);
                Lector2 = miComando2.ExecuteReader();

                while (Lector2.Read())
                {
                    provincia = Lector2.GetString(0);
                }
                Lector2.Close();
                miConexion2.Close();

                tablaClientes.Rows.Add(Lector.GetString(1), Lector.GetString(2), Lector.GetString(3), municipio, Lector.GetString(5), provincia, Lector.GetString(7));

                if (!this.Text.Equals("Alta Póliza"))
                {
                    if (codigoCliente == int.Parse(Lector.GetValue(0).ToString()))
                    {
                        if (tablaClientes.CurrentCell != null)
                            tablaClientes.CurrentCell.Selected = false;
                        tablaClientes.Rows[i].Selected = true;
                        tablaClientes.CurrentCell = tablaClientes.Rows[i].Cells[0];
                    }
                }
                i++;
            }
            Lector.Close();
            miConexion.Close();
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


        private void boton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numPolizaTB.Text.Equals("") || importeTB.Text.Equals("") || estadoCB.Text.Equals(""))
                {
                    labelError.Text = "*Introduce al menos número de poliza, importe y estado";
                }
                else
                {
                    if (tablaClientes.CurrentCell.Selected != false)
                    {
                        int codCliente = 0;
                        miConexion = new MySqlConnection(strConexion);
                        string Consulta = "SELECT Codigo FROM cliente WHERE Nombre LIKE '" + tablaClientes.CurrentRow.Cells[0].Value.ToString() + "' AND Telefono LIKE '" + tablaClientes.CurrentRow.Cells[2].Value.ToString() + "'";
                        miComando = new MySqlCommand(Consulta, miConexion);
                        miConexion.Open();
                        Lector = miComando.ExecuteReader();
                        while (Lector.Read())
                        {
                            codCliente = int.Parse(Lector.GetValue(0).ToString());
                        }
                        Lector.Close();
                        miConexion.Close();

                        if (this.Text.Equals("Alta Póliza"))
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
                    else
                    {
                        MessageBox.Show("Selecciona a un cliente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } catch (Exception)
            {
                MessageBox.Show("Error inesperado", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
