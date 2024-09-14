using dominio;
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

        }

        private void cbParametro2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void frmBuscar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cbMarcaBusqueda.DataSource = marcaNegocio.listar();
                cbCategoriaBusqueda.DataSource = categoriaNegocio.listar();
                cbMarcaBusqueda.SelectedIndex = -1;
                cbCategoriaBusqueda.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();

            List<Articulo> lista = new List<Articulo>();

            lista = negocio.listar();

            List<Articulo> listaFiltrada;



            try
            {

                string categoria = null;
                string marca = null;

                Categoria categoriaSeleccionada = (Categoria)cbCategoriaBusqueda.SelectedItem;
                if (categoriaSeleccionada != null)
                {
                    categoria = categoriaSeleccionada.descripcion;
                }

                Marca marcaSeleccionada = (Marca)cbMarcaBusqueda.SelectedItem;
                if (marcaSeleccionada != null)
                {
                    marca = marcaSeleccionada.NombreMarca;
                }

                int idArticulo = int.Parse(txtBoxIdBusqueda.Text);
                string nombre = txtBoxNombreBusqueda.Text;





                listaFiltrada = lista.FindAll(Item => (categoria == null || Item.Categoria.descripcion == categoria && marca == null || Item.Marca.NombreMarca == marca && Item.Nombre == nombre && Item.IdArticulo == idArticulo));
                dgvBusquedaAvanzada.DataSource = null;
                dgvBusquedaAvanzada.DataSource = listaFiltrada;

            }
            catch (Exception ex)
            {
                if (string.IsNullOrEmpty((string)cbCategoriaBusqueda.SelectedItem) || string.IsNullOrEmpty((string)cbCategoriaBusqueda.SelectedItem) || txtBoxIdBusqueda == null || txtBoxNombreBusqueda == null)
                {



                    MessageBox.Show("Complete todos los campos por favor, son obligatorios para la búsqueda");

                    return;
                }



            }

        }

    }
}
