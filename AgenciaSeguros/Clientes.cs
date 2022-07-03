using MySqlConnector;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgenciaSeguros
{
    public partial class Clientes : Form
    {
        MySqlConnection miConexion = new MySqlConnection();
        MySqlCommand miComando = new MySqlCommand();
        MySqlDataReader Lector;
        string strConexion = "server=127.0.0.1;uid=root;pwd=admin;database=agenciaseguros";

        public Clientes()
        {
            InitializeComponent();
            labelCliente.Text += Login.usuario;
        }

        private void Clientes_Load(object sender, System.EventArgs e)
        {
            actualizarTabla();
            if (tablaClientes.CurrentCell != null)
                tablaClientes.CurrentCell.Selected = false;
        }

        public void actualizarTabla()
        {
            tablaClientes.Rows.Clear();

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
                Consulta = "SELECT municipio FROM municipio WHERE municipio LIKE '" + Lector.GetString(4)+"'";
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
                Consulta = "SELECT provincia FROM provincia WHERE provincia LIKE '" + Lector.GetString(6)+"'";
                miComando2 = new MySqlCommand(Consulta, miConexion2);
                Lector2 = miComando2.ExecuteReader();

                while (Lector2.Read())
                {
                    provincia = Lector2.GetString(0);
                }
                Lector2.Close();
                miConexion2.Close();

                tablaClientes.Rows.Add(Lector.GetString(1), Lector.GetString(2), Lector.GetString(3), municipio, Lector.GetString(5), provincia, Lector.GetString(7));

            }
            Lector.Close();
            miConexion.Close();
        }

        private void añadirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GestionCliente gc = new GestionCliente();
            gc.Text = "Alta Cliente";
            gc.botonAñadir.Text = "Añadir";
            gc.ShowDialog();
            if (gc.DialogResult == DialogResult.OK)
            {
                actualizarTabla();
                MessageBox.Show("Cliente insertado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (tablaClientes.CurrentCell != null)
            {
                if (!tablaClientes.CurrentCell.Selected)
                {
                    MessageBox.Show("Selecciona a quien modificar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String nombre = tablaClientes.CurrentRow.Cells[0].Value.ToString();
                    int Codigo = -1;
                    miConexion.ConnectionString = strConexion;
                    miConexion.Open();
                    string Consulta = "SELECT Codigo FROM cliente WHERE Nombre LIKE '"+nombre+"'";
                    miComando = new MySqlCommand(Consulta, miConexion);
                    Lector = miComando.ExecuteReader();

                    while (Lector.Read())
                    {
                        Codigo = Lector.GetInt32(0);
                    }
                    Lector.Close();
                    miConexion.Close();

                    GestionCliente.codigo = Codigo;
                    if (Codigo != -1)
                    {
                        GestionCliente gc = new GestionCliente();
                        gc.Text = "Modificación Cliente";
                        gc.botonAñadir.Text = "Modificar";

                        gc.nombreTB.Text = tablaClientes.CurrentRow.Cells[0].Value.ToString();
                        gc.apellidosTB.Text = tablaClientes.CurrentRow.Cells[1].Value.ToString();
                        gc.telefonoTB.Text = tablaClientes.CurrentRow.Cells[2].Value.ToString();
                        gc.poblacionCB.Text = tablaClientes.CurrentRow.Cells[3].Value.ToString();
                        gc.codPostalTB.Text = tablaClientes.CurrentRow.Cells[4].Value.ToString();
                        gc.provinciaCB.Text = tablaClientes.CurrentRow.Cells[5].Value.ToString();
                        if (tablaClientes.CurrentRow.Cells[6].Value.ToString().Equals("Empresa"))
                        {
                            gc.empresaRB.Checked = true;
                        }
                        else if (tablaClientes.CurrentRow.Cells[6].Value.ToString().Equals("Particular"))
                        {
                            gc.particularRB.Checked = true;
                        }
                        gc.ShowDialog();
                        if (gc.DialogResult == DialogResult.OK)
                        {
                            actualizarTabla();
                            MessageBox.Show("Cliente modificado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona a quien modificar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaClientes.CurrentCell != null)
            {
                if (!tablaClientes.CurrentCell.Selected)
                {
                    MessageBox.Show("Selecciona a quien eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SeguroEliminar se = new SeguroEliminar();
                    se.ShowDialog();
                    if (se.DialogResult == DialogResult.OK)
                    {
                        String nombre = tablaClientes.CurrentRow.Cells[0].Value.ToString();
                        int Codigo = -1;
                        miConexion.ConnectionString = strConexion;
                        miConexion.Open();
                        string Consulta = "SELECT Codigo FROM cliente WHERE Nombre LIKE '" + nombre + "'";
                        miComando = new MySqlCommand(Consulta, miConexion);
                        Lector = miComando.ExecuteReader();

                        while (Lector.Read())
                        {
                            Codigo = Lector.GetInt32(0);
                        }
                        Lector.Close();

                        string strEliminar = "DELETE FROM cliente WHERE Codigo = " + Codigo + "";
                        miComando = new MySqlCommand(strEliminar, miConexion);
                        miComando.ExecuteNonQuery();
                        miConexion.Close();
                        actualizarTabla();
                        MessageBox.Show("Cliente eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona a quien eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void volverAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void tablaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            labelVisualizarPolizas_Click(sender,e);
        }

        private void boton_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.FromArgb(117, 194, 245);
        }

        private void boton_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.FromArgb(53, 121, 169);
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            if (tablaClientes.CurrentCell != null)
                tablaClientes.CurrentCell.Selected = false;
            labelVisualizarPolizas.Visible = false;
        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelVisualizarPolizas.Visible = true;
        }

        private void labelVisualizarPolizas_Click(object sender, EventArgs e)
        {
            PolizaCliente p = new PolizaCliente();
            p.Text = "Pólizas de " +tablaClientes.CurrentRow.Cells[0].Value;
            miConexion = new MySqlConnection(strConexion);
            string Consulta = "SELECT Codigo FROM cliente WHERE Nombre LIKE '" + tablaClientes.CurrentRow.Cells[0].Value.ToString() + "' AND Telefono LIKE '" + tablaClientes.CurrentRow.Cells[2].Value.ToString() + "' AND Apellidos LIKE '"+ tablaClientes.CurrentRow.Cells[1].Value.ToString()+"'";
            miComando = new MySqlCommand(Consulta, miConexion);
            miConexion.Open();
            Lector = miComando.ExecuteReader();
            while (Lector.Read())
            {
                PolizaCliente.codigoCliente = int.Parse(Lector.GetValue(0).ToString());
            }
            Lector.Close();
            miConexion.Close();
            p.nombreTB.Text = tablaClientes.CurrentRow.Cells[0].Value.ToString();
            p.apellidosTB.Text = tablaClientes.CurrentRow.Cells[1].Value.ToString();
            p.telefonoTB.Text = tablaClientes.CurrentRow.Cells[2].Value.ToString();
            p.poblacionCB.Text = tablaClientes.CurrentRow.Cells[3].Value.ToString();
            p.codPostalTB.Text = tablaClientes.CurrentRow.Cells[4].Value.ToString();
            p.provinciaCB.Text = tablaClientes.CurrentRow.Cells[5].Value.ToString();
            p.tipoTB.Text = tablaClientes.CurrentRow.Cells[6].Value.ToString();
            p.ShowDialog();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionInforme gi = new GestionInforme();
            gi.ShowDialog();
        }
    }
}
