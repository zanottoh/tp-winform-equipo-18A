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
    }
}
