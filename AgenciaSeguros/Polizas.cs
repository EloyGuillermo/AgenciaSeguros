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
    public partial class Polizas : Form
    {

        MySqlConnection miConexion = new MySqlConnection();
        MySqlCommand miComando = new MySqlCommand();
        MySqlDataReader Lector;
        string strConexion = "server=127.0.0.1;uid=root;pwd=admin;database=agenciaseguros";

        public Polizas()
        {
            InitializeComponent();
            labelCliente.Text += Login.usuario;

        }


        private void Polizas_Load(object sender, EventArgs e)
        {
            actualizarTabla();
            if (tablaPolizas.CurrentCell != null)
                tablaPolizas.CurrentCell.Selected = false;
        }

        public void actualizarTabla()
        {
            tablaPolizas.Rows.Clear();
            int i = 0;
            miConexion = new MySqlConnection(strConexion);
            string Consulta = "SELECT * FROM poliza ORDER BY FECHA DESC";
            miComando = new MySqlCommand(Consulta, miConexion);
            miConexion.Open();
            Lector = miComando.ExecuteReader();
            while (Lector.Read())
            {
                MySqlConnection miConexion2 = new MySqlConnection(strConexion);
                MySqlCommand miComando2 = new MySqlCommand();
                MySqlDataReader Lector2;

                double sumaPagos = 0;
                string Consulta2 = "SELECT * FROM pago WHERE NumPoliza = " + Lector.GetValue(0) + "";
                miComando2 = new MySqlCommand(Consulta2, miConexion2);
                miConexion2.Open();
                Lector2 = miComando2.ExecuteReader();
                while (Lector2.Read())
                {
                    sumaPagos += Lector2.GetDouble(3);
                }
                Lector2.Close();
                miConexion2.Close();

                MySqlConnection miConexion3 = new MySqlConnection(strConexion);
                MySqlCommand miComando3 = new MySqlCommand();
                MySqlDataReader Lector3;

                String nombre = "";
                string Consulta3 = "SELECT Nombre FROM cliente WHERE Codigo = " + Lector.GetInt32(1) + "";
                miComando3 = new MySqlCommand(Consulta3, miConexion3);
                miConexion3.Open();
                Lector3 = miComando3.ExecuteReader();
                while (Lector3.Read())
                {
                    nombre = Lector3.GetString(0);
                }
                Lector3.Close();
                miConexion3.Close();

                tablaPolizas.Rows.Add(Lector.GetValue(0), nombre, Lector.GetDateTime(2).ToString("dd/MM/yyyy"), Lector.GetDouble(3), Lector.GetString(4), Lector.GetString(5), (Lector.GetDouble(3) - sumaPagos), sumaPagos);

                for (int j = 0; j < tablaPolizas.Rows[i].Cells.Count; j++)
                {
                    if (Lector.GetString(4).Equals("Cobrada"))
                        tablaPolizas.Rows[i].Cells[j].Style.BackColor = Color.LimeGreen;
                    else if (Lector.GetString(4).Equals("A cuenta"))
                        tablaPolizas.Rows[i].Cells[j].Style.BackColor = Color.IndianRed;
                    else if (Lector.GetString(4).Equals("Liquidada"))
                        tablaPolizas.Rows[i].Cells[j].Style.BackColor = Color.Aquamarine;
                    else if (Lector.GetString(4).Equals("Pre anulada"))
                        tablaPolizas.Rows[i].Cells[j].Style.BackColor = Color.Orchid;
                    else if (Lector.GetString(4).Equals("Anulada"))
                        tablaPolizas.Rows[i].Cells[j].Style.BackColor = Color.DarkGray;
                    else
                        tablaPolizas.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
                i++;
            }
            Lector.Close();
            miConexion.Close();
            if (tablaPolizas.CurrentCell != null)
                tablaPolizas.CurrentCell.Selected = false;
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPoliza gp = new GestionPoliza();
            gp.Text = "Alta Póliza";
            gp.botonAñadir.Text = "Añadir";
            gp.ShowDialog();
            if (gp.DialogResult == DialogResult.OK)
            {
                actualizarTabla();
                MessageBox.Show("Póliza insertada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tablaPolizas.CurrentCell != null)
            {
                if (!tablaPolizas.CurrentCell.Selected)
                {
                    MessageBox.Show("Selecciona qué póliza eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SeguroEliminar se = new SeguroEliminar();
                    se.ShowDialog();
                    if (se.DialogResult == DialogResult.OK)
                    {
                        miConexion.Open();
                        string strEliminar = "DELETE FROM poliza WHERE NumPoliza = " + tablaPolizas.CurrentRow.Cells[0].Value + "";
                        miComando = new MySqlCommand(strEliminar, miConexion);
                        miComando.ExecuteNonQuery();
                        miConexion.Close();
                        actualizarTabla();
                        MessageBox.Show("Póliza eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona qué póliza eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaPolizas.CurrentCell != null)
            {
                if (!tablaPolizas.CurrentCell.Selected)
                {
                    MessageBox.Show("Selecciona qué póliza modificar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    GestionPoliza.codigo = int.Parse(tablaPolizas.CurrentRow.Cells[0].Value.ToString());
                    GestionPoliza.codigoCliente = capturarCodigoCliente(tablaPolizas.CurrentRow.Cells[1].Value.ToString(), int.Parse(tablaPolizas.CurrentRow.Cells[0].Value.ToString()));
                    GestionPoliza gp = new GestionPoliza();

                    gp.Text = "Modificación Póliza";
                    gp.botonAñadir.Text = "Modificar";

                    gp.numPolizaTB.Text = tablaPolizas.CurrentRow.Cells[0].Value.ToString();
                    gp.fechaDP.Text = tablaPolizas.CurrentRow.Cells[2].Value.ToString();
                    gp.importeTB.Text = tablaPolizas.CurrentRow.Cells[3].Value.ToString();
                    gp.estadoCB.Text = tablaPolizas.CurrentRow.Cells[4].Value.ToString();
                    gp.observacionesTB.Text = tablaPolizas.CurrentRow.Cells[5].Value.ToString();
                    gp.ShowDialog();
                    if (gp.DialogResult == DialogResult.OK)
                    {
                        actualizarTabla();
                        MessageBox.Show("Póliza modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona qué póliza modificar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void volverAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void boton_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(117, 194, 245);
        }

        private void boton_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(20, 29, 61);
        }

        private void botonVisualizar_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.FromArgb(117, 194, 245);
        }

        private void botonVisualizar_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.FromArgb(53, 121, 169);
        }

        private void Polizas_Click(object sender, EventArgs e)
        {
            if (tablaPolizas.CurrentCell != null)
                tablaPolizas.CurrentCell.Selected = false;

            labelAñadir.Visible = false;
            labelModificar.Visible = false;
            labelEliminar.Visible = false;
            pagoTB.Visible = false;
            okButton.Visible = false;
            pago2TB.Visible = false;
            okButton2.Visible = false;
            tablaPagos.Rows.Clear();
            labelGestionPagos.Visible = true;
            labelVisualizarCliente.Visible = false;
            pagoTB.Text = "";
            pago2TB.Text = "";
        }

        private void tablaPolizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelAñadir.Visible = true;
            labelModificar.Visible = true;
            labelEliminar.Visible = true;
            actualizarTablaPagos();
            if (tablaPagos.CurrentCell != null)
                tablaPagos.CurrentCell.Selected = false;
            labelGestionPagos.Visible = false;
            labelVisualizarCliente.Visible = true;
        }

        public void actualizarTablaPagos()
        {
            tablaPagos.Rows.Clear();

            miConexion = new MySqlConnection(strConexion);
            string Consulta = "SELECT * FROM pago WHERE NumPoliza = " + int.Parse(tablaPolizas.CurrentRow.Cells[0].Value.ToString()) + "";
            miComando = new MySqlCommand(Consulta, miConexion);
            miConexion.Open();
            Lector = miComando.ExecuteReader();
            while (Lector.Read())
            {
                tablaPagos.Rows.Add(Lector.GetValue(0), Lector.GetInt32(1), Lector.GetDateTime(2).ToString("dd/MM/yyyy"), Lector.GetDouble(3));
            }
            Lector.Close();
            miConexion.Close();
        }

        private void labelAñadir_Click(object sender, EventArgs e)
        {
            pagoTB.Visible = true;
            okButton.Visible = true;
            pago2TB.Text = "";
            pago2TB.Visible = false;
            okButton2.Visible = false;
        }

        private void labelModificar_Click(object sender, EventArgs e)
        {
            if (tablaPagos.CurrentCell != null)
            {
                if (!tablaPagos.CurrentCell.Selected)
                {
                    MessageBox.Show("Selecciona qué pago modificar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pagoTB.Visible = false;
                    okButton.Visible = false;
                    pago2TB.Visible = true;
                    okButton2.Visible = true;
                    pago2TB.Text = tablaPagos.CurrentRow.Cells[3].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Selecciona qué pago modificar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelEliminar_Click(object sender, EventArgs e)
        {
            if (tablaPagos.CurrentCell != null)
            {
                if (!tablaPagos.CurrentCell.Selected)
                {
                    MessageBox.Show("Selecciona qué pago eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SeguroEliminar se = new SeguroEliminar();
                    se.ShowDialog();
                    if (se.DialogResult == DialogResult.OK)
                    {

                        miConexion.Open();
                        string strEliminar = "DELETE FROM pago WHERE Codigo = " + int.Parse(tablaPagos.CurrentRow.Cells[0].Value.ToString()) + "";
                        miComando = new MySqlCommand(strEliminar, miConexion);
                        miComando.ExecuteNonQuery();
                        miConexion.Close();
                        actualizarTablaPagos();
                        actualizarTabla();
                        MessageBox.Show("Pago eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (tablaPolizas.CurrentCell != null)
                            tablaPolizas.CurrentCell.Selected = false;
                        if (tablaPagos.CurrentCell != null)
                            tablaPagos.CurrentCell.Selected = false;
                        Polizas_Click(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona qué pago eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public Boolean comprobarImporte(double importe, Boolean forma)
        {
            Boolean posible = false;
            if (forma)
            {
                if (importe <= double.Parse(tablaPolizas.CurrentRow.Cells[6].Value.ToString()))
                {
                    posible = true;
                }
            }
            else
            {
                if (importe <= double.Parse(tablaPagos.CurrentRow.Cells[3].Value.ToString()))
                {
                    posible = true;
                }
                else
                {
                    if ((importe - double.Parse(tablaPagos.CurrentRow.Cells[3].Value.ToString())) <= double.Parse(tablaPolizas.CurrentRow.Cells[6].Value.ToString()) && (double.Parse(tablaPolizas.CurrentRow.Cells[6].Value.ToString()) != 0))
                    {
                        posible = true;
                    }
                }
            }
            return posible;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!pagoTB.Text.Equals(""))
            {
                if (double.Parse(pagoTB.Text) != 0)
                {
                    if (comprobarImporte(double.Parse(pagoTB.Text.ToString().Replace(".", ",")), true))
                    {
                        miConexion.Open();
                        string Insertar = "INSERT INTO pago (NumPoliza, Fecha, Importe) VALUES (" + int.Parse(tablaPolizas.CurrentRow.Cells[0].Value.ToString()) + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + pagoTB.Text + ")";
                        miComando = new MySqlCommand(Insertar, miConexion);
                        miComando.ExecuteNonQuery();
                        miConexion.Close();
                        //int index = tablaPolizas.CurrentRow.Index;
                        actualizarTablaPagos();
                        actualizarTabla();
                        MessageBox.Show("Pago insertado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (tablaPolizas.CurrentCell != null)
                            tablaPolizas.CurrentCell.Selected = false;
                        if (tablaPagos.CurrentCell != null)
                            tablaPagos.CurrentCell.Selected = false;
                        pagoTB.Text = "";
                        Polizas_Click(sender, e);
                        //tablaPolizas.Rows[index].Selected = true;
                        //tablaPolizas_CellClick(null, null);
                    }
                    else
                    {
                        MessageBox.Show("El importe del pago es demasiado grande", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No puedes introducir un valor cero", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debes introducir algún valor", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public int capturarCodigoCliente(String nombre, int nPoliza)
        {
            int codCliente = 0;
            miConexion = new MySqlConnection(strConexion);
            string Consulta = "SELECT c.Codigo FROM cliente c JOIN poliza p ON (c.Codigo=p.CodCliente) WHERE c.Nombre = '" + nombre + "' AND p.NumPoliza = " + nPoliza + "";
            miComando = new MySqlCommand(Consulta, miConexion);
            miConexion.Open();
            Lector = miComando.ExecuteReader();
            while (Lector.Read())
            {
                codCliente = int.Parse(Lector.GetValue(0).ToString());
            }
            Lector.Close();
            miConexion.Close();

            return codCliente;
        }

        private void okButton2_Click(object sender, EventArgs e)
        {
            if (!pago2TB.Text.Equals(""))
            {
                if (double.Parse(pago2TB.Text) != 0)
                {
                    if (comprobarImporte(double.Parse(pago2TB.Text.Replace(".", ",")), false))
                    {
                        miConexion.Open();
                        string Modificar = "UPDATE pago SET Importe = " + pago2TB.Text.ToString().Replace(",", ".") + " WHERE Codigo = " + int.Parse(tablaPagos.CurrentRow.Cells[0].Value.ToString()) + "";
                        miComando = new MySqlCommand(Modificar, miConexion);
                        miComando.ExecuteNonQuery();
                        miConexion.Close();
                        //int index = tablaPolizas.CurrentRow.Index;
                        actualizarTablaPagos();
                        actualizarTabla();
                        MessageBox.Show("Pago modificado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (tablaPolizas.CurrentCell != null)
                            tablaPolizas.CurrentCell.Selected = false;
                        if (tablaPagos.CurrentCell != null)
                            tablaPagos.CurrentCell.Selected = false;
                        pago2TB.Text = "";
                        Polizas_Click(sender, e);
                        //tablaPolizas.Rows[index].Selected = true;
                        //tablaPolizas_CellClick(null, null);
                    }
                    else
                    {
                        MessageBox.Show("El importe del pago es demasiado grande", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No puedes introducir un valor cero", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debes introducir algún valor", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void verCliente()
        {
            VerCliente c = new VerCliente();

            miConexion = new MySqlConnection(strConexion);
            string Consulta = "SELECT * FROM cliente WHERE Codigo = " + capturarCodigoCliente(tablaPolizas.CurrentRow.Cells[1].Value.ToString(), int.Parse(tablaPolizas.CurrentRow.Cells[0].Value.ToString())) + "";
            miComando = new MySqlCommand(Consulta, miConexion);
            miConexion.Open();
            Lector = miComando.ExecuteReader();
            while (Lector.Read())
            {
                c.Text = "Información del cliente " + Lector.GetString(1);
                c.nombreTB.Text = Lector.GetString(1);
                c.apellidosTB.Text = Lector.GetString(2);
                c.telefonoTB.Text = Lector.GetString(3);
                c.poblacionCB.Text = Lector.GetString(4);
                c.codPostalTB.Text = Lector.GetString(5);
                c.provinciaCB.Text = Lector.GetString(6);
                c.tipoTB.Text = Lector.GetString(7);
            }
            Lector.Close();
            miConexion.Close();
            c.ShowDialog();
        }

        private void tablaPolizas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            verCliente();
        }

        private void tablaPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pago2TB.Visible)
            {
                labelModificar_Click(sender, e);
            }
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionInforme gi = new GestionInforme();
            gi.ShowDialog();
        }

        private void labelVisualizarCliente_Click(object sender, EventArgs e)
        {
            verCliente();
        }
    }
}
