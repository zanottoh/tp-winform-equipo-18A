using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_18A
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void botonBusqueda_Click(object sender, EventArgs e)
        {
            frmBuscar ventana = new frmBuscar();
            ventana.ShowDialog();
        }

        private void listarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmList ventana = new frmList();
            ventana.ShowDialog(this);

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {

            frmAgregar ventana = new frmAgregar();
            ventana.ShowDialog(this);

        }

        private void botonListar_Click(object sender, EventArgs e)
        {
            frmList ventana = new frmList();
            ventana.ShowDialog(this);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            dgbPrincipal.DataSource = negocio.listar();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
