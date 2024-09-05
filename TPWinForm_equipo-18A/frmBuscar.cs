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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void lblBusqueda_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbParametro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbParametro.Items.Add("ID");
            cbParametro.Items.Add("Marca");
            cbParametro.Items.Add("Categoria");
            cbParametro.Items.Add("Nombre de Articulo");
        }

        private void cbParametro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbParametro2.Items.Add("ID");
            cbParametro2.Items.Add("Marca");
            cbParametro2.Items.Add("Categoria");
            cbParametro2.Items.Add("Nombre de Articulo");
        }

       

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            cbParametro2.Items.Add("ID");
            cbParametro2.Items.Add("Marca");
            cbParametro2.Items.Add("Categoria");
            cbParametro2.Items.Add("Nombre de Articulo");

            cbParametro.Items.Add("ID");
            cbParametro.Items.Add("Marca");
            cbParametro.Items.Add("Categoria");
            cbParametro.Items.Add("Nombre de Articulo");
        }
    }
}
