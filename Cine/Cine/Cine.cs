using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Cine : Form
    {
        public Cine()
        {
            InitializeComponent();
        }

        private void modificaTablaPelicula_Click(object sender, EventArgs e)
        {
            FormPelicula f = new FormPelicula();

            f.ShowDialog();
        }

        private void Sucursal_Click(object sender, EventArgs e)
        {
            FormSucursal f = new FormSucursal();

            f.ShowDialog();
        }

        private void Membresia_Click(object sender, EventArgs e)
        {
            FormMembresia f = new FormMembresia();

            f.ShowDialog();
        }

        private void Sala_Click(object sender, EventArgs e)
        {
            FormSala f = new FormSala();

            f.ShowDialog();
        }

        private void Venta_Click(object sender, EventArgs e)
        {
            FormVenta f = new FormVenta();

            f.ShowDialog();
        }

        private void Funcion_Click(object sender, EventArgs e)
        {
            FormFuncion f = new FormFuncion();

            f.ShowDialog();
        }

        private void Asiento_Click(object sender, EventArgs e)
        {
            FormAsiento f = new FormAsiento();

            f.ShowDialog();
        }
    }
}
