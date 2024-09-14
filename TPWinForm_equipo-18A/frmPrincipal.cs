using dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
            cargar();
           

        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            dgbPrincipal.DataSource = negocio.listar();
            dgbPrincipal.Columns["IdArticulo"].Visible = false;

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            cbCategoria.DataSource = categoriaNegocio.listar();
            cbMarca.DataSource = marcaNegocio.listar();
            cbCategoria.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void dgbPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            ImagenNegocio imgNegocio = new ImagenNegocio();

            Articulo seleccionado = (Articulo)dgbPrincipal.CurrentRow.DataBoundItem;
            Imagen imagenObtenida = imgNegocio.ObtenerImagen(seleccionado.IdArticulo);
            cargarImagen(imagenObtenida);
        }

        private void cargarImagen(Imagen imagen)
        {
            try
            {
                pbxImagenSeleccion.Load(imagen.UrlImagen);
            }
          
            catch (Exception)
            {
                pbxImagenSeleccion.Load("https://static.vecteezy.com/system/resources/previews/016/916/479/non_2x/placeholder-icon-design-free-vector.jpg");
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar ventanaAgregar = new frmAgregar();
            ventanaAgregar.ShowDialog();
            cargar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            List<Articulo> lista = new List<Articulo>();

            lista = negocio.listar();

            List<Articulo> listaFiltrada;

            string categoria = null;
            string marca = null;

            Categoria categoriaSeleccionada = (Categoria)cbCategoria.SelectedItem;
            if (categoriaSeleccionada != null)
            {
                categoria = categoriaSeleccionada.descripcion;
            }

            Marca marcaSeleccionada = (Marca)cbMarca.SelectedItem;
            if (marcaSeleccionada != null)
            {
                marca = marcaSeleccionada.NombreMarca;
            }

            listaFiltrada = lista.FindAll(item =>
            (categoria == null || item.Categoria.descripcion == categoria) &&
            (marca == null || item.Marca.NombreMarca == marca)
                                                    );
            dgbPrincipal.DataSource = null;
            dgbPrincipal.DataSource = listaFiltrada;


        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            dgbPrincipal.DataSource = negocio.listar();

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            cbCategoria.DataSource = categoriaNegocio.listar();
            cbMarca.DataSource = marcaNegocio.listar();
            cbCategoria.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            frmBuscar ventanaBuscar = new frmBuscar();
            ventanaBuscar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ImagenNegocio imgNegocio = new ImagenNegocio();
            Articulo seleccionado = (Articulo)dgbPrincipal.CurrentRow.DataBoundItem;
            Imagen imgSeleccion = imgNegocio.ObtenerImagen(seleccionado.IdArticulo);
            frmAgregar ventanaModificar = new frmAgregar(seleccionado, imgSeleccion);
            ventanaModificar.ShowDialog();
            cargar();
        }

        private void agregarCategoriaToolstrip_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria frmAgregarCategoria = new frmAgregarCategoria();
            frmAgregarCategoria.ShowDialog();


        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
