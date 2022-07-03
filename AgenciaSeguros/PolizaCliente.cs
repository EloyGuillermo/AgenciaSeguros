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
    public partial class PolizaCliente : Form
    {
        public static int codigoCliente;
        MySqlConnection miConexion = new MySqlConnection();
        MySqlCommand miComando = new MySqlCommand();
        MySqlDataReader Lector;
        string strConexion = "server=127.0.0.1;uid=root;pwd=admin;database=agenciaseguros";

        public PolizaCliente()
        {
            InitializeComponent();
        }

        private void PolizaCliente_Load(object sender, EventArgs e)
        {
            actualizarTabla();
            if (tablaPolizas.CurrentCell != null)
                tablaPolizas.CurrentCell.Selected = false;

            if (tablaPagos.CurrentCell != null)
                tablaPagos.CurrentCell.Selected = false;
        }

        public void actualizarTabla()
        {
            tablaPolizas.Rows.Clear();
            int i = 0;
            miConexion = new MySqlConnection(strConexion);
            string Consulta = "SELECT * FROM poliza WHERE CodCliente = " + codigoCliente + "";
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
                tablaPolizas.Rows.Add(Lector.GetValue(0), Lector.GetInt32(1), Lector.GetDateTime(2).ToString("dd/MM/yyyy"), Lector.GetDouble(3), Lector.GetString(4), Lector.GetString(5), (Lector.GetDouble(3) - sumaPagos), sumaPagos);

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
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tablaPolizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelAñadir.Visible = true;
            labelModificar.Visible = true;
            labelEliminar.Visible = true;
            actualizarTablaPagos();
            if (tablaPagos.CurrentCell != null)
                tablaPagos.CurrentCell.Selected = false;
        }

        private void PolizaCliente_Click(object sender, EventArgs e)
        {
            if (tablaPolizas.CurrentCell != null)
                tablaPolizas.CurrentCell.Selected = false;
            tablaPagos.Rows.Clear();
            labelAñadir.Visible = false;
            labelModificar.Visible = false;
            labelEliminar.Visible = false;
            pagoTB.Visible = false;
            pago2TB.Visible = false;
            okButton.Visible = false;
            okButton2.Visible = false;
            pagoTB.Text = "";
            pago2TB.Text = "";
        }


        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPolizaCliente gpc = new GestionPolizaCliente();
            GestionPolizaCliente.codCliente = codigoCliente;
            gpc.Text = "Alta Póliza Cliente";
            gpc.botonAñadir.Text = "Añadir";
            gpc.ShowDialog();
            if (gpc.DialogResult == DialogResult.OK)
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
        private void boton_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(117, 194, 245);
        }

        private void boton_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(20, 29, 61);
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
                    GestionPolizaCliente gpc = new GestionPolizaCliente();
                    GestionPolizaCliente.codCliente = int.Parse(tablaPolizas.CurrentRow.Cells[1].Value.ToString());
                    gpc.Text = "Modificar Póliza Cliente";
                    gpc.botonAñadir.Text = "Modificar";

                    GestionPolizaCliente.codigo = int.Parse(tablaPolizas.CurrentRow.Cells[0].Value.ToString());
                    gpc.numPolizaTB.Text = tablaPolizas.CurrentRow.Cells[0].Value.ToString();
                    gpc.fechaDP.Text = tablaPolizas.CurrentRow.Cells[2].Value.ToString();
                    gpc.importeTB.Text = tablaPolizas.CurrentRow.Cells[3].Value.ToString();
                    gpc.estadoCB.Text = tablaPolizas.CurrentRow.Cells[4].Value.ToString();
                    gpc.observacionesTB.Text = tablaPolizas.CurrentRow.Cells[5].Value.ToString();
                    gpc.ShowDialog();

                    if (gpc.DialogResult == DialogResult.OK)
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
            this.Close();
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
                        PolizaCliente_Click(sender, e);
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
                        int index = tablaPolizas.CurrentRow.Index;
                        actualizarTablaPagos();
                        actualizarTabla();
                        MessageBox.Show("Pago insertado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (tablaPolizas.CurrentCell != null)
                            tablaPolizas.CurrentCell.Selected = false;
                        if (tablaPagos.CurrentCell != null)
                            tablaPagos.CurrentCell.Selected = false;
                        pagoTB.Text = "";
                        PolizaCliente_Click(sender, e);
                        tablaPolizas.Rows[index].Selected = true;
                        tablaPolizas_CellClick(null, null);
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
                        int index = tablaPolizas.CurrentRow.Index;
                        actualizarTablaPagos();
                        actualizarTabla();
                        MessageBox.Show("Pago modificado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (tablaPolizas.CurrentCell != null)
                            tablaPolizas.CurrentCell.Selected = false;
                        if (tablaPagos.CurrentCell != null)
                            tablaPagos.CurrentCell.Selected = false;
                        pago2TB.Text = "";
                        PolizaCliente_Click(sender, e);
                        tablaPolizas.Rows[index].Selected = true;
                        tablaPolizas_CellClick(null, null);
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
        private void tablaPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pago2TB.Visible)
            {
                labelModificar_Click(sender, e);
            }
        }
    }
}
