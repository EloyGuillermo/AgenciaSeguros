﻿using System;
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
    public partial class VerCliente : Form
    {
        public VerCliente()
        {
            InitializeComponent();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
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
    }
}
