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
            Imagen imagen = new Imagen();
            Articulo seleccionado = (Articulo)dgbPrincipal.CurrentRow.DataBoundItem;
            imagen.IdArticulo = seleccionado.IdArticulo;
            Imagen imagenObtenida = ObtenerImagen(imagen);
            cargarImagen(imagenObtenida);
        }

        private void cargarImagen(Imagen imagen)
        {
            try
            {
                pbxImagenSeleccion.Load(imagen.UrlImagen);
            }
            catch (Exception ex)
            {

                pbxImagenSeleccion.Load("https://static.vecteezy.com/system/resources/previews/016/916/479/non_2x/placeholder-icon-design-free-vector.jpg");
            }
        }

        private Imagen ObtenerImagen(Imagen imagen)
        {
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("SELECT ImagenUrl From IMAGENES where IdArticulo = "+ imagen.IdArticulo +"");
            datos.ejecutarLectura();


            while (datos.lector.Read())  // recorremos los resultados de la consulta
            {  
                imagen.UrlImagen = (string)datos.lector["ImagenUrl"];
                datos.cerrarConexion();
                return imagen;
            }

            datos.cerrarConexion();
            return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar ventanaAgregar = new frmAgregar();
            ventanaAgregar.ShowDialog();
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


            listaFiltrada = lista.FindAll(Item => (categoria == null || Item.Categoria.descripcion == categoria && marca == null || Item.Marca.NombreMarca == marca ));
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
    }
}
