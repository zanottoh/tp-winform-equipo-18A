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
        private Articulo articulo = null;
        private Imagen imagen = null;
        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Articulo articulo, Imagen imagen)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.imagen = imagen;
            Text = "Modificar Articulo";
            lblTitulo.Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imgNegocio = new ImagenNegocio();
            

            try
            {
                if(articulo == null)
                {
                    articulo = new Articulo();
                    imagen = new Imagen();
                }

                articulo.Codigo = tbCodigo.Text;
                articulo.Nombre = tbNombre.Text;
                articulo.Precio = decimal.Parse(tbPrecio.Text);
                articulo.Descripcion = tbDescripcion.Text;

                articulo.Marca = (Marca)cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmbCategoria.SelectedItem;

                imagen.UrlImagen = tbImagen.Text;


                if(articulo.IdArticulo != 0)
                {
                    negocio.modificar(articulo);
                    imgNegocio.modificar(imagen);
                    MessageBox.Show("Articulo modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    articulo = negocio.buscarArticulo(articulo);
                    imagen.IdArticulo = articulo.IdArticulo;
                    imgNegocio.agregar(imagen);
                    MessageBox.Show("Articulo agregado exitosamente");

                }





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
                cmbMarca.ValueMember = "IdMarca";
                cmbMarca.DisplayMember = "NombreMarca";
                cmbCategoria.DataSource = categoriaNegocio.listar();
                cmbCategoria.ValueMember = "id";
                cmbCategoria.DisplayMember = "descripcion";
                Articulo aux = articulo;

                if (articulo != null)
                {
                    tbCodigo.Text = articulo.Codigo;
                    tbNombre.Text = articulo.Nombre;
                    tbPrecio.Text = articulo.Precio.ToString();
                    tbDescripcion.Text = articulo.Descripcion;
                    tbImagen.Text = imagen.UrlImagen;
                    cargarImagen(tbImagen.Text);
                    cmbMarca.SelectedValue = articulo.Marca.IdMarca;
                    cmbCategoria.SelectedValue = articulo.Categoria.id;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/a/a3/Image-not-found.png");
            }
        }
    }
}
