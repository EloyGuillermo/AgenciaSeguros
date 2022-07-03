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
    public partial class VentanaInforme1 : Form
    {
        public static int cod1, cod2;
        public static DateTime fecha1, fecha2;

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public VentanaInforme1()
        {
            InitializeComponent();
        }

        private void boton_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(117, 194, 245);
        }

        private void boton_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = Color.FromArgb(20, 29, 61);
        }
        
        private void VentanaInforme1_Load(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.dataSetEntreClienteYFecha.DataTable1, cod1, cod2, fecha1, fecha2);
            this.reportViewer1.RefreshReport();
        }
    }
}
