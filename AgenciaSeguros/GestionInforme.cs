using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AgenciaSeguros
{
    public partial class GestionInforme : Form
    {
        public GestionInforme()
        {
            InitializeComponent();
        }

        private void GestionInforme_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter1.Fill(this.cargoClientes2.cliente);
            this.clienteTableAdapter.Fill(this.cargoClientes.cliente);
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

        private void botonGenerar_Click(object sender, EventArgs e)
        {
            if (todasRB.Checked)
            {
                VentanaInformeTodas viT = new VentanaInformeTodas();
                viT.ShowDialog();
            }
            else if (determinadoEstadoRB.Checked)
            {
                if (estadoCB.SelectedIndex < 0)
                {
                    labelError.Text = "Debes seleccionar un estado";
                }
                else
                {
                    VentanaInforme2 vi2 = new VentanaInforme2();
                    VentanaInforme2.estado = estadoCB.SelectedItem.ToString();
                    vi2.ShowDialog();
                }
            }
            else if (personalizadoRB.Checked)
            {
                VentanaInforme1 vi1 = new VentanaInforme1();
                VentanaInforme1.cod1 = int.Parse(clienteCB1.SelectedValue.ToString());
                VentanaInforme1.cod2 = int.Parse(clienteCB2.SelectedValue.ToString());
                VentanaInforme1.fecha1 = Convert.ToDateTime(fechaDP.Text.ToString());
                VentanaInforme1.fecha2 = Convert.ToDateTime(fechaDP2.Text.ToString());
                vi1.ShowDialog();
            }
        }


        private void todasRB_CheckedChanged(object sender, EventArgs e)
        {
            estadoCB.Enabled = false;
            clientesGB.Enabled = false;
            fechasGB.Enabled = false;
            labelError.Text = "";
        }

        private void determinadoEstadoRB_CheckedChanged(object sender, EventArgs e)
        {
            estadoCB.Enabled = true;
            clientesGB.Enabled = false;
            fechasGB.Enabled = false;
            labelError.Text = "";
        }

        private void personalizadoRB_CheckedChanged(object sender, EventArgs e)
        {
            estadoCB.Enabled = false;
            clientesGB.Enabled = true;
            fechasGB.Enabled = true;
            labelError.Text = "";
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
