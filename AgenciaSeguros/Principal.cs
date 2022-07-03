using System;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }

        private void pólizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Polizas p = new Polizas();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionInforme gi = new GestionInforme();
            gi.ShowDialog();
        }
    }
}
