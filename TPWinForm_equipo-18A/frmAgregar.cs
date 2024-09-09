using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;

namespace TPWinForm_equipo_18A
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo artNuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                artNuevo.Codigo = tbCodigo.Text;
                artNuevo.Nombre = tbNombre.Text;
                artNuevo.Precio = decimal.Parse(tbPrecio.Text);
                artNuevo.Descripcion = tbDescripcion.Text;

                artNuevo.Marca = (Marca)cmbMarca.SelectedItem;
                artNuevo.Categoria = (Categoria)cmbCategoria.SelectedItem;

                // Agregar imagen


                // escritura del articulo en la db

                negocio.agregar(artNuevo);
                MessageBox.Show("Articulo agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();


            try
            {
                cmbMarca.DataSource = marcaNegocio.listar();
                cmbCategoria.DataSource = categoriaNegocio.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
