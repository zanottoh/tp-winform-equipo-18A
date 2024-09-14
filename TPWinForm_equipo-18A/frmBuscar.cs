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

           

            if (cbCategoriaBusqueda.SelectedItem == null || cbMarcaBusqueda.SelectedItem == null || string.IsNullOrWhiteSpace(txtBoxIdBusqueda.Text) || string.IsNullOrWhiteSpace(txtBoxNombreBusqueda.Text))
            {

                MessageBox.Show("Complete todos los campos por favor, son obligatorios para la búsqueda.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            try
            {

                ArticuloNegocio negocio = new ArticuloNegocio();
                List<Articulo> lista = negocio.listar();
                List<Articulo> listaFiltrada;




                Categoria categoriaSeleccionada = (Categoria)cbCategoriaBusqueda.SelectedItem;
                string categoria = categoriaSeleccionada.descripcion;

                Marca marcaSeleccionada = (Marca)cbMarcaBusqueda.SelectedItem;
                string marca = marcaSeleccionada.NombreMarca;


                string codArticulo = txtBoxIdBusqueda.Text;


                string nombre = txtBoxNombreBusqueda.Text;


                listaFiltrada = lista.FindAll(item =>
                    item.Categoria.descripcion == categoria &&
                    item.Marca.NombreMarca == marca &&
                    item.Nombre.ToUpper ().Contains( nombre.ToUpper()) &&
                    item.Codigo.ToUpper().Contains( codArticulo.ToUpper()));


                dgvBusquedaAvanzada.DataSource = null;
                dgvBusquedaAvanzada.DataSource = listaFiltrada;



                ImagenNegocio imgNegocio = new ImagenNegocio();


                if (dgvBusquedaAvanzada.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvBusquedaAvanzada.CurrentRow.DataBoundItem;
                    Imagen imagenObtenida = imgNegocio.ObtenerImagen(seleccionado.IdArticulo);
                    cargarImagen(imagenObtenida);
                }
                else
                {
                    MessageBox.Show("No se encontró el artículo...");
                }

            }
           
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cargarImagen(Imagen imagen)
        {
            try
            {
                pbBusquedaAvanzada.Load(imagen.UrlImagen);
            }
            catch (Exception ex)
            {

                pbBusquedaAvanzada.Load("https://static.vecteezy.com/system/resources/previews/016/916/479/non_2x/placeholder-icon-design-free-vector.jpg");
            }
        }

    }


}


